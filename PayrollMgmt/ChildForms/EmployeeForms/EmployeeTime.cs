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
            MessageBox.Show("TEst");
        }
    }
}
