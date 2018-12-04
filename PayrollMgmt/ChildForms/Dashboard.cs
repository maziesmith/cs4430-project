using MySql.Data.MySqlClient;
using PayrollMgmt.ChildForms;
using PayrollMgmt.ChildForms.DepartmentForms;
using PayrollMgmt.ChildForms.EmployeeForms;
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
                    "This field only accepts integers! \nPlease reenter a valid employee ID", 
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
    }
}
