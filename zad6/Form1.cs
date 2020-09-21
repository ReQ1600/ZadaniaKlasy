using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad6
{
    public partial class Form1 : Form
    {
        private int? first;
        private int? second;
        private double third;
        private string fourth;
        private bool f;
        private bool s;
        private bool t;
        private bool fo;
        public Form1()
        {
            InitializeComponent();
            lbl.Text = "";
            f = false;
            s = false;
            t = false;
            fo = false;
        }


        private void Cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = true;
            switch (cb1.SelectedIndex)
            {
                case 0:
                    first = null;
                    break;
                case 1:
                    first = 1;
                    break;
                case 2:
                    first = 2;
                    break;
                case 3:
                    first = 3;
                    break;
                case 4:
                    first = 4;
                    break;
                case 5:
                    first = 5;
                    break;
                case 6:
                    first = 6;
                    break;
                case 7:
                    first = 7;
                    break;
                case 8:
                    first = 8;
                    break;
                case 9:
                    first = 9;
                    break;
            }
        }
        private void Cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = true;
            switch (cb2.SelectedIndex)
            {
                case 0:
                    second = 0;
                    break;
                case 1:
                    second = 1;
                    break;
                case 2:
                    second = 2;
                    break;
                case 3:
                    second = 3;
                    break;
                case 4:
                    second = 4;
                    break;
                case 5:
                    second = 5;
                    break;
                case 6:
                    second = 6;
                    break;
                case 7:
                    second = 7;
                    break;
                case 8:
                    second = 8;
                    break;
                case 9:
                    second = 9;
                    break;
            }
        }

        private void Cb3_SelectedIndexChanged(object sender, EventArgs e)
        {
            t = true;
            switch (cb3.SelectedIndex)
            {
                case 0:
                    third = 0.001;
                    break;
                case 1:
                    third = 0.01;
                    break;
                case 2:
                    third = 0.1;
                    break;
                case 3:
                    third = 1;
                    break;
                case 4:
                    third = 10;
                    break;
                case 5:
                    third = 100;
                    break;
                case 6:
                    third = 1000;
                    break;
                case 7:
                    third = 10000;
                    break;
                case 8:
                    third = 0.0001;
                    break;
                case 9:
                    third = 0.00001;
                    break;
            }
        }
        private void Cb4_SelectedIndexChanged(object sender, EventArgs e)
        {
            fo = true;
            switch (cb4.SelectedIndex)
            {
                case 0:
                    fourth = "\u00B1 1%";
                    break;
                case 1:
                    fourth = "\u00B1 2%";
                    break;
                case 2:
                    fourth = "\u00B1 0.5%";
                    break;
                case 3:
                    fourth = "\u00B1 0.25%";
                    break;
                case 4:
                    fourth = "\u00B1 0.10%";
                    break;
                case 5:
                    fourth = "\u00B1 0.05%";
                    break;
                case 6:
                    fourth = "\u00B1 5%";
                    break;
                case 7:
                    fourth = "\u00B1 10%";
                    break;
            }
        }
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCount_Click(object sender, EventArgs e)
        {
            
            if (f && s && t && fo)
            {
                int number = Convert.ToInt32($"{first}{second}");
                lbl.Text = $"Opór wynosi: {number*third}K\u2126 z tolerancją {fourth}";
            }
            else
            {
                MessageBox.Show("Nie podano wszystkich danych");
            }
        }


    }
}
