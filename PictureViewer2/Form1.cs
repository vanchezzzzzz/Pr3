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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Объявляем массив из 10 символов
        private int[] Arr = new int[10];

        //Кнопка для создания нового массива
        private void btnNewArr_Click(object sender, EventArgs e)
        {
            int n = 10;
            int a = int.Parse(txtMin.Text);
            int b = int.Parse(txtMax.Text);
            //генерация случайных чисел в массив
            Random r = new Random();
            //цикл для проверки кол-ва символов
            for(int i = 0; i < n; i++)
            {
                //заполнение текущего элемента массива случайными числами
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                //микроцикл для добавляния запятой в массиве
                if (i != n) lblArr.Text += ", ";
            }
            //снятие блокировки с кнопки сортировки
            btnSort.Enabled = true;
        }
        //функция для поиска минимальных позиций чисел
        private int MinNumber(int[]x, int m)
        {
            //эти две строки приводят к готовности минимальный элемент в оставшейся части массивамассива
            int min = x[m];
            int MinN = m;
            //цикл определения мин. элемента в оставшейся части массива
            for (int i = m; i<x.Length; i++)
            {
                //обновление минимального элемента массива
                if (x[i] < min)
                {
                    min = x[i];
                    MinN = i;
                }
            }
            //Возвращаем мин. элемент массива
            return MinN;
        }

        //кнопка сортировки
        private void btnSort_Click(object sender, EventArgs e)
        {
            int k, t;
            for (int i=0; i < Arr.Length; i++)
            {
                k = MinNumber(Arr, i);
                t = Arr[i];
                Arr[i] = Arr[k];
                Arr[k] = t;
                lblResult.Text += Arr[i];
                if (i != Arr.Length - 1) { lblResult.Text += ", "; }
            }
            btnSort.Enabled = false;
        }

        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }
    }
}
