using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEAFinalProject
{
    public class IkeaCustomerAppointment
    {
        public IkeaCustomer customerIkea { get; set; }
        // This getter/setter method allows new users to enter in information.. (will make changes to this comment after main method is done!

        public IkeaPersonalShoppingAppointment appointmentShopping { get; set; }
        // This getter/setter method allows the user to create one to many appointments.

        public IkeaCustomerAppointment (IkeaCustomer i, IkeaPersonalShoppingAppointment ipsa)
        {
            customerIkea = i;
            // We are setting our customerIkea public equal to i
            appointmentShopping = ipsa;
            // We are setting our appointmentshopping public to ipsa
        }



    }
}
