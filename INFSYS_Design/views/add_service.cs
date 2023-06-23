namespace INFSYS_Design.views
{
    partial class AddService
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(1001, 111);
            this.label1.TabIndex = 5;
            this.label1.Text = "THÊM DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(338, 141);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(407, 28);
            this.textBox_Name.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(173, 141);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(130, 28);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Tên dịch vụ";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(173, 193);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(130, 28);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Mô tả";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Description.Location = new System.Drawing.Point(338, 193);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(407, 28);
            this.textBox_Description.TabIndex = 8;
            // 
            // labelType
            // 
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(173, 248);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(130, 28);
            this.labelType.TabIndex = 11;
            this.labelType.Text = "Loại dịch vụ";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Location = new System.Drawing.Point(338, 248);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(407, 28);
            this.comboBox_Type.TabIndex = 12;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(173, 306);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(130, 28);
            this.labelPrice.TabIndex = 14;
            this.labelPrice.Text = "Giá";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Price.Location = new System.Drawing.Point(338, 306);
            this.textBox_Price.Multiline = true;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(407, 28);
            this.textBox_Price.TabIndex = 13;
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Add_btn.Location = new System.Drawing.Point(229, 407);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(127, 44);
            this.Add_btn.TabIndex = 15;
            this.Add_btn.Text = "Thêm";
            this.Add_btn.UseVisualStyleBackColor = true;
            // 
            // Back_btn
            // 
            this.Back_btn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Back_btn.Location = new System.Drawing.Point(537, 407);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(127, 44);
            this.Back_btn.TabIndex = 16;
            this.Back_btn.Text = "Hủy";
            this.Back_btn.UseVisualStyleBackColor = true;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm dịch vụ";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Back_btn;
    }
}