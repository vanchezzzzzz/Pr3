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
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }

        private void txtBoxLogin_TextChanged(object sender, EventArgs e)
        {
            ShowToolTip(txtBoxLogin, "Введите ваш логин");
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ShowToolTip(txtBoxPassword, "Введите ваш пароль");
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxPassword.UseSystemPasswordChar = false;
            txtBoxPassword.PasswordChar = checkBoxShowPassword.Checked ? '\0' : '*';
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string Username = "5606";
            string Password = GetPasswordHash("6065");

            string enteredUsername = txtBoxLogin.Text.Trim();
            string enteredPassword = txtBoxPassword.Text.Trim();

            if(enteredUsername == Username && VerifyPassword(enteredPassword, Password))
            {
                Органайзер form2 = new Органайзер();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetPasswordHash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        
        private bool VerifyPassword(string enteredPassword, string storedPasswordHash)
        {
            string enteredPasswordHash = GetPasswordHash(enteredPassword);
            return enteredPasswordHash == storedPasswordHash;
        }
    }
}
