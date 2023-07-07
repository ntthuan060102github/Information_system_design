using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFSYS_Design.views.components
{
    public partial class GUI_TeamInfoModal : Form
    {
        public GUI_TeamInfoModal(int maNguoiDaiDien)
        {
            InitializeComponent();
            this.textBox1.Text = maNguoiDaiDien.ToString();
        }

        private void team_info_modal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamName = this.textBox2.Text;
            string txt_num = this.textBox3.Text;
            int num;

            if (teamName.Length == 0 ||!int.TryParse(txt_num, out num))
            {
                MessageBox.Show(
                    "Thông tin không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
