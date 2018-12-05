using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMgmt.ChildForms.PayrollForms {
    class BonusAdd {
        private PayrollDatabase database;
        private readonly string BonusTitle;
        private readonly double BonusAmount;

        public BonusAdd(string BonusTitle, double BonusAmount) {
            this.database = PayrollDatabase.Instance;
            this.BonusTitle = BonusTitle;
            this.BonusAmount = BonusAmount;

            AddBonus();
        }

        private void AddBonus() {
            database.conn.Open();
            string queryHolidayType = "INSERT INTO bonustypes (BonusTitle, Amount) VALUES (@name, @pay)";

            MySqlCommand command = new MySqlCommand(queryHolidayType, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@name", this.BonusTitle);
            command.Parameters.AddWithValue("@pay", this.BonusAmount);
            command.ExecuteNonQuery();

            database.conn.Close();
        }
    }
}
