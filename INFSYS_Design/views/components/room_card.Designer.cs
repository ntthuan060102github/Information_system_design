
namespace INFSYS_Design.views.components
{
    partial class RoomCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.room_num = new System.Windows.Forms.Label();
            this.room_level = new System.Windows.Forms.Label();
            this.num_bed = new System.Windows.Forms.Label();
            this.bed_type = new System.Windows.Forms.Label();
            this.detail_btn = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // room_num
            // 
            this.room_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.room_num.Location = new System.Drawing.Point(12, 12);
            this.room_num.Name = "room_num";
            this.room_num.Size = new System.Drawing.Size(129, 32);
            this.room_num.TabIndex = 0;
            this.room_num.Text = "Phòng 105";
            // 
            // room_level
            // 
            this.room_level.AutoSize = true;
            this.room_level.Location = new System.Drawing.Point(25, 44);
            this.room_level.Name = "room_level";
            this.room_level.Size = new System.Drawing.Size(115, 17);
            this.room_level.TabIndex = 1;
            this.room_level.Text = "Hạng phòng: VIP";
            // 
            // num_bed
            // 
            this.num_bed.AutoSize = true;
            this.num_bed.Location = new System.Drawing.Point(26, 68);
            this.num_bed.Name = "num_bed";
            this.num_bed.Size = new System.Drawing.Size(88, 17);
            this.num_bed.TabIndex = 2;
            this.num_bed.Text = "Số giường: 2";
            this.num_bed.Click += new System.EventHandler(this.label1_Click);
            // 
            // bed_type
            // 
            this.bed_type.AutoSize = true;
            this.bed_type.Location = new System.Drawing.Point(26, 92);
            this.bed_type.Name = "bed_type";
            this.bed_type.Size = new System.Drawing.Size(156, 17);
            this.bed_type.TabIndex = 3;
            this.bed_type.Text = "Loại giường: giường đôi";
            this.bed_type.Click += new System.EventHandler(this.label2_Click);
            // 
            // detail_btn
            // 
            this.detail_btn.BackColor = System.Drawing.SystemColors.Control;
            this.detail_btn.Location = new System.Drawing.Point(223, 12);
            this.detail_btn.Name = "detail_btn";
            this.detail_btn.Size = new System.Drawing.Size(75, 23);
            this.detail_btn.TabIndex = 4;
            this.detail_btn.Text = "Chi tiết";
            this.detail_btn.UseVisualStyleBackColor = false;
            this.detail_btn.Click += new System.EventHandler(this.detail_btn_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(26, 116);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(170, 17);
            this.status.TabIndex = 5;
            this.status.Text = "Trạng thái: Đang sử dụng";
            // 
            // room_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.status);
            this.Controls.Add(this.detail_btn);
            this.Controls.Add(this.bed_type);
            this.Controls.Add(this.num_bed);
            this.Controls.Add(this.room_level);
            this.Controls.Add(this.room_num);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "room_card";
            this.Size = new System.Drawing.Size(309, 147);
            this.Load += new System.EventHandler(this.room_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label room_num;
        private System.Windows.Forms.Label room_level;
        private System.Windows.Forms.Label num_bed;
        private System.Windows.Forms.Label bed_type;
        private System.Windows.Forms.Button detail_btn;
        private System.Windows.Forms.Label status;
    }
}
