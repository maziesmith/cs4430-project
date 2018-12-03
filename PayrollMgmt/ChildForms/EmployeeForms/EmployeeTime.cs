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
        Boolean update = false;

        public EmployeeTime (int id) {
            InitializeComponent();
            this.database = PayrollDatabase.Instance;


            TimeDataTable.DataSource = PopulateDatatable(id);
        }

        private DataTable PopulateDatatable(int id) {
            string queryTime = "SELECT * FROM weeklyhours WHERE EmployeeID = @eid";
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

                EmployeeIDInput.Value = (decimal)((int)SelectedRow.Cells["EmployeeID"].Value);
                WeekStartInput.Value = (DateTime)SelectedRow.Cells["WeekStart"].Value;
                WeekEndInput.Value = (DateTime)SelectedRow.Cells["WeekEnd"].Value;
                TotalHoursInput.Value = (decimal)((double)SelectedRow.Cells["TotalHours"].Value);
                
                SubmitButton.Text = "Update";
            } else {
                update = false;



                SubmitButton.Text = "Add New";
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            if (update) {
                UpdateCurrentRow();
            } else {
                InsertNewRow();
            }
        }

        private void InsertNewRow() {
            throw new NotImplementedException();
        }

        private void UpdateCurrentRow() {
            throw new NotImplementedException();
        }
    }
}
