using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    class PeselValidationResult:Program
    {
        bool peselCorrect;
        string dateOfBirth;
        string Error ="Błąd";
        char[] peselArray;
        enum Gender
        {
            Woman=0,
            Man=1
        }

        public PeselValidationResult(string pesel)
        {
            peselArray = pesel.ToCharArray();
        }

        private string DateOfBirth()
        {
            int month = peselArray[2] * 10 + peselArray[3];
            string sMonth=null;
            switch (month)
            {
                case 1:
                    sMonth = "Styczeń";
                    break;
                default:
                    break;
            }
            return sMonth;
        }
        public void output()
        {
            string s = DateOfBirth();
            Console.WriteLine(s);
        }

    }
}
