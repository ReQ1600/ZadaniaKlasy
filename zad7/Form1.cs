using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            while (lb1.SelectedIndices.Count>0)
            {
                foreach (var item in lb1.SelectedIndices)
                {
                    lb2.Items.Add(lb1.Items[Convert.ToInt32(item)]);
                    lb1.Items.RemoveAt(Convert.ToInt32(item));
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            while (lb2.SelectedIndices.Count>0)
            {
                foreach (var item in lb2.SelectedIndices)
                {
                    lb1.Items.Add(lb2.Items[Convert.ToInt32(item)]);
                    lb2.Items.RemoveAt(Convert.ToInt32(item));
                }
            }
        }
    }
}
