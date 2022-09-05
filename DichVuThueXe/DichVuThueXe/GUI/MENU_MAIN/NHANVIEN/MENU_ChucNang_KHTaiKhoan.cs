using DichVuThueXe.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DichVuThueXe.GUI.MENU_MAIN.NHANVIEN
{
    public partial class MENU_ChucNang_KHTaiKhoan : Form
    {
        BUS_KHACHHANG_TAIKHOAN busNVTaiKhoan;

        public MENU_ChucNang_KHTaiKhoan()
        {
            InitializeComponent();
            busNVTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();

            /////////////////////////////////////////// TIM KIEM
            this.txtTimKiemNVTK.ForeColor = Color.Gray;
            this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";
            this.txtTimKiemNVTK.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtTimKiemNVTK.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// MK HIEN TAI
            this.txtMKHT.ForeColor = Color.Gray;
            this.txtMKHT.Text = " Mật khẩu hiện tại";
            this.txtMKHT.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKHT.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// MK MOI
            this.txtMKMoi.ForeColor = Color.Gray;
            this.txtMKMoi.Text = " Mật khẩu mới";
            this.txtMKMoi.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKMoi.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);

            /////////////////////////////////////////// NHAP LAI MK
            this.txtMKNhapLai.ForeColor = Color.Gray;
            this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
            this.txtMKNhapLai.Leave += new System.EventHandler(this.txtTimKiemNVTK_Leave);
            this.txtMKNhapLai.Enter += new System.EventHandler(this.txtTimKiemNVTK_Enter);
        }

        private void MENU_ChucNang_KHTaiKhoan_Load(object sender, EventArgs e)
        {
            this.initInputNVTK();
            this.btnRefeshNVTK_Click(sender, e);
        }

        public void initInputNVTK()
        {
            this.txtMaNV.Text = null;
            this.txtTaiKhoan.Text = null;
            this.txtViTri.Text = null;

            this.txtTaiKhoan.MaxLength = 25;
            this.txtMKHT.MaxLength = 25;
            this.txtMKMoi.MaxLength = 25;
            this.txtMKNhapLai.MaxLength = 25;
            this.txtViTri.MaxLength = 1;
        }

        public void loadDataTableNVTK()
        {
            this.busNVTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK();
        }

        public void loadDataTableNVTK(int maNV)
        {
            this.busNVTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK(maNV);
        }

        public void loadDataTableNVTK(string taiKhoan)
        {
            this.busNVTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();
            this.tbNVTaiKhoan.DataSource = busNVTaiKhoan.getListNV_TK(taiKhoan);
        }

        private void tbNVTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.tbNVTaiKhoan.CurrentRow.Selected = true;
                    this.txtMaNV.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.txtTaiKhoan.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtViTri.Text = this.tbNVTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ chọn dòng tương ứng", "Cảnh báo!");
            }
        }

        private void txtTimKiemNVTK_Leave(object sender, EventArgs e)
        {
            if (this.txtTimKiemNVTK.Text == null)
            {
                this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";
                this.txtTimKiemNVTK.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiemNVTK_Enter(object sender, EventArgs e)
        {
            if (this.txtTimKiemNVTK.Text == " Tìm kiếm trên bảng")
            {
                this.txtTimKiemNVTK.Text = null;
                this.txtTimKiemNVTK.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemNVTK_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTimKiemNVTK.Text) || string.IsNullOrEmpty(this.txtTimKiemNVTK.Text) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableNVTK();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiemNVTK.Text) && string.IsNullOrEmpty(this.txtTimKiemNVTK.Text)))
            {
                if (this.IsNumber(this.txtTimKiemNVTK.Text))
                    this.loadDataTableNVTK(int.Parse(this.txtTimKiemNVTK.Text));
                if (!this.IsNumber(this.txtTimKiemNVTK.Text))
                    this.loadDataTableNVTK(this.txtTimKiemNVTK.Text.Trim());
            }
        }

        private void txtMKHT_Leave(object sender, EventArgs e)
        {
            if (this.txtMKHT.Text == "")
            {
                this.txtMKHT.UseSystemPasswordChar = false;
                this.txtMKHT.Text = " Mật khẩu hiện tại";
                this.txtMKHT.ForeColor = Color.Gray;
            }
        }

        private void txtMKHT_Enter(object sender, EventArgs e)
        {
            if (this.txtMKHT.Text == " Mật khẩu hiện tại")
            {
                this.txtMKHT.Text = "";
                this.txtMKHT.ForeColor = Color.Black;
                this.txtMKHT.UseSystemPasswordChar = true;
            }

            if ((!this.txtMKMoi.UseSystemPasswordChar && !this.txtMKMoi.Text.Equals(" Mật khẩu mới")) ||
                (!this.txtMKNhapLai.UseSystemPasswordChar && !this.txtMKNhapLai.Text.Equals(" Nhập lại mật khẩu mới")))
                this.txtMKHT.UseSystemPasswordChar = false;
        }

        private void txtMKMoi_Leave(object sender, EventArgs e)
        {
            if (this.txtMKMoi.Text == "")
            {
                this.txtMKMoi.UseSystemPasswordChar = false;
                this.txtMKMoi.Text = " Mật khẩu mới";
                this.txtMKMoi.ForeColor = Color.Gray;
            }
        }

        private void txtMKMoi_Enter(object sender, EventArgs e)
        {
            if (this.txtMKMoi.Text == " Mật khẩu mới")
            {
                this.txtMKMoi.Text = "";
                this.txtMKMoi.ForeColor = Color.Black;
                this.txtMKMoi.UseSystemPasswordChar = true;
            }

            if ((!this.txtMKHT.UseSystemPasswordChar && !this.txtMKHT.Text.Equals(" Mật khẩu hiện tại")) ||
                (!this.txtMKNhapLai.UseSystemPasswordChar && !this.txtMKNhapLai.Text.Equals(" Nhập lại mật khẩu mới")))
                this.txtMKMoi.UseSystemPasswordChar = false;
        }

        private void txtMKNhapLai_Leave(object sender, EventArgs e)
        {
            if (this.txtMKNhapLai.Text == "")
            {
                this.txtMKNhapLai.UseSystemPasswordChar = false;
                this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
                this.txtMKNhapLai.ForeColor = Color.Gray;
            }
        }

        private void txtMKNhapLai_Enter(object sender, EventArgs e)
        {
            if (this.txtMKNhapLai.Text == " Nhập lại mật khẩu mới")
            {
                this.txtMKNhapLai.Text = "";
                this.txtMKNhapLai.ForeColor = Color.Black;
                this.txtMKNhapLai.UseSystemPasswordChar = true;
            }

            if ((!this.txtMKHT.UseSystemPasswordChar && !this.txtMKHT.Text.Equals(" Mật khẩu hiện tại")) ||
                (!this.txtMKMoi.UseSystemPasswordChar && !this.txtMKMoi.Text.Equals(" Mật khẩu mới")))
                this.txtMKNhapLai.UseSystemPasswordChar = false;
        }

        private static bool checkBtnHien = true;
        private void btnHienAn_Click(object sender, EventArgs e)
        {
            if (checkBtnHien)
            {
                this.btnHienAn.Text = "Ẩn";
                this.btnHienAn.BackColor = Color.LightGray;
                //this.btnHienAn.FlatAppearance.BorderColor = Color.Black;
                checkBtnHien = false;
            }
            else
            {
                this.btnHienAn.Text = "Hiện";
                this.btnHienAn.BackColor = Color.White;
                //this.btnHienAn.FlatAppearance.BorderColor = Color.White;
                checkBtnHien = true;
            }

            //////////////////////////////////////////////////

            if (this.txtMKHT.UseSystemPasswordChar || this.txtMKHT.Text.Equals(" Mật khẩu hiện tại"))
            {
                this.txtMKHT.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKHT.UseSystemPasswordChar = true;
            }

            //////////////////////////////////////////////////

            if (this.txtMKMoi.UseSystemPasswordChar || this.txtMKMoi.Text.Equals(" Mật khẩu mới"))
            {
                this.txtMKMoi.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKMoi.UseSystemPasswordChar = true;
            }

            //////////////////////////////////////////////////

            if (this.txtMKNhapLai.UseSystemPasswordChar || this.txtMKNhapLai.Text.Equals(" Nhập lại mật khẩu mới"))
            {
                this.txtMKNhapLai.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtMKNhapLai.UseSystemPasswordChar = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (this.isMKInputNotNull())
            {
                if (this.busNVTaiKhoan.kTraMK(this.txtMKHT.Text))
                {
                    if (this.isMKInputExactly())
                    {
                        if (MessageBox.Show("Xác nhận đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int maNV = int.Parse(this.txtMaNV.Text);
                            string matKhau = this.txtMKNhapLai.Text;
                            try
                            {
                                busNVTaiKhoan.doiMKNV(maNV, matKhau);
                                MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo");
                                resetTextBoxNVTK(maNV);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Đổi mật khẩu thất bại!!!", "Lỗi!");
                            }
                        }
                    }
                    else
                        MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không trùng khớp", "Không thể đổi mật khẩu!");
                }
                else
                    MessageBox.Show("Mật khẩu hiện tại không đúng", "Không thể đổi mật khẩu!");
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
        }

        private void btnRefeshNVTK_Click(object sender, EventArgs e)
        {
            this.txtTimKiemNVTK.ForeColor = Color.Gray;
            this.txtTimKiemNVTK.Text = " Tìm kiếm trên bảng";

            this.txtMaNV.Text = null;
            this.txtTaiKhoan.Text = null;
            this.txtViTri.Text = null;

            this.txtMKHT.ForeColor = Color.Gray;
            this.txtMKHT.Text = " Mật khẩu hiện tại";
            this.txtMKHT.UseSystemPasswordChar = false;

            this.txtMKMoi.ForeColor = Color.Gray;
            this.txtMKMoi.Text = " Mật khẩu mới";
            this.txtMKMoi.UseSystemPasswordChar = false;

            this.txtMKNhapLai.ForeColor = Color.Gray;
            this.txtMKNhapLai.Text = " Nhập lại mật khẩu mới";
            this.txtMKNhapLai.UseSystemPasswordChar = false;

            this.btnHienAn.Text = "Hiện";
            this.btnHienAn.BackColor = Color.White;
            checkBtnHien = true;

            this.loadDataTableNVTK();
        }

        public void resetTextBoxNVTK(int taiKhoan)
        {
            var tk = this.busNVTaiKhoan.getListNV_TK1(taiKhoan);
            this.txtMaNV.Text = tk.MaKH.ToString();
            this.txtTaiKhoan.Text = tk.Taikhoan.ToString();
            this.txtViTri.Text = tk.Vitri.ToString();
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool isMKInputNotNull()
        {
            if (string.IsNullOrWhiteSpace(this.txtMKHT.Text) || this.txtMKHT.ForeColor == Color.Gray ||
                string.IsNullOrWhiteSpace(this.txtMKMoi.Text) || this.txtMKMoi.ForeColor == Color.Gray ||
                string.IsNullOrWhiteSpace(this.txtMKNhapLai.Text) || this.txtMKNhapLai.ForeColor == Color.Gray)
                return false;
            return true;
        }

        public bool isMKInputExactly()
        {
            if (this.txtMKMoi.Text.Equals(this.txtMKNhapLai.Text) == false)
                return false;
            return true;
        }
    }
}
