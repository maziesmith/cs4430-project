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
            EmployeeTime timeEmployee = new EmployeeTime {
                MdiParent = this.dashParent,
                WindowState = FormWindowState.Maximized
            };
            timeEmployee.Show();
            this.Close();
        }

        private void ViewEmployee_button_Click (object sender, EventArgs e) {
            EmployeeDetails detailsEmployee = new EmployeeDetails {
                MdiParent = this.dashParent,
                WindowState = FormWindowState.Maximized
            };
            detailsEmployee.Show();
            this.Close();
        }
    }
}
