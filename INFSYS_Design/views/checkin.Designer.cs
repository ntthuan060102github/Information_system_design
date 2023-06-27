namespace INFSYS_Design.views
{
    partial class checkin
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
            this.label_customer_name = new System.Windows.Forms.Label();
            this.label_room_number = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtgHistory = new System.Windows.Forms.DataGridView();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_history = new System.Windows.Forms.Label();
            this.label_customer = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 221);
            this.panel1.TabIndex = 12;
            // 
            // label_customer_name
            // 
            this.label_customer_name.AutoSize = true;
            this.label_customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer_name.Location = new System.Drawing.Point(226, 136);
            this.label_customer_name.Name = "label_customer_name";
            this.label_customer_name.Size = new System.Drawing.Size(126, 16);
            this.label_customer_name.TabIndex = 18;
            this.label_customer_name.Text = "Tên khách hàng:";
            this.label_customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_room_number
            // 
            this.label_room_number.AutoSize = true;
            this.label_room_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room_number.Location = new System.Drawing.Point(226, 102);
            this.label_room_number.Name = "label_room_number";
            this.label_room_number.Size = new System.Drawing.Size(79, 16);
            this.label_room_number.TabIndex = 17;
            this.label_room_number.Text = "Số phòng:";
            this.label_room_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(598, 109);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(124, 26);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(412, 42);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(169, 39);
            this.title.TabIndex = 15;
            this.title.Text = "CHECKIN";
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
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Võ Ngọc Sơn";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "101";
            // 
            // dtgHistory
            // 
            this.dtgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOTEN,
            this.SOPHONG,
            this.THOIGIANNHAN});
            this.dtgHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtgHistory.Location = new System.Drawing.Point(0, 221);
            this.dtgHistory.Name = "dtgHistory";
            this.dtgHistory.RowHeadersVisible = false;
            this.dtgHistory.Size = new System.Drawing.Size(418, 316);
            this.dtgHistory.TabIndex = 13;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.HeaderText = "Tên khách hàng";
            this.HOTEN.Name = "HOTEN";
            // 
            // SOPHONG
            // 
            this.SOPHONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOPHONG.HeaderText = "Số phòng";
            this.SOPHONG.Name = "SOPHONG";
            // 
            // THOIGIANNHAN
            // 
            this.THOIGIANNHAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANNHAN.HeaderText = "Thời gian nhận phòng";
            this.THOIGIANNHAN.Name = "THOIGIANNHAN";
            // 
            // label_history
            // 
            this.label_history.BackColor = System.Drawing.Color.White;
            this.label_history.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_history.ForeColor = System.Drawing.Color.Black;
            this.label_history.Location = new System.Drawing.Point(0, 177);
            this.label_history.Name = "label_history";
            this.label_history.Size = new System.Drawing.Size(418, 44);
            this.label_history.TabIndex = 19;
            this.label_history.Text = "LỊCH SỬ ĐẶT PHÒNG";
            this.label_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_customer
            // 
            this.label_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_customer.BackColor = System.Drawing.Color.White;
            this.label_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_customer.ForeColor = System.Drawing.Color.Black;
            this.label_customer.Location = new System.Drawing.Point(418, 177);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(590, 44);
            this.label_customer.TabIndex = 20;
            this.label_customer.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckin
            // 
            this.btnCheckin.AutoSize = true;
            this.btnCheckin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(418, 511);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(590, 26);
            this.btnCheckin.TabIndex = 14;
            this.btnCheckin.Text = "Nhận phòng";
            this.btnCheckin.UseVisualStyleBackColor = false;
            // 
            // customer_gender
            // 
            this.customer_gender.AutoSize = true;
            this.customer_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_gender.Location = new System.Drawing.Point(596, 481);
            this.customer_gender.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_gender.Name = "customer_gender";
            this.customer_gender.Size = new System.Drawing.Size(108, 20);
            this.customer_gender.TabIndex = 21;
            this.customer_gender.Text = "Giới tính: Nam";
            this.customer_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_address
            // 
            this.customer_address.AutoSize = true;
            this.customer_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_address.Location = new System.Drawing.Point(596, 441);
            this.customer_address.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(246, 20);
            this.customer_address.TabIndex = 20;
            this.customer_address.Text = "Địa chỉ thường trú: Kbang, Gia Lai";
            this.customer_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_phone_num
            // 
            this.customer_phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_phone_num.Location = new System.Drawing.Point(597, 399);
            this.customer_phone_num.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_phone_num.Name = "customer_phone_num";
            this.customer_phone_num.Size = new System.Drawing.Size(158, 22);
            this.customer_phone_num.TabIndex = 19;
            this.customer_phone_num.Text = "Số ĐT: 0949531628";
            this.customer_phone_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_email
            // 
            this.customer_email.AutoSize = true;
            this.customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_email.Location = new System.Drawing.Point(597, 359);
            this.customer_email.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(194, 20);
            this.customer_email.TabIndex = 18;
            this.customer_email.Text = "Email: sonvo1@gmail.com";
            this.customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_year_of_birth
            // 
            this.customer_year_of_birth.AutoSize = true;
            this.customer_year_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_year_of_birth.Location = new System.Drawing.Point(597, 319);
            this.customer_year_of_birth.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_year_of_birth.Name = "customer_year_of_birth";
            this.customer_year_of_birth.Size = new System.Drawing.Size(119, 20);
            this.customer_year_of_birth.TabIndex = 17;
            this.customer_year_of_birth.Text = "Năm sinh: 2002";
            this.customer_year_of_birth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_id_num
            // 
            this.customer_id_num.AutoSize = true;
            this.customer_id_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_num.Location = new System.Drawing.Point(596, 279);
            this.customer_id_num.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_id_num.Name = "customer_id_num";
            this.customer_id_num.Size = new System.Drawing.Size(194, 20);
            this.customer_id_num.TabIndex = 16;
            this.customer_id_num.Text = "CCCD/CMND: 261549624";
            this.customer_id_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customer_name.Location = new System.Drawing.Point(655, 235);
            this.customer_name.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(135, 24);
            this.customer_name.TabIndex = 15;
            this.customer_name.Text = "Võ Ngọc Sơn";
            this.customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
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
            this.Name = "checkin";
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtgHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANNHAN;
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
    }
}