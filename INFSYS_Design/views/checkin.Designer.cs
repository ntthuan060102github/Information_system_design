namespace INFSYS_Design.views
{
    partial class GUI_Checkin
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
            this.label_customer = new System.Windows.Forms.Label();
            this.label_history = new System.Windows.Forms.Label();
            this.label_customer_name = new System.Windows.Forms.Label();
            this.label_room_number = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbSoPhong = new System.Windows.Forms.TextBox();
            this.dtgHistory = new System.Windows.Forms.DataGridView();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.customer_gender = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.Label();
            this.customer_phone_num = new System.Windows.Forms.Label();
            this.customer_email = new System.Windows.Forms.Label();
            this.customer_year_of_birth = new System.Windows.Forms.Label();
            this.customer_id_num = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_customer);
            this.panel1.Controls.Add(this.label_history);
            this.panel1.Controls.Add(this.label_customer_name);
            this.panel1.Controls.Add(this.label_room_number);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.tbSoPhong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 272);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_customer
            // 
            this.label_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customer.BackColor = System.Drawing.Color.White;
            this.label_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.ForeColor = System.Drawing.Color.Black;
            this.label_customer.Location = new System.Drawing.Point(557, 218);
            this.label_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(786, 54);
            this.label_customer.TabIndex = 20;
            this.label_customer.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.label_customer.Click += new System.EventHandler(this.label_customer_Click);
            // 
            // label_history
            // 
            this.label_history.BackColor = System.Drawing.Color.White;
            this.label_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_history.ForeColor = System.Drawing.Color.Black;
            this.label_history.Location = new System.Drawing.Point(0, 218);
            this.label_history.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(557, 54);
            this.label_history.TabIndex = 19;
            this.label_history.Text = "LỊCH SỬ ĐẶT PHÒNG";
            this.label_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_name.Location = new System.Drawing.Point(301, 167);
            this.label_customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(147, 20);
            this.label_customer_name.TabIndex = 18;
            this.label_customer_name.Text = "Tên khách hàng:";
            this.label_customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_room_number
            // 
            this.label_room_number.AutoSize = true;
            this.label_room_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room_number.Location = new System.Drawing.Point(301, 126);
            this.label_room_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_room_number.Name = "label_room_number";
            this.label_room_number.Size = new System.Drawing.Size(93, 20);
            this.label_room_number.TabIndex = 17;
            this.label_room_number.Text = "Số phòng:";
            this.label_room_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(797, 134);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(165, 37);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(549, 52);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(208, 48);
            this.title.TabIndex = 15;
            this.title.Text = "CHECKIN";
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
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(535, 162);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(195, 22);
            this.tbTenKH.TabIndex = 13;
            // 
            // tbSoPhong
            // 
            this.tbSoPhong.Location = new System.Drawing.Point(535, 121);
            this.tbSoPhong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSoPhong.Name = "tbSoPhong";
            this.tbSoPhong.Size = new System.Drawing.Size(96, 22);
            this.tbSoPhong.TabIndex = 12;
            // 
            // dtgHistory
            // 
            this.dtgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTEN,
            this.SOPHONG});
            this.dtgHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgHistory.Location = new System.Drawing.Point(0, 272);
            this.dtgHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgHistory.Name = "dtgHistory";
            this.dtgHistory.RowHeadersVisible = false;
            this.dtgHistory.RowHeadersWidth = 51;
            this.dtgHistory.Size = new System.Drawing.Size(557, 389);
            this.dtgHistory.TabIndex = 13;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.HeaderText = "Tên khách hàng";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            // 
            // SOPHONG
            // 
            this.SOPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOPHONG.HeaderText = "Số phòng";
            this.SOPHONG.MinimumWidth = 6;
            this.SOPHONG.Name = "SOPHONG";
            // 
            // btnCheckin
            // 
            this.btnCheckin.AutoSize = true;
            this.btnCheckin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(557, 625);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(787, 36);
            this.btnCheckin.TabIndex = 14;
            this.btnCheckin.Text = "Nhận phòng";
            this.btnCheckin.UseVisualStyleBackColor = false;
            // 
            // customer_gender
            // 
            this.customer_gender.AutoSize = true;
            this.customer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_gender.Location = new System.Drawing.Point(795, 592);
            this.customer_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_gender.Name = "customer_gender";
            this.customer_gender.Size = new System.Drawing.Size(134, 25);
            this.customer_gender.TabIndex = 21;
            this.customer_gender.Text = "Giới tính: Nam";
            this.customer_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_address
            // 
            this.customer_address.AutoSize = true;
            this.customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address.Location = new System.Drawing.Point(795, 543);
            this.customer_address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(303, 25);
            this.customer_address.TabIndex = 20;
            this.customer_address.Text = "Địa chỉ thường trú: Kbang, Gia Lai";
            this.customer_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_phone_num
            // 
            this.customer_phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_num.Location = new System.Drawing.Point(796, 491);
            this.customer_phone_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_phone_num.Name = "customer_phone_num";
            this.customer_phone_num.Size = new System.Drawing.Size(211, 27);
            this.customer_phone_num.TabIndex = 19;
            this.customer_phone_num.Text = "SĐT: 0949531628";
            this.customer_phone_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_email
            // 
            this.customer_email.AutoSize = true;
            this.customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_email.Location = new System.Drawing.Point(796, 442);
            this.customer_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(243, 25);
            this.customer_email.TabIndex = 18;
            this.customer_email.Text = "Email: sonvo1@gmail.com";
            this.customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_year_of_birth
            // 
            this.customer_year_of_birth.AutoSize = true;
            this.customer_year_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_year_of_birth.Location = new System.Drawing.Point(796, 393);
            this.customer_year_of_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_year_of_birth.Name = "customer_year_of_birth";
            this.customer_year_of_birth.Size = new System.Drawing.Size(149, 25);
            this.customer_year_of_birth.TabIndex = 17;
            this.customer_year_of_birth.Text = "Năm sinh: 2002";
            this.customer_year_of_birth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_id_num
            // 
            this.customer_id_num.AutoSize = true;
            this.customer_id_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_num.Location = new System.Drawing.Point(795, 343);
            this.customer_id_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_id_num.Name = "customer_id_num";
            this.customer_id_num.Size = new System.Drawing.Size(247, 25);
            this.customer_id_num.TabIndex = 16;
            this.customer_id_num.Text = "CCCD/CMND: 261549624";
            this.customer_id_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customer_name.Location = new System.Drawing.Point(873, 289);
            this.customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(166, 29);
            this.customer_name.TabIndex = 15;
            this.customer_name.Text = "Võ Ngọc Sơn";
            this.customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GUI_Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 661);
            this.Controls.Add(this.customer_gender);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.customer_phone_num);
            this.Controls.Add(this.customer_email);
            this.Controls.Add(this.customer_year_of_birth);
            this.Controls.Add(this.customer_id_num);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.dtgHistory);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_Checkin";
            this.Text = "checkin";
            this.Load += new System.EventHandler(this.checkin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_customer_name;
        private System.Windows.Forms.Label label_room_number;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbTenKH;
        private System.Windows.Forms.TextBox tbSoPhong;
        private System.Windows.Forms.DataGridView dtgHistory;
        private System.Windows.Forms.Label label_customer;
        private System.Windows.Forms.Label label_history;
        private System.Windows.Forms.Button btnCheckin;
        private System.Windows.Forms.Label customer_gender;
        private System.Windows.Forms.Label customer_address;
        private System.Windows.Forms.Label customer_phone_num;
        private System.Windows.Forms.Label customer_email;
        private System.Windows.Forms.Label customer_year_of_birth;
        private System.Windows.Forms.Label customer_id_num;
        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
    }
}