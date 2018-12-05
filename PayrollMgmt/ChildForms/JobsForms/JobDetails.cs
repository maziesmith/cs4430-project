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
    public partial class JobDetails : Form
    {
        PayrollDatabase database;
        int ID;
        private Boolean editStatus = false;

        public JobDetails(int id)
        {
            InitializeComponent();

            this.database = PayrollDatabase.Instance;
            this.ID = id;

            PopulateFields();
        }

        private void PopulateFields() {
            string queryEmployee = "SELECT JobTitle, Pay, JobDesription"+
                                  " FROM jobs WHERE JobID = @eid";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@eid", this.ID);
            MySqlDataReader ResultReader = command.ExecuteReader();

            while (ResultReader.Read())
            {
                JobTitleInput.Text = ResultReader.GetString(0);
                PayInput.Value = Convert.ToDecimal(ResultReader.GetString(1));
                JobDescInput.Text = ResultReader.GetString(2);
            }

            database.conn.Close();
        }

        private void EnableEditButton_Click(object sender, EventArgs e)
        {
            editStatus = !editStatus;

            JobTitleInput.Enabled = editStatus;
            PayInput.Enabled = editStatus;
            JobDescInput.Enabled = editStatus;
            UpdateButton.Enabled = editStatus;

            EnableEditButton.Text = (editStatus) ? "Disable Editing" : "Enable Editing";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string queryEmployee = "UPDATE jobs SET JobTitle = @jtitle, Pay = @jpay, " +
                "JobDesription = @jdesc WHERE JobId = @jid";

            database.conn.Open();
            MySqlCommand command = new MySqlCommand(queryEmployee, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@jtitle", JobTitleInput.Text);
            command.Parameters.AddWithValue("@jpay", PayInput.Text);
            command.Parameters.AddWithValue("@jdesc", JobDescInput.Text);
            command.Parameters.AddWithValue("@jid", this.ID);

            command.ExecuteNonQuery();

            database.conn.Close();

            JobDetails detailsJob = new JobDetails(this.ID)
            {
                MdiParent = this.MdiParent,
                WindowState = FormWindowState.Maximized
            };
            detailsJob.Show();
            this.Close();
        }
    }
}
