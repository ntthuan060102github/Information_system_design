namespace INFSYS_Design.views
{
    partial class booking_intermediary
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
            this.label_customer_info = new System.Windows.Forms.Label();
            this.label_list_empty_room = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pInfo_customer = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_customer_birth_day = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_customer_gender = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_customer_address = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_customer_id = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label_customer_email = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_customer_phone_number = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.dtg_list_empty_room = new System.Windows.Forms.DataGridView();
            this.SELECTROOM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAIPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.label_time_checkout = new System.Windows.Forms.Label();
            this.label_time_checkin = new System.Windows.Forms.Label();
            this.dtpCheckout = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.pInfo_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list_empty_room)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_customer_info);
            this.panel1.Controls.Add(this.label_list_empty_room);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 165);
            this.panel1.TabIndex = 26;
            // 
            // label_customer_info
            // 
            this.label_customer_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customer_info.BackColor = System.Drawing.Color.White;
            this.label_customer_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_customer_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_info.ForeColor = System.Drawing.Color.Black;
            this.label_customer_info.Location = new System.Drawing.Point(0, 121);
            this.label_customer_info.Name = "label_customer_info";
            this.label_customer_info.Size = new System.Drawing.Size(590, 44);
            this.label_customer_info.TabIndex = 30;
            this.label_customer_info.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_customer_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_list_empty_room
            // 
            this.label_list_empty_room.BackColor = System.Drawing.Color.White;
            this.label_list_empty_room.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_list_empty_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_list_empty_room.ForeColor = System.Drawing.Color.Black;
            this.label_list_empty_room.Location = new System.Drawing.Point(590, 121);
            this.label_list_empty_room.Name = "label_list_empty_room";
            this.label_list_empty_room.Size = new System.Drawing.Size(418, 44);
            this.label_list_empty_room.TabIndex = 29;
            this.label_list_empty_room.Text = "DANH SÁCH PHÒNG TRỐNG";
            this.label_list_empty_room.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.title.Location = new System.Drawing.Point(412, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(220, 50);
            this.title.TabIndex = 28;
            this.title.Text = "ĐẶT PHÒNG";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Red;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 36);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // pInfo_customer
            // 
            this.pInfo_customer.Controls.Add(this.dateTimePicker1);
            this.pInfo_customer.Controls.Add(this.label_customer_birth_day);
            this.pInfo_customer.Controls.Add(this.textBox6);
            this.pInfo_customer.Controls.Add(this.label_customer_gender);
            this.pInfo_customer.Controls.Add(this.textBox5);
            this.pInfo_customer.Controls.Add(this.label_customer_address);
            this.pInfo_customer.Controls.Add(this.textBox4);
            this.pInfo_customer.Controls.Add(this.label_customer_id);
            this.pInfo_customer.Controls.Add(this.textBox3);
            this.pInfo_customer.Controls.Add(this.label_customer_email);
            this.pInfo_customer.Controls.Add(this.textBox2);
            this.pInfo_customer.Controls.Add(this.label_customer_phone_number);
            this.pInfo_customer.Controls.Add(this.textBox1);
            this.pInfo_customer.Controls.Add(this.label_customer_name);
            this.pInfo_customer.Controls.Add(this.btnSend);
            this.pInfo_customer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pInfo_customer.Location = new System.Drawing.Point(0, 165);
            this.pInfo_customer.Name = "pInfo_customer";
            this.pInfo_customer.Size = new System.Drawing.Size(590, 372);
            this.pInfo_customer.TabIndex = 27;
            this.pInfo_customer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(326, 161);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 22);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label_customer_birth_day
            // 
            this.label_customer_birth_day.AutoSize = true;
            this.label_customer_birth_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_birth_day.Location = new System.Drawing.Point(127, 167);
            this.label_customer_birth_day.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_birth_day.Name = "label_customer_birth_day";
            this.label_customer_birth_day.Size = new System.Drawing.Size(82, 16);
            this.label_customer_birth_day.TabIndex = 43;
            this.label_customer_birth_day.Text = "Ngày sinh:";
            this.label_customer_birth_day.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_birth_day.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(326, 296);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(159, 22);
            this.textBox6.TabIndex = 42;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label_customer_gender
            // 
            this.label_customer_gender.AutoSize = true;
            this.label_customer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_gender.Location = new System.Drawing.Point(127, 299);
            this.label_customer_gender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_gender.Name = "label_customer_gender";
            this.label_customer_gender.Size = new System.Drawing.Size(66, 16);
            this.label_customer_gender.TabIndex = 41;
            this.label_customer_gender.Text = "Giới tính";
            this.label_customer_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_gender.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(326, 251);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 22);
            this.textBox5.TabIndex = 40;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label_customer_address
            // 
            this.label_customer_address.AutoSize = true;
            this.label_customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_address.Location = new System.Drawing.Point(127, 254);
            this.label_customer_address.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_address.Name = "label_customer_address";
            this.label_customer_address.Size = new System.Drawing.Size(139, 16);
            this.label_customer_address.TabIndex = 39;
            this.label_customer_address.Text = "Địa chỉ thường trú:";
            this.label_customer_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_address.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(325, 206);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 22);
            this.textBox4.TabIndex = 38;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label_customer_id
            // 
            this.label_customer_id.AutoSize = true;
            this.label_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_id.Location = new System.Drawing.Point(126, 209);
            this.label_customer_id.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_id.Name = "label_customer_id";
            this.label_customer_id.Size = new System.Drawing.Size(101, 16);
            this.label_customer_id.TabIndex = 37;
            this.label_customer_id.Text = "CMND/CCCD:";
            this.label_customer_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_id.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(325, 116);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 22);
            this.textBox3.TabIndex = 36;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label_customer_email
            // 
            this.label_customer_email.AutoSize = true;
            this.label_customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_email.Location = new System.Drawing.Point(126, 119);
            this.label_customer_email.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_email.Name = "label_customer_email";
            this.label_customer_email.Size = new System.Drawing.Size(51, 16);
            this.label_customer_email.TabIndex = 35;
            this.label_customer_email.Text = "Email:";
            this.label_customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_email.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(325, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 22);
            this.textBox2.TabIndex = 34;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_customer_phone_number
            // 
            this.label_customer_phone_number.AutoSize = true;
            this.label_customer_phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_phone_number.Location = new System.Drawing.Point(126, 74);
            this.label_customer_phone_number.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_phone_number.Name = "label_customer_phone_number";
            this.label_customer_phone_number.Size = new System.Drawing.Size(43, 16);
            this.label_customer_phone_number.TabIndex = 33;
            this.label_customer_phone_number.Text = "SĐT:";
            this.label_customer_phone_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_phone_number.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(326, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 22);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_name.Location = new System.Drawing.Point(127, 29);
            this.label_customer_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(126, 16);
            this.label_customer_name.TabIndex = 31;
            this.label_customer_name.Text = "Tên khách hàng:";
            this.label_customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_customer_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(0, 346);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(590, 26);
            this.btnSend.TabIndex = 30;
            this.btnSend.Text = "Gữi yêu cầu đặt phòng";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // dtg_list_empty_room
            // 
            this.dtg_list_empty_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_list_empty_room.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECTROOM,
            this.SOPHONG,
            this.LOAIPHONG});
            this.dtg_list_empty_room.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_list_empty_room.Location = new System.Drawing.Point(590, 165);
            this.dtg_list_empty_room.Name = "dtg_list_empty_room";
            this.dtg_list_empty_room.RowHeadersVisible = false;
            this.dtg_list_empty_room.Size = new System.Drawing.Size(418, 372);
            this.dtg_list_empty_room.TabIndex = 28;
            // 
            // SELECTROOM
            // 
            this.SELECTROOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SELECTROOM.HeaderText = "Chọn phòng";
            this.SELECTROOM.Name = "SELECTROOM";
            this.SELECTROOM.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SELECTROOM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SELECTROOM.Width = 90;
            // 
            // SOPHONG
            // 
            this.SOPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOPHONG.HeaderText = "Số phòng";
            this.SOPHONG.Name = "SOPHONG";
            // 
            // LOAIPHONG
            // 
            this.LOAIPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LOAIPHONG.HeaderText = "Loại phòng";
            this.LOAIPHONG.Name = "LOAIPHONG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpCheckout);
            this.panel2.Controls.Add(this.dtpCheckin);
            this.panel2.Controls.Add(this.label_time_checkout);
            this.panel2.Controls.Add(this.label_time_checkin);
            this.panel2.Controls.Add(this.btnBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(590, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 100);
            this.panel2.TabIndex = 29;
            // 
            // btnBook
            // 
            this.btnBook.AutoSize = true;
            this.btnBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(0, 74);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(418, 26);
            this.btnBook.TabIndex = 30;
            this.btnBook.Text = "Đặt phòng";
            this.btnBook.UseVisualStyleBackColor = false;
            // 
            // label_time_checkout
            // 
            this.label_time_checkout.AutoSize = true;
            this.label_time_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_checkout.Location = new System.Drawing.Point(34, 48);
            this.label_time_checkout.Name = "label_time_checkout";
            this.label_time_checkout.Size = new System.Drawing.Size(151, 16);
            this.label_time_checkout.TabIndex = 34;
            this.label_time_checkout.Text = "Thời gian trả phòng:";
            this.label_time_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_time_checkin
            // 
            this.label_time_checkin.AutoSize = true;
            this.label_time_checkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_checkin.Location = new System.Drawing.Point(34, 14);
            this.label_time_checkin.Name = "label_time_checkin";
            this.label_time_checkin.Size = new System.Drawing.Size(167, 16);
            this.label_time_checkin.TabIndex = 33;
            this.label_time_checkin.Text = "Thời gian nhận phòng:";
            this.label_time_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckout.Location = new System.Drawing.Point(229, 48);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(128, 20);
            this.dtpCheckout.TabIndex = 36;
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckin.Location = new System.Drawing.Point(229, 14);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(128, 20);
            this.dtpCheckin.TabIndex = 35;
            // 
            // booking_intermediary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_list_empty_room);
            this.Controls.Add(this.pInfo_customer);
            this.Controls.Add(this.panel1);
            this.Name = "booking_intermediary";
            this.Text = "booking_intermediary";
            this.Load += new System.EventHandler(this.booking_intermediary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pInfo_customer.ResumeLayout(false);
            this.pInfo_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list_empty_room)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_customer_info;
        private System.Windows.Forms.Label label_list_empty_room;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pInfo_customer;
        private System.Windows.Forms.DataGridView dtg_list_empty_room;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECTROOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAIPHONG;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_customer_birth_day;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_customer_gender;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label_customer_address;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_customer_id;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_customer_email;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_customer_phone_number;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label_time_checkout;
        private System.Windows.Forms.Label label_time_checkin;
        private System.Windows.Forms.DateTimePicker dtpCheckout;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
    }
}