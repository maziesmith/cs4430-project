using PayrollMgmt.ChildForms;
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

        public Dashboard (ParentForm dashParent) {
            this.dashParent = dashParent;
            InitializeComponent();
        }

        private void AddEmployee_button_Click (object sender, EventArgs e) {
            dashParent.RemoveChildren();
            EmployeeAdd addEmployee = new EmployeeAdd {
                MdiParent = this.dashParent,
                WindowState = FormWindowState.Maximized
            };
            addEmployee.Show();
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
                EmployeeDetails detailsEmployee = new EmployeeDetails(Int32.Parse(this.employeeDetailsID.Text)) {
                    MdiParent = this.dashParent,
                    WindowState = FormWindowState.Maximized
                };
                detailsEmployee.Show();
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
    }
}
