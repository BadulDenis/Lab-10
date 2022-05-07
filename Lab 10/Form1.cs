using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.AliceBlue);
            for (int i = 0; i < 50; i++)
                g.DrawLine(new Pen(Brushes.Red, 3),
                0, 4 * i + 20, 500, 4 * i + 20);
            SolidBrush B = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(B, 100, 100, 100, 100);
        }
    }
}
