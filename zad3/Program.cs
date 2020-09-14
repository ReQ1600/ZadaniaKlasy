using System;
using System.Collections;
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
            Customer c2 = new Customer("Agnieszka", "Słup", 2);
            Customer c3 = new Customer("Konrad", "Konradowicz",1);
            Customer c4 = new Customer("Jan", "Pawlak",3);
            Customer c5 = new Customer("Jan", "Pawalak",2);

            Console.WriteLine(c2.ToString());
            QueuePriority queue = new QueuePriority();
            queue.Enqueue(c1);
            queue.Enqueue(c2);
            queue.Enqueue(c3);
            queue.Enqueue(c4);

            Console.WriteLine(queue.Count());

            //tylko wyświetla tablice (nic ważnego)
            Hashtable stats = queue.Stats();
            foreach (string item in stats.Keys)
            {
                Console.WriteLine(item +" "+stats[item]);
            }


            Console.ReadKey();
        }
    }
}
