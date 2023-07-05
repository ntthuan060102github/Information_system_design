namespace INFSYS_Design.views
{
    partial class GUI_RoomStatus
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
            this.create_invoice_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.lb__compensation_cost = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_device_name = new System.Windows.Forms.Label();
            this.tb_device_name = new System.Windows.Forms.TextBox();
            this.tb_compensation_cost = new System.Windows.Forms.TextBox();
            this.lb_checkout_id = new System.Windows.Forms.Label();
            this.lb_checkout_id_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // create_invoice_btn
            // 
            this.create_invoice_btn.Location = new System.Drawing.Point(353, 270);
            this.create_invoice_btn.Name = "create_invoice_btn";
            this.create_invoice_btn.Size = new System.Drawing.Size(117, 29);
            this.create_invoice_btn.TabIndex = 5;
            this.create_invoice_btn.Text = "Tạo hóa đơn";
            this.create_invoice_btn.UseVisualStyleBackColor = true;
            this.create_invoice_btn.Click += new System.EventHandler(this.create_invoice_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(117, 270);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(97, 29);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            // 
            // lb__compensation_cost
            // 
            this.lb__compensation_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb__compensation_cost.Location = new System.Drawing.Point(40, 200);
            this.lb__compensation_cost.Name = "lb__compensation_cost";
            this.lb__compensation_cost.Size = new System.Drawing.Size(150, 28);
            this.lb__compensation_cost.TabIndex = 21;
            this.lb__compensation_cost.Text = "Chi phí đền bù:";
            this.lb__compensation_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_description
            // 
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(40, 150);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(150, 28);
            this.lb_description.TabIndex = 20;
            this.lb_description.Text = "Mô tả tình trạng:";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(200, 150);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(325, 28);
            this.tb_description.TabIndex = 2;
            // 
            // lb_device_name
            // 
            this.lb_device_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_device_name.Location = new System.Drawing.Point(40, 100);
            this.lb_device_name.Name = "lb_device_name";
            this.lb_device_name.Size = new System.Drawing.Size(150, 28);
            this.lb_device_name.TabIndex = 18;
            this.lb_device_name.Text = "Tên thiết bị:";
            this.lb_device_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_device_name
            // 
            this.tb_device_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_device_name.Location = new System.Drawing.Point(200, 100);
            this.tb_device_name.Multiline = true;
            this.tb_device_name.Name = "tb_device_name";
            this.tb_device_name.Size = new System.Drawing.Size(325, 28);
            this.tb_device_name.TabIndex = 1;
            // 
            // tb_compensation_cost
            // 
            this.tb_compensation_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compensation_cost.Location = new System.Drawing.Point(200, 200);
            this.tb_compensation_cost.Multiline = true;
            this.tb_compensation_cost.Name = "tb_compensation_cost";
            this.tb_compensation_cost.Size = new System.Drawing.Size(325, 28);
            this.tb_compensation_cost.TabIndex = 3;
            // 
            // lb_checkout_id
            // 
            this.lb_checkout_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkout_id.Location = new System.Drawing.Point(40, 50);
            this.lb_checkout_id.Name = "lb_checkout_id";
            this.lb_checkout_id.Size = new System.Drawing.Size(150, 28);
            this.lb_checkout_id.TabIndex = 28;
            this.lb_checkout_id.Text = "Mã Checkout:";
            this.lb_checkout_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_checkout_id_text
            // 
            this.lb_checkout_id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_checkout_id_text.Location = new System.Drawing.Point(200, 50);
            this.lb_checkout_id_text.Name = "lb_checkout_id_text";
            this.lb_checkout_id_text.Size = new System.Drawing.Size(150, 28);
            this.lb_checkout_id_text.TabIndex = 29;
            this.lb_checkout_id_text.Text = "1";
            this.lb_checkout_id_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_checkout_id_text.Click += new System.EventHandler(this.lb_checkout_id_text_Click);
            // 
            // GUI_RoomStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.lb_checkout_id_text);
            this.Controls.Add(this.lb_checkout_id);
            this.Controls.Add(this.tb_compensation_cost);
            this.Controls.Add(this.create_invoice_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.lb__compensation_cost);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_device_name);
            this.Controls.Add(this.tb_device_name);
            this.Name = "GUI_RoomStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tình trạng phòng";
            this.Load += new System.EventHandler(this.room_status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button create_invoice_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label lb__compensation_cost;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_device_name;
        private System.Windows.Forms.TextBox tb_device_name;
        private System.Windows.Forms.TextBox tb_compensation_cost;
        private System.Windows.Forms.Label lb_checkout_id;
        private System.Windows.Forms.Label lb_checkout_id_text;
    }
}