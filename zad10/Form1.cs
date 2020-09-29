using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int maxX;
        int maxY;
        int minY;
        Color colour = new Color();
        Random r = new Random(Guid.NewGuid().GetHashCode());
        Random g = new Random(Guid.NewGuid().GetHashCode());
        Random b = new Random(Guid.NewGuid().GetHashCode());
        Random x = new Random(Guid.NewGuid().GetHashCode());
        Random y = new Random(Guid.NewGuid().GetHashCode());
        private void Form1_Load(object sender, EventArgs e)
        {
            Form frm = (Form)sender;
            maxX = frm.Size.Width - panel1.Size.Width;
            maxY = frm.Size.Height;
            minY = panel1.Size.Height;
        }
        private void PositionChanger()
        {
            panel1.Location = new System.Drawing.Point(Convert.ToInt32(x.Next(maxX)),Convert.ToInt32(y.Next(minY,maxY)));
        }

        private void ColourChanger()
        {
            colour = Color.FromArgb (Convert.ToInt32(r.Next(255)), Convert.ToInt32(g.Next(255)), Convert.ToInt32(b.Next(255)));
            panel1.BackColor = colour;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            PositionChanger();
            ColourChanger();
        }
    }
}
