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
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class FORM_KHACHHANG_DOIMATKHAU : Form
    {
        private KHACHHANG_TAIKHOAN tk = Form1.getTKKH_NVCur();
        BUS_KHACHHANG bus_KhachHang;
        BUS_KHACHHANG_TAIKHOAN bus_KhachHangTaiKhoan;
        private KHACHHANG kh;
        public FORM_KHACHHANG_DOIMATKHAU()
        {
            InitializeComponent();
            bus_KhachHang = new BUS_KHACHHANG();
            bus_KhachHangTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();
        }
        private void FORM_KHACHHANG_DOIMATKHAU_Load(object sender, EventArgs e)
        {
            kh = bus_KhachHang.getKhachHangFromTK(Form1.getTKKH_NVCur());
        }
        public bool KiemTra()
        {
            if (txtTenKH.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập tên tài khoản !!";
                txtTenKH.Focus();
                return false;
            }
            else if (txtMKC.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu hiện tại !!";
                txtMKC.Focus();
                return false;
            }
            else if (txtMKM1.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng nhập mật khẩu mới !!";
                txtMKM1.Focus();
                return false;
            }
            else if (txtMKM2.Text == "")
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Vui lòng xác nhận mật khẩu !!";
                txtMKM2.Focus();
                return false;
            }
            else if (txtMKM1.Text != txtMKM2.Text)
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu mới và mật khẩu xác nhận không trùng khớp";
                txtMKM2.Focus();
                txtMKM2.SelectAll();
                return false;
            }
            else if (txtMKC.Text != tk.Matkhau)
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu cũ sai !!";
                txtMKC.Focus();
                return false;
            }
            else if (txtMKM1.Text == tk.Matkhau)
            {
                lblShowInfor.ForeColor = Color.Red;
                lblShowInfor.Text = "Mật khẩu mới phải khác mật khẩu cũ !!";
                txtMKC.Focus();
                return false;
            }
            return true;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                bus_KhachHangTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();
                bus_KhachHangTaiKhoan.UpdateMatKhau_BUS(kh.MaKH, txtMKM1.Text);
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            } 
        }

        private void ckbMK_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMK.Checked)
            {
                txtMKC.UseSystemPasswordChar = false;
                txtMKM1.UseSystemPasswordChar = false;
                txtMKM2.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKC.UseSystemPasswordChar = true;
                txtMKM1.UseSystemPasswordChar = true;
                txtMKM2.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
