using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad9
{
    enum Choice
    {
        kgFunty = 0,
        funtyKg = 1,
        cF = 2,
        fC = 3,
        kmhKts = 4,
        ktsKmh = 5
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }
        private void BtnZero_Click(object sender, EventArgs e)
        {
            Reset();
        }





        private void Reset()
        {
            lblIn.Text = "";
            lblOut.Text = "";
            tbOut.Text = "";
            tbIn.Text = "";
            lbChoice.ClearSelected();
            tbIn.Enabled = false;

        }
        private void LbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChoice.Items.Count != 0)
            {
                tbIn.Enabled = true;
            }
            switch (lbChoice.SelectedIndex)
            {
                case (int)Choice.kgFunty:
                    lblIn.Text = "kg";
                    lblOut.Text = "lb";
                    break;
                case (int)Choice.funtyKg:
                    lblIn.Text = "lb";
                    lblOut.Text = "kg";
                    break;
                case (int)Choice.cF:
                    lblIn.Text = "\u2103";
                    lblOut.Text = "\u2109";
                    break;
                case (int)Choice.fC:
                    lblIn.Text = "\u2109";
                    lblOut.Text = "\u2103";
                    break;
                case (int)Choice.kmhKts:
                    lblIn.Text = "km/h";
                    lblOut.Text = "kts";
                    break;
                case (int)Choice.ktsKmh:
                    lblIn.Text = "kts";
                    lblOut.Text = "km/h";
                    break;
                default:
                    break;
            }
        }
        private void TbIn_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(tbIn.Text.ToString(), out _)) return;
            else
            {
                switch (lbChoice.SelectedIndex)
                {
                    case (int)Choice.kgFunty:
                        tbOut.Text = Math.Round((Convert.ToDouble(tbIn.Text) * 0.4095124), 4).ToString();
                        break;
                    case (int)Choice.funtyKg:
                        tbOut.Text = Math.Round((Convert.ToDouble(tbIn.Text) / 0.4095124), 4).ToString();
                        break;
                    case (int)Choice.cF:
                        tbOut.Text = Math.Round((Convert.ToDouble(tbIn.Text)*1.8+32), 4).ToString();
                        break;
                    case (int)Choice.fC:
                        tbOut.Text = Math.Round(((Convert.ToDouble(tbIn.Text) - 32) / 1.8), 4).ToString();
                        break;
                    case (int)Choice.kmhKts:
                        tbOut.Text = Math.Round(Convert.ToDouble(tbIn.Text) / 1.85166, 4).ToString();
                        break;
                    case (int)Choice.ktsKmh:
                        tbOut.Text = Math.Round(Convert.ToDouble(tbIn.Text) * 1.85166, 4).ToString();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
