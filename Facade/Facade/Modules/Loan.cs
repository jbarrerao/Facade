using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modules
{
    public class Loan
    {
        public bool HasLoan(Customer c)
        {
            Console.WriteLine("Customer has loan.");
            return false;
        }
    }
}
