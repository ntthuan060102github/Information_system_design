using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INFSYS_Design.views.components;

namespace INFSYS_Design.views
{
    public partial class RoomManagement : Form
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void room_management_Load(object sender, EventArgs e)
        {

        }

        private void roomManagementCard5_Load(object sender, EventArgs e)
        {

        }

        private void new_room_btn_Click(object sender, EventArgs e)
        {
            AddRoomModal add_room_form = new AddRoomModal();
            add_room_form.ShowDialog(this);
            add_room_form.Dispose();
        }
    }
}
