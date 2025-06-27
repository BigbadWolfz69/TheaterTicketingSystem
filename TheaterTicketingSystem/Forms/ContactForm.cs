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
using TheaterTicketingSystem.Forms;

namespace TheaterTicketingSystem.Forms
{
    public partial class ContactForm : DevExpress.XtraEditors.XtraForm
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void simpleButtonSubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(memoEditContact.Text))
            {
                XtraMessageBox.Show("Please enter your message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XtraMessageBox.Show("Your message has been sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                memoEditContact.Text = string.Empty;
            }
        }


        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void simpleButtonSignUp_Click(object sender, EventArgs e)
        {
            SignForm signForm = new SignForm();
            signForm.Show();
            this.Hide();

        }


        private void simpleButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 