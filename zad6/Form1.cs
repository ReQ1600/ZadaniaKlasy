using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
            panel1.BackColor = Color.FromArgb(225, 229, 234);
            panel2.BackColor = Color.FromArgb(225, 229, 234);
            panel3.BackColor = Color.FromArgb(225, 229, 234);
            panel4.BackColor = Color.FromArgb(225, 229, 234);
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
                    panel1.BackColor = Color.Black;
                    break;
                case 1:
                    first = 1;
                    panel1.BackColor = Color.SaddleBrown;
                    break;
                case 2:
                    first = 2;
                    panel1.BackColor = Color.Red;
                    break;
                case 3:
                    first = 3;
                    panel1.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    first = 4;
                    panel1.BackColor = Color.Yellow;
                    break;
                case 5:
                    first = 5;
                    panel1.BackColor = Color.Green;
                    break;
                case 6:
                    first = 6;
                    panel1.BackColor = Color.Blue;
                    break;
                case 7:
                    first = 7;
                    panel1.BackColor = Color.DarkViolet;
                    break;
                case 8:
                    first = 8;
                    panel1.BackColor = Color.Gray;
                    break;
                case 9:
                    first = 9;
                    panel1.BackColor = Color.White;
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
                    panel2.BackColor = Color.Black;
                    break;
                case 1:
                    second = 1;
                    panel2.BackColor = Color.SaddleBrown;
                    break;
                case 2:
                    second = 2;
                    panel2.BackColor = Color.Red;
                    break;
                case 3:
                    second = 3;
                    panel2.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    second = 4;
                    panel2.BackColor = Color.Yellow;
                    break;
                case 5:
                    second = 5;
                    panel2.BackColor = Color.Green;
                    break;
                case 6:
                    second = 6;
                    panel2.BackColor = Color.Blue;
                    break;
                case 7:
                    second = 7;
                    panel2.BackColor = Color.DarkViolet;
                    break;
                case 8:
                    second = 8;
                    panel2.BackColor = Color.Gray;
                    break;
                case 9:
                    second = 9;
                    panel2.BackColor = Color.White;
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
                    panel3.BackColor = Color.Black;
                    break;
                case 1:
                    third = 0.01;
                    panel3.BackColor = Color.SaddleBrown;
                    break;
                case 2:
                    third = 0.1;
                    panel3.BackColor = Color.Red;
                    break;
                case 3:
                    third = 1;
                    panel3.BackColor = Color.DarkOrange;
                    break;
                case 4:
                    third = 10;
                    panel3.BackColor = Color.Yellow;
                    break;
                case 5:
                    third = 100;
                    panel3.BackColor = Color.Green;
                    break;
                case 6:
                    third = 1000;
                    panel3.BackColor = Color.Blue;
                    break;
                case 7:
                    third = 10000;
                    panel3.BackColor = Color.DarkViolet;
                    break;
                case 8:
                    third = 0.0001;
                    panel3.BackColor = Color.Goldenrod;
                    break;
                case 9:
                    third = 0.00001;
                    panel3.BackColor = Color.Silver;
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
                    panel4.BackColor = Color.SaddleBrown;
                    break;
                case 1:
                    fourth = "\u00B1 2%";
                    panel4.BackColor = Color.Red;
                    break;
                case 2:
                    fourth = "\u00B1 0.5%";
                    panel4.BackColor = Color.Green;
                    break;
                case 3:
                    fourth = "\u00B1 0.25%";
                    panel4.BackColor = Color.Blue;
                    break;
                case 4:
                    fourth = "\u00B1 0.10%";
                    panel4.BackColor = Color.DarkViolet;
                    break;
                case 5:
                    fourth = "\u00B1 0.05%";
                    panel4.BackColor = Color.Gray;
                    break;
                case 6:
                    fourth = "\u00B1 5%";
                    panel4.BackColor = Color.Goldenrod;
                    break;
                case 7:
                    fourth = "\u00B1 10%";
                    panel4.BackColor = Color.Silver;
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

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pb_Click(object sender, EventArgs e)
        {
            Process.Start("https://pl.mouser.com/technical-resources/conversion-calculators/resistor-color-code-calculator");
        }

        private void Pb_MouseHover(object sender, EventArgs e)
        {
            lbl.Text = "Strona z której został \"zapożyczony\" obraz";
        }

        private void Pb_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
