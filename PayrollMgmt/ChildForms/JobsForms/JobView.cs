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
    public partial class JobView : Form
    {
        PayrollDatabase database;
        public JobView()
        {
            InitializeComponent();
            this.database = PayrollDatabase.Instance;

            JobDataTable.DataSource = PopulateDeptDataTable();
        }
        private DataTable PopulateDeptDataTable()
        {
            string queryTime = "SELECT JobID AS ID, JobTitle AS Title, Pay, DepartmentName"+ 
                                " FROM jobs JOIN departments ON jobs.DepartmentID = departments.DepartmentID; ";

            DataTable ResultTable = new DataTable();
            MySqlCommand command = new MySqlCommand(queryTime, database.conn);
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            command.CommandType = CommandType.Text;
            dataAdapter.SelectCommand = command;

            database.conn.Open();
            dataAdapter.Fill(ResultTable);
            database.conn.Close();

            return ResultTable;
        }

        private void JobDataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow SelectedRow = JobDataTable.CurrentRow;

            if (SelectedRow.Index != JobDataTable.NewRowIndex)
            {
                JobDetails detailsDepartment = new JobDetails((int)SelectedRow.Cells["ID"].Value)
                {
                    MdiParent = this.MdiParent,
                    WindowState = FormWindowState.Maximized
                };
                detailsDepartment.Show();
                this.Close();
            }
        }
    }
}
