
namespace INFSYS_Design.views
{
    partial class GUI_Home
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
            this.hello_label = new System.Windows.Forms.Label();
            this.btn_customer_list = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkin_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hello_label
            // 
            this.hello_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hello_label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hello_label.Location = new System.Drawing.Point(15, 83);
            this.hello_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(976, 33);
            this.hello_label.TabIndex = 0;
            this.hello_label.Text = "Xin chào Người dùng";
            this.hello_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hello_label.Click += new System.EventHandler(this.hello_label_Click);
            // 
            // btn_customer_list
            // 
            this.btn_customer_list.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_customer_list.Location = new System.Drawing.Point(374, 162);
            this.btn_customer_list.Name = "btn_customer_list";
            this.btn_customer_list.Size = new System.Drawing.Size(259, 46);
            this.btn_customer_list.TabIndex = 2;
            this.btn_customer_list.Text = "Danh sách khách hàng";
            this.btn_customer_list.UseVisualStyleBackColor = false;
            this.btn_customer_list.Click += new System.EventHandler(this.btn_customer_list_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(374, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Danh sách phòng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkin_btn
            // 
            this.checkin_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkin_btn.Location = new System.Drawing.Point(374, 266);
            this.checkin_btn.Name = "checkin_btn";
            this.checkin_btn.Size = new System.Drawing.Size(259, 46);
            this.checkin_btn.TabIndex = 4;
            this.checkin_btn.Text = "Checkin";
            this.checkin_btn.UseVisualStyleBackColor = false;
            this.checkin_btn.Click += new System.EventHandler(this.checkin_btn_Click);
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.checkin_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_customer_list);
            this.Controls.Add(this.hello_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GUI_Home";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Button btn_customer_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button checkin_btn;
    }
}