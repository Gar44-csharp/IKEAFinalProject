using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEAFinalProject
{
    public class IkeaPersonalShoppingAppointment
    {
        private static int instance;
        //
        public int IkeaID { get; set; }
        //
        public DateTime appointmentDate { get; set; }
        //
        public IkeaPersonalShoppingAppointment()
        //
        {
            instance++;
            //
            IkeaID = instance;
            //
        }







    }
}
