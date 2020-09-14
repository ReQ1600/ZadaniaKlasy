using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class NonStaticStuff//w sensie nie statyczna klasa (nie miałem pomysłu jak nazwać)
    {   
        static public string ArabskieNaRzymskie(int number)
        {
            
            if (number <= 3999 && number >= 1)
            {
                char[] numberArray = number.ToString().ToCharArray();
                int numberLenght = number.ToString().Length;
                if (numberLenght == 1)
                {
                    return SingleDigit(numberArray, 0);
                }
                else if (numberLenght == 2)
                {
                    return DoubleDigit(numberArray, 0) + SingleDigit(numberArray, 1);
                }
                else if (numberLenght == 3)
                {
                    return TripleDigit(numberArray, 0) + DoubleDigit(numberArray, 1) + SingleDigit(numberArray, 2);
                }
                else
                {
                    return QuadrupleDigit(numberArray, 0) + TripleDigit(numberArray, 1) + DoubleDigit(numberArray, 2) + SingleDigit(numberArray, 3);
                }
                
            }
            else
            {
                Console.WriteLine("Podana liczba musi być z przedziału <1, 3999>");
                return (null);
            }
        }
        static public int RzymskieNaArabskie(string number)
        {
            return 0;
        }
        private static string SingleDigit(char[] numberArray,int n)
        {
            int first = Convert.ToInt32(numberArray[n].ToString());
            switch (first)
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
            }
            return null;
        }
        private static string DoubleDigit(char[] numberArray, int n)
        {
            int second = Convert.ToInt32(numberArray[n].ToString());
            switch (second)
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
            }
            return null;
        }
        private static string TripleDigit(char[] numberArray, int n)
        {
            int third = Convert.ToInt32(numberArray[n].ToString());
            switch (third)
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
            }
            return null;
        }
        private static string QuadrupleDigit(char[] numberArray, int n)
        {
            int fourth = Convert.ToInt32(numberArray[n].ToString());
            switch (fourth)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
            }
            return null;
        }
    }
}
