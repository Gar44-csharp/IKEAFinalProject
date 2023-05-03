using System.Collections.Generic;
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

        static void LoadingScreen() // This defines a method called LoadingScreen
        {
            var ikeaCustomer1 = new IkeaCustomer // This creates a new instance of the IkeaCustomer class and assigns it to the variable ikeaCustomer1
            {
                FirstName = "Jimmy", // This line sets the FirstName property of ikeaCustomer1 to "Jimmy"
                LastName = "Wade", // This sets the LastName property of ikeaCustomer1 to "Wade"
                Username = "JimmyEliteHeat21", // This sets the Username property of ikeaCustomer1 to "JimmyEliteHeat21"
                Password = "Heatbroomsweep",   // This sets the Password property of ikeaCustomer1 to "Heatbroomsweep"
            };
            var ikeaCustomer2 = new IkeaCustomer  // This creates a new instance of the IkeaCustomer class and assigns it to the variable ikeaCustomer2
            {
                FirstName = "Giannis",  // This sets the FirstName property of ikeaCustomer2 to "Giannis"
                LastName = "Portis Jr", // This sets the LastName property of ikeaCustomer2 to "Portis Jr"
                Username = "GP349Jr",  // This line sets the Username property of ikeaCustomer2 to "GP349Jr"
                Password = "Bucksin6", // This line sets the Password property of ikeaCustomer2 to "Bucksin6"
            };
            var ikeaCustomer3 = new IkeaCustomer  // This creates a new instance of the IkeaCustomer class and assigns it to the variable ikeaCustomer3
            {
                FirstName = "Lebron", // This sets the FirstName property of ikeaCustomer3 to "Lebron"
                LastName = "Davis", // This sets the LastName property of ikeaCustomer3 to "Davis"
                Username = "LakeshowLD23", // This sets the Username property of ikeaCustomer3 to "LakeshowLD23"
                Password = "LAForLikfe20", // This sets the Password property of ikeaCustomer3 to "LAForLikfe20"
            };
            
            ikeaCustomers = new IkeaCustomers(); // This creates a new instance of the IkeaCustomers class and assigns it to the variable ikeaCustomers
            ikeaCustomers.customers.Add(ikeaCustomer1); // Adds the ikeaCustomer1 object to the customers list property of the ikeaCustomers object
            ikeaCustomers.customers.Add(ikeaCustomer2); // Adds the ikeaCustomer2 object to the customers list property of the ikeaCustomers object
            ikeaCustomers.customers.Add(ikeaCustomer3); //Adds the ikeaCustomer3 object to the customers list property of the ikeaCustomers object

            var ikeaCustomerAppointment1 = new IkeaPersonalShoppingAppointment(); // This creates a new instance of the IkeaPersonalShoppingAppointment class and assigns it to the variable ikeaCustomerAppointment1
            var ikeaCustomerAppointment2 = new IkeaPersonalShoppingAppointment(); //This creates a new instance of the IkeaPersonalShoppingAppointment class and assigns it to the variable ikeaCustomerAppointment2
            var ikeaCustomerAppointment3 = new IkeaPersonalShoppingAppointment(); //This creates a new instance of the IkeaPersonalShoppingAppointment class and assigns it to the variable ikeaCustomerAppointment3


        }

        static void AppointmentPage()
        {
            bool done = false; // creates a boolean variable named 'done' and set it to 'false'
            while (!done) // Starts a while loop that continues as long as 'done' is false
            {
            Console.WriteLine("Choose your option: 1: Login  2: Logout 3: View Your Ikea Personal Shopping Appointment 4: Quit 5: Set Up An Appointment"); // We are asking the user to enter an option from 1-5.
            Console.WriteLine("Please choose one of the options above: "); // We ask the user to choose the following options above
            String option = Console.ReadLine(); // We are reading what the user inputs and store the information into string option
            switch (option) //we start our switch statement
            {
//<<<<<<< Updated upstream
              
                case "1": //when the user enters 1, it leads the user to the login screen
                    LoginScreen(); // the code in loginscreen runs
                    break; //moves on to case 2
                case "2": // leads the user to the logout screen
                    LogoutScreen(); //the code in Logoutscreen void runs
                    break; //moves on to case 3
                case "3": // Allows the user to the view their appointment 
                    ViewIkeaPersonalShoppingAppointment(); //leads to appointment screen
                    break; // brings you to next case.
                case "4": //leads the user to the quit option
                    Console.Clear(); // Quits the screen.
                    break; // moves on to case 5
                case "5": //leads the user to set up an Ikea Appointment
                    SignUpForAnAppointment(); //the code in SetUpAnAppointment runs
                    break; //moves on to default
                default: // test...
                    Console.WriteLine("You entered an incorrect character!"); // The user entered in the wrong character for options
                    break; //our switch statement concludes.
//>>>>>>> Stashed changes
            }


            static void LoginScreen()
                {
                    if (verifyCustomer == null) // Checking if verifyCustomer is null
                    {
                        Console.WriteLine("Please enter your IKEA username: "); // This prints a message asking the user to enter their IKEA username
                        string username = Console.ReadLine(); // This reads the input from the user and store it in the variable username
                        Console.WriteLine("Please enter your IKEA password: "); // This prints a message asking the user to enter their IKEA password
                        string password = Console.ReadLine(); // This reads the input from the user and store it in the variable password
                        verifyCustomer = ikeaCustomers.Verify(username,password); // This calls the Verify method of the ikeaCustomers object to verify the username and password
                        if (verifyCustomer != null) // Checking if verifyCustomer is not null
                        {
                            Console.WriteLine($"Welcome {verifyCustomer.FirstName}"); // If it isn't null then this displays a welcome message with the first name of the verified customer
                        } 
                        else
                        {
                            Console.WriteLine("That username or password is invalid");  // If it is null then this displays an error message indicating that the username or password is invalid
                        }
                    }
                }
            }

            static void LogoutScreen()
            {
                verifyCustomer = null; // Sets the value of verifyCustomer to null, which effectively logs the customer out
                Console.WriteLine("You are logged out!"); // This displays a message indicating that the customer has been logged out
            }

            static void SignUpForAnAppointment()
            {
                Console.Write("What is your First Name: "); // This displays a prompt asking the user to enter their first name
                string firstname = Console.ReadLine(); // Reads the input from the user and stores it in the variable firstname
                Console.Write("What is your Last Name: ");  // This displays a prompt asking the user to enter their last name
                string lastname = Console.ReadLine(); // Reads the input from the user and store it in the variable lastname
                Console.WriteLine("Please type a Username: "); // This displays a prompt asking the user to enter a username
                string username = Console.ReadLine(); // Reads the input from the user and store it in the variable username
                Console.Write("Please enter a Password: "); // This displays a prompt asking the user to enter a password
                string password = Console.ReadLine(); // Reads the input from the user and store it in the variable password
                Console.WriteLine("Awesome! We have created your Ikea profile so you can make appointments!");  // This displays a message indicating that the Ikea profile has been created for the user to make appointments
            }

            static void ViewIkeaPersonalShoppingAppointment()
            {
                if (verifyCustomer == null) // Checks if verifyCustomer is null, indicating that the user is not logged in
                {
                    Console.WriteLine("Oh no, it seems like you are not logged in!"); // If it's true, this displays a message indicating that the user is not logged in and return from the method
                    return;
                }

                var ikeaAppointmentList = ikeaCustomerAppointments.Where(o => o.customerIkea.Username == verifyCustomer.Username);
                // Creates a new variable named ikeaAppointmentList and assign it a filtered list of IkeaPersonalShoppingAppointment objects.
                // The filtering condition checks if the customer's username in each appointment matches the username of the logged-in customer.
                if (ikeaAppointmentList.Count() == 0)   // Checks if the count of ikeaAppointmentList is 0, indicating that the customer has no personal shopping appointments
                {
                    Console.WriteLine("We have no record of your IKEA personal shopping appointment"); // If true, this displays a message indicating that there is no record of their IKEA personal shopping appointment
                }
                else
                {
                    foreach(var IkeaPersonalShoppingAppointment in  ikeaAppointmentList) // If the customer has personal shopping appointments, iterates through each appointment in ikeaAppointmentList
                    {
                        Console.WriteLine(IkeaPersonalShoppingAppointment.appointmentShopping.appointmentDate);  // This displays the appointment date for each appointment
                    }
                }
            }         
        }
    }
}
