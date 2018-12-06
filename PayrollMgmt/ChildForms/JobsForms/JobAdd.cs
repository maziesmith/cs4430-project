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
    public partial class JobAdd : Form
    {
        PayrollDatabase database;
        PickDepartment pickDepartment = new PickDepartment();
        int departmentId = 0;
        public JobAdd()
        {
            InitializeComponent();
            database = PayrollDatabase.Instance;
        }

        private void createJob_Click(object sender, EventArgs e)
        {
            string jobName = jName.Text;
            string jobDesc = jDescription.Text;
            double jobPay = 0;
            try
            {
                jobPay = Convert.ToDouble(jPay.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("Error, Please Enter a Number Value for Pay");
                return;
            }
            int departmentID = this.departmentId;
            if ((string.IsNullOrWhiteSpace(jobName )) || (string.IsNullOrWhiteSpace(jobDesc)) || departmentID == 0)
            {
                Console.WriteLine("Error Null Value");
                MessageBox.Show("Error Null Value");
            }
            else
            {
                string queryTime = "INSERT INTO jobs (JobTitle, Pay, DepartmentID, JobDesription)" +
                                    "VALUES ('" + jobName + "'," + jobPay + "," + departmentID + ",'" + jobDesc + "');";
                MySqlCommand command = new MySqlCommand(queryTime, database.conn);

                try
                {
                   
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Job Created!");
                    jName.Text = "";
                    jDescription.Text = "";
                    jPay.Text = "0.00";
                    jDepartment.Text = "";


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error");
                    MessageBox.Show("Database Error, Please Contact Admin");
                    command.Connection.Close();
                }

            }
        }

        private void selectDepartment_Click(object sender, EventArgs e)
        {
            var dialogResult = pickDepartment.ShowDialog();

            string departmentName = pickDepartment.departmentName;
            int departmentID = pickDepartment.departmentID;

            if (departmentName != null && departmentID != 0)
            {
                jDepartment.Text = departmentName;
                departmentId = departmentID;
            }
        }
    }
}
