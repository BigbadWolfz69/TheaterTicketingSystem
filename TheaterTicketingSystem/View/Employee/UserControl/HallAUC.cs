using DevExpress.CodeParser;
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

namespace TheaterTicketingSystem.View.Employee.UserControl
{
    public partial class HallAUC : DevExpress.XtraEditors.XtraUserControl
    {
        public HallAUC()
        {
            InitializeComponent();
            this.Load += HallAUC_Load;
        }

        private void HallAUC_Load(object sender, EventArgs e)
        {
        }
    }
}
