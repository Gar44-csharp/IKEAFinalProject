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
        //
        public int IkeaEmployeeID { get; set; }
        //
        public string EmployeeUsername { get; set; }
        //
        public string EmployeePassword { get; set; }
        //
        public string FirstName { get; set; }
        //
        public string LastName { get; set; }
        //

        public IkeaEmployee()
        {
            autoEmployeeInstance++;
            //
            IkeaEmployeeID = autoEmployeeInstance;
            //
        }






    }
}
