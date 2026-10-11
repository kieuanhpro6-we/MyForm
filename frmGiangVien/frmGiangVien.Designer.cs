namespace frmGiangVien
{
    partial class frmGiangVien
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cboMaSo = new System.Windows.Forms.ComboBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rdNu = new System.Windows.Forms.RadioButton();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
			this.lbDanhSachHP = new System.Windows.Forms.ListBox();
			this.lbHocPhanDay = new System.Windows.Forms.ListBox();
			this.btnChon = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThongBao = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.linklblLienHe = new System.Windows.Forms.LinkLabel();
			this.btnTim = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Magenta;
			this.label1.Location = new System.Drawing.Point(-5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(793, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mã Số";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 121);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(59, 19);
			this.label8.TabIndex = 7;
			this.label8.Text = "Họ Tên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Ngày Sinh";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "Ngoại Ngữ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(411, 155);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 19);
			this.label6.TabIndex = 12;
			this.label6.Text = "Địa chỉ mail";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(411, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 19);
			this.label7.TabIndex = 11;
			this.label7.Text = "Số ĐT";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(411, 86);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 19);
			this.label9.TabIndex = 10;
			this.label9.Text = "Giới Tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(96, 293);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 19);
			this.label5.TabIndex = 13;
			this.label5.Text = "Danh sách môn học";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(685, 496);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(63, 19);
			this.label11.TabIndex = 15;
			this.label11.Text = "Website";
			// 
			// cboMaSo
			// 
			this.cboMaSo.Cursor = System.Windows.Forms.Cursors.Default;
			this.cboMaSo.FormattingEnabled = true;
			this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
			this.cboMaSo.Location = new System.Drawing.Point(100, 85);
			this.cboMaSo.Name = "cboMaSo";
			this.cboMaSo.Size = new System.Drawing.Size(121, 24);
			this.cboMaSo.TabIndex = 16;
			this.cboMaSo.SelectedIndexChanged += new System.EventHandler(this.cboMaSo_SelectedIndexChanged);
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNam.Location = new System.Drawing.Point(522, 86);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(58, 21);
			this.rdNam.TabIndex = 17;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rdNu
			// 
			this.rdNu.AutoSize = true;
			this.rdNu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdNu.Location = new System.Drawing.Point(604, 86);
			this.rdNu.Name = "rdNu";
			this.rdNu.Size = new System.Drawing.Size(48, 21);
			this.rdNu.TabIndex = 18;
			this.rdNu.Text = "Nữ";
			this.rdNu.UseVisualStyleBackColor = true;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(100, 121);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(259, 22);
			this.txtHoTen.TabIndex = 19;
			// 
			// mtxtSoDT
			// 
			this.mtxtSoDT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mtxtSoDT.Location = new System.Drawing.Point(522, 120);
			this.mtxtSoDT.Mask = "(\\0633).000.000";
			this.mtxtSoDT.Name = "mtxtSoDT";
			this.mtxtSoDT.Size = new System.Drawing.Size(195, 25);
			this.mtxtSoDT.TabIndex = 20;
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
			this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(100, 155);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(132, 25);
			this.dtpNgaySinh.TabIndex = 21;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(522, 154);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(234, 22);
			this.txtMail.TabIndex = 22;
			// 
			// chklbNgoaiNgu
			// 
			this.chklbNgoaiNgu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chklbNgoaiNgu.FormattingEnabled = true;
			this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
			this.chklbNgoaiNgu.Location = new System.Drawing.Point(100, 192);
			this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
			this.chklbNgoaiNgu.Size = new System.Drawing.Size(187, 84);
			this.chklbNgoaiNgu.TabIndex = 23;
			// 
			// lbDanhSachHP
			// 
			this.lbDanhSachHP.FormattingEnabled = true;
			this.lbDanhSachHP.ItemHeight = 16;
			this.lbDanhSachHP.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
			this.lbDanhSachHP.Location = new System.Drawing.Point(100, 316);
			this.lbDanhSachHP.Name = "lbDanhSachHP";
			this.lbDanhSachHP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDanhSachHP.Size = new System.Drawing.Size(259, 148);
			this.lbDanhSachHP.TabIndex = 24;
			// 
			// lbHocPhanDay
			// 
			this.lbHocPhanDay.FormattingEnabled = true;
			this.lbHocPhanDay.ItemHeight = 16;
			this.lbHocPhanDay.Location = new System.Drawing.Point(458, 316);
			this.lbHocPhanDay.Name = "lbHocPhanDay";
			this.lbHocPhanDay.Size = new System.Drawing.Size(259, 148);
			this.lbHocPhanDay.TabIndex = 25;
			// 
			// btnChon
			// 
			this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChon.Location = new System.Drawing.Point(377, 356);
			this.btnChon.Name = "btnChon";
			this.btnChon.Size = new System.Drawing.Size(60, 35);
			this.btnChon.TabIndex = 26;
			this.btnChon.Text = ">>";
			this.btnChon.UseVisualStyleBackColor = true;
			this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(377, 397);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(60, 35);
			this.btnXoa.TabIndex = 27;
			this.btnXoa.Text = "<<";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThongBao
			// 
			this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThongBao.ForeColor = System.Drawing.Color.Blue;
			this.btnThongBao.Location = new System.Drawing.Point(136, 477);
			this.btnThongBao.Name = "btnThongBao";
			this.btnThongBao.Size = new System.Drawing.Size(135, 35);
			this.btnThongBao.TabIndex = 30;
			this.btnThongBao.Text = "Thông báo";
			this.btnThongBao.UseVisualStyleBackColor = true;
			this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(454, 293);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(160, 19);
			this.label10.TabIndex = 14;
			this.label10.Text = "Môn học giáo viên dạy";
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.Color.Blue;
			this.btnExit.Location = new System.Drawing.Point(587, 477);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(85, 35);
			this.btnExit.TabIndex = 31;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.Blue;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.Location = new System.Drawing.Point(431, 476);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(127, 35);
			this.btnCancel.TabIndex = 32;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// linklblLienHe
			// 
			this.linklblLienHe.AutoSize = true;
			this.linklblLienHe.Location = new System.Drawing.Point(754, 496);
			this.linklblLienHe.Name = "linklblLienHe";
			this.linklblLienHe.Size = new System.Drawing.Size(50, 16);
			this.linklblLienHe.TabIndex = 33;
			this.linklblLienHe.TabStop = true;
			this.linklblLienHe.Text = "Liên hệ";
			this.linklblLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLienHe_LinkClicked);
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.ForeColor = System.Drawing.Color.Blue;
			this.btnTim.Location = new System.Drawing.Point(20, 477);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(93, 35);
			this.btnTim.TabIndex = 34;
			this.btnTim.Text = "Tìm GV";
			this.btnTim.UseVisualStyleBackColor = true;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.Blue;
			this.btnThem.Location = new System.Drawing.Point(291, 477);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(124, 35);
			this.btnThem.TabIndex = 35;
			this.btnThem.Text = "Thêm GV";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// frmGiangVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 524);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.linklblLienHe);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnThongBao);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnChon);
			this.Controls.Add(this.lbHocPhanDay);
			this.Controls.Add(this.lbDanhSachHP);
			this.Controls.Add(this.chklbNgoaiNgu);
			this.Controls.Add(this.txtMail);
			this.Controls.Add(this.dtpNgaySinh);
			this.Controls.Add(this.mtxtSoDT);
			this.Controls.Add(this.txtHoTen);
			this.Controls.Add(this.rdNu);
			this.Controls.Add(this.rdNam);
			this.Controls.Add(this.cboMaSo);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmGiangVien";
			this.Text = "Giảng viên";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel linklblLienHe;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.Button btnThem;
	}
}

