namespace INFSYS_Design.views
{
    partial class GUI_Invoice
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
            this.pay_btn = new System.Windows.Forms.Button();
            this.lb_cost_without_tax = new System.Windows.Forms.Label();
            this.lb_vat = new System.Windows.Forms.Label();
            this.lb_create_at = new System.Windows.Forms.Label();
            this.lb_invoice_id = new System.Windows.Forms.Label();
            this.lb_invoice_id_text = new System.Windows.Forms.Label();
            this.lb_create_at_text = new System.Windows.Forms.Label();
            this.lb_vat_text = new System.Windows.Forms.Label();
            this.lb_cost_without_tax_text = new System.Windows.Forms.Label();
            this.lb_total_cost = new System.Windows.Forms.Label();
            this.lb_total_cost_text = new System.Windows.Forms.Label();
            this.lb_amount_receiced = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_change = new System.Windows.Forms.Label();
            this.lb_change_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pay_btn
            // 
            this.pay_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pay_btn.Location = new System.Drawing.Point(454, 464);
            this.pay_btn.Name = "pay_btn";
            this.pay_btn.Size = new System.Drawing.Size(97, 29);
            this.pay_btn.TabIndex = 25;
            this.pay_btn.Text = "Thanh toán";
            this.pay_btn.UseVisualStyleBackColor = true;
            this.pay_btn.Click += new System.EventHandler(this.pay_btn_Click);
            // 
            // lb_cost_without_tax
            // 
            this.lb_cost_without_tax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cost_without_tax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cost_without_tax.Location = new System.Drawing.Point(333, 259);
            this.lb_cost_without_tax.Name = "lb_cost_without_tax";
            this.lb_cost_without_tax.Size = new System.Drawing.Size(150, 28);
            this.lb_cost_without_tax.TabIndex = 24;
            this.lb_cost_without_tax.Text = "Chi phí chưa thuế:";
            this.lb_cost_without_tax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_vat
            // 
            this.lb_vat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vat.Location = new System.Drawing.Point(333, 209);
            this.lb_vat.Name = "lb_vat";
            this.lb_vat.Size = new System.Drawing.Size(150, 28);
            this.lb_vat.TabIndex = 21;
            this.lb_vat.Text = "VAT:";
            this.lb_vat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_create_at
            // 
            this.lb_create_at.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_create_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_create_at.Location = new System.Drawing.Point(333, 159);
            this.lb_create_at.Name = "lb_create_at";
            this.lb_create_at.Size = new System.Drawing.Size(150, 28);
            this.lb_create_at.TabIndex = 20;
            this.lb_create_at.Text = "Thời gian tạo:";
            this.lb_create_at.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_invoice_id
            // 
            this.lb_invoice_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_invoice_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoice_id.Location = new System.Drawing.Point(333, 109);
            this.lb_invoice_id.Name = "lb_invoice_id";
            this.lb_invoice_id.Size = new System.Drawing.Size(150, 28);
            this.lb_invoice_id.TabIndex = 18;
            this.lb_invoice_id.Text = "Mã hóa đơn:";
            this.lb_invoice_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_invoice_id_text
            // 
            this.lb_invoice_id_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_invoice_id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_invoice_id_text.Location = new System.Drawing.Point(552, 109);
            this.lb_invoice_id_text.Name = "lb_invoice_id_text";
            this.lb_invoice_id_text.Size = new System.Drawing.Size(100, 28);
            this.lb_invoice_id_text.TabIndex = 27;
            this.lb_invoice_id_text.Text = "0000000";
            this.lb_invoice_id_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_create_at_text
            // 
            this.lb_create_at_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_create_at_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_create_at_text.Location = new System.Drawing.Point(552, 159);
            this.lb_create_at_text.Name = "lb_create_at_text";
            this.lb_create_at_text.Size = new System.Drawing.Size(100, 28);
            this.lb_create_at_text.TabIndex = 28;
            this.lb_create_at_text.Text = "29/06/2023";
            this.lb_create_at_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_vat_text
            // 
            this.lb_vat_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_vat_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vat_text.Location = new System.Drawing.Point(552, 209);
            this.lb_vat_text.Name = "lb_vat_text";
            this.lb_vat_text.Size = new System.Drawing.Size(100, 28);
            this.lb_vat_text.TabIndex = 29;
            this.lb_vat_text.Text = "10%";
            this.lb_vat_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_cost_without_tax_text
            // 
            this.lb_cost_without_tax_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_cost_without_tax_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cost_without_tax_text.Location = new System.Drawing.Point(552, 259);
            this.lb_cost_without_tax_text.Name = "lb_cost_without_tax_text";
            this.lb_cost_without_tax_text.Size = new System.Drawing.Size(100, 28);
            this.lb_cost_without_tax_text.TabIndex = 30;
            this.lb_cost_without_tax_text.Text = "5000000";
            this.lb_cost_without_tax_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_cost
            // 
            this.lb_total_cost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_cost.Location = new System.Drawing.Point(333, 309);
            this.lb_total_cost.Name = "lb_total_cost";
            this.lb_total_cost.Size = new System.Drawing.Size(150, 28);
            this.lb_total_cost.TabIndex = 31;
            this.lb_total_cost.Text = "Tổng chi phí:";
            this.lb_total_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_total_cost_text
            // 
            this.lb_total_cost_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_total_cost_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_cost_text.Location = new System.Drawing.Point(552, 309);
            this.lb_total_cost_text.Name = "lb_total_cost_text";
            this.lb_total_cost_text.Size = new System.Drawing.Size(100, 28);
            this.lb_total_cost_text.TabIndex = 32;
            this.lb_total_cost_text.Text = "5500000";
            this.lb_total_cost_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_amount_receiced
            // 
            this.lb_amount_receiced.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_amount_receiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_amount_receiced.Location = new System.Drawing.Point(333, 359);
            this.lb_amount_receiced.Name = "lb_amount_receiced";
            this.lb_amount_receiced.Size = new System.Drawing.Size(150, 28);
            this.lb_amount_receiced.TabIndex = 33;
            this.lb_amount_receiced.Text = "Số tiền nhận:";
            this.lb_amount_receiced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.Location = new System.Drawing.Point(552, 359);
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(100, 27);
            this.tb_description.TabIndex = 34;
            this.tb_description.Text = "10000000";
            // 
            // lb_change
            // 
            this.lb_change.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_change.Location = new System.Drawing.Point(333, 407);
            this.lb_change.Name = "lb_change";
            this.lb_change.Size = new System.Drawing.Size(150, 28);
            this.lb_change.TabIndex = 35;
            this.lb_change.Text = "Số tiền trả lại:";
            this.lb_change.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_change_text
            // 
            this.lb_change_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_change_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_change_text.Location = new System.Drawing.Point(548, 407);
            this.lb_change_text.Name = "lb_change_text";
            this.lb_change_text.Size = new System.Drawing.Size(100, 28);
            this.lb_change_text.TabIndex = 36;
            this.lb_change_text.Text = "4500000";
            this.lb_change_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1006, 105);
            this.label1.TabIndex = 37;
            this.label1.Text = "Hóa đơn bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_change_text);
            this.Controls.Add(this.lb_change);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_amount_receiced);
            this.Controls.Add(this.lb_total_cost_text);
            this.Controls.Add(this.lb_total_cost);
            this.Controls.Add(this.lb_cost_without_tax_text);
            this.Controls.Add(this.lb_vat_text);
            this.Controls.Add(this.lb_create_at_text);
            this.Controls.Add(this.lb_invoice_id_text);
            this.Controls.Add(this.pay_btn);
            this.Controls.Add(this.lb_cost_without_tax);
            this.Controls.Add(this.lb_vat);
            this.Controls.Add(this.lb_create_at);
            this.Controls.Add(this.lb_invoice_id);
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button pay_btn;
        private System.Windows.Forms.Label lb_cost_without_tax;
        private System.Windows.Forms.Label lb_vat;
        private System.Windows.Forms.Label lb_create_at;
        private System.Windows.Forms.Label lb_invoice_id;
        private System.Windows.Forms.Label lb_invoice_id_text;
        private System.Windows.Forms.Label lb_create_at_text;
        private System.Windows.Forms.Label lb_vat_text;
        private System.Windows.Forms.Label lb_cost_without_tax_text;
        private System.Windows.Forms.Label lb_total_cost;
        private System.Windows.Forms.Label lb_total_cost_text;
        private System.Windows.Forms.Label lb_amount_receiced;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_change;
        private System.Windows.Forms.Label lb_change_text;
        private System.Windows.Forms.Label label1;
    }
}