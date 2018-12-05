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

namespace PayrollMgmt.ChildForms.DepartmentForms {
    public partial class DepartmentDetails : Form {

        PayrollDatabase database;
        int ID;
        private Boolean editStatus = false;

        public DepartmentDetails(int id) {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = id;

            PopulateFields();
        }

        private void PopulateFields()
        {
            string queryEmployee = "SELECT DepartmentName, Location, Description" +
                                  " FROM departments WHERE DepartmentID = @did";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@did", this.ID);
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read())
            {
                DeptNameInput.Text = ResultReader.GetString(0);
                deptLocationInput.Text = ResultReader.GetString(1);
                deptDescInput.Text = ResultReader.GetString(2);
            }

            database.conn.Close();
        }

        private void EnableEditButton_Click(object sender, EventArgs e)
        {
            editStatus = !editStatus;

            DeptNameInput.Enabled = editStatus;
            deptLocationInput.Enabled = editStatus;
            deptDescInput.Enabled = editStatus;
            UpdateButton.Enabled = editStatus;

            EnableEditButton.Text = (editStatus) ? "Disable Editing" : "Enable Editing";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string queryEmployee = "UPDATE departments SET DepartmentName = @dtitle, Location = @dpay, " +
                "Description = @ddesc WHERE DepartmentID = @did";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@dtitle", DeptNameInput.Text);
            command.Parameters.AddWithValue("@dpay", deptLocationInput.Text);
            command.Parameters.AddWithValue("@ddesc", deptDescInput.Text);
            command.Parameters.AddWithValue("@did", this.ID);

            command.ExecuteNonQuery();

            database.conn.Close();

            DepartmentDetails detailsJob = new DepartmentDetails(this.ID)
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            detailsJob.Show();
            this.Close();
        }
    }
}
