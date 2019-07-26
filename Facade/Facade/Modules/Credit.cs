using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modules
{
    public class Credit
    {
        public bool CorrecCreditHistory (Customer c)
        {
            Console.WriteLine("Customer has correct history.");
            return true;
        }
    }
}
