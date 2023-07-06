namespace INFSYS_Design.views
{
    partial class GUI_DatPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgDSPhongTrong = new System.Windows.Forms.DataGridView();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgLoaiPhong = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label_customer_birth_day = new System.Windows.Forms.Label();
            this.label_customer_gender = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label_customer_address = new System.Windows.Forms.Label();
            this.tbDinhDanh = new System.Windows.Forms.TextBox();
            this.label_customer_id = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label_customer_email = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label_customer_phone_number = new System.Windows.Forms.Label();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.tbYeuCauDacBiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDSCho = new System.Windows.Forms.CheckBox();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label_time_checkout = new System.Windows.Forms.Label();
            this.label_time_checkin = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_namSinh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDSPhongTrong
            // 
            this.dtgDSPhongTrong.AllowUserToAddRows = false;
            this.dtgDSPhongTrong.AllowUserToResizeRows = false;
            this.dtgDSPhongTrong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgDSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPHONG});
            this.dtgDSPhongTrong.Location = new System.Drawing.Point(851, 143);
            this.dtgDSPhongTrong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDSPhongTrong.Name = "dtgDSPhongTrong";
            this.dtgDSPhongTrong.RowHeadersVisible = false;
            this.dtgDSPhongTrong.RowHeadersWidth = 51;
            this.dtgDSPhongTrong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSPhongTrong.Size = new System.Drawing.Size(155, 248);
            this.dtgDSPhongTrong.TabIndex = 28;
            this.dtgDSPhongTrong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_list_empty_room_CellContentClick);
            // 
            // SOPHONG
            // 
            this.SOPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOPHONG.HeaderText = "Số phòng";
            this.SOPHONG.MinimumWidth = 6;
            this.SOPHONG.Name = "SOPHONG";
            // 
            // LOAIGIUONG
            // 
            this.LOAIGIUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAIGIUONG.HeaderText = "Loại giường";
            this.LOAIGIUONG.MinimumWidth = 6;
            this.LOAIGIUONG.Name = "LOAIGIUONG";
            this.LOAIGIUONG.ReadOnly = true;
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOGIUONG.HeaderText = "Số giường";
            this.SOGIUONG.MinimumWidth = 6;
            this.SOGIUONG.Name = "SOGIUONG";
            this.SOGIUONG.ReadOnly = true;
            // 
            // HANGPHONG
            // 
            this.HANGPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HANGPHONG.HeaderText = "Hạng phòng";
            this.HANGPHONG.MinimumWidth = 6;
            this.HANGPHONG.Name = "HANGPHONG";
            this.HANGPHONG.ReadOnly = true;
            // 
            // MALOAIPHONG
            // 
            this.MALOAIPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALOAIPHONG.HeaderText = "Loại phòng";
            this.MALOAIPHONG.MinimumWidth = 6;
            this.MALOAIPHONG.Name = "MALOAIPHONG";
            this.MALOAIPHONG.ReadOnly = true;
            // 
            // dtgLoaiPhong
            // 
            this.dtgLoaiPhong.AllowUserToAddRows = false;
            this.dtgLoaiPhong.AllowUserToDeleteRows = false;
            this.dtgLoaiPhong.AllowUserToResizeColumns = false;
            this.dtgLoaiPhong.AllowUserToResizeRows = false;
            this.dtgLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dtgLoaiPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgLoaiPhong.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAIPHONG,
            this.HANGPHONG,
            this.SOGIUONG,
            this.LOAIGIUONG});
            this.dtgLoaiPhong.Location = new System.Drawing.Point(347, 143);
            this.dtgLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgLoaiPhong.MultiSelect = false;
            this.dtgLoaiPhong.Name = "dtgLoaiPhong";
            this.dtgLoaiPhong.ReadOnly = true;
            this.dtgLoaiPhong.RowHeadersVisible = false;
            this.dtgLoaiPhong.RowHeadersWidth = 51;
            this.dtgLoaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgLoaiPhong.Size = new System.Drawing.Size(505, 248);
            this.dtgLoaiPhong.TabIndex = 30;
            this.dtgLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLoaiPhong_SelectionChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(148, 472);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 24);
            this.comboBox2.TabIndex = 74;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(148, 391);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(1, 472);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 24);
            this.label5.TabIndex = 72;
            this.label5.Text = "Hình thức thanh toán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(148, 431);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(187, 26);
            this.dtpNgayDen.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(0, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 70;
            this.label2.Text = "Ngày đến";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_customer_birth_day
            // 
            this.label_customer_birth_day.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_birth_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_birth_day.Location = new System.Drawing.Point(0, 268);
            this.label_customer_birth_day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_birth_day.Name = "label_customer_birth_day";
            this.label_customer_birth_day.Size = new System.Drawing.Size(147, 26);
            this.label_customer_birth_day.TabIndex = 68;
            this.label_customer_birth_day.Text = "Năm sinh";
            this.label_customer_birth_day.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_customer_gender
            // 
            this.label_customer_gender.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_gender.Location = new System.Drawing.Point(1, 391);
            this.label_customer_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_gender.Name = "label_customer_gender";
            this.label_customer_gender.Size = new System.Drawing.Size(146, 24);
            this.label_customer_gender.TabIndex = 67;
            this.label_customer_gender.Text = "Giới tính";
            this.label_customer_gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(148, 350);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(187, 26);
            this.tbDiaChi.TabIndex = 66;
            // 
            // label_customer_address
            // 
            this.label_customer_address.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_address.Location = new System.Drawing.Point(0, 347);
            this.label_customer_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_address.Name = "label_customer_address";
            this.label_customer_address.Size = new System.Drawing.Size(147, 30);
            this.label_customer_address.TabIndex = 65;
            this.label_customer_address.Text = "Địa chỉ thường trú";
            this.label_customer_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDinhDanh
            // 
            this.tbDinhDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDinhDanh.Location = new System.Drawing.Point(148, 308);
            this.tbDinhDanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbDinhDanh.Name = "tbDinhDanh";
            this.tbDinhDanh.Size = new System.Drawing.Size(187, 26);
            this.tbDinhDanh.TabIndex = 64;
            this.tbDinhDanh.Text = "064";
            // 
            // label_customer_id
            // 
            this.label_customer_id.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_id.Location = new System.Drawing.Point(-1, 305);
            this.label_customer_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(148, 30);
            this.label_customer_id.TabIndex = 63;
            this.label_customer_id.Text = "CMND/CCCD";
            this.label_customer_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(148, 229);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 26);
            this.tbEmail.TabIndex = 62;
            this.tbEmail.Text = "thuan@gmai.com";
            // 
            // label_customer_email
            // 
            this.label_customer_email.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_email.Location = new System.Drawing.Point(0, 226);
            this.label_customer_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_email.Name = "label_customer_email";
            this.label_customer_email.Size = new System.Drawing.Size(147, 30);
            this.label_customer_email.TabIndex = 61;
            this.label_customer_email.Text = "Email";
            this.label_customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(148, 186);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(187, 26);
            this.tbSDT.TabIndex = 60;
            this.tbSDT.Text = "0328221179";
            // 
            // label_customer_phone_number
            // 
            this.label_customer_phone_number.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_phone_number.Location = new System.Drawing.Point(0, 183);
            this.label_customer_phone_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_phone_number.Name = "label_customer_phone_number";
            this.label_customer_phone_number.Size = new System.Drawing.Size(147, 30);
            this.label_customer_phone_number.TabIndex = 59;
            this.label_customer_phone_number.Text = "SĐT";
            this.label_customer_phone_number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(148, 148);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(187, 26);
            this.tbTenKH.TabIndex = 58;
            this.tbTenKH.Text = "thuan";
            // 
            // label_customer_name
            // 
            this.label_customer_name.BackColor = System.Drawing.Color.Transparent;
            this.label_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_name.Location = new System.Drawing.Point(0, 143);
            this.label_customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(147, 30);
            this.label_customer_name.TabIndex = 57;
            this.label_customer_name.Text = "Tên khách hàng";
            this.label_customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbYeuCauDacBiet
            // 
            this.tbYeuCauDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYeuCauDacBiet.Location = new System.Drawing.Point(623, 426);
            this.tbYeuCauDacBiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbYeuCauDacBiet.Multiline = true;
            this.tbYeuCauDacBiet.Name = "tbYeuCauDacBiet";
            this.tbYeuCauDacBiet.Size = new System.Drawing.Size(370, 35);
            this.tbYeuCauDacBiet.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(636, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 21);
            this.label3.TabIndex = 81;
            this.label3.Text = "Yêu cầu đặc biệt";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkDSCho
            // 
            this.checkDSCho.BackColor = System.Drawing.Color.Transparent;
            this.checkDSCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkDSCho.Location = new System.Drawing.Point(623, 486);
            this.checkDSCho.Margin = new System.Windows.Forms.Padding(4);
            this.checkDSCho.Name = "checkDSCho";
            this.checkDSCho.Size = new System.Drawing.Size(144, 24);
            this.checkDSCho.TabIndex = 80;
            this.checkDSCho.Text = "Danh sách chờ";
            this.checkDSCho.UseVisualStyleBackColor = false;
            this.checkDSCho.CheckedChanged += new System.EventHandler(this.checkDSCho_CheckedChanged);
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(375, 487);
            this.dtpCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(215, 22);
            this.dtpCheckout.TabIndex = 79;
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(375, 427);
            this.dtpCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(215, 22);
            this.dtpCheckin.TabIndex = 78;
            // 
            // label_time_checkout
            // 
            this.label_time_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_time_checkout.Location = new System.Drawing.Point(375, 463);
            this.label_time_checkout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time_checkout.Name = "label_time_checkout";
            this.label_time_checkout.Size = new System.Drawing.Size(215, 21);
            this.label_time_checkout.TabIndex = 77;
            this.label_time_checkout.Text = "Thời gian trả phòng";
            this.label_time_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_time_checkin
            // 
            this.label_time_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_time_checkin.Location = new System.Drawing.Point(375, 404);
            this.label_time_checkin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time_checkin.Name = "label_time_checkin";
            this.label_time_checkin.Size = new System.Drawing.Size(215, 21);
            this.label_time_checkin.TabIndex = 76;
            this.label_time_checkin.Text = "Thời gian nhận phòng";
            this.label_time_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSubmit.Location = new System.Drawing.Point(775, 479);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(218, 37);
            this.btnSubmit.TabIndex = 75;
            this.btnSubmit.Text = "Đặt phòng/thêm yêu cầu";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 32);
            this.btn_back.TabIndex = 83;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 29);
            this.label1.TabIndex = 84;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(348, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(658, 29);
            this.label4.TabIndex = 85;
            this.label4.Text = "THÔNG TIN ĐẶT PHÒNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(-1, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1007, 42);
            this.label6.TabIndex = 86;
            this.label6.Text = "ĐẶT PHÒNG";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_namSinh
            // 
            this.tb_namSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namSinh.Location = new System.Drawing.Point(148, 268);
            this.tb_namSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tb_namSinh.Name = "tb_namSinh";
            this.tb_namSinh.Size = new System.Drawing.Size(187, 26);
            this.tb_namSinh.TabIndex = 87;
            this.tb_namSinh.Text = "2002";
            // 
            // GUI_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.tb_namSinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tbYeuCauDacBiet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkDSCho);
            this.Controls.Add(this.dtpCheckout);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.label_time_checkout);
            this.Controls.Add(this.label_time_checkin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpNgayDen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_customer_birth_day);
            this.Controls.Add(this.label_customer_gender);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.label_customer_address);
            this.Controls.Add(this.tbDinhDanh);
            this.Controls.Add(this.label_customer_id);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label_customer_email);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.label_customer_phone_number);
            this.Controls.Add(this.tbTenKH);
            this.Controls.Add(this.label_customer_name);
            this.Controls.Add(this.dtgLoaiPhong);
            this.Controls.Add(this.dtgDSPhongTrong);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_DatPhong";
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.booking_intermediary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgDSPhongTrong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIPHONG;
        private System.Windows.Forms.DataGridView dtgLoaiPhong;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_customer_birth_day;
        private System.Windows.Forms.Label label_customer_gender;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.Label label_customer_address;
        private System.Windows.Forms.TextBox tbDinhDanh;
        private System.Windows.Forms.Label label_customer_id;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label_customer_email;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label label_customer_phone_number;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.TextBox tbYeuCauDacBiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkDSCho;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label label_time_checkout;
        private System.Windows.Forms.Label label_time_checkin;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_namSinh;
    }
}