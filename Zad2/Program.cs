using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj pesel");
            PeselValidationResult pesel = new PeselValidationResult(Console.ReadLine());
            pesel.output();
            Console.ReadKey();
        }
    }
}
