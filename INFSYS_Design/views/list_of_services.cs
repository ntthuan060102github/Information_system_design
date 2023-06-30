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
    public partial class list_of_services : Form
    {
        public list_of_services()
        {
            InitializeComponent();
        }

        private void add_service_btn_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            addService.ShowDialog();
            addService.Dispose();
        }

        private void update_service_btn_Click(object sender, EventArgs e)
        {
            UpdateService updateService = new UpdateService();
            updateService.ShowDialog();
            updateService.Dispose();
        }

        private void delete_service_btn_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            GUI_Home home = new GUI_Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
