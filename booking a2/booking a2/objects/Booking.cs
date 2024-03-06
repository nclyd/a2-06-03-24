using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.objects
{
    class Booking
    {
        private int bookingID;
        private int noOfPods;
        private int noOfGuests;

        private DateTime startDate;
        private DateTime endDate;

        public DateTime EndDate { get => endDate; set => endDate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
    }
}
