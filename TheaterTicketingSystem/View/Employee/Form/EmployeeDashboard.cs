using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheaterTicketingSystem.View.Employee.UserControl;

namespace TheaterTicketingSystem.View.Employee.Form
{
    public partial class EmployeeDashboard : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void buttonTicketBooking_Click(object sender, EventArgs e)
        {
            TicketBookingUC ticketBookingUC = new TicketBookingUC();
            ticketBookingUC.Dock = DockStyle.Fill;
            panelForUC.Controls.Add(ticketBookingUC);

            buttonSignOut.Visible = false;
            buttonShowtimeOverview.Visible = false;
            buttonActivityLog.Visible = false;
            buttonTicketBooking.Visible = false;
            pictureEditUser.Visible = false;
            labelControlUsername.Visible = false;
        }

    }
}