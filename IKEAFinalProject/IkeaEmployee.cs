using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKEAFinalProject
{
    public class IkeaEmployee
    {
        private static int autoEmployeeInstance;
        // This line allows the user to input integers for user information

        public int IkeaEmployeeID { get; set; }
        // This line asks for the user to input/create a ID for the account

        public string EmployeeUsername { get; set; }
        // This line asks for the user to input/create a username for the account

        public string EmployeePassword { get; set; }
        // This line asks for the user to input/create a password for the account

        public string FirstName { get; set; }
        // This line outputs the first name

        public string LastName { get; set; }
        // This line outputs the last name

        public IkeaEmployee()
        {
            autoEmployeeInstance++;
            IkeaEmployeeID = autoEmployeeInstance;
            
        }






    }
}
