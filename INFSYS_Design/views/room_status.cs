using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFSYS_Design.views
{
    public partial class RoomStatus : Form
    {
        public RoomStatus()
        {
            InitializeComponent();
        }

        private void room_status_Load(object sender, EventArgs e)
        {

        }

        private void create_invoice_btn_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.ShowDialog();
            this.Close();
        }
    }
}
