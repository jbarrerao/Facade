using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modules
{
    public class Bank
    {
        public bool HasFunds(Customer c)
        {
            Console.WriteLine("The customer has funds");
            return true;
        }
    }
}
