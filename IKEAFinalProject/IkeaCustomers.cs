using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IKEAFinalProject.IkeaCustomers;

namespace IKEAFinalProject
{
    public class IkeaCustomers
    {
        internal class Customers
        {
            public List<IkeaCustomer> customers { get; set; }

            public Customers()
            {
                customers = new List<IkeaCustomer>();
            }
            // This function allows the user to input new information or for returning users to input info

            public IkeaCustomer Verify(string username, string password)
            {
                var c = customers.Where(o => (o.Username == username) && (o.Password == password));
                // This function checks whether or not the user has inputed the right username and or password

                if (c.Count() > 0)
                {
                    return c.First();
                    // If the user imout the right information they get access to the main menu
                }
                else
                {
                    return null;
                    // If the username and or password is wrong the program will return a invalid comment
                }
            }

        }
    }




}

