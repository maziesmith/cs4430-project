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

namespace PayrollMgmt.ChildForms.EmployeeForms {
    public partial class EmployeeList : Form {
        PayrollDatabase database;

        public EmployeeList(string searchString) {
            InitializeComponent();

            database = PayrollDatabase.Instance;
            EmployeeDataTable.DataSource = PopulateDataTable(searchString);
        }

        private DataTable PopulateDataTable(string searchString) {
            string queryTime = "SELECT EmployeeID, CONCAT(FirstName, ' ', Lastname) AS Name," +
                "Street, City, Zip, Phone, HireDate FROM employees " +
                "WHERE FirstName LIKE @search " +
                "OR LastName LIKE @search " +
                "OR Street LIKE @search " +
                "OR State LIKE @search " +
                "OR Phone LIKE @search " +
                "OR City LIKE @search";
            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.Parameters.AddWithValue("@search", "%" + searchString + "%");
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private void EmployeeDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow SelectedRow = EmployeeDataTable.CurrentRow;

            EmployeeDetails detailsEmployee = new EmployeeDetails((int)SelectedRow.Cells["EmployeeID"].Value) {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            detailsEmployee.Show();
            this.Close();
        }
    }
}
