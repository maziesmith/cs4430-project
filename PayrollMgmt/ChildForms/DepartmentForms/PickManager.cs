using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PayrollMgmt.ChildForms.DepartmentForms
{
    public partial class PickManager : Form
    {
        PayrollDatabase database;
        public string managerfirstname { get; set; }
        public string managerlastname { get; set; }
        public int managerid { get; set; }

        public PickManager()
        {
            InitializeComponent();
            

            this.database = PayrollDatabase.Instance;

            managerList.DataSource = populateTable();
        }


        private DataTable populateTable()
        {
            string queryTime = "SELECT FirstName,Lastname,EmployeeID FROM employees;";

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

        private void managerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            selectManager.Enabled = true;
        }

        private void selectManager_Click(object sender, EventArgs e)
        {
            managerfirstname = managerList.CurrentRow.Cells[0].Value.ToString();
            managerlastname = managerList.CurrentRow.Cells[1].Value.ToString();
            managerid = Convert.ToInt32(managerList.CurrentRow.Cells[2].Value.ToString());
            this.Hide();
        }
    }
}
