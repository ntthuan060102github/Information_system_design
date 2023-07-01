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
    public partial class GUI_ListOfServices : Form
    {
        public GUI_ListOfServices()
        {
            InitializeComponent();
        }

        private void add_service_btn_Click(object sender, EventArgs e)
        {
            GUI_AddService addService = new GUI_AddService();
            addService.ShowDialog();
            addService.Dispose();
        }

        private void update_service_btn_Click(object sender, EventArgs e)
        {
            GUI_UpdateService updateService = new GUI_UpdateService();
            updateService.ShowDialog();
            updateService.Dispose();
        }

        private void delete_service_btn_Click(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            //Program.previousForm.Show();
            this.Hide();
        }

        private void list_of_services_Load(object sender, EventArgs e)
        {

        }
    }
}
