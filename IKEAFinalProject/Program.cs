using System.Text;

namespace IKEAFinalProject
{
    public class Program
    {
        private static IkeaCustomers ikeaCustomers;
        private static List<IkeaPersonalShoppingAppointment> ikeaPersonalShoppingAppointments;
        private static List<IkeaCustomerAppointment> ikeaCustomerAppointments;
        private static IkeaCustomer verifyCustomer;
        private static IkeaCustomer newIkeaCustomer;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello IKEA customer, welcome to our personal shopping appointment portal!");
            // This is introducing the IKEA customer to the appointment page!
            LoadingScreen();
            //
            AppointmentPage();
            //                
        }

        static void LoadingScreen() 
        {
            var ikeaCustomer1 = new IkeaCustomer
            {
                FirstName = "Jimmy",
                LastName = "Wade",
                Username = "JimmyEliteHeat21",
                Password = "Heatbroomsweep",
            };
            var ikeaCustomerAppointment1 = new IkeaPersonalShoppingAppointment();
            var ikeaCustomerAppointment2 = new IkeaPersonalShoppingAppointment();
            var ikeaCustomerAppointment3 = new IkeaPersonalShoppingAppointment();



        }

       





    }
}