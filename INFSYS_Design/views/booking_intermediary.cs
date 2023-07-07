using INFSYS_Design.controllers;
using INFSYS_Design.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace INFSYS_Design.views
{
    public partial class GUI_DatPhong : Form
    {
        public GUI_DatPhong()
        {
            InitializeComponent();
            List<LoaiPhong> dsLoaiPhong = LoaiPhong.layDanhSachLoaiPhong();
            foreach (LoaiPhong typeroom in dsLoaiPhong)
            {
                this.dtgLoaiPhong.Rows.Add(
                    typeroom.maLoaiPhong,
                    typeroom.hangPhong,
                    typeroom.soGiuong,
                    typeroom.loaiGiuong
                );
            }

            int loaiPhongColumnIndex = dtgLoaiPhong.Columns["MALOAIPHONG"].Index;
            DataGridViewRow currentRow = dtgLoaiPhong.CurrentRow;
            if (currentRow != null)
            {
                object value = currentRow.Cells[loaiPhongColumnIndex].Value;
                string type = value.ToString();

                List<Phong> p = Phong.layDanhSachPhongTrongTheoLoaiPhong(type);
                foreach (Phong room in p)
                {
                    this.dtgDSPhongTrong.Rows.Add(
                        room.soPhong,
                        room.loaiPhong
                    );
                }
            }
            this.comboBox1.Items.Add("Nam");
            this.comboBox1.Items.Add("Nữ");
            this.comboBox1.Text = "Nam";
            this.comboBox2.Items.Add("Trực tiếp");
            this.comboBox2.Items.Add("Chuyển khoản");
            this.comboBox2.Text = "Trực tiếp";
        }

        private void booking_intermediary_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg_list_empty_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dtgDSPhongTrong.Rows.Clear();
            string roomType = this.dtgLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();

            List<Phong> listOfRoom = Phong.layDanhSachPhongTrongTheoLoaiPhong(roomType);
            foreach (Phong room in listOfRoom)
            {
                this.dtgDSPhongTrong.Rows.Add(room.soPhong.ToString());
            }
        }

        private void label_customer_info_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void tbLoaiPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_time_checkout_Click(object sender, EventArgs e)
        {

        }

        private void dtpCheckout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label_time_checkin_Click(object sender, EventArgs e)
        {

        }
        private void dtgLoaiPhong_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(!this.checkDSCho.Checked)
            {
                this.dtgDSPhongTrong.Rows.Clear();
                string roomType = this.dtgLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();

                List<Phong> listOfRoom = Phong.layDanhSachPhongTrongTheoLoaiPhong(roomType);
                foreach(Phong room in listOfRoom)
                {
                    this.dtgDSPhongTrong.Rows.Add(room.soPhong.ToString());
                }
            }
        }

        private void label_list_empty_room_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string customer_name = this.tbTenKH.Text;
            string customer_phone = this.tbSDT.Text;
            string customer_email = this.tbEmail.Text;
            string txt_customer_year_of_birthday = this.tb_namSinh.Text;
            int customer_year_of_birthday;
            string customer_id = this.tbDinhDanh.Text;
            string customer_address = this.tbDiaChi.Text;
            string customer_gender = this.comboBox1.SelectedItem.ToString();
            string payment_method = this.comboBox2.SelectedItem.ToString();
            DateTime checkin_date = this.dtpCheckin.Value;
            DateTime return_date = this.dtpCheckout.Value;
            bool to_wait_list = this.checkDSCho.Checked;
            string specialRequest = this.tbYeuCauDacBiet.Text;

            if (customer_name.Length <= 0)
            {
                MessageBox.Show(
                    "Tên khách hàng không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (!Regex.IsMatch(customer_phone, @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"))
            {
                MessageBox.Show(
                    "Số điện thoại không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (!Regex.IsMatch(customer_email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show(
                    "Email không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (
                !(int.TryParse(txt_customer_year_of_birthday, out customer_year_of_birthday)
                && customer_year_of_birthday >= 1990
                && customer_year_of_birthday <= DateTime.Now.Year - 18)
            )
            {
                MessageBox.Show(
                    "Năm sinh không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (customer_id.Length <= 0)
            {
                MessageBox.Show(
                    "CCCD/CMND không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (checkin_date.Date < DateTime.Now.Date)
            {
                MessageBox.Show(
                    "Ngày checkin dự kiến không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (return_date.Date < DateTime.Now.Date)
            {
                MessageBox.Show(
                    "Ngày trả phòng dự kiến không hợp lệ!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else if (this.dtgLoaiPhong.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại phòng!",
                    "Thông báo!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!to_wait_list)
            {
                if (this.dtgDSPhongTrong.SelectedRows.Count == 0)
                {
                    MessageBox.Show(
                        "Vui lòng chọn phòng!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            int customerDbId = ThongTinKhachHang.themKhachHang(
                customer_id,
                customer_email,
                customer_year_of_birthday,
                customer_name,
                customer_phone,
                customer_address,
                customer_gender == "Nam" ? 1 : 0
            );
            Console.WriteLine(this.dtgLoaiPhong.SelectedRows[0].Cells[0].ToString());
            int requestId = YeuCauDatPhong.themYeuCauDatPhong(
                (return_date - checkin_date).Days,
                checkin_date,
                specialRequest,
                customerDbId,
                this.dtgLoaiPhong.SelectedRows[0].Cells[0].Value.ToString()
            );

            if (to_wait_list)
            {
                if(DanhSachCho.themDanhSachCho(checkin_date.AddDays(7), requestId))
                {
                    MessageBox.Show(
                        "Thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            else
            {
                LoaiPhong roomType = LoaiPhong.layThongTinLoaiPhong(this.dtgLoaiPhong.SelectedRows[0].Cells[0].Value.ToString());
                int roomNum = Convert.ToInt32(this.dtgDSPhongTrong.SelectedRows[0].Cells[0].Value.ToString());
                bool history = LichSuDatPhong.themLichSuDatPhong(
                    return_date, 
                    payment_method == "Tr?c ti?p" ? "TRUC_TIEP" : "CHUYEN_KHOAN", 
                    roomType.gia,
                    requestId, 
                    roomNum
                );
                bool room_modified = Phong.capNhatTrangThai(roomNum, "DANG_SU_DUNG");
                
                if (history && room_modified)
                {
                    MessageBox.Show(
                        "Thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
        }

        private void checkDSCho_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkDSCho.Checked)
            {
                this.dtgDSPhongTrong.Rows.Clear();
            }
            else
            {
                this.dtgDSPhongTrong.Rows.Clear();
                string roomType = this.dtgLoaiPhong.SelectedRows[0].Cells[0].Value.ToString();

                List<Phong> listOfRoom = Phong.layDanhSachPhongTrongTheoLoaiPhong(roomType);
                foreach (Phong room in listOfRoom)
                {
                    this.dtgDSPhongTrong.Rows.Add(room.soPhong.ToString());
                }

            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }
    }
}