using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad8
{
    public partial class Form1 : Form
    {
        Hashtable values = new Hashtable(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb.Text = "";
        }

        private void BtnCount_Click(object sender, EventArgs e)
        {

            int place = (int)num.Value;
            int oldNum = 0;
            int number = 1;
            int rNum=1;

            if (values.ContainsKey(place))
            {
                tb.Text = $"{values[place]}";
            }
            else
            {
                if (rbIte.Checked)
                {
                    for (int i = 1; i < place; i++)
                    {
                        number += oldNum;
                        oldNum = number - oldNum;
                    }
                    tb.Text = number.ToString();
                }
                else
                {
                    tb.Text = FibonacciReccurence();
                }

                values.Add(place, number);
            }


            String FibonacciReccurence()
            {
                if (rNum<place)
                {
                    number += oldNum;
                    oldNum = number - oldNum;
                    rNum++;
                    FibonacciReccurence();
                }
                if(rNum==place)
                {
                    return number.ToString();
                }
                return null;
            }
        }

    }
}
