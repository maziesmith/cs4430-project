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

namespace PayrollMgmt.ChildForms {
    public partial class EmployeeTime : Form {
        PayrollDatabase database;
        int ID;
        Boolean update = false;

        public EmployeeTime (int id) {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = id;

            EmployeeIDInput.Value = this.ID;
            TimeDataTable.DataSource = PopulateDatatable(id);
        }

        private DataTable PopulateDatatable(int id) {
            string queryTime = "SELECT LastName, FirstName, WeekStart, WeekEnd, TotalHours " +
                "FROM weeklyhours NATURAL JOIN employees WHERE EmployeeID = @eid";
            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.Parameters.AddWithValue("@eid", id);
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private void TimeDataTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
           
            DataGridViewRow SelectedRow = TimeDataTable.CurrentRow;

            if (!(SelectedRow.Index == TimeDataTable.NewRowIndex)) {
                update = true;

                WeekStartInput.Enabled = false;
                WeekEndInput.Enabled = false;

                WeekStartInput.Value = (DateTime)SelectedRow.Cells["WeekStart"].Value;
                WeekEndInput.Value = (DateTime)SelectedRow.Cells["WeekEnd"].Value;
                TotalHoursInput.Value = (decimal)((double)SelectedRow.Cells["TotalHours"].Value);
                
                SubmitButton.Text = "Update";
            } else {
                update = false;

                WeekStartInput.Enabled = true;
                WeekEndInput.Enabled = false;

                WeekStartInput.Value = DateTime.Today;
                WeekEndInput.Value = DateTime.Today.AddDays(6);
                TotalHoursInput.Value = (decimal)0.0;

                SubmitButton.Text = "Add New";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (update) {
                UpdateCurrentRow(WeekStartInput.Value, WeekEndInput.Value, TotalHoursInput.Value);
            } else {
                InsertNewRow(WeekStartInput.Value, WeekEndInput.Value, TotalHoursInput.Value);
            }
        }

        private void InsertNewRow(DateTime start, DateTime end, decimal hours) {
            string queryTime = "INSERT INTO weeklyhours (EmployeeID, WeekStart, WeekEnd, TotalHours) " +
                "VALUES (@id, @start, @end, @hours)";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", this.ID);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);
            command.Parameters.AddWithValue("@hours", hours);

            try {
                command.ExecuteNonQuery();
            } catch (MySqlException SQLEx) {
                if(SQLEx.Number == 1062) {
                    MessageBox.Show(
                        "This week range has already been added! \nPlease reenter your values!",
                        "PRIMARY KEY ERROR", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } finally {
                database.conn.Close();
            }

            TimeDataTable.DataSource = PopulateDatatable(this.ID);
        }

        private void UpdateCurrentRow(DateTime start, DateTime end, decimal hours) {
            string queryTime = "UPDATE weeklyhours SET TotalHours = @hours WHERE WeekStart = @start AND WeekEnd = @end";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@hours", hours);
            command.Parameters.AddWithValue("@start", start);
            command.Parameters.AddWithValue("@end", end);

            command.ExecuteNonQuery();

            database.conn.Close();
            TimeDataTable.DataSource = PopulateDatatable(this.ID);
        }

        private void WeekStartInput_ValueChanged(object sender, EventArgs e) {
            WeekEndInput.Value = WeekStartInput.Value.AddDays(6);
        }
    }
}
