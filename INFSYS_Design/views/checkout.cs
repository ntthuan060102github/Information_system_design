﻿using System;
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
    public partial class checkout : Form
    {
        public checkout()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            RoomStatus roomStatus = new RoomStatus();
            roomStatus.ShowDialog();
            this.Close();
        }
    }
}
