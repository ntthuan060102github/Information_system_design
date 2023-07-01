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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_roomBookingId = new System.Windows.Forms.Label();
            this.cbb_service = new System.Windows.Forms.ComboBox();
            this.lb_service = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_fee = new System.Windows.Forms.Label();
            this.lb_fee_text = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_roomBookingId
            // 
            this.lb_roomBookingId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_roomBookingId.AutoSize = true;
            this.lb_roomBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roomBookingId.Location = new System.Drawing.Point(289, 50);
            this.lb_roomBookingId.Name = "lb_roomBookingId";
            this.lb_roomBookingId.Size = new System.Drawing.Size(110, 20);
            this.lb_roomBookingId.TabIndex = 0;
            this.lb_roomBookingId.Text = "Mã đặt phòng";
            // 
            // cbb_service
            // 
            this.cbb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_service.FormattingEnabled = true;
            this.cbb_service.Location = new System.Drawing.Point(474, 94);
            this.cbb_service.Name = "cbb_service";
            this.cbb_service.Size = new System.Drawing.Size(200, 24);
            this.cbb_service.TabIndex = 3;
            this.cbb_service.Text = "--Chọn dịch vụ--";
            // 
            // lb_service
            // 
            this.lb_service.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_service.AutoSize = true;
            this.lb_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_service.Location = new System.Drawing.Point(300, 94);
            this.lb_service.Name = "lb_service";
            this.lb_service.Size = new System.Drawing.Size(124, 20);
            this.lb_service.TabIndex = 2;
            this.lb_service.Text = "Dịch vụ đăng kí";
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.Location = new System.Drawing.Point(457, 488);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 29);
            this.update_btn.TabIndex = 26;
            this.update_btn.Text = "Đăng kí";
            this.update_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(474, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 27;
            // 
            // lb_Time
            // 
            this.lb_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Time.Location = new System.Drawing.Point(300, 147);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(111, 20);
            this.lb_Time.TabIndex = 28;
            this.lb_Time.Text = "Ngày sử dụng";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(474, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // lb_fee
            // 
            this.lb_fee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_fee.AutoSize = true;
            this.lb_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fee.Location = new System.Drawing.Point(301, 194);
            this.lb_fee.Name = "lb_fee";
            this.lb_fee.Size = new System.Drawing.Size(98, 20);
            this.lb_fee.TabIndex = 30;
            this.lb_fee.Text = "Phí tạm tính";
            // 
            // lb_fee_text
            // 
            this.lb_fee_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_fee_text.AutoSize = true;
            this.lb_fee_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fee_text.Location = new System.Drawing.Point(470, 194);
            this.lb_fee_text.Name = "lb_fee_text";
            this.lb_fee_text.Size = new System.Drawing.Size(54, 20);
            this.lb_fee_text.TabIndex = 31;
            this.lb_fee_text.Text = "50000";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service_id,
            this.service_name,
            this.service_description,
            this.service_type,
            this.service_price});
            this.dataGridView1.Location = new System.Drawing.Point(130, 236);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 234);
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
            // GUI_RegisterService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_fee_text);
            this.Controls.Add(this.lb_fee);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cbb_service);
            this.Controls.Add(this.lb_service);
            this.Controls.Add(this.lb_roomBookingId);
            this.Name = "GUI_RegisterService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_roomBookingId;
        private System.Windows.Forms.ComboBox cbb_service;
        private System.Windows.Forms.Label lb_service;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_fee;
        private System.Windows.Forms.Label lb_fee_text;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_price;
    }
}