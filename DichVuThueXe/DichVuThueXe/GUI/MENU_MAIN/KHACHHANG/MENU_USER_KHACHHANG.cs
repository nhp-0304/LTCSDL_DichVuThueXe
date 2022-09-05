using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class MENU_USER_KHACHHANG : Form
    {
        BUS_KHACHHANG_TAIKHOAN bUS_KHACHHANG_TAIKHOAN;
        public MENU_USER_KHACHHANG()
        {
            InitializeComponent();
        }

        private void MENU_USER_KHACHHANG_Load(object sender, EventArgs e)
        {

        }
        private void btnThongTinKhachHang_Click(object sender, EventArgs e)
        {
            FORM_KHACHHANG_CHINHSUATHONGTIN f = new FORM_KHACHHANG_CHINHSUATHONGTIN();
            f.Show();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            FORM_KHACHHANG_DOIMATKHAU f = new FORM_KHACHHANG_DOIMATKHAU();
            f.Show();
        }

        private void btnTaoHopDong_Click(object sender, EventArgs e)
        {
            FORM_KHACHHANG_TAOHOPDONG f = new FORM_KHACHHANG_TAOHOPDONG();
            f.Show();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}
