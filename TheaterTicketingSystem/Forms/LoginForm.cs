using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TheaterTicketingSystem.Forms
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        public LoginForm()
        {
            InitializeComponent();

            textEditEmAdd.EditValue = null;
            textEditPassword.EditValue = null;
            textEditEmAdd.SetPlaceholder("Email Address");
            textEditPassword.SetPlaceholder("Password");
        }

        private void checkEditShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (textEditPassword.Properties.UseSystemPasswordChar)
            {

                textEditPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {

                textEditPassword.Properties.UseSystemPasswordChar = true;
            }
        }
   
        private void simpleButtonSignUp_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
            this.Hide();

        }

        private void simpleButtonContact_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm();
            contactForm.Show();
            this.Hide();
        }

        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}