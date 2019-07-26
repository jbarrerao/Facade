using Facade.Interfaces;
using Facade.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade
{
    public class FacadeHipotec : IHipotec
    {
        public bool IsFiable(Customer customer)
        {
            return ValidateIsFiable(customer);
        }

        private static bool ValidateIsFiable(Customer customer)
        {
            if (!new Bank().HasFunds(customer) || !new Credit().CorrecCreditHistory(customer)
                || !new Loan().HasLoan(customer))
            {
                Console.WriteLine("The customer don't get the loan.");
                return false;
            }
            else
            {
                Console.WriteLine("The customer get the loan.");
                return true;
            }
        }
    }
}
