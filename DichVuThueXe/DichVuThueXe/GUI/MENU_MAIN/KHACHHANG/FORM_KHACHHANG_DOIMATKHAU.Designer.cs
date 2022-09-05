
namespace DichVuThueXe.GUI
{
    partial class FORM_KHACHHANG_DOIMATKHAU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_KHACHHANG_DOIMATKHAU));
            this.btnLuu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblShowInfor = new System.Windows.Forms.Label();
            this.ckbMK = new System.Windows.Forms.CheckBox();
            this.txtMKM1 = new System.Windows.Forms.TextBox();
            this.txtMKC = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMKM2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.diaChiLabel = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::DichVuThueXe.Properties.Resources.mayxanh;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(249, 288);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 49);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 49;
            this.label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::DichVuThueXe.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.lblShowInfor);
            this.groupBox1.Controls.Add(this.ckbMK);
            this.groupBox1.Controls.Add(this.txtMKM1);
            this.groupBox1.Controls.Add(this.txtMKC);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMKM2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.diaChiLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(69, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 214);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // lblShowInfor
            // 
            this.lblShowInfor.AutoSize = true;
            this.lblShowInfor.BackColor = System.Drawing.Color.Transparent;
            this.lblShowInfor.Location = new System.Drawing.Point(20, 171);
            this.lblShowInfor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblShowInfor.Name = "lblShowInfor";
            this.lblShowInfor.Size = new System.Drawing.Size(11, 16);
            this.lblShowInfor.TabIndex = 52;
            this.lblShowInfor.Text = ".";
            // 
            // ckbMK
            // 
            this.ckbMK.AutoSize = true;
            this.ckbMK.BackColor = System.Drawing.Color.Transparent;
            this.ckbMK.Location = new System.Drawing.Point(229, 171);
            this.ckbMK.Margin = new System.Windows.Forms.Padding(2);
            this.ckbMK.Name = "ckbMK";
            this.ckbMK.Size = new System.Drawing.Size(128, 20);
            this.ckbMK.TabIndex = 5;
            this.ckbMK.Text = "Hiển thị mật khẩu";
            this.ckbMK.UseVisualStyleBackColor = false;
            this.ckbMK.CheckedChanged += new System.EventHandler(this.ckbMK_CheckedChanged);
            // 
            // txtMKM1
            // 
            this.txtMKM1.Location = new System.Drawing.Point(142, 104);
            this.txtMKM1.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKM1.Name = "txtMKM1";
            this.txtMKM1.Size = new System.Drawing.Size(224, 22);
            this.txtMKM1.TabIndex = 3;
            this.txtMKM1.UseSystemPasswordChar = true;
            // 
            // txtMKC
            // 
            this.txtMKC.Location = new System.Drawing.Point(142, 72);
            this.txtMKC.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKC.Name = "txtMKC";
            this.txtMKC.Size = new System.Drawing.Size(224, 22);
            this.txtMKC.TabIndex = 2;
            this.txtMKC.UseSystemPasswordChar = true;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(142, 43);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(224, 22);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtMKM2
            // 
            this.txtMKM2.Location = new System.Drawing.Point(143, 137);
            this.txtMKM2.Margin = new System.Windows.Forms.Padding(2);
            this.txtMKM2.Name = "txtMKM2";
            this.txtMKM2.Size = new System.Drawing.Size(224, 22);
            this.txtMKM2.TabIndex = 4;
            this.txtMKM2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nhập lại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(19, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tài khoản:";
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.BackColor = System.Drawing.Color.Transparent;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(19, 73);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(82, 16);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mật khẩu cũ:";
            // 
            // diaChiLabel
            // 
            this.diaChiLabel.AutoSize = true;
            this.diaChiLabel.BackColor = System.Drawing.Color.Transparent;
            this.diaChiLabel.Location = new System.Drawing.Point(19, 107);
            this.diaChiLabel.Name = "diaChiLabel";
            this.diaChiLabel.Size = new System.Drawing.Size(90, 16);
            this.diaChiLabel.TabIndex = 6;
            this.diaChiLabel.Text = "Mật khẩu mới:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.BackgroundImage")));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(376, 288);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 49);
            this.btnThoat.TabIndex = 50;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FORM_KHACHHANG_DOIMATKHAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DichVuThueXe.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FORM_KHACHHANG_DOIMATKHAU";
            this.Text = "FORM_KHACHHANG_DOIMATKHAU";
            this.Load += new System.EventHandler(this.FORM_KHACHHANG_DOIMATKHAU_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMKM1;
        private System.Windows.Forms.TextBox txtMKC;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMKM2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label diaChiLabel;
        private System.Windows.Forms.CheckBox ckbMK;
        private System.Windows.Forms.Label lblShowInfor;
        private System.Windows.Forms.Button btnThoat;
    }
}