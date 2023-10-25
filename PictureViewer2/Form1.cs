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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*добавление переменных
             * и перевод их в целочисленный тип*/
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);
            //Проверка верности значений и вывод ошибки
            if (fromX > toX)
            {
                MessageBox.Show("Неверные значения");
                txtX1.Text = "";
                txtX2.Text = "";
            }
            //Проверка верности значений и вывод ошибки
            if (fromY > toY)
            {
                MessageBox.Show("Неверные значения");
                txtY1.Text = "";
                txtY2.Text = "";
            }
            for (int x = fromX; x<= toX; x++)
            {
                /*вложенный цикл для расчета функции
                 * внешний цикл будет перебирать переменную x
                 * а внутренний - y*/
                for (int y = fromY; y<= toY; y++)
                {
                    //внесение результатов вычисление в поле результата
                    lstResult.Items.Add($"z(x,y)={x}-{y} = {x - y}");
                }    
            }
        }
    }
}
