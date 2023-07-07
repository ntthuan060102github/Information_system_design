
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
            this.btn_tour_management = new System.Windows.Forms.Button();
            this.btn_room_booking = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // btn_tour_management
            // 
            this.btn_tour_management.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_tour_management.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_tour_management.Location = new System.Drawing.Point(374, 266);
            this.btn_tour_management.Name = "btn_tour_management";
            this.btn_tour_management.Size = new System.Drawing.Size(259, 46);
            this.btn_tour_management.TabIndex = 4;
            this.btn_tour_management.Text = "Quản lý hệ thống Tour";
            this.btn_tour_management.UseVisualStyleBackColor = false;
            // 
            // btn_room_booking
            // 
            this.btn_room_booking.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_room_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_room_booking.Location = new System.Drawing.Point(374, 318);
            this.btn_room_booking.Name = "btn_room_booking";
            this.btn_room_booking.Size = new System.Drawing.Size(259, 46);
            this.btn_room_booking.TabIndex = 5;
            this.btn_room_booking.Text = "Đặt phòng";
            this.btn_room_booking.UseVisualStyleBackColor = false;
            this.btn_room_booking.Click += new System.EventHandler(this.btn_room_booking_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.Location = new System.Drawing.Point(374, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Quản lý dịch vụ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.Location = new System.Drawing.Point(374, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(259, 46);
            this.button3.TabIndex = 7;
            this.button3.Text = "Đặt dịch vụ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GUI_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_room_booking);
            this.Controls.Add(this.btn_tour_management);
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
        private System.Windows.Forms.Button btn_tour_management;
        private System.Windows.Forms.Button btn_room_booking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}