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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_LoaiPhong = new System.Windows.Forms.Label();
            this.label_cus_info = new System.Windows.Forms.Label();
            this.label_list_empty_room = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pTTKhachHang = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDen = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
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
            this.dtgDSPhongTrong = new System.Windows.Forms.DataGridView();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtgLoaiPhong = new System.Windows.Forms.DataGridView();
            this.MALOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIGIUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbYeuCauDacBiet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkDSCho = new System.Windows.Forms.CheckBox();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.label_time_checkout = new System.Windows.Forms.Label();
            this.label_time_checkin = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pTTKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhongTrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiPhong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_LoaiPhong);
            this.panel1.Controls.Add(this.label_cus_info);
            this.panel1.Controls.Add(this.label_list_empty_room);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 175);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lb_LoaiPhong
            // 
            this.lb_LoaiPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_LoaiPhong.BackColor = System.Drawing.Color.White;
            this.lb_LoaiPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_LoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LoaiPhong.ForeColor = System.Drawing.Color.Black;
            this.lb_LoaiPhong.Location = new System.Drawing.Point(412, 69);
            this.lb_LoaiPhong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_LoaiPhong.Name = "lb_LoaiPhong";
            this.lb_LoaiPhong.Size = new System.Drawing.Size(352, 38);
            this.lb_LoaiPhong.TabIndex = 32;
            this.lb_LoaiPhong.Text = "LOẠI PHÒNG";
            this.lb_LoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cus_info
            // 
            this.label_cus_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_cus_info.BackColor = System.Drawing.Color.White;
            this.label_cus_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_cus_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cus_info.ForeColor = System.Drawing.Color.Black;
            this.label_cus_info.Location = new System.Drawing.Point(-26, 144);
            this.label_cus_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_cus_info.Name = "label_cus_info";
            this.label_cus_info.Size = new System.Drawing.Size(348, 38);
            this.label_cus_info.TabIndex = 30;
            this.label_cus_info.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_cus_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_cus_info.Click += new System.EventHandler(this.label_customer_info_Click);
            // 
            // label_list_empty_room
            // 
            this.label_list_empty_room.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_list_empty_room.BackColor = System.Drawing.Color.White;
            this.label_list_empty_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_list_empty_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_list_empty_room.ForeColor = System.Drawing.Color.Black;
            this.label_list_empty_room.Location = new System.Drawing.Point(708, 137);
            this.label_list_empty_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_list_empty_room.Name = "label_list_empty_room";
            this.label_list_empty_room.Size = new System.Drawing.Size(0, 38);
            this.label_list_empty_room.TabIndex = 29;
            this.label_list_empty_room.Text = "DANH SÁCH PHÒNG TRỐNG";
            this.label_list_empty_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_list_empty_room.Click += new System.EventHandler(this.label_list_empty_room_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(507, 32);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.title.Size = new System.Drawing.Size(0, 75);
            this.title.TabIndex = 28;
            this.title.Text = "ĐẶT PHÒNG";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Red;
            this.btnReturn.Location = new System.Drawing.Point(16, 15);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(117, 44);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // pTTKhachHang
            // 
            this.pTTKhachHang.Controls.Add(this.comboBox2);
            this.pTTKhachHang.Controls.Add(this.comboBox1);
            this.pTTKhachHang.Controls.Add(this.label5);
            this.pTTKhachHang.Controls.Add(this.dtpNgayDen);
            this.pTTKhachHang.Controls.Add(this.label2);
            this.pTTKhachHang.Controls.Add(this.dtpNgaySinh);
            this.pTTKhachHang.Controls.Add(this.label_customer_birth_day);
            this.pTTKhachHang.Controls.Add(this.label_customer_gender);
            this.pTTKhachHang.Controls.Add(this.tbDiaChi);
            this.pTTKhachHang.Controls.Add(this.label_customer_address);
            this.pTTKhachHang.Controls.Add(this.tbDinhDanh);
            this.pTTKhachHang.Controls.Add(this.label_customer_id);
            this.pTTKhachHang.Controls.Add(this.tbEmail);
            this.pTTKhachHang.Controls.Add(this.label_customer_email);
            this.pTTKhachHang.Controls.Add(this.tbSDT);
            this.pTTKhachHang.Controls.Add(this.label_customer_phone_number);
            this.pTTKhachHang.Controls.Add(this.tbTenKH);
            this.pTTKhachHang.Controls.Add(this.label_customer_name);
            this.pTTKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.pTTKhachHang.Location = new System.Drawing.Point(0, 175);
            this.pTTKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pTTKhachHang.Name = "pTTKhachHang";
            this.pTTKhachHang.Size = new System.Drawing.Size(348, 425);
            this.pTTKhachHang.TabIndex = 27;
            this.pTTKhachHang.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(-1, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 53;
            this.label5.Text = "Hình thức thanh toán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNgayDen
            // 
            this.dtpNgayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDen.Location = new System.Drawing.Point(156, 327);
            this.dtpNgayDen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.dtpNgayDen.Name = "dtpNgayDen";
            this.dtpNgayDen.Size = new System.Drawing.Size(150, 26);
            this.dtpNgayDen.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(-2, 323);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Ngày đến:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(156, 160);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 26);
            this.dtpNgaySinh.TabIndex = 44;
            this.dtpNgaySinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_customer_birth_day
            // 
            this.label_customer_birth_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_birth_day.Location = new System.Drawing.Point(-2, 157);
            this.label_customer_birth_day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_birth_day.Name = "label_customer_birth_day";
            this.label_customer_birth_day.Size = new System.Drawing.Size(150, 30);
            this.label_customer_birth_day.TabIndex = 43;
            this.label_customer_birth_day.Text = "Ngày sinh:";
            this.label_customer_birth_day.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_birth_day.Click += new System.EventHandler(this.label7_Click);
            // 
            // label_customer_gender
            // 
            this.label_customer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_gender.Location = new System.Drawing.Point(-1, 282);
            this.label_customer_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_gender.Name = "label_customer_gender";
            this.label_customer_gender.Size = new System.Drawing.Size(150, 30);
            this.label_customer_gender.TabIndex = 41;
            this.label_customer_gender.Text = "Giới tính:";
            this.label_customer_gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_gender.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(156, 241);
            this.tbDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbDiaChi.Multiline = true;
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(150, 30);
            this.tbDiaChi.TabIndex = 40;
            this.tbDiaChi.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label_customer_address
            // 
            this.label_customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_address.Location = new System.Drawing.Point(-2, 236);
            this.label_customer_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_address.Name = "label_customer_address";
            this.label_customer_address.Size = new System.Drawing.Size(150, 30);
            this.label_customer_address.TabIndex = 39;
            this.label_customer_address.Text = "Địa chỉ thường trú:";
            this.label_customer_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_address.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbDinhDanh
            // 
            this.tbDinhDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDinhDanh.Location = new System.Drawing.Point(156, 198);
            this.tbDinhDanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbDinhDanh.Multiline = true;
            this.tbDinhDanh.Name = "tbDinhDanh";
            this.tbDinhDanh.Size = new System.Drawing.Size(150, 30);
            this.tbDinhDanh.TabIndex = 38;
            this.tbDinhDanh.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label_customer_id
            // 
            this.label_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_id.Location = new System.Drawing.Point(-3, 198);
            this.label_customer_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(150, 30);
            this.label_customer_id.TabIndex = 37;
            this.label_customer_id.Text = "CMND/CCCD:";
            this.label_customer_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_id.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(156, 117);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 30);
            this.tbEmail.TabIndex = 36;
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label_customer_email
            // 
            this.label_customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_email.Location = new System.Drawing.Point(-2, 117);
            this.label_customer_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_email.Name = "label_customer_email";
            this.label_customer_email.Size = new System.Drawing.Size(150, 30);
            this.label_customer_email.TabIndex = 35;
            this.label_customer_email.Text = "Email:";
            this.label_customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_email.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(156, 74);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbSDT.Multiline = true;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(150, 30);
            this.tbSDT.TabIndex = 34;
            this.tbSDT.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_customer_phone_number
            // 
            this.label_customer_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_phone_number.Location = new System.Drawing.Point(-2, 74);
            this.label_customer_phone_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_phone_number.Name = "label_customer_phone_number";
            this.label_customer_phone_number.Size = new System.Drawing.Size(150, 30);
            this.label_customer_phone_number.TabIndex = 33;
            this.label_customer_phone_number.Text = "SĐT:";
            this.label_customer_phone_number.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_phone_number.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbTenKH
            // 
            this.tbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKH.Location = new System.Drawing.Point(156, 33);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbTenKH.Multiline = true;
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(150, 30);
            this.tbTenKH.TabIndex = 32;
            this.tbTenKH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_customer_name
            // 
            this.label_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_customer_name.Location = new System.Drawing.Point(-2, 33);
            this.label_customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(150, 30);
            this.label_customer_name.TabIndex = 31;
            this.label_customer_name.Text = "Tên khách hàng:";
            this.label_customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_customer_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtgDSPhongTrong
            // 
            this.dtgDSPhongTrong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSPhongTrong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SOPHONG,
            this.LOAIPHONG});
            this.dtgDSPhongTrong.Location = new System.Drawing.Point(566, 174);
            this.dtgDSPhongTrong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgDSPhongTrong.Name = "dtgDSPhongTrong";
            this.dtgDSPhongTrong.RowHeadersVisible = false;
            this.dtgDSPhongTrong.RowHeadersWidth = 51;
            this.dtgDSPhongTrong.Size = new System.Drawing.Size(260, 237);
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
            // LOAIPHONG
            // 
            this.LOAIPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAIPHONG.HeaderText = "Loại phòng";
            this.LOAIPHONG.MinimumWidth = 6;
            this.LOAIPHONG.Name = "LOAIPHONG";
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(498, 38);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 37);
            this.btnSubmit.TabIndex = 31;
            this.btnSubmit.Text = "Gữi yêu cầu";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtgLoaiPhong
            // 
            this.dtgLoaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgLoaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoaiPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAIPHONG,
            this.HANGPHONG,
            this.SOGIUONG,
            this.LOAIGIUONG});
            this.dtgLoaiPhong.Location = new System.Drawing.Point(348, 175);
            this.dtgLoaiPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgLoaiPhong.Name = "dtgLoaiPhong";
            this.dtgLoaiPhong.RowHeadersVisible = false;
            this.dtgLoaiPhong.RowHeadersWidth = 51;
            this.dtgLoaiPhong.Size = new System.Drawing.Size(210, 185);
            this.dtgLoaiPhong.TabIndex = 30;
            this.dtgLoaiPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLoaiPhong_CellContentClick);
            // 
            // MALOAIPHONG
            // 
            this.MALOAIPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALOAIPHONG.HeaderText = "Loại phòng";
            this.MALOAIPHONG.MinimumWidth = 6;
            this.MALOAIPHONG.Name = "MALOAIPHONG";
            // 
            // HANGPHONG
            // 
            this.HANGPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HANGPHONG.HeaderText = "Hạng phòng";
            this.HANGPHONG.MinimumWidth = 6;
            this.HANGPHONG.Name = "HANGPHONG";
            // 
            // SOGIUONG
            // 
            this.SOGIUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOGIUONG.HeaderText = "Số giường";
            this.SOGIUONG.MinimumWidth = 6;
            this.SOGIUONG.Name = "SOGIUONG";
            // 
            // LOAIGIUONG
            // 
            this.LOAIGIUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAIGIUONG.HeaderText = "Loại giường";
            this.LOAIGIUONG.MinimumWidth = 6;
            this.LOAIGIUONG.Name = "LOAIGIUONG";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbYeuCauDacBiet);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.checkDSCho);
            this.panel3.Controls.Add(this.dtpCheckout);
            this.panel3.Controls.Add(this.dtpCheckin);
            this.panel3.Controls.Add(this.label_time_checkout);
            this.panel3.Controls.Add(this.label_time_checkin);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(348, 390);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 210);
            this.panel3.TabIndex = 31;
            // 
            // tbYeuCauDacBiet
            // 
            this.tbYeuCauDacBiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbYeuCauDacBiet.Location = new System.Drawing.Point(456, 5);
            this.tbYeuCauDacBiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.tbYeuCauDacBiet.Name = "tbYeuCauDacBiet";
            this.tbYeuCauDacBiet.Size = new System.Drawing.Size(211, 26);
            this.tbYeuCauDacBiet.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Yêu cầu đặc biệt:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkDSCho
            // 
            this.checkDSCho.AutoSize = true;
            this.checkDSCho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDSCho.Location = new System.Drawing.Point(315, 45);
            this.checkDSCho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkDSCho.Name = "checkDSCho";
            this.checkDSCho.Size = new System.Drawing.Size(138, 21);
            this.checkDSCho.TabIndex = 41;
            this.checkDSCho.Text = "Danh sách chờ";
            this.checkDSCho.UseVisualStyleBackColor = true;
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(225, 44);
            this.dtpCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(169, 22);
            this.dtpCheckout.TabIndex = 40;
            this.dtpCheckout.ValueChanged += new System.EventHandler(this.dtpCheckout_ValueChanged);
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(225, 10);
            this.dtpCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(169, 22);
            this.dtpCheckin.TabIndex = 39;
            this.dtpCheckin.ValueChanged += new System.EventHandler(this.dtpCheckin_ValueChanged);
            // 
            // label_time_checkout
            // 
            this.label_time_checkout.AutoSize = true;
            this.label_time_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_checkout.Location = new System.Drawing.Point(37, 52);
            this.label_time_checkout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time_checkout.Name = "label_time_checkout";
            this.label_time_checkout.Size = new System.Drawing.Size(156, 17);
            this.label_time_checkout.TabIndex = 38;
            this.label_time_checkout.Text = "Thời gian trả phòng:";
            this.label_time_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_time_checkout.Click += new System.EventHandler(this.label_time_checkout_Click);
            // 
            // label_time_checkin
            // 
            this.label_time_checkin.AutoSize = true;
            this.label_time_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_checkin.Location = new System.Drawing.Point(37, 17);
            this.label_time_checkin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_time_checkin.Name = "label_time_checkin";
            this.label_time_checkin.Size = new System.Drawing.Size(172, 17);
            this.label_time_checkin.TabIndex = 37;
            this.label_time_checkin.Text = "Thời gian nhận phòng:";
            this.label_time_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_time_checkin.Click += new System.EventHandler(this.label_time_checkin_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 369);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 24);
            this.comboBox2.TabIndex = 56;
            // 
            // GUI_DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dtgLoaiPhong);
            this.Controls.Add(this.dtgDSPhongTrong);
            this.Controls.Add(this.pTTKhachHang);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_DatPhong";
            this.Text = "booking_intermediary";
            this.Load += new System.EventHandler(this.booking_intermediary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pTTKhachHang.ResumeLayout(false);
            this.pTTKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSPhongTrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoaiPhong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_cus_info;
        private System.Windows.Forms.Label label_list_empty_room;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pTTKhachHang;
        private System.Windows.Forms.DataGridView dtgDSPhongTrong;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
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
        private System.Windows.Forms.DateTimePicker dtpNgayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lb_LoaiPhong;
        private System.Windows.Forms.DataGridView dtgLoaiPhong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.Label label_time_checkout;
        private System.Windows.Forms.Label label_time_checkin;
        private System.Windows.Forms.CheckBox checkDSCho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbYeuCauDacBiet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAIPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOGIUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIGIUONG;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}