namespace Bai7
{
    partial class Bai7
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai7));
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtMaSV = new TextBox();
            label3 = new Label();
            rdNam = new RadioButton();
            rdNữ = new RadioButton();
            listView1 = new ListView();
            HoTen = new ColumnHeader();
            MaSinhVien = new ColumnHeader();
            GioiTInh = new ColumnHeader();
            NgoaiNgu = new ColumnHeader();
            DanToc = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            chkAnh = new CheckBox();
            chkPhap = new CheckBox();
            chkHoa = new CheckBox();
            cboDanToc = new ComboBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 59);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 119);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã Sinh Viên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(285, 56);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(324, 27);
            txtHoTen.TabIndex = 2;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(285, 112);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(324, 27);
            txtMaSV.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 180);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "giới TÍnh";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(285, 180);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(62, 24);
            rdNam.TabIndex = 5;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNữ
            // 
            rdNữ.AutoSize = true;
            rdNữ.Location = new Point(483, 180);
            rdNữ.Name = "rdNữ";
            rdNữ.Size = new Size(50, 24);
            rdNữ.TabIndex = 6;
            rdNữ.TabStop = true;
            rdNữ.Text = "Nữ";
            rdNữ.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { HoTen, MaSinhVien, GioiTInh, NgoaiNgu, DanToc });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(130, 376);
            listView1.Name = "listView1";
            listView1.Size = new Size(500, 214);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // HoTen
            // 
            HoTen.Text = "Họ Tên";
            HoTen.Width = 100;
            // 
            // MaSinhVien
            // 
            MaSinhVien.Text = "Mã SInh Viên";
            MaSinhVien.TextAlign = HorizontalAlignment.Center;
            MaSinhVien.Width = 100;
            // 
            // GioiTInh
            // 
            GioiTInh.Text = "Giới Tính";
            GioiTInh.Width = 100;
            // 
            // NgoaiNgu
            // 
            NgoaiNgu.Text = "Ngoại Ngữ";
            NgoaiNgu.TextAlign = HorizontalAlignment.Center;
            NgoaiNgu.Width = 100;
            // 
            // DanToc
            // 
            DanToc.Text = "Dân Tộc";
            DanToc.TextAlign = HorizontalAlignment.Center;
            DanToc.Width = 100;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 250);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngoại Ngữ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 322);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Dân Tộc";
            // 
            // chkAnh
            // 
            chkAnh.AutoSize = true;
            chkAnh.Location = new Point(285, 250);
            chkAnh.Name = "chkAnh";
            chkAnh.Size = new Size(57, 24);
            chkAnh.TabIndex = 10;
            chkAnh.Text = "Anh";
            chkAnh.UseVisualStyleBackColor = true;
            // 
            // chkPhap
            // 
            chkPhap.AutoSize = true;
            chkPhap.Location = new Point(418, 250);
            chkPhap.Name = "chkPhap";
            chkPhap.Size = new Size(64, 24);
            chkPhap.TabIndex = 11;
            chkPhap.Text = "Pháp";
            chkPhap.UseVisualStyleBackColor = true;
            // 
            // chkHoa
            // 
            chkHoa.AutoSize = true;
            chkHoa.Location = new Point(571, 250);
            chkHoa.Name = "chkHoa";
            chkHoa.Size = new Size(59, 24);
            chkHoa.TabIndex = 12;
            chkHoa.Text = "Hoa";
            chkHoa.UseVisualStyleBackColor = true;
            // 
            // cboDanToc
            // 
            cboDanToc.FormattingEnabled = true;
            cboDanToc.Location = new Point(285, 314);
            cboDanToc.Name = "cboDanToc";
            cboDanToc.Size = new Size(324, 28);
            cboDanToc.TabIndex = 13;
            // 
            // btnThem
            // 
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.Location = new Point(130, 629);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(119, 58);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = true;
            // KHÔNG CÒN DÒNG GÁN SỰ KIỆN RÁC Ở ĐÂY NỮA
            // 
            // btnXoa
            // 
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.Location = new Point(316, 629);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 58);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.Location = new Point(494, 629);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 58);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = true;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 710);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(cboDanToc);
            Controls.Add(chkHoa);
            Controls.Add(chkPhap);
            Controls.Add(chkAnh);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listView1);
            Controls.Add(rdNữ);
            Controls.Add(rdNam);
            Controls.Add(label3);
            Controls.Add(txtMaSV);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai7";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtMaSV;
        private Label label3;
        private RadioButton rdNam;
        private RadioButton rdNữ;
        private ListView listView1;
        private ColumnHeader HoTen;
        private ColumnHeader MaSinhVien;
        private ColumnHeader GioiTInh;
        private ColumnHeader NgoaiNgu;
        private ColumnHeader DanToc;
        private Label label4;
        private Label label5;
        private CheckBox chkAnh;
        private CheckBox chkPhap;
        private CheckBox chkHoa;
        private ComboBox cboDanToc;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}