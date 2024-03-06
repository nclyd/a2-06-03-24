using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.dbAccess
{
    internal class PodDBAccess
    {
        private Database db;

        public PodDBAccess(Database _db)
        {
            db = _db;
        }



        public void GetAvailablePods()
        {

            string sqlCmd = "select podno from pod" +
                            "where podno NOT IN" +
                            "(select podno" +
                            "FROM Booking-Pod bp" +
                            "inner join booking b on b.bookingid = bp.bookingid" +
                            "where (b.StartDate<'01/02/2024'" +
                            "and b.endDate>'01/02/2024')" +
                            "or (b.startDate>'01/02/2024'" +
                            "and b.StartDate<'01/10/2024'))";
            db.Cmd = db.Conn.CreateCommand();
            db.Cmd.CommandText = sqlCmd;
            db.Rdr = db.Cmd.ExecuteReader();

        }
    }

    
}