using MySql.Data.MySqlClient;
using PayrollMgmt.Utils;
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
    public partial class EmployeeAdd : Form {
        PayrollDatabase database;
        int DeptID;

        public EmployeeAdd (int deptID) {
            InitializeComponent();
            this.database = PayrollDatabase.Instance;
            this.DeptID = deptID;

            PopulateJobInput();
            PopulateHolidayInput();
            PopulateDeductionInput();
            PopulateBonusInput();
        }

        private void PopulateBonusInput() {
            string queryBonus = "SELECT BonusType, BonusTitle FROM bonustypes";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryBonus, database.conn);
            command.Prepare();
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                BonusesInput.Items.Add(new ComboBoxItem(ResultReader.GetString(1), ResultReader.GetInt32(0)));
            }

            database.conn.Close();
        }

        private void PopulateDeductionInput() {
            string queryDeduction = "SELECT DeductionType, DeductionName FROM deductiontypes";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryDeduction, database.conn);
            command.Prepare();
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                DeductionsInput.Items.Add(new ComboBoxItem(ResultReader.GetString(1), ResultReader.GetInt32(0)));
            }

            database.conn.Close();
        }

        private void PopulateHolidayInput() {
            string queryHoliday = "SELECT HolidayType, HolidayName FROM holidaytypes";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryHoliday, database.conn);
            command.Prepare();
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                HolidayInput.Items.Add(new ComboBoxItem(ResultReader.GetString(1), ResultReader.GetInt32(0)));
            }

            database.conn.Close();
        }

        private void PopulateJobInput() {
            string queryDept = "SELECT JobID, JobTitle FROM jobs WHERE DepartmentID = @id";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryDept, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@id", this.DeptID);
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                JobInput.Items.Add(new ComboBoxItem(ResultReader.GetString(1), ResultReader.GetInt32(0)));
            }

            database.conn.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e) {
            foreach(Control c in PersonalTableContainer.Controls) {
                foreach (Control c2 in c.Controls) {
                    if (c2 is TextBox currentTextBox) {
                        if (string.IsNullOrWhiteSpace(currentTextBox.Text)) {
                            MessageBox.Show(
                                "You have left a field empty, please fill out all fields.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    } else if (c2 is ComboBox currentComboBox) {
                        if (currentComboBox.SelectedItem == null) {
                            MessageBox.Show(
                                "You have left a field empty, please fill out all fields.",
                                "Input Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }
                    } else if (c2 is NumericUpDown currentUpDown) {
                        if (currentUpDown.Value == 0) {
                            MessageBox.Show(
                                    "You have left a field empty, please fill out all fields.",
                                    "Input Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
            }

            if(JobInput.SelectedItem == null) {
                MessageBox.Show(
                    "You have left a field empty, please fill out all fields.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            int generatedKey = AddEmployee();
            AddEmployeeHolidays(generatedKey);
            AddEmployeeDeducions(generatedKey);
            AddEmployeeBonuses(generatedKey);
        }

        private void AddEmployeeBonuses(int generatedKey) {
            database.conn.Open();
            string queryBonuses = "INSERT INTO bonues (EmployeeID, BonusType) VALUES (@eid, @type)";

            MySqlCommand command = new MySqlCommand(queryBonuses, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", generatedKey);

            foreach(ComboBoxItem currentItem in BonusesInput.SelectedItems) {
                command.Parameters.AddWithValue("@type", currentItem.Value);
                command.ExecuteNonQuery();
            }

            database.conn.Close();
        }

        private void AddEmployeeDeducions(int generatedKey) {
            database.conn.Open();
            string queryBonuses = "INSERT INTO deductions (EmployeeID, DeductionType) VALUES (@eid, @type)";

            MySqlCommand command = new MySqlCommand(queryBonuses, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", generatedKey);

            foreach (ComboBoxItem currentItem in DeductionsInput.SelectedItems) {
                command.Parameters.AddWithValue("@type", currentItem.Value);
                command.ExecuteNonQuery();
            }

            database.conn.Close();
        }

        private void AddEmployeeHolidays(int generatedKey) {
            database.conn.Open();
            string queryBonuses = "INSERT INTO holidays (EmployeeID, HolidayType) VALUES (@eid, @type)";

            MySqlCommand command = new MySqlCommand(queryBonuses, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", generatedKey);

            foreach (ComboBoxItem currentItem in HolidayInput.SelectedItems) {
                command.Parameters.AddWithValue("@type", currentItem.Value);
                command.ExecuteNonQuery();
            }

            database.conn.Close();
        }

        private int AddEmployee() {
            string queryEmployees = "INSERT INTO employees (FirstName, LastName," +
                "JobID, Street, City, State, Zip, Phone, HireDate) VALUES " +
                "(@fname, @lname, @id, @street, @city, @state, @zip, @phone, @hiredate)";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployees, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@fname", FnameInput.Text);
            command.Parameters.AddWithValue("@lname", LnameInput.Text);
            command.Parameters.AddWithValue("@id", (JobInput.SelectedItem as ComboBoxItem).Value);
            command.Parameters.AddWithValue("@street", StreetInput.Text);
            command.Parameters.AddWithValue("@city", CityInput.Text);
            command.Parameters.AddWithValue("@state", StateInput.SelectedItem);
            command.Parameters.AddWithValue("@zip", ZipInput.Value);
            command.Parameters.AddWithValue("@phone", PhoneInput.Text);
            command.Parameters.AddWithValue("@hiredate", HireDateInput.Value);

            command.ExecuteNonQuery();

            string queryNewKey = "SELECT @@Identity";
            //TODO Will need to find way to return ID of new employee that was recently inserted
            command.CommandText = queryNewKey;
            command.CommandType = CommandType.Text;
            var key = command.ExecuteScalar();

            database.conn.Close();

            return Convert.ToInt32(key);
        }
    }
}
