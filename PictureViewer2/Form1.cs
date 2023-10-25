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

        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            //Получить текущие значения из поля секунд
            int seconds = Int32.Parse(txtSeconds.Text);
            //Получить текущие значения из поля минут
            int minutes = Int32.Parse(txtMinutes.Text);
            //Добавление секунд
            seconds += 1;
            //цикл проверки секунд и "перевод" их в минуты
            if (seconds >= 60)
            {
                seconds = 0;
                minutes += 1;
            }
            //обновление поля секунд новым значением
            txtSeconds.Text = seconds.ToString();
            //обновление поля минут новым значением
            txtMinutes.Text = minutes.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Отключение таймера
            tmrSecundomer.Enabled = false;
            //Получение текущей даты
            DateTime currentTime = DateTime.Now;
            //Внесение даты в строку
            txtDate.Text = currentTime.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //переключение таймера при нажатии на кнопку
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;
            //изменение надписи на кнопке
            if(tmrSecundomer.Enabled)
            {
                btnStart.Text = "Остановить";
            }
            else
            {
                btnStart.Text = "Запустить";
            }
        }

        //кнопка ресета таймера
        private void button1_Click(object sender, EventArgs e)
        {
                txtSeconds.Text = "0";
                txtMinutes.Text = "0";
        }
    }
}
