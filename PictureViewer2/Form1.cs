using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame

{
    public partial class Form1 : Form
    {
        //Задача рандомных символов в строку (фигурки)
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",","k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        //firstClicked - первое нажатие игрока, second - второе, изначально равны нулю
        Label firstClicked = null;
        Label secondClicked = null;
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            //Проверка наличия фигурок на панели и их скрытие от игрока
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Включение таймера на исчезновение фигурок и отключение только после двух не совпадающих фигурок
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if(clickedLabel !=null)
            {
                //Если игрок нажал на открытую фигурку то ничего не происходит
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                //Если фигурка не совпадает то меняется цвет на черный и повторяется цикл
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                //Если игрок выбирает правильные 2 фигурки то они остаются и закрашиваются в черный цвет
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                //Проверка на победителя
                CheckForWinner();
                /*Если игрок выбрал 2 одинаковые фигурки то они сохраняются и сбрасываются на значение null
                что бы игрок мог дальше играть*/
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                //Старт таймера на 100 МС
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            //Скрыть обе иконки
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            //Сбросить обе иконки
            firstClicked = null;
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            //Проверка всех фигурок
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            //Сообщение победителю
            MessageBox.Show("Молодец!");
            Close();
        }
    }
}
