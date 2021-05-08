using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            Graphics g = Graphics.FromHwnd(this.Handle);
            Pen pen = new Pen(Color.DeepPink);
            pen.Width = 3;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Font font = new Font("Arial Black", 14);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.DiagonalCross, Color.BlueViolet);
            Brush brush = Brushes.Red;

            int x = 100;
            int y = 90;
            int width = 200;
            int height = 100;

            Rectangle rectangle = new Rectangle(x, y, width, height);
            g.DrawRectangle(pen, rectangle);

            g.DrawString("RECTANGLE", font, brush, 130, 130);

            Rectangle elipse = new Rectangle(100, 250, 120, 100);
            g.FillEllipse(hatchBrush, elipse);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
