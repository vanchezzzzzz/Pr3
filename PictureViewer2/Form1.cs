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
            int seconds = Int32.Parse(txtSeconds.Text);
            int minutes = Int32.Parse(txtMinutes.Text);
            seconds += 1;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes += 1;
            }
            txtSeconds.Text = seconds.ToString();
            txtMinutes.Text = minutes.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = false;
            DateTime currentTime = DateTime.Now;
            txtDate.Text = currentTime.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;
            if(tmrSecundomer.Enabled)
            {
                btnStart.Text = "Остановить";
            }
            else
            {
                btnStart.Text = "Запустить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                txtSeconds.Text = "0";
                txtMinutes.Text = "0";
        }
    }
}
