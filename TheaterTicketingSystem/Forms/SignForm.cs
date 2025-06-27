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
using BCrypt.Net;
using System.Data.SqlClient;


namespace TheaterTicketingSystem.Forms
{
    public partial class SignForm : DevExpress.XtraEditors.XtraForm
    {
        private const string CS = @"Server=DESKTOP-2F393AM\SQLEXPRESS04;Database=AuthDemo;Trusted_Connection=True;";
        bool isPasswordVisible = false;

        public SignForm()
        {
            InitializeComponent();
            textEditEmailAdd.EditValue = null;
            textEditPassword.EditValue = null;
            textEditName.EditValue = null;
            textEditEmailAdd.SetPlaceholder("Email Address");
            textEditPassword.SetPlaceholder("Password");
            textEditName.SetPlaceholder("Full Name");

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



        private void simpleButtonSignupBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditEmailAdd.Text) ||
                string.IsNullOrWhiteSpace(textEditPassword.Text))
            {
                XtraMessageBox.Show("Username and password are required.");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(textEditPassword.Text);
            const string sql = @"INSERT INTO dbo.Users (Username, PasswordHash) VALUES (@u, @p);";
            try
            {
                using var db = new SqlConnection(CS);
                using var cmd = new SqlCommand(sql, db);

                cmd.Parameters.AddWithValue("@u", textEditEmailAdd.Text.Trim());
                cmd.Parameters.AddWithValue("@p", hash);

                db.Open();
                cmd.ExecuteNonQuery();

                XtraMessageBox.Show("Successfully Added");
            }
            catch (SqlException ex) when (ex.Number == 2627)
            {
                XtraMessageBox.Show("Username already exists. Pick another.");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error saving user:\n" + ex.Message);
            }
        }


        private void simpleButtonLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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