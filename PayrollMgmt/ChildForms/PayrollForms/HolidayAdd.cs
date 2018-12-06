using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMgmt.ChildForms.PayrollForms {
    class HolidayAdd {
        private PayrollDatabase database;
        private readonly string HolidayName;
        private readonly double HolidayPayment;

        public HolidayAdd(string HolidayName, double HolidayPayment) {
            this.database = PayrollDatabase.Instance;
            this.HolidayName = HolidayName;
            this.HolidayPayment = HolidayPayment;

            AddHoliday();
        }

        private void AddHoliday() {
            database.conn.Open();
            string queryHolidayType = "INSERT INTO holidaytypes (HolidayName, Payment) VALUES (@name, @pay)";

            MySqlCommand command = new MySqlCommand(queryHolidayType, database.conn);
            command.Prepare();
            command.Parameters.AddWithValue("@name", this.HolidayName);
            command.Parameters.AddWithValue("@pay", this.HolidayPayment);
            command.ExecuteNonQuery();

            database.conn.Close();
        }
    }
}
