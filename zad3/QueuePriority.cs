﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    public class QueuePriority : Customer
    {
        string fname;
        string lname;
        int priority;

        static Queue<string> customersf = new Queue<string>();//kolejka osob ktore zostana obsluzone pierwsze
        static Queue<string> customerss = new Queue<string>();//drugie
        static Queue<string> customerst = new Queue<string>();//trzecie
        static Queue<string> customersTrueList = new Queue<string>();//kolejka wszystkich osob


        QueuePriority(string fname, string lname, int priority) : base(fname, lname, priority)
        {
            this.fname = fname; this.lname = lname; this.priority = priority;
        }

        /// <summary>
        /// dodaje klienta do kolejki
        /// </summary>
        /// <param name="customer">nazwa klienta</param>
        public static void Enqueue(Customer customer)
        {
            if (customer.Priority == 3)
            {
                customersf.Enqueue(customer.Fname+" "+customer.Lname);
                
            }
            else if (customer.Priority==2)
            {
                customerss.Enqueue( customer.Fname+" "+customer.Lname);
                
            }
            else
            {
                customerst.Enqueue(customer.Fname+" "+customer.Lname);
                
            }
            Sort();
            
        }
        public static void Sort()
        {
            customersTrueList.Clear();
            if (customersf.Count() > 0)
            {
                foreach (var customer in customersf)
                {
                    customersTrueList.Enqueue(customer);
                }
            }
           if (customerss.Count()>0)
            {
                foreach (var customer in customerss)
                {
                    customersTrueList.Enqueue(customer);
                }
            }
            if (customerst.Count()>0)
            {
                foreach (var customer in customerst)
                {
                    customersTrueList.Enqueue(customer);
                }
            }
        }
    }
}
