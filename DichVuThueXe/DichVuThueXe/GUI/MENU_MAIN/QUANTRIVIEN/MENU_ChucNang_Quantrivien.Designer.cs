
namespace DichVuThueXe.GUI
{
    partial class MENU_ChucNang_Quantrivien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENU_ChucNang_Quantrivien));
            this.xEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.xETableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.XETableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnRefreshNV = new System.Windows.Forms.Button();
            this.tbNV = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbXe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnChuaDiChuyen = new System.Windows.Forms.RadioButton();
            this.rbtnDiChuyen = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtTenXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.NHANVIENTableAdapter();
            this.toolTipTimKiemNV = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNV)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xEBindingSource
            // 
            this.xEBindingSource.DataMember = "XE";
            this.xEBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xETableAdapter
            // 
            this.xETableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::DichVuThueXe.Properties.Resources.bg;
            this.tabPage2.Controls.Add(this.btnDoiMK);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.tbNV);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.ForeColor = System.Drawing.Color.Blue;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1018, 390);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Quản Trị Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(188, 351);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(2);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(89, 31);
            this.btnDoiMK.TabIndex = 4;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.btnSuaNV);
            this.groupBox4.Controls.Add(this.btnXoaNV);
            this.groupBox4.Controls.Add(this.btnRefreshNV);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(4, 254);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(278, 93);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Location = new System.Drawing.Point(4, 50);
            this.btnSuaNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(90, 26);
            this.btnSuaNV.TabIndex = 0;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = true;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(183, 50);
            this.btnXoaNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(90, 26);
            this.btnXoaNV.TabIndex = 0;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnRefreshNV
            // 
            this.btnRefreshNV.Location = new System.Drawing.Point(4, 20);
            this.btnRefreshNV.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshNV.Name = "btnRefreshNV";
            this.btnRefreshNV.Size = new System.Drawing.Size(268, 25);
            this.btnRefreshNV.TabIndex = 0;
            this.btnRefreshNV.Text = "Làm mới";
            this.btnRefreshNV.UseVisualStyleBackColor = true;
            this.btnRefreshNV.Click += new System.EventHandler(this.btnRefreshNV_Click);
            // 
            // tbNV
            // 
            this.tbNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbNV.Location = new System.Drawing.Point(286, 11);
            this.tbNV.Margin = new System.Windows.Forms.Padding(2);
            this.tbNV.Name = "tbNV";
            this.tbNV.RowHeadersWidth = 51;
            this.tbNV.RowTemplate.Height = 24;
            this.tbNV.Size = new System.Drawing.Size(729, 371);
            this.tbNV.TabIndex = 0;
            this.tbNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbNV_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.dtpNgaySinh);
            this.groupBox5.Controls.Add(this.txtTimKiemNV);
            this.groupBox5.Controls.Add(this.txtSDT);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtDiaChi);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtGioiTinh);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtCMND);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtTenNV);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtMaNV);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.ForeColor = System.Drawing.Color.Blue;
            this.groupBox5.Location = new System.Drawing.Point(4, 5);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(278, 244);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin nhập liệu";
            // 
            // label12
            // 
            this.label12.AccessibleName = "";
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 9);
            this.label12.TabIndex = 0;
            this.label12.Text = "(i): Keyboard layout ở định dạng ENG để có hiệu xuất cao nhất";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(85, 161);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(182, 20);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(4, 25);
            this.txtTimKiemNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(263, 20);
            this.txtTimKiemNV.TabIndex = 2;
            this.txtTimKiemNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiemNV_MouseClick);
            this.txtTimKiemNV.Enter += new System.EventHandler(this.txtTimKiemNV_Enter);
            this.txtTimKiemNV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiemNV_KeyUp);
            this.txtTimKiemNV.Leave += new System.EventHandler(this.txtTimKiemNV_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.AccessibleName = "";
            this.txtSDT.Location = new System.Drawing.Point(85, 206);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.MaxLength = 10;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(182, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 209);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AccessibleName = "";
            this.txtDiaChi.Location = new System.Drawing.Point(85, 184);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(182, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AccessibleName = "";
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 186);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Địa chỉ:";
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 163);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày sinh:";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AccessibleName = "";
            this.txtGioiTinh.Location = new System.Drawing.Point(85, 138);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioiTinh.MaxLength = 10;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(182, 20);
            this.txtGioiTinh.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Giới tính:";
            // 
            // txtCMND
            // 
            this.txtCMND.AccessibleName = "";
            this.txtCMND.Location = new System.Drawing.Point(85, 115);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(2);
            this.txtCMND.MaxLength = 12;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(182, 20);
            this.txtCMND.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CMND / CCCD:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.AccessibleName = "";
            this.txtTenNV.Location = new System.Drawing.Point(85, 93);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.MaxLength = 50;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(182, 20);
            this.txtTenNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.AccessibleName = "";
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(85, 70);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(182, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AccessibleName = "";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã nhân viên:";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::DichVuThueXe.Properties.Resources.bg;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.tbXe);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Blue;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1018, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Trị Xe";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Location = new System.Drawing.Point(4, 238);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(278, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 58);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(71, 28);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(4, 58);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(71, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(202, 58);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(71, 28);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 28);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(268, 25);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbXe
            // 
            this.tbXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbXe.Location = new System.Drawing.Point(286, 11);
            this.tbXe.Margin = new System.Windows.Forms.Padding(2);
            this.tbXe.Name = "tbXe";
            this.tbXe.RowHeadersWidth = 51;
            this.tbXe.RowTemplate.Height = 24;
            this.tbXe.Size = new System.Drawing.Size(729, 336);
            this.tbXe.TabIndex = 0;
            this.tbXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbXe_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBienSo);
            this.groupBox1.Controls.Add(this.txtMaXe);
            this.groupBox1.Controls.Add(this.txtTenXe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(278, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập liệu";
            // 
            // label13
            // 
            this.label13.AccessibleName = "";
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 46);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 9);
            this.label13.TabIndex = 5;
            this.label13.Text = "(i): Keyboard layout ở định dạng ENG để có hiệu xuất cao nhất";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnChuaDiChuyen);
            this.groupBox2.Controls.Add(this.rbtnDiChuyen);
            this.groupBox2.Location = new System.Drawing.Point(7, 161);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(260, 46);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trạng thái";
            // 
            // rbtnChuaDiChuyen
            // 
            this.rbtnChuaDiChuyen.AutoSize = true;
            this.rbtnChuaDiChuyen.Location = new System.Drawing.Point(141, 19);
            this.rbtnChuaDiChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnChuaDiChuyen.Name = "rbtnChuaDiChuyen";
            this.rbtnChuaDiChuyen.Size = new System.Drawing.Size(120, 17);
            this.rbtnChuaDiChuyen.TabIndex = 1;
            this.rbtnChuaDiChuyen.TabStop = true;
            this.rbtnChuaDiChuyen.Text = "Không có hợp đồng";
            this.rbtnChuaDiChuyen.UseVisualStyleBackColor = true;
            // 
            // rbtnDiChuyen
            // 
            this.rbtnDiChuyen.AutoSize = true;
            this.rbtnDiChuyen.Location = new System.Drawing.Point(40, 19);
            this.rbtnDiChuyen.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDiChuyen.Name = "rbtnDiChuyen";
            this.rbtnDiChuyen.Size = new System.Drawing.Size(87, 17);
            this.rbtnDiChuyen.TabIndex = 0;
            this.rbtnDiChuyen.TabStop = true;
            this.rbtnDiChuyen.Text = "Có hợp đồng";
            this.rbtnDiChuyen.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(4, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(263, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            this.txtTimKiem.Leave += new System.EventHandler(this.txtTimKiem_Leave);
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(47, 138);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(220, 20);
            this.txtMaLoai.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mã loại:";
            // 
            // txtBienSo
            // 
            this.txtBienSo.Location = new System.Drawing.Point(47, 115);
            this.txtBienSo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBienSo.MaxLength = 25;
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(220, 20);
            this.txtBienSo.TabIndex = 2;
            // 
            // txtMaXe
            // 
            this.txtMaXe.AccessibleName = "";
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Location = new System.Drawing.Point(47, 70);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(220, 20);
            this.txtMaXe.TabIndex = 2;
            // 
            // txtTenXe
            // 
            this.txtTenXe.Location = new System.Drawing.Point(47, 93);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenXe.MaxLength = 50;
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(220, 20);
            this.txtTenXe.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Biển số:";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên xe:";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã xe:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // toolTipTimKiemNV
            // 
            this.toolTipTimKiemNV.IsBalloon = true;
            this.toolTipTimKiemNV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTimKiemNV.ToolTipTitle = "Gợi ý";
            // 
            // MENU_ChucNang_Quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DichVuThueXe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1044, 434);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MENU_ChucNang_Quantrivien";
            this.Text = "Chức Năng Quản Trị Viên";
            this.Load += new System.EventHandler(this.MENU_ChucNang_Quantrivien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNV)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource xEBindingSource;
        private HTTX_DataSetTableAdapters.XETableAdapter xETableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxHeader;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnRefreshNV;
        private System.Windows.Forms.DataGridView tbNV;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView tbXe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnChuaDiChuyen;
        private System.Windows.Forms.RadioButton rbtnDiChuyen;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtTenXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private HTTX_DataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.ToolTip toolTipTimKiemNV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}