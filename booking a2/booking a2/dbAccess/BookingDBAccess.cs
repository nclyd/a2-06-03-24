using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.dbAccess
{
    class BookingDBAccess
    {
        private Database db;

        public BookingDBAccess(Database _db)
        {
            db = _db;
        }
    }
}
