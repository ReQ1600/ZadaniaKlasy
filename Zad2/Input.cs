using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class Input
    {
        public char[] CharArray;

        public bool input()
        {
            Console.WriteLine("podaj pesel");
            char[] CharArray= Console.ReadLine().ToCharArray();
            return true;
        }

    }
}
