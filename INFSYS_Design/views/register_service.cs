using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.controllers;

namespace INFSYS_Design.views
{
    public partial class GUI_RegisterService : Form
    {
        private List<DichVu> listOfServices;
        public GUI_RegisterService()
        {
            InitializeComponent();
            List<Phong> listOfRooms = Phong.layDanhSachPhongDangSuDung();
            foreach(Phong room in listOfRooms)
            {
                this.comboBox1.Items.Add(room.soPhong);
            }

            this.listOfServices = DichVu.layDanhSachDichVu();
            
            foreach(DichVu service in this.listOfServices)
            {
                //this.cbb_service.Items.Add($"<{service.ma}> {service.tenDichVu}");
            }
        }

        private void GUI_RegisterService_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }

        private void cbb_service_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_fee_Click(object sender, EventArgs e)
        {

        }

        private void lb_fee_text_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
