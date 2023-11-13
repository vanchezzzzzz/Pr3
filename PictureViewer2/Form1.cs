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

        //Кнопка вызова диалога для выбора картинки
        private void showButton_Click(object sender, EventArgs e)
        {
            //Show the open File dialog.If the user clicks OK, load the
            //picture that the user chose.
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        //Кнопка очистки изображения
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the picture.
            pictureBox1.Image = null;
        }

        //Кнопка для выбора цвета фона
        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Show the color dialog box. If the user clicks OK, change the
            // PictureBox control's background to the color the user chose.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        //флажок растягивания изображения, изначально оно в состоянии Normal
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }

        //Кнопка сохранения картинки с выбором пути
        private void saveFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
        //Открытие второй формы
        private void openForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
