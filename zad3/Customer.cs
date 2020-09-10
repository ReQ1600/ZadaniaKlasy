using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class Customer
    {
        private string fname;
        private string lname;
        private int priority; //1-3
        public string Fname { get { return fname; }}
        public string Lname { get { return lname; }}
        public int Priority { get { return priority; }}
        /// <summary>
        /// tworzy nowego klienta
        /// </summary>
        /// <param name="fname">podać imie klienta</param>
        /// <param name="name">podać nazwisko klienta</param>
        /// <param name="priority">podać priorytet klienta</param>
        public Customer(string fname, string lname, int priority)
        {
            this.fname = fname; this.lname = lname; this.priority = priority;
        }
        /// <summary>
        /// dodaje do kolejki nowego klienta
        /// </summary>
        /// <returns></returns>
    }
}
