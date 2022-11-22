namespace Bai11_P1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDonVi = new System.Windows.Forms.ComboBox();
            this.txtHsluong = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGetNhanVienByGT = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtHSLTo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "getNhanVien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(463, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bai11 Phiếu 1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(559, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(521, 233);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getNhanVien);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ho Ten :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngay Sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gioi Tinh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "He so luong (from) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ma don vi :";
            // 
            // cbxDonVi
            // 
            this.cbxDonVi.FormattingEnabled = true;
            this.cbxDonVi.Location = new System.Drawing.Point(531, 374);
            this.cbxDonVi.Name = "cbxDonVi";
            this.cbxDonVi.Size = new System.Drawing.Size(279, 28);
            this.cbxDonVi.TabIndex = 9;
            // 
            // txtHsluong
            // 
            this.txtHsluong.Location = new System.Drawing.Point(531, 325);
            this.txtHsluong.Name = "txtHsluong";
            this.txtHsluong.Size = new System.Drawing.Size(279, 27);
            this.txtHsluong.TabIndex = 10;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(531, 275);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(279, 27);
            this.txtGioiTinh.TabIndex = 11;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(531, 227);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(279, 27);
            this.txtNgaySinh.TabIndex = 12;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(531, 178);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(279, 27);
            this.txtHoTen.TabIndex = 13;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(531, 130);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(279, 27);
            this.txtMa.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "getNhanVienByMa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 29);
            this.button3.TabIndex = 16;
            this.button3.Text = "getDonVi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(839, 378);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 29);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(839, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 29);
            this.button4.TabIndex = 18;
            this.button4.Text = "getDonViByMa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(839, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 29);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(128, 130);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(279, 27);
            this.txtMaDV.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ma Don Vi :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ten Don Vi :";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Location = new System.Drawing.Point(128, 178);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(279, 27);
            this.txtTenDV.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(773, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nhan Vien";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(86, 484);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(344, 233);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getSingleDonVi);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(209, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 28);
            this.label11.TabIndex = 26;
            this.label11.Text = "Don Vi";
            // 
            // btnGetNhanVienByGT
            // 
            this.btnGetNhanVienByGT.Location = new System.Drawing.Point(-1, 282);
            this.btnGetNhanVienByGT.Name = "btnGetNhanVienByGT";
            this.btnGetNhanVienByGT.Size = new System.Drawing.Size(187, 29);
            this.btnGetNhanVienByGT.TabIndex = 27;
            this.btnGetNhanVienByGT.Text = "getNhanVienByGioiTinh";
            this.btnGetNhanVienByGT.UseVisualStyleBackColor = true;
            this.btnGetNhanVienByGT.Click += new System.EventHandler(this.btnGetNhanVienByGT_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-1, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(185, 29);
            this.button5.TabIndex = 28;
            this.button5.Text = "getNhanVienLuongFromTo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // txtHSLTo
            // 
            this.txtHSLTo.Location = new System.Drawing.Point(160, 229);
            this.txtHSLTo.Name = "txtHSLTo";
            this.txtHSLTo.Size = new System.Drawing.Size(247, 27);
            this.txtHSLTo.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 30;
            this.label12.Text = "He so luong (to) :";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(209, 282);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 29);
            this.button6.TabIndex = 31;
            this.button6.Text = "Them Nhan Vien";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(209, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 29);
            this.button7.TabIndex = 32;
            this.button7.Text = "Xoa Nhan Vien";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(212, 382);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 29);
            this.button8.TabIndex = 33;
            this.button8.Text = "Sua Nhan Vien";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 763);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtHSLTo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnGetNhanVienByGT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtGioiTinh);
            this.Controls.Add(this.txtHsluong);
            this.Controls.Add(this.cbxDonVi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.loadData);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbxDonVi;
        private TextBox txtHsluong;
        private TextBox txtGioiTinh;
        private TextBox txtNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMa;
        private Button button2;
        private Button button3;
        private Button btnClose;
        private Button button4;
        private Button btnClear;
        private TextBox txtMaDV;
        private Label label8;
        private Label label9;
        private TextBox txtTenDV;
        private Label label10;
        private DataGridView dataGridView2;
        private Label label11;
        private Button btnGetNhanVienByGT;
        private Button button5;
        private TextBox txtHSLTo;
        private Label label12;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}