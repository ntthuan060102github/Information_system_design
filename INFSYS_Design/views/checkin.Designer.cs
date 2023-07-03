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
            this.title = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCheckin = new System.Windows.Forms.Button();
            this.customer_gender = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.Label();
            this.customer_phone_num = new System.Windows.Forms.Label();
            this.customer_email = new System.Windows.Forms.Label();
            this.customer_year_of_birth = new System.Windows.Forms.Label();
            this.customer_id_num = new System.Windows.Forms.Label();
            this.customer_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_customer);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 246);
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
            this.label_customer.Location = new System.Drawing.Point(0, 175);
            this.label_customer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_customer.Name = "label_customer";
            this.label_customer.Size = new System.Drawing.Size(1005, 71);
            this.label_customer.TabIndex = 20;
            this.label_customer.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label_customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(394, 81);
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
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(13, 13);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(107, 34);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCheckin
            // 
            this.btnCheckin.AutoSize = true;
            this.btnCheckin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckin.Location = new System.Drawing.Point(0, 485);
            this.btnCheckin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckin.Name = "btnCheckin";
            this.btnCheckin.Size = new System.Drawing.Size(1006, 44);
            this.btnCheckin.TabIndex = 14;
            this.btnCheckin.Text = "Nhận phòng";
            this.btnCheckin.UseVisualStyleBackColor = false;
            this.btnCheckin.Click += new System.EventHandler(this.btnCheckin_Click);
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
            this.customer_phone_num.Location = new System.Drawing.Point(1, 428);
            this.customer_phone_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_phone_num.Name = "customer_phone_num";
            this.customer_phone_num.Size = new System.Drawing.Size(1005, 39);
            this.customer_phone_num.TabIndex = 19;
            this.customer_phone_num.Text = "SĐT: 0949531628";
            this.customer_phone_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer_email
            // 
            this.customer_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_email.Location = new System.Drawing.Point(1, 393);
            this.customer_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(1005, 25);
            this.customer_email.TabIndex = 18;
            this.customer_email.Text = "Email: sonvo1@gmail.com";
            this.customer_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer_year_of_birth
            // 
            this.customer_year_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_year_of_birth.Location = new System.Drawing.Point(0, 354);
            this.customer_year_of_birth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_year_of_birth.Name = "customer_year_of_birth";
            this.customer_year_of_birth.Size = new System.Drawing.Size(1005, 25);
            this.customer_year_of_birth.TabIndex = 17;
            this.customer_year_of_birth.Text = "Năm sinh: 2002";
            this.customer_year_of_birth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer_id_num
            // 
            this.customer_id_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_id_num.Location = new System.Drawing.Point(0, 317);
            this.customer_id_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_id_num.Name = "customer_id_num";
            this.customer_id_num.Size = new System.Drawing.Size(1006, 25);
            this.customer_id_num.TabIndex = 16;
            this.customer_id_num.Text = "CCCD/CMND: 261549624";
            this.customer_id_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer_name
            // 
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customer_name.Location = new System.Drawing.Point(0, 276);
            this.customer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 25);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(1006, 29);
            this.customer_name.TabIndex = 15;
            this.customer_name.Text = "Võ Ngọc Sơn";
            this.customer_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customer_name.Click += new System.EventHandler(this.customer_name_Click);
            // 
            // GUI_Checkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.customer_gender);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.customer_phone_num);
            this.Controls.Add(this.customer_email);
            this.Controls.Add(this.customer_year_of_birth);
            this.Controls.Add(this.customer_name);
            this.Controls.Add(this.customer_id_num);
            this.Controls.Add(this.btnCheckin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_Checkin";
            this.Text = "checkin";
            this.Load += new System.EventHandler(this.checkin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label_customer;
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