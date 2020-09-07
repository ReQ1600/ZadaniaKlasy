using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Eployee : Program
    {

        string name;
        string surname;
        double hourlyRate;
        Double payment;
        
        public Eployee(string name="Nie podano", string surname="Nie podano", double hourlyRate=0.0)
        {
            this.name = name;   this.surname = surname; this.hourlyRate = hourlyRate;
        }

        public void RegisterTime(double hours)
        {
            if (hours <= 8&&hours>0)
            {
                payment = hours*hourlyRate;
            }
            else if (hours>8)
            {
                payment = payment + 8 * 100 + (hours-8)*200;
            }
            else
            {
                payment = payment + 0;
            }
        }

        public void PaySalary()
        {
            Console.WriteLine($"Stan należności po stronie pracodawcy={payment}");
        }
    }
}
