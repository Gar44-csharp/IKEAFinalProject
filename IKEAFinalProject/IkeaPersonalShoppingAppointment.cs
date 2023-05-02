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
        // This is setting in the foundation for the creation of new userID's
        public int IkeaID { get; set; }
        // This collects the users IkeaID.
        public DateTime appointmentDate { get; set; }
        // This collects the appointment time for the user.
        public IkeaPersonalShoppingAppointment()
        // This collects information to schedule the date of the appointment
        {
            instance++;
            // It is adding each instance to then use for new Ikea user ID's.
            IkeaID = instance;
            // IkeaID will add 1 for each new instance created.
        }







    }
}
