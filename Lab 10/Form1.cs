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
            g.Clear(Color.White);
            SolidBrush A = new SolidBrush(Color.Red);
            g.FillEllipse(A, 110, 70, 400, 400);
            SolidBrush B = new SolidBrush(Color.Black);
            g.FillRectangle(B, 200, 100, 20, 1000);
            g.FillRectangle(B, 0, 300, 1000, 100);
            g.FillRectangle(B, 400, 100, 20, 1000);
            g.FillRectangle(B, 160, 150, 300, 20);
            g.FillRectangle(B, 300, 100, 20, 50);
            Pen P = new Pen(Color.Black,30);
            g.DrawArc(P, 160, 30, 300, 80, 0, 180);
        }
    }
}
