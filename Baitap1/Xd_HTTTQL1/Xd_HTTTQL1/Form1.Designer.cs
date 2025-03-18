namespace Xd_HTTTQL1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            NgayLapHoaDonDate = new DateTimePicker();
            DiaChiBox = new TextBox();
            DienThoaiBox = new TextBox();
            KhachHangBox = new TextBox();
            NhanVienBox = new TextBox();
            SoHoaDonBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            SuaBtn = new Button();
            XoaBtn = new Button();
            ThemBtn = new Button();
            SoLuongBox = new TextBox();
            DonGiaBox = new TextBox();
            SanPhamBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            DonHangTable = new DataGridView();
            label11 = new Label();
            InHoaDonBtn = new Button();
            LamLaiBtn = new Button();
            TriGiaHoaDonBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DonHangTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 46);
            label1.TabIndex = 0;
            label1.Text = "NHẬP THÔNG TIN HÓA ĐƠN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(NgayLapHoaDonDate);
            groupBox1.Controls.Add(DiaChiBox);
            groupBox1.Controls.Add(DienThoaiBox);
            groupBox1.Controls.Add(KhachHangBox);
            groupBox1.Controls.Add(NhanVienBox);
            groupBox1.Controls.Add(SoHoaDonBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "thông tin hóa đơn";
            // 
            // NgayLapHoaDonDate
            // 
            NgayLapHoaDonDate.Format = DateTimePickerFormat.Short;
            NgayLapHoaDonDate.Location = new Point(170, 94);
            NgayLapHoaDonDate.Name = "NgayLapHoaDonDate";
            NgayLapHoaDonDate.Size = new Size(124, 30);
            NgayLapHoaDonDate.TabIndex = 12;
            NgayLapHoaDonDate.ValueChanged += NgayLapHoaDonDate_ValueChanged;
            // 
            // DiaChiBox
            // 
            DiaChiBox.Location = new Point(531, 139);
            DiaChiBox.Name = "DiaChiBox";
            DiaChiBox.Size = new Size(220, 30);
            DiaChiBox.TabIndex = 11;
            DiaChiBox.TextChanged += DiaChiBox_TextChanged;
            // 
            // DienThoaiBox
            // 
            DienThoaiBox.Location = new Point(559, 90);
            DienThoaiBox.Name = "DienThoaiBox";
            DienThoaiBox.Size = new Size(175, 30);
            DienThoaiBox.TabIndex = 10;
            DienThoaiBox.TextChanged += DienThoaiBox_TextChanged;
            // 
            // KhachHangBox
            // 
            KhachHangBox.Location = new Point(472, 38);
            KhachHangBox.Name = "KhachHangBox";
            KhachHangBox.Size = new Size(232, 30);
            KhachHangBox.TabIndex = 9;
            KhachHangBox.TextChanged += KhachHangBox_TextChanged;
            // 
            // NhanVienBox
            // 
            NhanVienBox.Location = new Point(182, 142);
            NhanVienBox.Name = "NhanVienBox";
            NhanVienBox.Size = new Size(127, 30);
            NhanVienBox.TabIndex = 8;
            NhanVienBox.TextChanged += NhanVienBox_TextChanged;
            // 
            // SoHoaDonBox
            // 
            SoHoaDonBox.Location = new Point(126, 42);
            SoHoaDonBox.Name = "SoHoaDonBox";
            SoHoaDonBox.Size = new Size(183, 30);
            SoHoaDonBox.TabIndex = 6;
            SoHoaDonBox.TextChanged += SoHoaDonBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(363, 146);
            label7.Name = "label7";
            label7.Size = new Size(162, 23);
            label7.TabIndex = 5;
            label7.Text = "Địa chỉ khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(363, 97);
            label6.Name = "label6";
            label6.Size = new Size(190, 23);
            label6.TabIndex = 4;
            label6.Text = "Điện thoại khách hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(363, 45);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 3;
            label5.Text = "Khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 149);
            label4.Name = "label4";
            label4.Size = new Size(170, 23);
            label4.TabIndex = 2;
            label4.Text = "Nhân viên bán hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 101);
            label3.Name = "label3";
            label3.Size = new Size(158, 23);
            label3.TabIndex = 1;
            label3.Text = "Ngày lập hóa đơn ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 49);
            label2.Name = "label2";
            label2.Size = new Size(101, 23);
            label2.TabIndex = 0;
            label2.Text = "Số hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SuaBtn);
            groupBox2.Controls.Add(XoaBtn);
            groupBox2.Controls.Add(ThemBtn);
            groupBox2.Controls.Add(SoLuongBox);
            groupBox2.Controls.Add(DonGiaBox);
            groupBox2.Controls.Add(SanPhamBox);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 258);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 265);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // SuaBtn
            // 
            SuaBtn.Location = new Point(259, 202);
            SuaBtn.Name = "SuaBtn";
            SuaBtn.Size = new Size(94, 29);
            SuaBtn.TabIndex = 8;
            SuaBtn.Text = "Sửa";
            SuaBtn.UseVisualStyleBackColor = true;
            SuaBtn.Click += SuaBtn_Click;
            // 
            // XoaBtn
            // 
            XoaBtn.Location = new Point(148, 202);
            XoaBtn.Name = "XoaBtn";
            XoaBtn.Size = new Size(94, 29);
            XoaBtn.TabIndex = 7;
            XoaBtn.Text = "Xóa";
            XoaBtn.UseVisualStyleBackColor = true;
            XoaBtn.Click += XoaBtn_Click;
            // 
            // ThemBtn
            // 
            ThemBtn.Location = new Point(38, 202);
            ThemBtn.Name = "ThemBtn";
            ThemBtn.Size = new Size(94, 29);
            ThemBtn.TabIndex = 6;
            ThemBtn.Text = "Thêm";
            ThemBtn.UseVisualStyleBackColor = true;
            ThemBtn.Click += ThemBtn_Click;
            // 
            // SoLuongBox
            // 
            SoLuongBox.Location = new Point(126, 132);
            SoLuongBox.Name = "SoLuongBox";
            SoLuongBox.Size = new Size(199, 30);
            SoLuongBox.TabIndex = 5;
            SoLuongBox.TextChanged += SoLuongBox_TextChanged;
            // 
            // DonGiaBox
            // 
            DonGiaBox.Location = new Point(126, 83);
            DonGiaBox.Name = "DonGiaBox";
            DonGiaBox.Size = new Size(199, 30);
            DonGiaBox.TabIndex = 4;
            DonGiaBox.TextChanged += DonGiaBox_TextChanged;
            // 
            // SanPhamBox
            // 
            SanPhamBox.Location = new Point(126, 40);
            SanPhamBox.Name = "SanPhamBox";
            SanPhamBox.Size = new Size(199, 30);
            SanPhamBox.TabIndex = 3;
            SanPhamBox.TextChanged += SanPhamBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 139);
            label10.Name = "label10";
            label10.Size = new Size(80, 23);
            label10.TabIndex = 2;
            label10.Text = "số lượng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 90);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 1;
            label9.Text = "đơn giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(38, 47);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 0;
            label8.Text = "sản phẩm";
            // 
            // DonHangTable
            // 
            DonHangTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DonHangTable.Location = new Point(422, 258);
            DonHangTable.Name = "DonHangTable";
            DonHangTable.RowHeadersWidth = 51;
            DonHangTable.Size = new Size(366, 187);
            DonHangTable.TabIndex = 3;
            DonHangTable.CellContentClick += DonHangTable_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(504, 463);
            label11.Name = "label11";
            label11.Size = new Size(117, 20);
            label11.TabIndex = 4;
            label11.Text = "Trị giá hóa đơn:";
            // 
            // InHoaDonBtn
            // 
            InHoaDonBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InHoaDonBtn.ForeColor = Color.IndianRed;
            InHoaDonBtn.Location = new Point(471, 494);
            InHoaDonBtn.Name = "InHoaDonBtn";
            InHoaDonBtn.Size = new Size(94, 29);
            InHoaDonBtn.TabIndex = 5;
            InHoaDonBtn.Text = "In hóa đơn";
            InHoaDonBtn.UseVisualStyleBackColor = true;
            InHoaDonBtn.Click += InHoaDonBtn_Click;
            // 
            // LamLaiBtn
            // 
            LamLaiBtn.Location = new Point(591, 494);
            LamLaiBtn.Name = "LamLaiBtn";
            LamLaiBtn.Size = new Size(94, 29);
            LamLaiBtn.TabIndex = 6;
            LamLaiBtn.Text = "làm lại";
            LamLaiBtn.UseVisualStyleBackColor = true;
            LamLaiBtn.Click += LamLaiBtn_Click;
            // 
            // TriGiaHoaDonBox
            // 
            TriGiaHoaDonBox.Location = new Point(621, 456);
            TriGiaHoaDonBox.Name = "TriGiaHoaDonBox";
            TriGiaHoaDonBox.ReadOnly = true;
            TriGiaHoaDonBox.Size = new Size(167, 27);
            TriGiaHoaDonBox.TabIndex = 7;
            TriGiaHoaDonBox.TextChanged += TriGiaHoaDonBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(TriGiaHoaDonBox);
            Controls.Add(LamLaiBtn);
            Controls.Add(InHoaDonBtn);
            Controls.Add(label11);
            Controls.Add(DonHangTable);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DonHangTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker NgayLapHoaDonDate;
        private TextBox DiaChiBox;
        private TextBox DienThoaiBox;
        private TextBox KhachHangBox;
        private TextBox NhanVienBox;
        private TextBox SoHoaDonBox;
        private GroupBox groupBox2;
        private Button SuaBtn;
        private Button XoaBtn;
        private Button ThemBtn;
        private TextBox SoLuongBox;
        private TextBox DonGiaBox;
        private TextBox SanPhamBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView DonHangTable;
        private Label label11;
        private Button InHoaDonBtn;
        private Button LamLaiBtn;
        private TextBox TriGiaHoaDonBox;
    }
}
