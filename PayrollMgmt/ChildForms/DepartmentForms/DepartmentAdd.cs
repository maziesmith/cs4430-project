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
using PayrollMgmt.Utils;

namespace PayrollMgmt.ChildForms.DepartmentForms
{
    public partial class DepartmentAdd : Form
    {
        PayrollDatabase database;
        PickManager pickManager = new PickManager();
        int managerID = 0;

        public DepartmentAdd()
        {
            InitializeComponent();
            database = PayrollDatabase.Instance;

        }


        private void selectManager_Click(object sender, EventArgs e)
        {

            var dialogResult = pickManager.ShowDialog();
            
            string firstname = pickManager.managerfirstname;
            string lastname = pickManager.managerlastname;
            int employeeID = pickManager.managerid;

            if (firstname != null && lastname != null && employeeID != 0)
            {
                dManager.Text = firstname + " " + lastname;
                managerID = employeeID;
            }

        }

        private void createDepartment_Click(object sender, EventArgs e)
        {
            string departmentName = dName.Text;
            string departmentDesc = dDescription.Text;
            string departmentLoc = dLocation.Text;
            int managerId = this.managerID;
            if (departmentName == null || departmentDesc == null || departmentLoc == null || managerID == 0)
            {
                Console.WriteLine("Error Null Value");
                MessageBox.Show("Error Null Value");
            }
            else {
                string queryTime = "INSERT INTO departments (DepartmentName,Description,Location,ManagerID)" +
                                    "VALUES ('"+ departmentName +"','"+ departmentDesc +"','"+ departmentLoc +"',"+ managerId + ");";

                try
                {
                    MySqlCommand command = new MySqlCommand(queryTime, database.conn);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    MessageBox.Show("Department Created!");
                    dName.Text = "";
                    dDescription.Text = "";
                    dLocation.Text = "";
                    dManager.Text = "";


                }
                catch (Exception ex) {
                    Console.WriteLine("Error");
                    MessageBox.Show("Database Error, Please Contact Admin");
                }

            }

            
        }
    }
}
