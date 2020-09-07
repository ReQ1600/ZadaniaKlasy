using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Program
    {
        public double payment;
        static void Main(string[] args)
        {
           
            Eployee emp1 = new Eployee("Jan", "Kowalski", 100.0);
            emp1.RegisterTime(10);
            emp1.PaySalary();

            Console.ReadKey();
        }
    }
}
