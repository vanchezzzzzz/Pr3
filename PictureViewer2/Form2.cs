using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сичтаем с формы требуемые значени
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXMax.Text);
            double Step = double.Parse(textBoxStep.Text);
            //количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;
            //массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double Xk = 2;
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            //расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение
                X[i] = Xmin + Step * i;
                //вычисляем значение функций в точке X
                y1[i] = Math.Pow(10, -2) * (-1.5) * (0.75) / (X[i] + Math.Cos(Math.Sqrt(Math.Pow((-1.25), 3) * X[i])));
                y2[i] = Math.Sqrt(1-(Math.Pow(Math.Abs(Xk-1),2)));
            }
            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            //определяем шаг сетки [eq
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            //добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(X, y1);
            chart1.Series[1].Points.DataBindXY(X, y2);
        }
    }
}
