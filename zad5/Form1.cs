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

namespace zad5
{
    public partial class FormMain : Form
    {
        bool first;
        bool mathOpTypeDecided;
        bool comaf;
        bool sign;
        bool comas;
        double fBtn;
        double sBtn;
        double fnum;
        double snum;
        char mathOpType;
        public FormMain()
        {
            InitializeComponent();
            lbl.Text = "";
            first = true;
            mathOpTypeDecided = false;
            comaf = false;
            comas = false;
            sign = false;
        }
        private void Lbl_Click(object sender, EventArgs e)
        {
            
        }
        private void BC_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
            first = true;
            mathOpTypeDecided = false;
            comaf = false;
            comas = false;
            sign = false;
            fBtn=0;
            sBtn =0;
            fnum = -1;
            snum = -1;
            mathOpType ='_';
        }

        private void BEq_Click(object sender, EventArgs e)
        {
            if (fnum != -1 && snum != -1)
            {
                switch (mathOpType)
                {
                    case '+':
                        lbl.Text = $"{fnum + snum}";
                        break;
                    case '-':
                        lbl.Text = $"{fnum - snum}";
                        break;
                    case '*':
                        lbl.Text = $"{fnum * snum}";
                        break;
                    case '/':
                        lbl.Text = $"{fnum / snum}";
                        break;
                }
            }
        }
        private void BPlus_Click(object sender, EventArgs e)
        {
            mathOpType = '+';
            lbl.Text += "+";
            sign = true;
            mathOpTypeDecided = true;
        }

        private void BMinus_Click(object sender, EventArgs e)
        {
            mathOpType = '-';
            lbl.Text += "-";
            mathOpTypeDecided = true;
            sign = true;

        }

        private void BMulti_Click(object sender, EventArgs e)
        {
            mathOpType = '*';
            lbl.Text += "x";
            mathOpTypeDecided = true;
            sign = true;
        }

        private void BDiv_Click(object sender, EventArgs e)
        {
            sign = true;
            lbl.Text += "/";
            mathOpTypeDecided = true;
            mathOpType = '/';
        }



        private void B0_Click(object sender, EventArgs e)
        {
            DisplayNum(0);
            FOSNum();
        }

        private void B7_Click(object sender, EventArgs e)
        {
            DisplayNum(7);
            FOSNum();
        }

        private void BComa_Click(object sender, EventArgs e)
        {
            if (!first && !mathOpTypeDecided && !comaf)
            {
                lbl.Text += ",";
                comaf = true;
            }
            else if (!first && !mathOpTypeDecided && comaf)
            {
                string txts = null;
                char[] txtc = lbl.Text.ToCharArray();
                ArrayList txt = new ArrayList(txtc);
                int place = -1;
                foreach (char item in txt)
                {
                    place++;
                    if (item.Equals(','))
                    {
                        txt.RemoveAt(place);
                        break;
                    }
                    txts += item;
                }
                fnum = Convert.ToDouble(txts);
                lbl.Text = txts;
                comaf = false;
            }
            else if (!first && mathOpTypeDecided && !comas)
            {
                lbl.Text += ",";
                comas = true;
            }
            else if (!first && mathOpTypeDecided && comas)
            {
                ArrayList txt = new ArrayList(lbl.Text.ToCharArray());
                string txth = null;
                string txts = null;
                int place = -1;
                foreach (char item in txt)
                {
                    if (item.Equals('-') || item.Equals('+') || item.Equals('x') || item.Equals('/'))
                    {
                        txth = "";
                    }
                    txth += item;
                }
                ArrayList sTxt = new ArrayList(txth.ToCharArray());
                foreach (char item in sTxt)
                {
                    place++;
                    if (item.Equals(','))
                    {
                       sTxt.RemoveAt(place);
                        break;
                    }
                    txts += item;
                }
                snum = Convert.ToDouble(txts);
                lbl.Text = $"{fnum}{mathOpType}{snum}";
                comas = false;

            }
            else
            {
                MessageBox.Show("coś się wypierdutnęło");
            }
        }

        private void B9_Click(object sender, EventArgs e)
        {
            DisplayNum(9);
            FOSNum();
        }

        private void B8_Click(object sender, EventArgs e)
        {
            DisplayNum(8);
            FOSNum();
        }

        private void B4_Click(object sender, EventArgs e)
        {
            DisplayNum(4);
            FOSNum();
        }

        private void B6_Click(object sender, EventArgs e)
        {
            DisplayNum(6);
            FOSNum();
        }

        private void B5_Click(object sender, EventArgs e)
        {
            DisplayNum(5);
            FOSNum();
        }

        private void B3_Click(object sender, EventArgs e)
        {
            DisplayNum(3);
            FOSNum();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            DisplayNum(2);
            FOSNum();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            DisplayNum(1);
            FOSNum();
        }

        private void DisplayNum(int Numbtn)
        {
            if (first==true)
            {
                fBtn = Numbtn;
                lbl.Text = $"{Numbtn}";
                first = false;
            }
            else
            {
                sBtn = Numbtn;
                lbl.Text += $"{Numbtn}";
            }
        }
        private void FOSNum()
        {
            string tfnum="";
            string tsnum="";
            ArrayList lblTxt = new ArrayList(lbl.Text.ToCharArray());
            if (!first&&sign)
            {
                foreach (char item in lblTxt)
                {
                    if (item.Equals('-') || item.Equals('+') || item.Equals('x') || item.Equals('/'))
                    {
                        break;
                    }
                    tfnum += item;
                }
                fnum = Convert.ToDouble(tfnum);
            }
            else if (!first&&!sign)
            {
                fnum = Convert.ToDouble(lbl.Text);
            }
            if (!first && sign)
            {
                comaf = true;
                foreach (char item in lblTxt)
                {
                    tsnum += item;
                    if (item.Equals('-') || item.Equals('+') || item.Equals('x') || item.Equals('/'))
                    {
                        tsnum = "";
                    }
                    if (!tsnum.Equals(""))
                    {
                        snum = Convert.ToDouble(tsnum);
                    }
                }
            }
        }


    }
}
