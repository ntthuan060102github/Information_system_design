namespace INFSYS_Design.views
{
    partial class GUI_RegisterTour
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
            this.register_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tour_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tour_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tour_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travel_agency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_date_start = new System.Windows.Forms.Label();
            this.lb_special_requirements = new System.Windows.Forms.Label();
            this.lb_tour_id = new System.Windows.Forms.Label();
            this.cbb_tour_id = new System.Windows.Forms.ComboBox();
            this.tb_special_requirements = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_roomBookingId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.register_btn.Location = new System.Drawing.Point(453, 488);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(97, 29);
            this.register_btn.TabIndex = 5;
            this.register_btn.Text = "Đăng kí";
            this.register_btn.UseVisualStyleBackColor = true;
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
            this.tour_id,
            this.tour_name,
            this.tour_description,
            this.date_start,
            this.date_end,
            this.service_type,
            this.travel_agency});
            this.dataGridView1.Location = new System.Drawing.Point(12, 236);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 234);
            this.dataGridView1.TabIndex = 35;
            // 
            // tour_id
            // 
            this.tour_id.HeaderText = "Mã tour";
            this.tour_id.MinimumWidth = 6;
            this.tour_id.Name = "tour_id";
            this.tour_id.ReadOnly = true;
            // 
            // tour_name
            // 
            this.tour_name.HeaderText = "Tên tour";
            this.tour_name.MinimumWidth = 6;
            this.tour_name.Name = "tour_name";
            this.tour_name.ReadOnly = true;
            // 
            // tour_description
            // 
            this.tour_description.HeaderText = "Mô tả";
            this.tour_description.MinimumWidth = 6;
            this.tour_description.Name = "tour_description";
            this.tour_description.ReadOnly = true;
            // 
            // date_start
            // 
            this.date_start.HeaderText = "Ngày bắt đầu";
            this.date_start.MinimumWidth = 6;
            this.date_start.Name = "date_start";
            this.date_start.ReadOnly = true;
            // 
            // date_end
            // 
            this.date_end.HeaderText = "Ngày kết thúc";
            this.date_end.MinimumWidth = 6;
            this.date_end.Name = "date_end";
            this.date_end.ReadOnly = true;
            // 
            // service_type
            // 
            this.service_type.HeaderText = "Loại dịch vụ";
            this.service_type.MinimumWidth = 6;
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            // 
            // travel_agency
            // 
            this.travel_agency.HeaderText = "Đơn vị lữ hành";
            this.travel_agency.MinimumWidth = 6;
            this.travel_agency.Name = "travel_agency";
            this.travel_agency.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lb_date_start
            // 
            this.lb_date_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_date_start.AutoSize = true;
            this.lb_date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_start.Location = new System.Drawing.Point(293, 180);
            this.lb_date_start.Name = "lb_date_start";
            this.lb_date_start.Size = new System.Drawing.Size(158, 20);
            this.lb_date_start.TabIndex = 40;
            this.lb_date_start.Text = "Thời gian khởi hành:";
            // 
            // lb_special_requirements
            // 
            this.lb_special_requirements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_special_requirements.AutoSize = true;
            this.lb_special_requirements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_special_requirements.Location = new System.Drawing.Point(293, 130);
            this.lb_special_requirements.Name = "lb_special_requirements";
            this.lb_special_requirements.Size = new System.Drawing.Size(140, 20);
            this.lb_special_requirements.TabIndex = 37;
            this.lb_special_requirements.Text = "Nhu cầu đặc biệt:";
            // 
            // lb_tour_id
            // 
            this.lb_tour_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_tour_id.AutoSize = true;
            this.lb_tour_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tour_id.Location = new System.Drawing.Point(294, 80);
            this.lb_tour_id.Name = "lb_tour_id";
            this.lb_tour_id.Size = new System.Drawing.Size(71, 20);
            this.lb_tour_id.TabIndex = 36;
            this.lb_tour_id.Text = "Mã tour:";
            // 
            // cbb_tour_id
            // 
            this.cbb_tour_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_tour_id.FormattingEnabled = true;
            this.cbb_tour_id.Location = new System.Drawing.Point(467, 80);
            this.cbb_tour_id.Name = "cbb_tour_id";
            this.cbb_tour_id.Size = new System.Drawing.Size(200, 24);
            this.cbb_tour_id.TabIndex = 2;
            // 
            // tb_special_requirements
            // 
            this.tb_special_requirements.Location = new System.Drawing.Point(467, 130);
            this.tb_special_requirements.Multiline = true;
            this.tb_special_requirements.Name = "tb_special_requirements";
            this.tb_special_requirements.Size = new System.Drawing.Size(200, 20);
            this.tb_special_requirements.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(467, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 1;
            // 
            // lb_roomBookingId
            // 
            this.lb_roomBookingId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_roomBookingId.AutoSize = true;
            this.lb_roomBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_roomBookingId.Location = new System.Drawing.Point(294, 30);
            this.lb_roomBookingId.Name = "lb_roomBookingId";
            this.lb_roomBookingId.Size = new System.Drawing.Size(115, 20);
            this.lb_roomBookingId.TabIndex = 46;
            this.lb_roomBookingId.Text = "Mã đặt phòng:";
            // 
            // GUI_RegisterTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_roomBookingId);
            this.Controls.Add(this.tb_special_requirements);
            this.Controls.Add(this.cbb_tour_id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_date_start);
            this.Controls.Add(this.lb_special_requirements);
            this.Controls.Add(this.lb_tour_id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.register_btn);
            this.Name = "GUI_RegisterTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí Tour";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tour_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tour_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tour_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn travel_agency;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_date_start;
        private System.Windows.Forms.Label lb_special_requirements;
        private System.Windows.Forms.Label lb_tour_id;
        private System.Windows.Forms.ComboBox cbb_tour_id;
        private System.Windows.Forms.TextBox tb_special_requirements;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_roomBookingId;
    }
}