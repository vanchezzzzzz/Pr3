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

namespace PictureViewer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Цвета
            Color purple = Color.Purple;
            Color yellow = Color.Yellow;
            Color red = Color.Red;

            // Перья для различных стилей линий
            Pen solidPen = new Pen(red, 2);
            Pen dashedPen = new Pen(purple, 8) { DashStyle = DashStyle.Dash };
            Pen dottedPen = new Pen(yellow, 4) { DashStyle = DashStyle.Dot };

            // Заливка
            SolidBrush solidBrush = new SolidBrush(purple);

            // Рисуем линии различных стилей
            g.DrawLine(solidPen, 20, 20, 200, 20);
            g.DrawLine(dashedPen, 20, 50, 200, 50);
            g.DrawLine(dottedPen, 20, 80, 200, 80);

            // Рисуем круг
            g.DrawEllipse(solidPen, 50, 120, 100, 100);
            g.FillEllipse(solidBrush, 200, 120, 100, 100);

            // Рисуем прямоугольники
            g.DrawRectangle(solidPen, 20, 250, 120, 80);
            g.FillRectangle(solidBrush, 200, 250, 120, 80);
        }
    }
}
