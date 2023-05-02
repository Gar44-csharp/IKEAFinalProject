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

            public IkeaCustomer Authenticate(string username, string password)
            {
                var c = customers.Where(o => (o.Username == username) && (o.Password == password));

                if (c.Count() > 0)
                {
                    return c.First();
                }
                else
                {
                    return null;
                }
            }

        }
    }




}

