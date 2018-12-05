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

namespace PayrollMgmt.ChildForms.JobsForms
{
    public partial class PickDepartment : Form
    {
        PayrollDatabase database;
        public string departmentName { get; set; }
        public int departmentID { get; set; }

        public PickDepartment()
        {
            
            InitializeComponent();

            this.database = PayrollDatabase.Instance;

            departmentList.DataSource = populateTable();
        }
        private DataTable populateTable()
        {
            string queryTime = "SELECT DepartmentName,DepartmentID FROM departments;";

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

    
        private void selectDepartment_Click(object sender, EventArgs e)
        {
            departmentName = departmentList.CurrentRow.Cells[0].Value.ToString();
            departmentID = Convert.ToInt32(departmentList.CurrentRow.Cells[1].Value.ToString());
            this.Hide();
        }

    }
}
