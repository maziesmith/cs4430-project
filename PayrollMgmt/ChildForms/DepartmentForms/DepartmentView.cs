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

namespace PayrollMgmt.ChildForms.DepartmentForms {
    public partial class DepartmentView : Form {
        PayrollDatabase database;

        public DepartmentView() {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;

            DeptDataTable.DataSource = PopulateDeptDataTable();
        }

        private DataTable PopulateDeptDataTable() {
            string queryTime = "SELECT DepartmentID AS ID, DepartmentName AS Name, Location, CONCAT(FirstName, ' ', LastName) AS `Manager Name`," +
                " CONCAT(Street, ', ', City, ', ', State, ', ', ZIP) AS `Manager Address`, Phone AS `Manager Phone`" +
                " FROM departments JOIN employees ON departments.ManagerID = employees.EmployeeID";

            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private void DeptDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewRow SelectedRow = DeptDataTable.CurrentRow;

            if(SelectedRow.Index != DeptDataTable.NewRowIndex) {
                DepartmentDetails detailsDepartment = new DepartmentDetails((int)SelectedRow.Cells["ID"].Value) {
                    MdiParent = this.MdiParent,
                    WindowState = FormWindowState.Maximized
                };
                detailsDepartment.Show();
                this.Close();
            }
        }
    }
}
