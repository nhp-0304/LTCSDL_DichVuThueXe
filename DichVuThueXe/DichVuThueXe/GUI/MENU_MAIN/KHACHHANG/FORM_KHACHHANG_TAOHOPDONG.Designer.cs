
namespace DichVuThueXe.GUI
{
    partial class FORM_KHACHHANG_TAOHOPDONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_KHACHHANG_TAOHOPDONG));
            this.gridV_Xe = new System.Windows.Forms.DataGridView();
            this.btnTaoHopDong = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_LOAIDV = new System.Windows.Forms.ComboBox();
            this.lOAIDVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hTTX_DataSet = new DichVuThueXe.HTTX_DataSet();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtIDCar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOAIDVTableAdapter = new DichVuThueXe.HTTX_DataSetTableAdapters.LOAIDVTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridV_Xe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridV_Xe
            // 
            this.gridV_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridV_Xe.Location = new System.Drawing.Point(21, 35);
            this.gridV_Xe.Margin = new System.Windows.Forms.Padding(2);
            this.gridV_Xe.Name = "gridV_Xe";
            this.gridV_Xe.RowHeadersWidth = 51;
            this.gridV_Xe.RowTemplate.Height = 24;
            this.gridV_Xe.Size = new System.Drawing.Size(688, 184);
            this.gridV_Xe.TabIndex = 0;
            this.gridV_Xe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridV_Xe_CellClick);
            // 
            // btnTaoHopDong
            // 
            this.btnTaoHopDong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTaoHopDong.BackgroundImage")));
            this.btnTaoHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHopDong.Location = new System.Drawing.Point(591, 350);
            this.btnTaoHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaoHopDong.Name = "btnTaoHopDong";
            this.btnTaoHopDong.Size = new System.Drawing.Size(113, 54);
            this.btnTaoHopDong.TabIndex = 12;
            this.btnTaoHopDong.Text = "Tạo hợp đồng";
            this.btnTaoHopDong.UseVisualStyleBackColor = true;
            this.btnTaoHopDong.Click += new System.EventHandler(this.btnTaoHopDong_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(738, 350);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 54);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(500, 111);
            this.dtpNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(242, 23);
            this.dtpNgayKetThuc.TabIndex = 15;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(500, 69);
            this.dtpNgayBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(242, 23);
            this.dtpNgayBatDau.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(388, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày kết thúc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(388, 71);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày bắt đầu:";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(130, 111);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(210, 23);
            this.txtServiceID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(18, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn loại DV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.gridV_Xe);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(124, 417);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(760, 237);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xe có thể thuê:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.cbb_LOAIDV);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.dtpNgayKetThuc);
            this.groupBox1.Controls.Add(this.dtpNgayBatDau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtCarName);
            this.groupBox1.Controls.Add(this.txtIDCar);
            this.groupBox1.Controls.Add(this.txtServiceID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(124, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(760, 259);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // cbb_LOAIDV
            // 
            this.cbb_LOAIDV.DataSource = this.lOAIDVBindingSource;
            this.cbb_LOAIDV.DisplayMember = "Tenloai";
            this.cbb_LOAIDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LOAIDV.FormattingEnabled = true;
            this.cbb_LOAIDV.Location = new System.Drawing.Point(130, 67);
            this.cbb_LOAIDV.Name = "cbb_LOAIDV";
            this.cbb_LOAIDV.Size = new System.Drawing.Size(210, 25);
            this.cbb_LOAIDV.TabIndex = 17;
            this.cbb_LOAIDV.ValueMember = "MaL";
            this.cbb_LOAIDV.SelectedIndexChanged += new System.EventHandler(this.cbb_LOAIDV_SelectedIndexChanged);
            // 
            // lOAIDVBindingSource
            // 
            this.lOAIDVBindingSource.DataMember = "LOAIDV";
            this.lOAIDVBindingSource.DataSource = this.hTTX_DataSet;
            // 
            // hTTX_DataSet
            // 
            this.hTTX_DataSet.DataSetName = "HTTX_DataSet";
            this.hTTX_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(130, 31);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(210, 23);
            this.txtTenKH.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 146);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(210, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(130, 214);
            this.txtCarName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.ReadOnly = true;
            this.txtCarName.Size = new System.Drawing.Size(210, 23);
            this.txtCarName.TabIndex = 5;
            // 
            // txtIDCar
            // 
            this.txtIDCar.Location = new System.Drawing.Point(130, 181);
            this.txtIDCar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDCar.Name = "txtIDCar";
            this.txtIDCar.ReadOnly = true;
            this.txtIDCar.Size = new System.Drawing.Size(210, 23);
            this.txtIDCar.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(18, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tên xe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(18, 187);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mã xe:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(18, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(331, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHI TIẾT HỢP ĐỒNG";
            // 
            // lOAIDVTableAdapter
            // 
            this.lOAIDVTableAdapter.ClearBeforeFill = true;
            // 
            // FORM_KHACHHANG_TAOHOPDONG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DichVuThueXe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(982, 677);
            this.Controls.Add(this.btnTaoHopDong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_KHACHHANG_TAOHOPDONG";
            this.Text = "FORM_KHACHHANG_TAOHOPDONG";
            this.Load += new System.EventHandler(this.FORM_KHACHHANG_TAOHOPDONG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridV_Xe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIDVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hTTX_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridV_Xe;
        private System.Windows.Forms.Button btnTaoHopDong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtIDCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbb_LOAIDV;
        private HTTX_DataSet hTTX_DataSet;
        private System.Windows.Forms.BindingSource lOAIDVBindingSource;
        private HTTX_DataSetTableAdapters.LOAIDVTableAdapter lOAIDVTableAdapter;
    }
}