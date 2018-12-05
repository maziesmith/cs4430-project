using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMgmt.ChildForms.PayrollForms {
    class DeductionAdd {
        private PayrollDatabase database;
        private readonly string DeductionName;
        private readonly double DeductionAmount;

        public DeductionAdd(string DeductionName, double DeductionAmount) {
            this.database = PayrollDatabase.Instance;
            this.DeductionName = DeductionName;
            this.DeductionAmount = DeductionAmount;

            AddDeduction();
        }

        private void AddDeduction() {
            database.conn.Open();
            string queryHolidayType = "INSERT INTO deductiontypes (DeductionName, Amount) VALUES (@name, @pay)";

            MySqlCommand command = new MySqlCommand(queryHolidayType, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@name", this.DeductionName);
            command.Parameters.AddWithValue("@pay", this.DeductionAmount);
            command.ExecuteNonQuery();

            database.conn.Close();
        }
    }
}
