using System.ComponentModel.Design;
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
            // This is a method that will be used later for development of the loading screen.
            AppointmentPage();
            // This is a method that will be used later for the development of Appointment page.              
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
            var ikeaCustomer2 = new IkeaCustomer
            {
                FirstName = "Giannis",
                LastName = "Portis Jr",
                Username = "GP349Jr",
                Password = "Bucksin6",
            };
            var ikeaCustomer3 = new IkeaCustomer
            {
                FirstName = "Lebron",
                LastName = "Davis",
                Username = "LakeshowLD23",
                Password = "LAForLikfe20",
            };
            
            ikeaCustomers = new IkeaCustomers();
            ikeaCustomers.customers.Add(ikeaCustomer1);
            ikeaCustomers.customers.Add(ikeaCustomer2);
            ikeaCustomers.customers.Add(ikeaCustomer3);
            
            var ikeaCustomerAppointment1 = new IkeaPersonalShoppingAppointment();
            var ikeaCustomerAppointment2 = new IkeaPersonalShoppingAppointment();
            var ikeaCustomerAppointment3 = new IkeaPersonalShoppingAppointment();
            
        }

        static void AppointmentPage()
        {
            if (verifyCustomer == null)
            {
            Console.WriteLine("Choose your option: 1: Login  2: Logout 3: View Your Ikea Personal Shopping Appointment 4: Quit 5: Set Up An Appointment"); // We are asking the user to enter an option from 1-5.
            Console.WriteLine("Please choose one of the options above: "); // We ask the user to choose the following options above
            String option = Console.ReadLine(); // We are reading what the user inputs and store the information into string option
            switch (option) //we start our switch statement
            {
//<<<<<<< Updated upstream
              
                case "1": //when the user enters 1, it leads the user to the login screen
                    LoginScreen(); // the code in loginscreen runs
                    break; //move on to case 2
                case "2": // leads the user to the logout screen
                    LogoutScreen(); //the code in Logoutscreen void runs
                    break; //move on to case 3
                case "3": // Allows the user to the view their appointment 
                    ViewIkeaPersonalShoppingAppointment(); //leads to appointment screen
                    break; // brings you to next case.
                case "4": //leads the user to the quit option
                    Console.Clear(); // Quits the screen.
                    break; // move on to case 5
                case "5": //leads the user to set up an Ikea Appointment
                    SignUpForAnAppointment(); //the code in SetUpAnAppointment runs
                    break; //move on to default
                default: // test...
                    Console.WriteLine("You entered an incorrect character!"); // The user entered in the wrong character for options
                    break; //our switch statement concludes.
//>>>>>>> Stashed changes
            }


            static void LoginScreen()
                {
                    if (verifyCustomer == null)
                    {
                        Console.WriteLine("Please enter your IKEA username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Please enter your IKEA password: ");
                        string password = Console.ReadLine();
                        verifyCustomer = ikeaCustomers.Verify(username,password);
                        if (verifyCustomer != null)
                        {
                            Console.WriteLine($"Welcome {verifyCustomer.FirstName}");
                        } 
                        else
                        {
                            Console.WriteLine("That username or password is invalid");
                        }
                    }
                }
            }

            static void LogoutScreen()
            {
                verifyCustomer = null;
                Console.WriteLine("You are logged out!");
            }

            static void SignUpForAnAppointment()
            {
                Console.Write("What is your First Name: ");
                string firstname = Console.ReadLine();
                Console.Write("What is your Last Name: ");
                string lastname = Console.ReadLine();
                Console.WriteLine("Please type a Username: ");
                string username = Console.ReadLine();
                Console.Write("Please enter a Password: ");
                string password = Console.ReadLine();
                Console.WriteLine("Awesome! We have created your Ikea profile so you can make appointments!");
            }

            static void ViewIkeaPersonalShoppingAppointment()
            {
                if (verifyCustomer == null)
                {
                    Console.WriteLine("Oh no, it seems like you are not logged in!");
                }

                var ikeaAppointmentList = ikeaCustomerAppointments.Where(o => o.customerIkea.Username == verifyCustomer.Username);

                if(ikeaAppointmentList.Count() == 0)
                {
                    Console.WriteLine("We have no record of your IKEA personal shopping appointment");
                }
                else
                {
                    foreach(var personalShopping in  ikeaAppointmentList)
                    {
                        Console.WriteLine(personalShopping.appointmentShopping.appointmentDate);
                    }
                }
            }         
        }
    }
}
