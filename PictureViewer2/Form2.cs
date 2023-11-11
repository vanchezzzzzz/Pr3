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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lst.Items.Add(txt.Text);
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = File.Create(fileName, 1024))
            using(BinaryWriter bw = new BinaryWriter(fs))
            {
                for (var i = 0; i < lst.Items.Count; i++)
                {
                    bw.Write(lst.Items[i].ToString());
                }
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //получить путь к файлу
            string fileName = txtFileName.Text;
            //пиписька корочи
            lstFromfile.Items.Clear();
            using(FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                while (br.PeekChar()!= -1)
                {
                    lstFromfile.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
