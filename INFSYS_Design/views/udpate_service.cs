using INFSYS_Design.controllers;
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
    public partial class GUI_UpdateService : Form
    {
        public GUI_UpdateService(int ma)
        {
            InitializeComponent();
            DichVu service = DichVu.layThongTinDichVu(ma);
            this.tb_service_id.Text = service.ma.ToString();
            this.tb_name.Text = service.tenDichVu;
            this.tb_description.Text = service.moTa;
            this.tb_type.Text = service.loaiDichVu;
            this.tb_price.Text = service.gia.ToString();
        }

        private void udpate_service_Load(object sender, EventArgs e)
        {

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string text_ma = tb_service_id.Text;
                string text_tenDichVu = tb_name.Text;
                string text_moTa = tb_description.Text;
                string text_loaiDichVu = tb_type.Text;
                string text_gia = tb_price.Text;
                int ma = int.Parse(text_ma);
                int gia = int.Parse(text_gia);
                if (string.IsNullOrEmpty(text_tenDichVu))
                {
                    MessageBox.Show(
                        "Tên dịch vụ không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_moTa))
                {
                    MessageBox.Show(
                        "Mô tả không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_loaiDichVu))
                {
                    MessageBox.Show(
                        "Loại dịch vụ không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_gia))
                {
                    MessageBox.Show(
                        "Giá không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (gia < 0)
                {
                    MessageBox.Show(
                        "Giá không hợp lệ!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                if (DichVu.suaDichVu(ma, text_tenDichVu, text_moTa, text_loaiDichVu, gia))
                {
                    MessageBox.Show(
                        "Thành công!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    int idx = Program.previousForm.Count - 1;
                    Form prvForm = Program.previousForm[idx];
                    Program.previousForm.RemoveAt(idx);
                    prvForm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Thất bại!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thông tin nhập vào không hợp lệ!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }
    

        private void back_btn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }
    }
}
