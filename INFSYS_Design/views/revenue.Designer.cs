namespace INFSYS_Design.views
{
    partial class GUI_XemDoanhThu
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSee = new System.Windows.Forms.Button();
            this.label_date_start = new System.Windows.Forms.Label();
            this.label_date_end = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAHOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THOIGIANTAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHIPHICHUATHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTIENNHAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACHECKOUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.Red;
            this.btnReturn.Location = new System.Drawing.Point(12, 12);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(85, 36);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnSee
            // 
            this.btnSee.AutoSize = true;
            this.btnSee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSee.Location = new System.Drawing.Point(590, 139);
            this.btnSee.Name = "btnSee";
            this.btnSee.Size = new System.Drawing.Size(124, 26);
            this.btnSee.TabIndex = 1;
            this.btnSee.Text = "Xem doanh thu";
            this.btnSee.UseVisualStyleBackColor = true;
            // 
            // label_date_start
            // 
            this.label_date_start.AutoSize = true;
            this.label_date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_start.Location = new System.Drawing.Point(284, 126);
            this.label_date_start.Name = "label_date_start";
            this.label_date_start.Size = new System.Drawing.Size(106, 16);
            this.label_date_start.TabIndex = 2;
            this.label_date_start.Text = "Ngày bắt đầu:";
            this.label_date_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_date_start.Click += new System.EventHandler(this.label_date_start_Click);
            // 
            // label_date_end
            // 
            this.label_date_end.AutoSize = true;
            this.label_date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date_end.Location = new System.Drawing.Point(284, 167);
            this.label_date_end.Name = "label_date_end";
            this.label_date_end.Size = new System.Drawing.Size(109, 16);
            this.label_date_end.TabIndex = 3;
            this.label_date_end.Text = "Ngày kết thúc:";
            this.label_date_end.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(287, 54);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(427, 39);
            this.title.TabIndex = 4;
            this.title.Text = "DOANH THU KHÁCH SẠN";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(433, 122);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(128, 20);
            this.dtpStart.TabIndex = 5;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(433, 163);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(128, 20);
            this.dtpEnd.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHOADON,
            this.THOIGIANTAO,
            this.VAT,
            this.CHIPHICHUATHUE,
            this.SOTIENNHAN,
            this.MACHECKOUT});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 320);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MAHOADON
            // 
            this.MAHOADON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAHOADON.HeaderText = "Mã hóa đơn";
            this.MAHOADON.Name = "MAHOADON";
            // 
            // THOIGIANTAO
            // 
            this.THOIGIANTAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THOIGIANTAO.HeaderText = "Thời gian tạo";
            this.THOIGIANTAO.Name = "THOIGIANTAO";
            // 
            // VAT
            // 
            this.VAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VAT.HeaderText = "VAT";
            this.VAT.Name = "VAT";
            // 
            // CHIPHICHUATHUE
            // 
            this.CHIPHICHUATHUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CHIPHICHUATHUE.HeaderText = "Chi phí chưa thuế";
            this.CHIPHICHUATHUE.Name = "CHIPHICHUATHUE";
            // 
            // SOTIENNHAN
            // 
            this.SOTIENNHAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SOTIENNHAN.HeaderText = "Số tiền đã nhận";
            this.SOTIENNHAN.Name = "SOTIENNHAN";
            // 
            // MACHECKOUT
            // 
            this.MACHECKOUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MACHECKOUT.HeaderText = "Mã checkout";
            this.MACHECKOUT.Name = "MACHECKOUT";
            // 
            // revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label_date_end);
            this.Controls.Add(this.label_date_start);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.btnReturn);
            this.Name = "revenue";
            this.Text = "revenue";
            this.Load += new System.EventHandler(this.revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSee;
        private System.Windows.Forms.Label label_date_start;
        private System.Windows.Forms.Label label_date_end;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn THOIGIANTAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHIPHICHUATHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTIENNHAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHECKOUT;
    }
}