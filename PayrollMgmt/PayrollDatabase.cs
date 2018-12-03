using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollMgmt.ChildForms {
    public sealed class PayrollDatabase {
        public static PayrollDatabase Instance { get; } = new PayrollDatabase();
        public MySqlConnection conn { get; private set; }

        PayrollDatabase() {
            DBConnect();
        }

        private void DBConnect() {
            string connStr = "server=localhost;user=root;database=payroll";
            this.conn = new MySqlConnection(connStr);

            conn.Close();
        }
    }
    
}
