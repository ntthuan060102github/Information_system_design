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

namespace INFSYS_Design.views.components
{
    public partial class GUI_AddRoomModal : Form
    {
        public GUI_AddRoomModal()
        {
            InitializeComponent();
            List<LoaiPhong> listOfRoomTypes = LoaiPhong.layDanhSachLoaiPhong();

            if (listOfRoomTypes != null)
            {
                foreach(LoaiPhong roomType in listOfRoomTypes)
                {
                    this.comboBox1.Items.Add(roomType.maLoaiPhong);
                }
            }
            
        }

        private void add_room_modal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
