using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zad2
{
    class Program
    {
        public static char[] pesel;
        static void Main(string[] args)
        {
            Console.WriteLine("podaj pesel");
            pesel = Console.ReadLine().ToCharArray();

            Console.WriteLine(pesel[3]);
            Console.ReadKey();
        }
    }
}
