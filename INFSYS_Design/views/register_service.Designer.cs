namespace INFSYS_Design.views
{
    partial class GUI_RegisterService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_roomBookingId = new System.Windows.Forms.Label();
            this.register_btn = new System.Windows.Forms.Button();
            this.lb_Time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_fee = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.back_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_roomBookingId
            // 
            this.lb_roomBookingId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_roomBookingId.AutoSize = true;
            this.lb_roomBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roomBookingId.Location = new System.Drawing.Point(300, 46);
            this.lb_roomBookingId.Name = "lb_roomBookingId";
            this.lb_roomBookingId.Size = new System.Drawing.Size(110, 20);
            this.lb_roomBookingId.TabIndex = 0;
            this.lb_roomBookingId.Text = "Mã đặt phòng";
            // 
            // register_btn
            // 
            this.register_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.register_btn.Location = new System.Drawing.Point(664, 459);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(313, 29);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Đăng ký";
            this.register_btn.UseVisualStyleBackColor = false;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // lb_Time
            // 
            this.lb_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(660, 429);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(111, 20);
            this.lb_Time.TabIndex = 28;
            this.lb_Time.Text = "Ngày sử dụng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(777, 428);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lb_fee
            // 
            this.lb_fee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fee.Location = new System.Drawing.Point(642, 497);
            this.lb_fee.Name = "lb_fee";
            this.lb_fee.Size = new System.Drawing.Size(358, 20);
            this.lb_fee.TabIndex = 30;
            this.lb_fee.Text = "Phí tạm tính: 100000";
            this.lb_fee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_fee.Click += new System.EventHandler(this.lb_fee_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service_id,
            this.service_name,
            this.service_description,
            this.service_type,
            this.service_price});
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(618, 435);
            this.dataGridView1.TabIndex = 32;
            // 
            // service_id
            // 
            this.service_id.HeaderText = "Mã dịch vụ";
            this.service_id.MinimumWidth = 6;
            this.service_id.Name = "service_id";
            this.service_id.ReadOnly = true;
            // 
            // service_name
            // 
            this.service_name.HeaderText = "Tên dịch vụ";
            this.service_name.MinimumWidth = 6;
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            // 
            // service_description
            // 
            this.service_description.HeaderText = "Mô tả";
            this.service_description.MinimumWidth = 6;
            this.service_description.Name = "service_description";
            this.service_description.ReadOnly = true;
            // 
            // service_type
            // 
            this.service_type.HeaderText = "Loại dich vụ";
            this.service_type.MinimumWidth = 6;
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            // 
            // service_price
            // 
            this.service_price.HeaderText = "Giá";
            this.service_price.MinimumWidth = 6;
            this.service_price.Name = "service_price";
            this.service_price.ReadOnly = true;
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(86, 29);
            this.back_btn.TabIndex = 33;
            this.back_btn.Text = "Trang chủ";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(474, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 34;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.coupon});
            this.dataGridView2.Location = new System.Drawing.Point(646, 82);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(348, 337);
            this.dataGridView2.TabIndex = 35;
            // 
            // name
            // 
            this.name.HeaderText = "Tên dịch vụ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Giá";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // coupon
            // 
            this.coupon.HeaderText = "Khuyến mãi";
            this.coupon.MinimumWidth = 6;
            this.coupon.Name = "coupon";
            this.coupon.ReadOnly = true;
            // 
            // GUI_RegisterService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_fee);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.lb_roomBookingId);
            this.Name = "GUI_RegisterService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí dịch vụ";
            this.Load += new System.EventHandler(this.GUI_RegisterService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_roomBookingId;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_fee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_price;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn coupon;
    }
}