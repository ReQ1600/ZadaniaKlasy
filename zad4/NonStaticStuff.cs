using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class NonStaticStuff
    {
        private readonly SortedDictionary<int, string> ArabskieRzymskie = new SortedDictionary<int, string>
        {
            {1, "I" },
            {4,"IV" },
            {5, "V" },
            {9, "IX" },
            {10, "X" },
            {40, "XL" },
            {50, "L" },
            {90, "XC" },
            {100, "C" },
            {400, "CD" },
            {500, "D" },
            {900, "CM" },
            {1000, "M" }
        };
        
        static public string ArabskieNaRzymskie(int number)
        {
            if (number <= 3999 && number >= 1)
            {
                int numberLenght = number.ToString().Length;
                if (numberLenght == 1)
                {
                    return SingleDigit(number);
                }
                else if (numberLenght == 2)
                {
                    return DoubleDigit(number) + SingleDigit(number);
                }
                else if (numberLenght == 3)
                {
                    return TripleDigit(number) + DoubleDigit(number) + SingleDigit(number);
                }
                else
                {
                    return QuadrupleDigit(number) + TripleDigit(number) + DoubleDigit(number) + SingleDigit(number);
                }
                
            }
            else
            {
                Console.WriteLine("Podana liczba musi być z przedziału <1, 3999>");
                return ("-1");
            }
        }
        static public int RzymskieNaArabskie(string number)
        {
            return 0;
        }
        private static string SingleDigit(int number)
        {
            int o = number % 10;
            switch (o)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return "_";
            }
        }
        private static string DoubleDigit(int number)
        {
            int o = number % 100;
            switch (o)
            {
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return "XL";
                case 5:
                    return "L";
                case 6:
                    return "LX";
                case 7:
                    return "LXX";
                case 8:
                    return "LXXX";
                case 9:
                    return "XC";
                default:
                    return "_";
            }
        }
        private static string TripleDigit(int number)
        {
            int o = number % 1000;
            switch (o)
            {
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return "CD";
                case 5:
                    return "D";
                case 6:
                    return "DC";
                case 7:
                    return "DCC";
                case 8:
                    return "DCCC";
                case 9:
                    return "CM";
                default:
                    return "_";
            }
        }
        private static string QuadrupleDigit(int number)
        {
            int o = number % 10000;
            switch (o)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                default:
                    return "_";
            }
        }
    }
}
