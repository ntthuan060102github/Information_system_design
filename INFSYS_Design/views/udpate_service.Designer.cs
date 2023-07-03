namespace INFSYS_Design.views
{
    partial class GUI_UpdateService
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
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.lb_serviceId = new System.Windows.Forms.Label();
            this.tb_service_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.Location = new System.Drawing.Point(339, 296);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(97, 29);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Hủy";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.Location = new System.Drawing.Point(96, 296);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 29);
            this.update_btn.TabIndex = 5;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // lb_price
            // 
            this.lb_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(50, 230);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(120, 28);
            this.lb_price.TabIndex = 24;
            this.lb_price.Text = "Giá";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_price
            // 
            this.tb_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(189, 230);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(325, 28);
            this.tb_price.TabIndex = 4;
            // 
            // lb_type
            // 
            this.lb_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(50, 180);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(120, 28);
            this.lb_type.TabIndex = 21;
            this.lb_type.Text = "Loại dịch vụ";
            this.lb_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_description
            // 
            this.lb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(50, 130);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(120, 28);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "Mô tả";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(189, 130);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(325, 28);
            this.tb_description.TabIndex = 2;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(50, 80);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(120, 28);
            this.lb_name.TabIndex = 18;
            this.lb_name.Text = "Tên dịch vụ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(189, 80);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(325, 28);
            this.tb_name.TabIndex = 1;
            // 
            // tb_type
            // 
            this.tb_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_type.Location = new System.Drawing.Point(189, 180);
            this.tb_type.Multiline = true;
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(325, 28);
            this.tb_type.TabIndex = 3;
            // 
            // lb_serviceId
            // 
            this.lb_serviceId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_serviceId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_serviceId.Location = new System.Drawing.Point(50, 30);
            this.lb_serviceId.Name = "lb_serviceId";
            this.lb_serviceId.Size = new System.Drawing.Size(120, 28);
            this.lb_serviceId.TabIndex = 25;
            this.lb_serviceId.Text = "Mã dịch vụ";
            this.lb_serviceId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_service_id
            // 
            this.tb_service_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_service_id.Enabled = false;
            this.tb_service_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_service_id.Location = new System.Drawing.Point(189, 30);
            this.tb_service_id.Multiline = true;
            this.tb_service_id.Name = "tb_service_id";
            this.tb_service_id.Size = new System.Drawing.Size(325, 28);
            this.tb_service_id.TabIndex = 26;
            // 
            // GUI_UpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.tb_service_id);
            this.Controls.Add(this.lb_serviceId);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Name = "GUI_UpdateService";
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
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_type;
        private System.Windows.Forms.Label lb_serviceId;
        private System.Windows.Forms.TextBox tb_service_id;
    }
}