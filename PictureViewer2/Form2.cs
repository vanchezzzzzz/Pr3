using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureViewer2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //кнопка добавления строки в лист
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //добавляем текст из TextBox в List
            lst.Items.Add(txt.Text);
            //очистить TextBox
            txt.Clear();
        }

        //кнопка сохранения
        private void btnSave_Click(object sender, EventArgs e)
        {
            //получение пути файла из TextBox
            string fileName = txtFileName.Text;
            //проверка на наличие файла
            if (File.Exists(fileName))
            {
                //если существует - удаляем
                File.Delete(fileName);
            }
            // Используем конструкцию using для автоматического закрытия FileStream и BinaryWriter после использования
            // создаем файл или перезаписываем существующий
            using (FileStream fs = File.Create(fileName, 1024))
            // класс для работы с данными файла в двоичной виде
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                // пока не конец списка Записываем каждый элемент из элемента управления ListBox в файл
                for (var i = 0; i < lst.Items.Count; i++)
                {
                    bw.Write(lst.Items[i].ToString());
                }
                //закрытие BW и FS
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //получить путь к файлу
            string fileName = txtFileName.Text;
            //очищение строки файла
            lstFromfile.Items.Clear();
            //используем FileStream и BinaryReader (Файловый поток и Бинарный читатель)
            /* Используем конструкцию using для создания FileStream и BinaryReader
            и обеспечиваем автоматическое закрытие ресурсов (файлового потока и бинарного читателя),
            когда они больше не нужны, чтобы избежать утечек ресурсов. 
            Создаем FileStream для открытия файла с заданным именем в режиме FileMode.Open (для чтения).
            FileStream - класс для работы с потоком байтов в файле.
            Он также используется в конструкции using, что гарантирует его закрытие после использования. */
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            /* Создаем BinaryReader для чтения данных из FileStream.
            BinaryReader - обертка вокруг потока, предоставляющая методы чтения примитивных типов данных из бинарного потока.
            Также используется в конструкции using для автоматического закрытия после использования. */
            using (BinaryReader br = new BinaryReader(fs))
            {
                /* Начинаем цикл, который будет выполняться до тех пор, пока не достигнут конец файла.
                Метод PeekChar() возвращает следующий символ без перемещения указателя текущей позиции в файле. */
                while (br.PeekChar()!= -1)
                {
                   //добавляем в элемент ListBox каждую строку прочитанную с помощью BR
                    lstFromfile.Items.Add(br.ReadString());
                }
                //закрытие br и fs
                br.Close();
                fs.Close();
            }
        }

        //кнопка закрытия   
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
