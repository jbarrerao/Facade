using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Modules
{
    public class Customer
    {
        private string Name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
    }
}
