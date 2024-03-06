using booking_a2.objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.dbAccess
{
    class CustomerDBAccess
    {
        private Database db;

        public CustomerDBAccess(Database _db)
        {
            db = _db;
        }

        public List<Customer> getAllCustomers()
        {
            string sqlCmd = "SELECT * FROM Customer order by Surname asc";
            return RunQuery(sqlCmd);
        }

        public void CreateCustomer(string forename, string Surname, int telNo, string address)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Customer VALUES('" + forename + "','" + Surname + "','" + telNo + "','" + address + "')";
            db.Cmd.ExecuteNonQuery();
        }

        public void UpdateCustomer(Customer c)
        {
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = "INSERT INTO Customer VALUES ('" + c.Forename + "','" + c.Surname + "','" + c.TelNo + "','" + c.Address + "')";
            db.Cmd.ExecuteNonQuery();
        }

        public List<Customer> RunQuery(string sqlCmd)
        {
            List<Customer> results = new List<Customer>();
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();
            while (db.Rdr.Read())
            {
                results.Add(getProjectFromReader());
            }
            db.Rdr.Close();
            return results;
        }

        public Customer getProjectFromReader()
        {
            Customer cust = new Customer();
            cust.CustomerID = db.Rdr.GetInt32(0);
            cust.Forename = db.Rdr.GetString(1);
            cust.Surname = db.Rdr.GetString(2);
            cust.TelNo = db.Rdr.GetString(3);
            cust.Address = db.Rdr.GetString(4);
            return cust;
        }
    }
}
