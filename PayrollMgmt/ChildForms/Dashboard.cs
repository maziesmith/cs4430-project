using MySql.Data.MySqlClient;
using PayrollMgmt.ChildForms;
using PayrollMgmt.ChildForms.DepartmentForms;
using PayrollMgmt.ChildForms.EmployeeForms;
using PayrollMgmt.ChildForms.PayrollForms;
using PayrollMgmt.ChildForms.JobsForms;
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

namespace PayrollMgmt {
    public partial class Dashboard : Form {
        ParentForm dashParent;
        PayrollDatabase dbConn;

        public Dashboard (ParentForm dashParent) {
            this.dashParent = dashParent;
            InitializeComponent();

            
            if((dbConn = PayrollDatabase.Instance) != null) {
                dashParent.StatusUpdate = "Connected to database successfully!";
            }

            PopulateDeptInputs();
        }

        private void PopulateDeptInputs() {
            dbConn.conn.Open();
            string queryDepartments = "SELECT DepartmentName, DepartmentID FROM departments";
            MySqlCommand command = new MySqlCommand(queryDepartments, dbConn.conn);
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read()) {
                DeptInput.Items.Add(new ComboBoxItem(ResultReader.GetString(0), ResultReader.GetInt32(1)));
                ViewDeptEmpInput.Items.Add(new ComboBoxItem(ResultReader.GetString(0), ResultReader.GetInt32(1)));
                PayDeptInput.Items.Add(new ComboBoxItem(ResultReader.GetString(0), ResultReader.GetInt32(1)));
            }

            dbConn.conn.Close();
        }

        private void AddEmployee_button_Click (object sender, EventArgs e) {
            if (DeptInput.SelectedItem != null) {
                dashParent.RemoveChildren();
                EmployeeAdd addEmployee = new EmployeeAdd((DeptInput.SelectedItem as ComboBoxItem).Value) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                addEmployee.Show();
            }
        }

        private void TimeEmployee_button_Click (object sender, EventArgs e) {
            try {
                EmployeeTime timeEmployee = new EmployeeTime(Int32.Parse(this.employeeTimeID.Text)) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                timeEmployee.Show();
                this.Close();
            } catch (FormatException) {
                MessageBox.Show(
                    "This field only accepts integers! \nPlease reenter a valid employee ID",
                    "Format Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ViewEmployee_button_Click (object sender, EventArgs e) {
            try {
                EmployeeList listEmployee = new EmployeeList(this.EmployeeDetailsID.Text) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                listEmployee.Show();
                this.Close();
            } catch(FormatException){
                MessageBox.Show(
                    "Invalid Input", 
                    "Format Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void EmployeeID_Enter(object sender, EventArgs e) {
            TextBox currentSender = null;
            if (sender is TextBox) {
                currentSender = (TextBox)sender;
                if (currentSender.Text == "Employee ID"){
                    currentSender.Text = "";
                    currentSender.ForeColor = Color.Black;
                }
            }
        }

        private void EmployeeID_Leave(object sender, EventArgs e) {
            TextBox currentSender = null;
            if (sender is TextBox) {
                currentSender = (TextBox)sender;
                if (currentSender.Text == "") {
                    currentSender.Text = "Employee ID";
                    currentSender.ForeColor = Color.Gray;
                }
            }
        }

        private void ViewDepartmentButton_Click(object sender, EventArgs e){
            DepartmentView viewDepartment = new DepartmentView() {
                MdiParent = this.dashParent,
                WindowState = FormWindowState.Maximized
            };
            viewDepartment.Show();
            this.Close();
        }

        private void ViewDeptEmpButton_Click(object sender, EventArgs e) {
            if(ViewDeptEmpInput.SelectedItem != null) {
                DepartmentEmployees employeesDepartment = new DepartmentEmployees((ViewDeptEmpInput.SelectedItem as ComboBoxItem).Value) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                employeesDepartment.Show();
                this.Close();
            }
        }

        private void PayDeptInput_SelectedIndexChanged(object sender, EventArgs e) {
            dbConn.conn.Open();
            string queryEmployees = "SELECT EmployeeID, CONCAT('ID: ', EmployeeID, ' - ', LastName, ', ', FirstName) AS Name FROM employees NATURAL JOIN jobs WHERE DepartmentID = @did";

            PayEmpInput.Items.Clear();

            MySqlCommand command = new MySqlCommand(queryEmployees, dbConn.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@did", (PayDeptInput.SelectedItem as ComboBoxItem).Value);
            MySqlDataReader ResultsReader = command.ExecuteReader();

            while (ResultsReader.Read()) {
                PayEmpInput.Items.Add(new ComboBoxItem(ResultsReader.GetString(1), ResultsReader.GetInt32(0)));
            }

            dbConn.conn.Close();
        }

        private void PayEmpButton_Click(object sender, EventArgs e) {
            if (PayEmpInput.SelectedItem != null) {
                PayrollPay payPayroll = new PayrollPay((PayEmpInput.SelectedItem as ComboBoxItem).Value) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                payPayroll.Show();
                this.Close();
            }
        }

        private void EmployeeDetailsID_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                ViewEmployee_button_Click(this, new EventArgs());
            }
        }

        private void employeeTimeID_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                TimeEmployee_button_Click(this, new EventArgs());
            }
        }
    }
}
