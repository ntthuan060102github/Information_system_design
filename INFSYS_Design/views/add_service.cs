using System.Windows.Forms;
using System;
using INFSYS_Design.controllers;

namespace INFSYS_Design.views
{
    partial class GUI_AddService
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.tb_type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(189, 43);
            this.tb_name.Multiline = true;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(325, 28);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(50, 43);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(120, 28);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "Tên dịch vụ";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_description
            // 
            this.lb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_description.Location = new System.Drawing.Point(50, 95);
            this.lb_description.Name = "lb_description";
            this.lb_description.Size = new System.Drawing.Size(120, 28);
            this.lb_description.TabIndex = 9;
            this.lb_description.Text = "Mô tả";
            this.lb_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(189, 95);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(325, 28);
            this.tb_description.TabIndex = 2;
            // 
            // lb_type
            // 
            this.lb_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.Location = new System.Drawing.Point(50, 150);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(120, 28);
            this.lb_type.TabIndex = 11;
            this.lb_type.Text = "Loại dịch vụ";
            this.lb_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_price
            // 
            this.lb_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(50, 208);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(120, 28);
            this.lb_price.TabIndex = 14;
            this.lb_price.Text = "Giá";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_price
            // 
            this.tb_price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(189, 208);
            this.tb_price.Multiline = true;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(325, 28);
            this.tb_price.TabIndex = 4;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.Location = new System.Drawing.Point(97, 283);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(97, 29);
            this.add_btn.TabIndex = 5;
            this.add_btn.Text = "Thêm";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.Location = new System.Drawing.Point(340, 283);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(97, 29);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "Hủy";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // tb_type
            // 
            this.tb_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_type.Location = new System.Drawing.Point(189, 150);
            this.tb_type.Multiline = true;
            this.tb_type.Name = "tb_type";
            this.tb_type.Size = new System.Drawing.Size(325, 28);
            this.tb_type.TabIndex = 3;
            // 
            // GUI_AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.tb_type);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.lb_description);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tb_name);
            this.Name = "GUI_AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm dịch vụ";
            this.Load += new System.EventHandler(this.AddService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_description;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button back_btn;

        private void add_btn_Click(object sender, System.EventArgs e)
        {
            try
            {
                string text_tenDichVu = tb_name.Text;
                string text_moTa = tb_description.Text;
                string text_loaiDichVu = tb_type.Text;
                string text_gia = tb_price.Text;
                int gia = int.Parse(text_gia);

                if (string.IsNullOrEmpty(text_tenDichVu))
                {
                    MessageBox.Show(
                        "Tên dịch vụ không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_moTa))
                {
                    MessageBox.Show(
                        "Mô tả không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_loaiDichVu)) 
                {
                    MessageBox.Show(
                        "Loại dịch vụ không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
                if (string.IsNullOrEmpty(text_gia))
                {
                    MessageBox.Show(
                        "Giá không được để trống!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }                            
                if (gia < 0)
                {
                    MessageBox.Show(
                        "Giá không hợp lệ!",
                        "Lỗi!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                if (DichVu.themDichVu(text_tenDichVu, text_moTa, text_loaiDichVu, gia))
                {
                    MessageBox.Show(
                        "Thành công!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(
                        "Thất bại!",
                        "Thông báo!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Thông tin nhập vào không hợp lệ!",
                    "Lỗi!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            int idx = Program.previousForm.Count - 1;
            Form prvForm = Program.previousForm[idx];
            Program.previousForm.RemoveAt(idx);
            prvForm.Show();
            this.Hide();
        }
    }
}