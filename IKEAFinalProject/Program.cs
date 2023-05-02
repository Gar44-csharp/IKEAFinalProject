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

        static void AppointmentPage()
        {
            Console.WriteLine("Choose your option: 1: Login  2: Logout 3: Clear 4: Quit 5: Set Up An Appointment");
            Console.WriteLine("Please choose one of the options above: ");
            String option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    LoginScreen();
                    break;
                case "2":
                    LogoutScreen();
                    break;
                case "3":
                    Eliminate();
                    break;
                case "4":
                    IQuit();
                    break;
                case "5":
                    SetUpAnAppointment();
                    break;
                default:
                    Console.WriteLine("You entered an incorrect character!");
                    break;





            }


            static void LoginScreen()
            {
            }

            static void LogoutScreen()
            {

            }

            static void Eliminate()
            {

            }

            static void IQuit()
            {

            }

            static void SetUpAnAppointment()
            {
            }

        }







    }
}