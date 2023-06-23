
namespace INFSYS_Design.views
{
    partial class RoomExtension
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
            this.room_number = new System.Windows.Forms.TextBox();
            this.room_number_label = new System.Windows.Forms.Label();
            this.room_level_label = new System.Windows.Forms.Label();
            this.room_level = new System.Windows.Forms.TextBox();
            this.bed_type_label = new System.Windows.Forms.Label();
            this.bed_type = new System.Windows.Forms.TextBox();
            this.num_bed_label = new System.Windows.Forms.Label();
            this.num_bed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.year_of_birth_label = new System.Windows.Forms.Label();
            this.year_of_birth = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.id_num_label = new System.Windows.Forms.Label();
            this.id_num = new System.Windows.Forms.TextBox();
            this.customer_name_label = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.phone_num_label = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.gender_label = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.TextBox();
            this.waiting_list = new System.Windows.Forms.DataGridView();
            this.created_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.waiting_list)).BeginInit();
            this.SuspendLayout();
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(152, 78);
            this.room_number.Multiline = true;
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(333, 29);
            this.room_number.TabIndex = 0;
            // 
            // room_number_label
            // 
            this.room_number_label.Location = new System.Drawing.Point(46, 81);
            this.room_number_label.Name = "room_number_label";
            this.room_number_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.room_number_label.Size = new System.Drawing.Size(100, 23);
            this.room_number_label.TabIndex = 1;
            this.room_number_label.Text = "Số phòng";
            this.room_number_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.room_number_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // room_level_label
            // 
            this.room_level_label.Location = new System.Drawing.Point(46, 142);
            this.room_level_label.Name = "room_level_label";
            this.room_level_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.room_level_label.Size = new System.Drawing.Size(100, 17);
            this.room_level_label.TabIndex = 3;
            this.room_level_label.Text = "Hạng phòng";
            this.room_level_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.room_level_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // room_level
            // 
            this.room_level.Location = new System.Drawing.Point(152, 135);
            this.room_level.Multiline = true;
            this.room_level.Name = "room_level";
            this.room_level.Size = new System.Drawing.Size(333, 29);
            this.room_level.TabIndex = 2;
            // 
            // bed_type_label
            // 
            this.bed_type_label.Location = new System.Drawing.Point(43, 250);
            this.bed_type_label.Name = "bed_type_label";
            this.bed_type_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bed_type_label.Size = new System.Drawing.Size(103, 17);
            this.bed_type_label.TabIndex = 7;
            this.bed_type_label.Text = "Loại giường";
            this.bed_type_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bed_type_label.Click += new System.EventHandler(this.bed_type_label_Click);
            // 
            // bed_type
            // 
            this.bed_type.Location = new System.Drawing.Point(152, 245);
            this.bed_type.Multiline = true;
            this.bed_type.Name = "bed_type";
            this.bed_type.Size = new System.Drawing.Size(333, 29);
            this.bed_type.TabIndex = 6;
            // 
            // num_bed_label
            // 
            this.num_bed_label.Location = new System.Drawing.Point(46, 193);
            this.num_bed_label.Name = "num_bed_label";
            this.num_bed_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_bed_label.Size = new System.Drawing.Size(100, 17);
            this.num_bed_label.TabIndex = 5;
            this.num_bed_label.Text = "Số giường";
            this.num_bed_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.num_bed_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_bed
            // 
            this.num_bed.Location = new System.Drawing.Point(152, 188);
            this.num_bed.Multiline = true;
            this.num_bed.Name = "num_bed";
            this.num_bed.Size = new System.Drawing.Size(333, 29);
            this.num_bed.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(396, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông tin phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(583, 33);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(402, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thông tin khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_of_birth_label
            // 
            this.year_of_birth_label.Location = new System.Drawing.Point(530, 253);
            this.year_of_birth_label.Name = "year_of_birth_label";
            this.year_of_birth_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.year_of_birth_label.Size = new System.Drawing.Size(109, 17);
            this.year_of_birth_label.TabIndex = 16;
            this.year_of_birth_label.Text = "Năm sinh";
            this.year_of_birth_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // year_of_birth
            // 
            this.year_of_birth.Location = new System.Drawing.Point(643, 248);
            this.year_of_birth.Multiline = true;
            this.year_of_birth.Name = "year_of_birth";
            this.year_of_birth.Size = new System.Drawing.Size(302, 29);
            this.year_of_birth.TabIndex = 15;
            // 
            // email_label
            // 
            this.email_label.Location = new System.Drawing.Point(533, 196);
            this.email_label.Name = "email_label";
            this.email_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.email_label.Size = new System.Drawing.Size(106, 17);
            this.email_label.TabIndex = 14;
            this.email_label.Text = "Email";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(643, 191);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(302, 29);
            this.email.TabIndex = 13;
            // 
            // id_num_label
            // 
            this.id_num_label.Location = new System.Drawing.Point(533, 145);
            this.id_num_label.Name = "id_num_label";
            this.id_num_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id_num_label.Size = new System.Drawing.Size(106, 17);
            this.id_num_label.TabIndex = 12;
            this.id_num_label.Text = "CCCD/CMND";
            this.id_num_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // id_num
            // 
            this.id_num.Location = new System.Drawing.Point(643, 138);
            this.id_num.Multiline = true;
            this.id_num.Name = "id_num";
            this.id_num.Size = new System.Drawing.Size(302, 29);
            this.id_num.TabIndex = 11;
            // 
            // customer_name_label
            // 
            this.customer_name_label.Location = new System.Drawing.Point(533, 84);
            this.customer_name_label.Name = "customer_name_label";
            this.customer_name_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customer_name_label.Size = new System.Drawing.Size(106, 23);
            this.customer_name_label.TabIndex = 10;
            this.customer_name_label.Text = "Họ tên";
            this.customer_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.customer_name_label.Click += new System.EventHandler(this.label6_Click);
            // 
            // customer_name
            // 
            this.customer_name.Location = new System.Drawing.Point(643, 81);
            this.customer_name.Multiline = true;
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(302, 29);
            this.customer_name.TabIndex = 9;
            this.customer_name.TextChanged += new System.EventHandler(this.customer_name_TextChanged);
            // 
            // phone_num_label
            // 
            this.phone_num_label.Location = new System.Drawing.Point(530, 315);
            this.phone_num_label.Name = "phone_num_label";
            this.phone_num_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.phone_num_label.Size = new System.Drawing.Size(109, 17);
            this.phone_num_label.TabIndex = 19;
            this.phone_num_label.Text = "Số điện thoại";
            this.phone_num_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phone_num
            // 
            this.phone_num.Location = new System.Drawing.Point(643, 310);
            this.phone_num.Multiline = true;
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(302, 29);
            this.phone_num.TabIndex = 18;
            // 
            // address_label
            // 
            this.address_label.Location = new System.Drawing.Point(530, 380);
            this.address_label.Name = "address_label";
            this.address_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.address_label.Size = new System.Drawing.Size(109, 17);
            this.address_label.TabIndex = 21;
            this.address_label.Text = "Địa chỉ";
            this.address_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(643, 375);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(302, 29);
            this.address.TabIndex = 20;
            // 
            // gender_label
            // 
            this.gender_label.Location = new System.Drawing.Point(530, 445);
            this.gender_label.Name = "gender_label";
            this.gender_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gender_label.Size = new System.Drawing.Size(109, 17);
            this.gender_label.TabIndex = 23;
            this.gender_label.Text = "Giới tính";
            this.gender_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(643, 440);
            this.gender.Multiline = true;
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(302, 29);
            this.gender.TabIndex = 22;
            // 
            // waiting_list
            // 
            this.waiting_list.AllowUserToAddRows = false;
            this.waiting_list.AllowUserToDeleteRows = false;
            this.waiting_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waiting_list.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waiting_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waiting_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.created_at,
            this.deadline,
            this.status});
            this.waiting_list.Location = new System.Drawing.Point(49, 296);
            this.waiting_list.Name = "waiting_list";
            this.waiting_list.ReadOnly = true;
            this.waiting_list.RowHeadersVisible = false;
            this.waiting_list.RowHeadersWidth = 51;
            this.waiting_list.RowTemplate.Height = 24;
            this.waiting_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.waiting_list.Size = new System.Drawing.Size(436, 173);
            this.waiting_list.TabIndex = 24;
            this.waiting_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // created_at
            // 
            this.created_at.HeaderText = "Thời gian tạo";
            this.created_at.MinimumWidth = 6;
            this.created_at.Name = "created_at";
            this.created_at.ReadOnly = true;
            this.created_at.Width = 125;
            // 
            // deadline
            // 
            this.deadline.HeaderText = "Thời gian hết hạn";
            this.deadline.MinimumWidth = 6;
            this.deadline.Name = "deadline";
            this.deadline.ReadOnly = true;
            this.deadline.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Trạng thái";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
            // 
            // RoomExtension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.waiting_list);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address);
            this.Controls.Add(this.phone_num_label);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.year_of_birth_label);
            this.Controls.Add(this.year_of_birth);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email);
            this.Controls.Add(this.id_num_label);
            this.Controls.Add(this.id_num);
            this.Controls.Add(this.customer_name_label);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bed_type_label);
            this.Controls.Add(this.bed_type);
            this.Controls.Add(this.num_bed_label);
            this.Controls.Add(this.num_bed);
            this.Controls.Add(this.room_level_label);
            this.Controls.Add(this.room_level);
            this.Controls.Add(this.room_number_label);
            this.Controls.Add(this.room_number);
            this.Name = "RoomExtension";
            this.Text = "Gia hạn";
            this.Load += new System.EventHandler(this.RoomExtension_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waiting_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox room_number;
        private System.Windows.Forms.Label room_number_label;
        private System.Windows.Forms.Label room_level_label;
        private System.Windows.Forms.TextBox room_level;
        private System.Windows.Forms.Label bed_type_label;
        private System.Windows.Forms.TextBox bed_type;
        private System.Windows.Forms.Label num_bed_label;
        private System.Windows.Forms.TextBox num_bed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label year_of_birth_label;
        private System.Windows.Forms.TextBox year_of_birth;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label id_num_label;
        private System.Windows.Forms.TextBox id_num;
        private System.Windows.Forms.Label customer_name_label;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label phone_num_label;
        private System.Windows.Forms.TextBox phone_num;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.DataGridView waiting_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_at;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}

