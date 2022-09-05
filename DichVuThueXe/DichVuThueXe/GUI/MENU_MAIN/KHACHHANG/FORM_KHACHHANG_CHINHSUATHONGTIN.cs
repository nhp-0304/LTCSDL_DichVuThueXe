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
    public partial class FORM_KHACHHANG_CHINHSUATHONGTIN : Form
    {
        BUS_KHACHHANG bUS_KHACHHANG;
        BUS_KHACHHANG_TAIKHOAN bUS_kHACHHANG_TAIKHOAN;
        BUS_HOPDONG bUS_HOPDONG;
        BUS_XE bUS_XE;
        private KHACHHANG kh;
        private static HOPDONG hdgCur;
        private bool clickGridV_VoHang = false;
        public FORM_KHACHHANG_CHINHSUATHONGTIN()
        {
            InitializeComponent();
            bUS_kHACHHANG_TAIKHOAN = new BUS_KHACHHANG_TAIKHOAN();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            bUS_HOPDONG = new BUS_HOPDONG();
            bUS_XE = new BUS_XE();
            kh = bUS_KHACHHANG.getKhachHangFromTK(Form1.getTKKH_NVCur());
        }

        private void FORM_KHACHHANG_CHINHSUATHONGTIN_Load(object sender, EventArgs e)
        {
            loadKH();
            loadVoHang();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkInput() == true)
            {
                bUS_KHACHHANG.UpdateKH_fUser(kh.MaKH, txtHoten.Text, txtDiaChi.Text, cbbGioitinh.Text, dtpNgaySinh.Value);
                MessageBox.Show("Chỉnh sửa thành công!!");
            }
        }
        private void loadKH()
        {
            txtHoten.Text = kh.Ten;
            txtCMND.Text = kh.CMND;
            cbbGioitinh.Text = kh.Gioitinh;
            txtDiaChi.Text = kh.Diachi;
            txtDienThoai.Text = kh.SDT;
            dtpNgaySinh.Value = kh.Ngaysinh;
        }
        private void loadVoHang()
        {
            bUS_HOPDONG = new BUS_HOPDONG();
            gridV_Vohang.DataSource = bUS_HOPDONG.getVoHang(kh.MaKH);
        }

        private bool checkInput()
        {
            if (txtHoten.Text.Equals(kh.Ten) && txtDiaChi.Equals(kh.Diachi) && dtpNgaySinh.Value.Date == kh.Ngaysinh.Date && cbbGioitinh.Text.Equals(kh.Gioitinh))
            { MessageBox.Show("Chưa có sự thay đổi để chỉnh sửa!!"); return false; }
            else
                if (!string.IsNullOrEmpty(txtHoten.Text) && !string.IsNullOrEmpty(txtDiaChi.Text))
                return true;
                else
                        if (string.IsNullOrEmpty(txtHoten.Text) && string.IsNullOrEmpty(txtDiaChi.Text))
                        { { MessageBox.Show("Chưa nhập họ tên và địa chỉ!!"); return false; } }
                        else
                            if (string.IsNullOrEmpty(txtHoten.Text))
                            { MessageBox.Show("Chưa nhập họ tên !!"); return false; }
                            else
                                if (string.IsNullOrEmpty(txtDiaChi.Text))
                                { MessageBox.Show("Chưa nhập địa chỉ!!"); return false; }
                                else return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (clickGridV_VoHang != false)
            {
                int maXe_stamp = hdgCur.Maxe;
                if (bUS_HOPDONG.deleteHDG_HD(hdgCur.MaHDG) == 1)
                {
                    bUS_XE.setTTChoXeHetHD(maXe_stamp);
                    MessageBox.Show("Hợp đồng này đã xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadVoHang();
                }
                else
                    MessageBox.Show("Hợp đồng này đã được thanh toán, không thể xoá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Chọn hợp đồng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridV_Vohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clickGridV_VoHang = true; // LỖI KHI KO CLICK VÀO - fix
                int index = gridV_Vohang.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                string cell = gridV_Vohang.Rows[index].Cells[0].Value.ToString().Trim();
                hdgCur = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(cell));
            }
            catch
            {
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
