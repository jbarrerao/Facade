﻿using Facade.Facade;
using Facade.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new FacadeHipotec().IsFiable(new Customer("Juan Pablo")));
            Console.ReadKey();
        }
    }
}
