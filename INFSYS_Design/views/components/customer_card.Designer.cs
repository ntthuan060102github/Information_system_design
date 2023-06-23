
namespace INFSYS_Design.views.components
{
    partial class CustomerCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customer_name = new System.Windows.Forms.Label();
            this.customer_id_num = new System.Windows.Forms.Label();
            this.customer_year_of_birth = new System.Windows.Forms.Label();
            this.customer_email = new System.Windows.Forms.Label();
            this.customer_phone_num = new System.Windows.Forms.Label();
            this.customer_address = new System.Windows.Forms.Label();
            this.customer_gender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customer_name
            // 
            this.customer_name.AutoSize = true;
            this.customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customer_name.Location = new System.Drawing.Point(13, 13);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(199, 25);
            this.customer_name.TabIndex = 0;
            this.customer_name.Text = "Nguyen Trong Thuan";
            this.customer_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // customer_id_num
            // 
            this.customer_id_num.AutoSize = true;
            this.customer_id_num.Location = new System.Drawing.Point(27, 47);
            this.customer_id_num.Name = "customer_id_num";
            this.customer_id_num.Size = new System.Drawing.Size(193, 17);
            this.customer_id_num.TabIndex = 1;
            this.customer_id_num.Text = "CCCD/CMND: 064202013424";
            // 
            // customer_year_of_birth
            // 
            this.customer_year_of_birth.AutoSize = true;
            this.customer_year_of_birth.Location = new System.Drawing.Point(27, 69);
            this.customer_year_of_birth.Name = "customer_year_of_birth";
            this.customer_year_of_birth.Size = new System.Drawing.Size(107, 17);
            this.customer_year_of_birth.TabIndex = 2;
            this.customer_year_of_birth.Text = "Năm sinh: 2002";
            // 
            // customer_email
            // 
            this.customer_email.AutoSize = true;
            this.customer_email.Location = new System.Drawing.Point(27, 92);
            this.customer_email.Name = "customer_email";
            this.customer_email.Size = new System.Drawing.Size(174, 17);
            this.customer_email.TabIndex = 3;
            this.customer_email.Text = "Email: thuannt29@fpt.com";
            // 
            // customer_phone_num
            // 
            this.customer_phone_num.Location = new System.Drawing.Point(27, 117);
            this.customer_phone_num.Name = "customer_phone_num";
            this.customer_phone_num.Size = new System.Drawing.Size(140, 17);
            this.customer_phone_num.TabIndex = 4;
            this.customer_phone_num.Text = "Số ĐT: 0328221179";
            // 
            // customer_address
            // 
            this.customer_address.AutoSize = true;
            this.customer_address.Location = new System.Drawing.Point(27, 143);
            this.customer_address.Name = "customer_address";
            this.customer_address.Size = new System.Drawing.Size(195, 17);
            this.customer_address.TabIndex = 5;
            this.customer_address.Text = "Địa chỉ thường trú: KTX khu B";
            // 
            // customer_gender
            // 
            this.customer_gender.AutoSize = true;
            this.customer_gender.Location = new System.Drawing.Point(27, 168);
            this.customer_gender.Name = "customer_gender";
            this.customer_gender.Size = new System.Drawing.Size(97, 17);
            this.customer_gender.TabIndex = 6;
            this.customer_gender.Text = "Giới tính: Nam";
            this.customer_gender.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CustomerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.customer_gender);
            this.Controls.Add(this.customer_address);
            this.Controls.Add(this.customer_phone_num);
            this.Controls.Add(this.customer_email);
            this.Controls.Add(this.customer_year_of_birth);
            this.Controls.Add(this.customer_id_num);
            this.Controls.Add(this.customer_name);
            this.Name = "CustomerCard";
            this.Size = new System.Drawing.Size(245, 196);
            this.Load += new System.EventHandler(this.customer_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customer_name;
        private System.Windows.Forms.Label customer_id_num;
        private System.Windows.Forms.Label customer_year_of_birth;
        private System.Windows.Forms.Label customer_email;
        private System.Windows.Forms.Label customer_phone_num;
        private System.Windows.Forms.Label customer_address;
        private System.Windows.Forms.Label customer_gender;
    }
}
