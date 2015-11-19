using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.UCR_Rectangles
{
    public partial class Rectangles_form : Form
    {
        public Rectangles_form()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string box1 = textBox1_window.Text;
            string box2 = textBox2_window.Text;
            string box3 = textBox3.Text;
            string box4 = textBox4.Text;
            int a = int.Parse(box1);
            int b = int.Parse(box2);
            int c = int.Parse(box3);
            int d = int.Parse(box4);

            string xlat = textBox_latitude.Text;
            string ylat = textBox_lon.Text;

            DrawRectangle(a, b, c, d);
        }
        private void DrawRectangle(int a, int b, int c, int d)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(a, b, c, d));
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
