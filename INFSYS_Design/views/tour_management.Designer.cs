
namespace INFSYS_Design.views
{
    partial class GUI_DanhSachTour
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_tour_btn = new System.Windows.Forms.Button();
            this.update_tour_btn = new System.Windows.Forms.Button();
            this.add_tour_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.service_price,
            this.Column1,
            this.service_type,
            this.Column2});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 482);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // service_id
            // 
            this.service_id.HeaderText = "Mã Tour";
            this.service_id.MinimumWidth = 6;
            this.service_id.Name = "service_id";
            this.service_id.ReadOnly = true;
            // 
            // service_name
            // 
            this.service_name.HeaderText = "Tên Tour";
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
            // service_price
            // 
            this.service_price.HeaderText = "Thời gian bắt đầu";
            this.service_price.MinimumWidth = 6;
            this.service_price.Name = "service_price";
            this.service_price.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thời gian kết thúc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // service_type
            // 
            this.service_type.HeaderText = "Loại dich vụ";
            this.service_type.MinimumWidth = 6;
            this.service_type.Name = "service_type";
            this.service_type.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Đơn vị lữ hành";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // delete_tour_btn
            // 
            this.delete_tour_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.delete_tour_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_tour_btn.Location = new System.Drawing.Point(325, 6);
            this.delete_tour_btn.Name = "delete_tour_btn";
            this.delete_tour_btn.Size = new System.Drawing.Size(97, 29);
            this.delete_tour_btn.TabIndex = 8;
            this.delete_tour_btn.Text = "Xóa tour";
            this.delete_tour_btn.UseVisualStyleBackColor = false;
            this.delete_tour_btn.Click += new System.EventHandler(this.delete_tour_btn_Click);
            // 
            // update_tour_btn
            // 
            this.update_tour_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.update_tour_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_tour_btn.Location = new System.Drawing.Point(222, 6);
            this.update_tour_btn.Name = "update_tour_btn";
            this.update_tour_btn.Size = new System.Drawing.Size(97, 29);
            this.update_tour_btn.TabIndex = 7;
            this.update_tour_btn.Text = "Sửa tour";
            this.update_tour_btn.UseVisualStyleBackColor = false;
            this.update_tour_btn.Click += new System.EventHandler(this.update_tour_btn_Click);
            // 
            // add_tour_btn
            // 
            this.add_tour_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add_tour_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_tour_btn.Location = new System.Drawing.Point(104, 6);
            this.add_tour_btn.Name = "add_tour_btn";
            this.add_tour_btn.Size = new System.Drawing.Size(112, 29);
            this.add_tour_btn.TabIndex = 6;
            this.add_tour_btn.Text = "Thêm tour";
            this.add_tour_btn.UseVisualStyleBackColor = false;
            this.add_tour_btn.Click += new System.EventHandler(this.add_tour_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.back_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_btn.Location = new System.Drawing.Point(12, 6);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(86, 29);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Trang chủ";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // GUI_DanhSachTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_tour_btn);
            this.Controls.Add(this.update_tour_btn);
            this.Controls.Add(this.add_tour_btn);
            this.Controls.Add(this.back_btn);
            this.Name = "GUI_DanhSachTour";
            this.Text = "Quản lý Tour";
            this.Load += new System.EventHandler(this.tour_management_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete_tour_btn;
        private System.Windows.Forms.Button update_tour_btn;
        private System.Windows.Forms.Button add_tour_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}