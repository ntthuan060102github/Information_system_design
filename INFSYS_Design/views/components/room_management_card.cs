
namespace INFSYS_Design.views.components
{
    partial class RoomManagementCard
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
            this.delete_btn = new System.Windows.Forms.Button();
            this.bed_type = new System.Windows.Forms.Label();
            this.num_bed = new System.Windows.Forms.Label();
            this.room_level = new System.Windows.Forms.Label();
            this.room_num = new System.Windows.Forms.Label();
            this.modify_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.delete_btn.Location = new System.Drawing.Point(27, 121);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(112, 25);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Xóa";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // bed_type
            // 
            this.bed_type.AutoSize = true;
            this.bed_type.Location = new System.Drawing.Point(25, 93);
            this.bed_type.Name = "bed_type";
            this.bed_type.Size = new System.Drawing.Size(156, 17);
            this.bed_type.TabIndex = 9;
            this.bed_type.Text = "Loại giường: giường đôi";
            // 
            // num_bed
            // 
            this.num_bed.AutoSize = true;
            this.num_bed.Location = new System.Drawing.Point(25, 69);
            this.num_bed.Name = "num_bed";
            this.num_bed.Size = new System.Drawing.Size(88, 17);
            this.num_bed.TabIndex = 8;
            this.num_bed.Text = "Số giường: 2";
            // 
            // room_level
            // 
            this.room_level.AutoSize = true;
            this.room_level.Location = new System.Drawing.Point(24, 45);
            this.room_level.Name = "room_level";
            this.room_level.Size = new System.Drawing.Size(115, 17);
            this.room_level.TabIndex = 7;
            this.room_level.Text = "Hạng phòng: VIP";
            // 
            // room_num
            // 
            this.room_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.room_num.Location = new System.Drawing.Point(11, 13);
            this.room_num.Name = "room_num";
            this.room_num.Size = new System.Drawing.Size(129, 32);
            this.room_num.TabIndex = 6;
            this.room_num.Text = "Phòng 105";
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.SystemColors.Control;
            this.modify_btn.Location = new System.Drawing.Point(163, 121);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(112, 25);
            this.modify_btn.TabIndex = 11;
            this.modify_btn.Text = "Chỉnh sửa";
            this.modify_btn.UseVisualStyleBackColor = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // RoomManagementCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.bed_type);
            this.Controls.Add(this.num_bed);
            this.Controls.Add(this.room_level);
            this.Controls.Add(this.room_num);
            this.Name = "RoomManagementCard";
            this.Size = new System.Drawing.Size(312, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label bed_type;
        private System.Windows.Forms.Label num_bed;
        private System.Windows.Forms.Label room_level;
        private System.Windows.Forms.Label room_num;
        private System.Windows.Forms.Button modify_btn;
    }
}
