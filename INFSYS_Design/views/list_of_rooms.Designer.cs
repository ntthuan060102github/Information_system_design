﻿
namespace INFSYS_Design.views
{
    partial class GUI_ListOfRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ListOfRooms));
            this.back_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.room_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_bed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bed_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_view_detail = new System.Windows.Forms.Button();
            this.add_room_btn = new System.Windows.Forms.Button();
            this.btn_delete_room = new System.Windows.Forms.Button();
            this.btn_checkin = new System.Windows.Forms.Button();
            this.btn_checkout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.SystemColors.Control;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.back_btn, "back_btn");
            this.back_btn.Name = "back_btn";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_num,
            this.room_status,
            this.room_level,
            this.num_bed,
            this.bed_type,
            this.price});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // room_num
            // 
            resources.ApplyResources(this.room_num, "room_num");
            this.room_num.Name = "room_num";
            this.room_num.ReadOnly = true;
            // 
            // room_status
            // 
            resources.ApplyResources(this.room_status, "room_status");
            this.room_status.Name = "room_status";
            this.room_status.ReadOnly = true;
            // 
            // room_level
            // 
            resources.ApplyResources(this.room_level, "room_level");
            this.room_level.Name = "room_level";
            this.room_level.ReadOnly = true;
            // 
            // num_bed
            // 
            resources.ApplyResources(this.num_bed, "num_bed");
            this.num_bed.Name = "num_bed";
            this.num_bed.ReadOnly = true;
            // 
            // bed_type
            // 
            resources.ApplyResources(this.bed_type, "bed_type");
            this.bed_type.Name = "bed_type";
            this.bed_type.ReadOnly = true;
            // 
            // price
            // 
            resources.ApplyResources(this.price, "price");
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // btn_view_detail
            // 
            this.btn_view_detail.BackColor = System.Drawing.SystemColors.Control;
            this.btn_view_detail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_detail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_view_detail, "btn_view_detail");
            this.btn_view_detail.Name = "btn_view_detail";
            this.btn_view_detail.UseVisualStyleBackColor = false;
            this.btn_view_detail.Click += new System.EventHandler(this.btn_view_detail_Click);
            // 
            // add_room_btn
            // 
            this.add_room_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_room_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_room_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.add_room_btn, "add_room_btn");
            this.add_room_btn.Name = "add_room_btn";
            this.add_room_btn.UseVisualStyleBackColor = false;
            this.add_room_btn.Click += new System.EventHandler(this.add_room_btn_Click);
            // 
            // btn_delete_room
            // 
            this.btn_delete_room.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delete_room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_room.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_delete_room, "btn_delete_room");
            this.btn_delete_room.Name = "btn_delete_room";
            this.btn_delete_room.UseVisualStyleBackColor = false;
            this.btn_delete_room.Click += new System.EventHandler(this.btn_delete_room_Click);
            // 
            // btn_checkin
            // 
            this.btn_checkin.BackColor = System.Drawing.SystemColors.Control;
            this.btn_checkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_checkin, "btn_checkin");
            this.btn_checkin.Name = "btn_checkin";
            this.btn_checkin.UseVisualStyleBackColor = false;
            this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.SystemColors.Control;
            this.btn_checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checkout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btn_checkout, "btn_checkout");
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.UseVisualStyleBackColor = false;
            // 
            // GUI_ListOfRooms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.btn_checkin);
            this.Controls.Add(this.btn_delete_room);
            this.Controls.Add(this.add_room_btn);
            this.Controls.Add(this.btn_view_detail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back_btn);
            this.Name = "GUI_ListOfRooms";
            this.Load += new System.EventHandler(this.list_of_rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_level;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_bed;
        private System.Windows.Forms.DataGridViewTextBoxColumn bed_type;
        private System.Windows.Forms.Button btn_view_detail;
        private System.Windows.Forms.Button add_room_btn;
        private System.Windows.Forms.Button btn_delete_room;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button btn_checkin;
        private System.Windows.Forms.Button btn_checkout;
    }
}