using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheaterTicketingSystem.GlobalSettings;
using TheaterTicketingSystem.Models;

namespace TheaterTicketingSystem.View.Employee.Form
{
    public partial class SaveOrderForm : DevExpress.XtraEditors.XtraForm
    {
        public SaveOrderForm()
        {
            InitializeComponent();
        }

        private void SaveOrderForm_Load(object sender, EventArgs e)
        {
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonConfirmOrder_Click(object sender, EventArgs e)
        {

        }

        
    }
}