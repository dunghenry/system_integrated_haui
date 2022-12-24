namespace TranVanDung_2019603537
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThemNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maNV = new System.Windows.Forms.TextBox();
            this.tenNV = new System.Windows.Forms.TextBox();
            this.HsLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.XoaNV = new System.Windows.Forms.Button();
            this.SuaNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemNV
            // 
            this.ThemNV.Location = new System.Drawing.Point(682, 123);
            this.ThemNV.Name = "ThemNV";
            this.ThemNV.Size = new System.Drawing.Size(94, 29);
            this.ThemNV.TabIndex = 0;
            this.ThemNV.Text = "ThêmNV";
            this.ThemNV.UseVisualStyleBackColor = true;
            this.ThemNV.Click += new System.EventHandler(this.ThemNV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(396, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "MaNV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TenNV:";
            // 
            // maNV
            // 
            this.maNV.Location = new System.Drawing.Point(435, 123);
            this.maNV.Name = "maNV";
            this.maNV.Size = new System.Drawing.Size(197, 27);
            this.maNV.TabIndex = 4;
            // 
            // tenNV
            // 
            this.tenNV.Location = new System.Drawing.Point(435, 177);
            this.tenNV.Name = "tenNV";
            this.tenNV.Size = new System.Drawing.Size(197, 27);
            this.tenNV.TabIndex = 5;
            // 
            // HsLuong
            // 
            this.HsLuong.Location = new System.Drawing.Point(435, 226);
            this.HsLuong.Name = "HsLuong";
            this.HsLuong.Size = new System.Drawing.Size(197, 27);
            this.HsLuong.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "HSLuong:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 364);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(508, 188);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(682, 225);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 29);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // XoaNV
            // 
            this.XoaNV.Location = new System.Drawing.Point(682, 180);
            this.XoaNV.Name = "XoaNV";
            this.XoaNV.Size = new System.Drawing.Size(94, 29);
            this.XoaNV.TabIndex = 10;
            this.XoaNV.Text = "XoáNV";
            this.XoaNV.UseVisualStyleBackColor = true;
            this.XoaNV.Click += new System.EventHandler(this.XoaNV_Click);
            // 
            // SuaNV
            // 
            this.SuaNV.Location = new System.Drawing.Point(824, 123);
            this.SuaNV.Name = "SuaNV";
            this.SuaNV.Size = new System.Drawing.Size(94, 29);
            this.SuaNV.TabIndex = 11;
            this.SuaNV.Text = "Sửa";
            this.SuaNV.UseVisualStyleBackColor = true;
            this.SuaNV.Click += new System.EventHandler(this.SuaNV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 635);
            this.Controls.Add(this.SuaNV);
            this.Controls.Add(this.XoaNV);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HsLuong);
            this.Controls.Add(this.tenNV);
            this.Controls.Add(this.maNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemNV);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoadData);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ThemNV;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox maNV;
        private TextBox tenNV;
        private TextBox HsLuong;
        private Label label4;
        private DataGridView dataGridView1;
        private Button Exit;
        private Button XoaNV;
        private Button SuaNV;
    }
}