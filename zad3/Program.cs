using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer("Adam", "Nowak", 1);
            Customer c2 = new Customer("Agnieszka", "Słup", 1);
            Customer c3 = new Customer("Tomasz", "Kreatywny", 2);
            Customer c4 = new Customer("Konrad", "Konradowicz",3);

            QueuePriority.Enqueue(c1);
            QueuePriority.Enqueue(c2);
            QueuePriority.Enqueue(c3);
            QueuePriority.Enqueue(c4);
            


            Console.ReadKey();
        }
    }
}
