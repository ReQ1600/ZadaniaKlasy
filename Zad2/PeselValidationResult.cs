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

        public string DateOfBirth()
        {
            int month=0;
            int yearFirstNumbers;
            if (Convert.ToInt32(peselArray[2].ToString()) - 8 >= 0)
            {
                month = (Convert.ToInt32(peselArray[2].ToString()) - 8) * 10 + Convert.ToInt32(peselArray[3].ToString());
                yearFirstNumbers = 18;
            }
            else if (Convert.ToInt32(peselArray[2].ToString()) - 6 >= 0)
            {
                month = (Convert.ToInt32(peselArray[2].ToString()) - 6) * 10 + Convert.ToInt32(peselArray[3].ToString());
                yearFirstNumbers = 22;
            }
            else if ((Convert.ToInt32(peselArray[2].ToString()) - 4 >= 0))
            {
                month = (Convert.ToInt32(peselArray[2].ToString()) - 4) * 10 + Convert.ToInt32(peselArray[3].ToString());
                yearFirstNumbers = 21;
            }
            else if ((Convert.ToInt32(peselArray[2].ToString()) - 2 >= 0))
            {
                month = (Convert.ToInt32(peselArray[2].ToString()) - 2) * 10 + Convert.ToInt32(peselArray[3].ToString());
                yearFirstNumbers = 20;
            }
            else
            {
                month = Convert.ToInt32(peselArray[2].ToString()) * 10 + Convert.ToInt32(peselArray[3].ToString());
                yearFirstNumbers = 19;

            }
            string sMonth = null;
            switch (month)
            {
                case 1:
                    sMonth = "Styczeń";
                    break;
                case 2:
                    sMonth = "Luty";
                        break;
                case 3:
                    sMonth = "Marzec";
                    break;
                case 4:
                    sMonth = "Kwiecień";
                    break;
                case 5:
                    sMonth = "Maj";
                    break;
                case 6:
                    sMonth = "Czerwiec";
                    break;
                case 7:
                    sMonth = "Lipiec";
                    break;
                case 8:
                    sMonth = "Sierpień";
                    break;
                case 9:
                    sMonth = "Wrzesień";
                    break;
                case 10:
                    sMonth = "Październik";
                    break;
                case 11:
                    sMonth = "Listopad";
                    break;
                case 12:
                    sMonth = "Grudnień";
                    break;
            }

            return $"{yearFirstNumbers}{peselArray[0]}{peselArray[1]} {sMonth}";
        }
        public void output()
        {
            dateOfBirth = DateOfBirth();
            Console.WriteLine(dateOfBirth);
        }

    }
}
