
namespace bt_gui1_21520835
{
    partial class Form1
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
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGpa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tên = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MãLớp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(134, 143);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(331, 22);
            this.txtMssv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(134, 183);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(331, 22);
            this.txtTen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(134, 228);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(331, 22);
            this.txtMalop.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "GPA";
            // 
            // txtGpa
            // 
            this.txtGpa.Location = new System.Drawing.Point(134, 271);
            this.txtGpa.Name = "txtGpa";
            this.txtGpa.Size = new System.Drawing.Size(331, 22);
            this.txtGpa.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 43);
            this.button2.TabIndex = 9;
            this.button2.Text = "Chỉnh sửa thông tin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(550, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sinh viên";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MSSV,
            this.Tên,
            this.MãLớp,
            this.GPA});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(431, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "MSSV";
            // 
            // Tên
            // 
            this.Tên.Text = "Tên";
            this.Tên.Width = 120;
            // 
            // MãLớp
            // 
            this.MãLớp.Text = "MãLớp";
            this.MãLớp.Width = 80;
            // 
            // GPA
            // 
            this.GPA.Text = "GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGpa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMssv);
            this.Name = "Form1";
            this.Text = "Quản lí sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGpa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader Tên;
        private System.Windows.Forms.ColumnHeader MãLớp;
        private System.Windows.Forms.ColumnHeader GPA;
    }
}

