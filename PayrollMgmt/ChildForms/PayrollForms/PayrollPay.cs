using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMgmt.ChildForms.PayrollForms {
    public partial class PayrollPay : Form {
        PayrollDatabase database;
        int ID;
        double totalDeductions = 0;
        double totalBonuses = 0;
        double calculatedAdjustment = 0;
        double employeePay = 0;
        double overtimeHours = 0;
        double overtimePay = 0;
        double preCalcTotal = 0;
        double finalCalcTotal = 0;
        DateTime paidDate;

        public PayrollPay(int ID) {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = ID;

            HoursDataTable.DataSource = PopulateDataTable();
            PayDataTable.DataSource = PopulatePayDataTable();
            InitializeVariables();

            PayDataLabel.Text = "$" + employeePay.ToString() + "/hr";
            BonusesDataLabel.Text = "+" + totalBonuses.ToString() + "%";
            DeductionsDataLabel.Text = "-" + totalDeductions.ToString() + "%";
        }

        private void InitializeVariables() {
            database.conn.Open();
            string queryEmployees = "SELECT Pay FROM employees NATURAL JOIN jobs WHERE EmployeeID = @eid";

            MySqlCommand command = new MySqlCommand(queryEmployees, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", this.ID);

            MySqlDataReader ResultsReader = command.ExecuteReader();

            if (ResultsReader.Read()) {
                this.employeePay = ResultsReader.GetDouble(0);
                this.overtimePay = ResultsReader.GetDouble(0) * 1.5;
            }
            ResultsReader.Close();

            command.CommandText = "SELECT Amount FROM bonuses NATURAL JOIN bonustypes WHERE EmployeeID = @eid";
            ResultsReader = command.ExecuteReader();

            while (ResultsReader.Read()) {
                this.totalBonuses += ResultsReader.GetDouble(0);
            }
            ResultsReader.Close();

            command.CommandText = "SELECT Amount FROM deductions NATURAL JOIN deductiontypes WHERE EmployeeID = @eid";
            ResultsReader = command.ExecuteReader();

            while (ResultsReader.Read()) {
                this.totalDeductions += ResultsReader.GetDouble(0);
            }
            ResultsReader.Close();

            database.conn.Close();

            this.calculatedAdjustment = (totalBonuses - totalDeductions) * 1/100;
        }

        private DataTable PopulatePayDataTable() {
            string queryTime = "SELECT Amount, LastPaid AS `Pay Date`, NextPaid AS `Next Pay Date` FROM payments WHERE EmployeeID = @eid";
            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.Parameters.AddWithValue("@eid", this.ID);
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private DataTable PopulateDataTable() {
            string queryTime = "SELECT CONCAT(LastName, ', ', FirstName) AS Name , WeekStart, WeekEnd, TotalHours " +
                "FROM weeklyhours NATURAL JOIN employees WHERE EmployeeID = @eid";
            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.Parameters.AddWithValue("@eid", this.ID);
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private void HoursDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow SelectedRow = HoursDataTable.CurrentRow;

            if(SelectedRow.Index != HoursDataTable.NewRowIndex) {
                PromptLabel.Visible = false;
                SubmitButton.Enabled = true;

                paidDate = ((DateTime)SelectedRow.Cells["WeekStart"].Value);
                if(((double)SelectedRow.Cells["TotalHours"].Value) > 40) {
                    this.overtimeHours = ((double)SelectedRow.Cells["TotalHours"].Value) - 40;
                    this.preCalcTotal = 40.0 * employeePay;
                    this.preCalcTotal += overtimeHours * overtimePay;
                } else {
                    this.preCalcTotal = (((double)SelectedRow.Cells["TotalHours"].Value) * employeePay);
                }

                this.finalCalcTotal = this.preCalcTotal * (1.00 + calculatedAdjustment);

                HourDataLabel.Text = ((double)SelectedRow.Cells["TotalHours"].Value).ToString() + "/hrs";
                PreTotalMathLabel.Text = ((double)SelectedRow.Cells["TotalHours"].Value).ToString() + "/hrs\n X $" + employeePay.ToString() + "/hr ";
                PreTotalDataLabel.Text = "$" + ((double)SelectedRow.Cells["TotalHours"].Value) * employeePay;

                OvertimeHoursDataLabel.Text = this.overtimeHours.ToString() + "/hrs";
                OvertimePayDataLabel.Text = "$" + this.overtimePay.ToString();

                FinalPayDataLabel.Text = "$"  + string.Format("{0:N2}", (Math.Truncate(finalCalcTotal * 100) / 100).ToString());
            } else {
                PromptLabel.Visible = true;
                SubmitButton.Enabled = false;

                HourDataLabel.Text = "0";
                PreTotalMathLabel.Text = "0";
                PreTotalDataLabel.Text = "0";
                OvertimeHoursDataLabel.Text = "0";
                OvertimePayDataLabel.Text = "0";
                FinalPayDataLabel.Text = "0";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            database.conn.Open();
            string queryPayments = "INSERT INTO payments (EmployeeID, Amount, LastPaid, NextPaid) VALUES (@id, @amount, @this, @next)";

            MySqlCommand command = new MySqlCommand(queryPayments, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", this.ID);
            command.Parameters.AddWithValue("@amount", finalCalcTotal);
            command.Parameters.AddWithValue("@this", this.paidDate);
            command.Parameters.AddWithValue("@next", this.paidDate.AddDays(7));

            try {
                command.ExecuteNonQuery();
            } catch(MySqlException SqlEx) {
                if(SqlEx.ErrorCode == 1062) {
                    MessageBox.Show(
                      "This employee has already been paid for the selected week! \nPlease select a new week!",
                      "PRIMARY KEY ERROR",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                }
            }
                      
            database.conn.Close();
            PayDataTable.DataSource = PopulatePayDataTable();
        }
    }
}
