namespace INFSYS_Design.views
{
    partial class list_of_services
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.back_btn = new System.Windows.Forms.Button();
            this.add_service_btn = new System.Windows.Forms.Button();
            this.update_service_btn = new System.Windows.Forms.Button();
            this.delete_service_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.service_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(86, 29);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Trang chủ";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // add_service_btn
            // 
            this.add_service_btn.Location = new System.Drawing.Point(104, 12);
            this.add_service_btn.Name = "add_service_btn";
            this.add_service_btn.Size = new System.Drawing.Size(97, 29);
            this.add_service_btn.TabIndex = 1;
            this.add_service_btn.Text = "Thêm dịch vụ";
            this.add_service_btn.UseVisualStyleBackColor = true;
            this.add_service_btn.Click += new System.EventHandler(this.add_service_btn_Click);
            // 
            // update_service_btn
            // 
            this.update_service_btn.Location = new System.Drawing.Point(207, 12);
            this.update_service_btn.Name = "update_service_btn";
            this.update_service_btn.Size = new System.Drawing.Size(97, 29);
            this.update_service_btn.TabIndex = 2;
            this.update_service_btn.Text = "Sửa dịch vụ";
            this.update_service_btn.UseVisualStyleBackColor = true;
            this.update_service_btn.Click += new System.EventHandler(this.update_service_btn_Click);
            // 
            // delete_service_btn
            // 
            this.delete_service_btn.Location = new System.Drawing.Point(310, 12);
            this.delete_service_btn.Name = "delete_service_btn";
            this.delete_service_btn.Size = new System.Drawing.Size(97, 29);
            this.delete_service_btn.TabIndex = 3;
            this.delete_service_btn.Text = "Xóa dịch vụ";
            this.delete_service_btn.UseVisualStyleBackColor = true;
            this.delete_service_btn.Click += new System.EventHandler(this.delete_service_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service_id,
            this.service_name,
            this.service_description,
            this.service_type,
            this.service_price});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 482);
            this.dataGridView1.TabIndex = 4;
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
            // list_of_services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_service_btn);
            this.Controls.Add(this.update_service_btn);
            this.Controls.Add(this.add_service_btn);
            this.Controls.Add(this.back_btn);
            this.Name = "list_of_services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button add_service_btn;
        private System.Windows.Forms.Button update_service_btn;
        private System.Windows.Forms.Button delete_service_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_price;
    }
}