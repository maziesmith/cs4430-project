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

        public EmployeeAdd (int deptID) {
            InitializeComponent();
            this.database = PayrollDatabase.Instance;
        }

        private void SubmitButton_Click(object sender, EventArgs e) {

        }
    }
}
