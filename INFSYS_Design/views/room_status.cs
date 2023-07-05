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
    public partial class GUI_RoomStatus : Form
    {
        public GUI_RoomStatus(int checkoutId)
        {
            InitializeComponent();
            this.lb_checkout_id_text.Text = checkoutId.ToString();
        }

        private void room_status_Load(object sender, EventArgs e)
        {

        }

        private void create_invoice_btn_Click(object sender, EventArgs e)
        {
            GUI_Invoice invoice = new GUI_Invoice();
            invoice.ShowDialog();
            this.Close();
        }

        private void lb_checkout_id_text_Click(object sender, EventArgs e)
        {

        }
    }
}
