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
    public partial class DepartmentEmployees : Form {
        PayrollDatabase database;
        int ID;

        public DepartmentEmployees(int ID) {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = ID;

            EmployeesDataTable.DataSource = PopulateEmployeesDataTable();
        }

        private DataTable PopulateEmployeesDataTable() {
            string queryTime = "SELECT * FROM employees NATURAL JOIN jobs WHERE DepartmentID = @id";

            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.Parameters.AddWithValue("@id", this.ID);
            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }
    }
}
