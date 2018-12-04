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
    public partial class EmployeeDetails : Form {
        PayrollDatabase database;
        int ID;
        private Boolean editStatus = false;

        public EmployeeDetails (int id) {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = id;

            PopulateFields();
        }

        private void PopulateFields() {
            string queryEmployee = "SELECT FirstName, LastName," +
                "Street, City, State, Zip, Phone, HireDate FROM employees WHERE EmployeeID = @eid";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", this.ID);
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                FnameInput.Text = ResultReader.GetString(0);
                LnameInput.Text = ResultReader.GetString(1);
                StreetInput.Text = ResultReader.GetString(2);
                CityInput.Text = ResultReader.GetString(3);
                StateInput.SelectedIndex = StateInput.FindStringExact(ResultReader.GetString(4));
                ZipInput.Value = ResultReader.GetInt32(5);
                PhoneInput.Text = ResultReader.GetString(6);
                HireDateInput.Value = ResultReader.GetDateTime(7);
            }

            database.conn.Close();

        }

        private void EnableEditButton_Click(object sender, EventArgs e) {
            editStatus = !editStatus;

            FnameInput.Enabled = editStatus;
            LnameInput.Enabled = editStatus;
            StreetInput.Enabled = editStatus;
            CityInput.Enabled = editStatus;
            StateInput.Enabled = editStatus;
            ZipInput.Enabled = editStatus; 
            PhoneInput.Enabled = editStatus;
            HireDateInput.Enabled = editStatus;
            UpdateButton.Enabled = editStatus;

            EnableEditButton.Text = (editStatus) ? "Disable Editing" : "Enable Editing";
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            string queryEmployee = "UPDATE employees SET FirstName = @fname, LastName = @lname, " +
                "Street = @street, City = @city, Zip = @zip, Phone = @phone, HireDate = @hiredate WHERE " +
                "EmployeeID = @eid";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@fname", FnameInput.Text);
            command.Parameters.AddWithValue("@lname", LnameInput.Text);
            command.Parameters.AddWithValue("@street", StreetInput.Text);
            command.Parameters.AddWithValue("@city", CityInput.Text);
            command.Parameters.AddWithValue("@zip", ZipInput.Value);
            command.Parameters.AddWithValue("@phone", PhoneInput.Text);
            command.Parameters.AddWithValue("@hiredate", HireDateInput.Value);
            command.Parameters.AddWithValue("@eid", this.ID);
 
            command.ExecuteNonQuery();

            database.conn.Close();

            EmployeeDetails detailsEmployee = new EmployeeDetails(this.ID) {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            detailsEmployee.Show();
            this.Close();
        }
    }
}
