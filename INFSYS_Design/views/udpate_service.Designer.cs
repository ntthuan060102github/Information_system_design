namespace INFSYS_Design.views
{
    partial class UdpateService
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
            this.back_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.cbb_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(340, 283);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(97, 29);
            this.back_btn.TabIndex = 26;
            this.back_btn.Text = "Hủy";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(97, 283);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 29);
            this.update_btn.TabIndex = 25;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // lb_price
            // 
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(50, 208);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(120, 28);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "Giá";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(189, 208);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(325, 28);
            this.tb_price.TabIndex = 23;
            // 
            // cbb_type
            // 
            this.cbb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_type.FormattingEnabled = true;
            this.cbb_type.Location = new System.Drawing.Point(189, 150);
            this.cbb_type.Name = "cbb_type";
            this.cbb_type.Size = new System.Drawing.Size(325, 28);
            this.cbb_type.TabIndex = 22;
            // 
            // lb_type
            // 
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(50, 150);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(120, 28);
            this.lb_type.TabIndex = 21;
            this.lb_type.Text = "Loại dịch vụ";
            this.lb_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_description
            // 
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(50, 95);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(120, 28);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "Mô tả";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(189, 95);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(325, 28);
            this.tb_description.TabIndex = 19;
            // 
            // lb_name
            // 
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(50, 43);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(120, 28);
            this.lb_name.TabIndex = 18;
            this.lb_name.Text = "Tên dịch vụ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(189, 43);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(325, 28);
            this.tb_name.TabIndex = 17;
            // 
            // UdpateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.cbb_type);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Name = "UdpateService";
            this.Text = "Sửa dịch vụ";
            this.Load += new System.EventHandler(this.udpate_service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ComboBox cbb_type;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
    }
}