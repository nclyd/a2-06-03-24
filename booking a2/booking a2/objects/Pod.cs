using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booking_a2.objects
{
    class Pod
    {

        private int podID;
        private char type;
        private int capacity;

        public int PodID { get => podID; set => podID = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public char Type { get => type; set => type = value; }
    }
}
