using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    public static class conversion
    {
        public static string ArabskieNaRzymskie(int number)
        {
            string rNumber = NonStaticStuff.ArabskieNaRzymskie(number);
            return (rNumber);
        }
        public static int RzymskieNaArabskie(string number)
        {
            int aNumber = NonStaticStuff.RzymskieNaArabskie(number);
            return (aNumber);
        }
    }
}
