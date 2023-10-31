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

        private void tmr_Tick(object sender, EventArgs e)
        {
            krokodial.Left = krokodial.Left + 20;
            if (krokodial.Left + krokodial.Width >= this.Width)
            {
                tmr.Stop();
                btnStart.Text = "Детей съели :( ";
                return;
            }
        }

        private bool isAnimating = false;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (isAnimating)
            {
                //возвращает изображение в начальное положение
                //(устанавливает значение свойства Left изображения pct в 0 пикселей)
                tmr.Stop();
                krokodial.Left = 0;
                btnStart.Text = "Вы спасли детей!";
                isAnimating = false;
            }
            else
            {
                tmr.Start();
                btnStart.Text = "Спасти детей!";
                //Устанавливает значение переменной(выполняется)
                isAnimating = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
