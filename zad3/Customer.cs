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
        private int priority;

        public int Priority { get { return priority; } }
        public string FullName { get { return fname +" "+ lname; } }
        public Customer(string fname, string lname, int priority)
        {
            this.fname = fname; this.lname = lname; this.priority = priority;
        }

        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
