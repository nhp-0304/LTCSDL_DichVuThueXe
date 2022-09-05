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
    public partial class FORM_KHACHHANG_TAOHOPDONG : Form
    {

        private HOPDONG hopDong = new HOPDONG();
        BUS_XE bus_Xe;
        BUS_LOAIDV bUS_LOAIDV;
        BUS_KHACHHANG bUS_KHACHHANG;
        BUS_NHANVIEN bus_NhanVien;
        BUS_KHACHHANG_TAIKHOAN bus_KHACHHANG_TAIKHOAN;
        BUS_HOPDONG bus_HopDong;
        BUS_HOADON bUS_HOADON;
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        private KHACHHANG_TAIKHOAN kh_tkCur = Form1.getTKKH_NVCur();
        int maNV = 0;
        public FORM_KHACHHANG_TAOHOPDONG()
        {
            InitializeComponent();
            bus_Xe = new BUS_XE();
            bUS_LOAIDV = new BUS_LOAIDV();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            bus_NhanVien = new BUS_NHANVIEN();
            bus_KHACHHANG_TAIKHOAN = new BUS_KHACHHANG_TAIKHOAN();
            bus_HopDong = new BUS_HOPDONG();
            bUS_HOADON = new BUS_HOADON();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
        }

        private void FORM_KHACHHANG_TAOHOPDONG_Load(object sender, EventArgs e)
        {
            this.lOAIDVTableAdapter.Fill(this.hTTX_DataSet.LOAIDV);
            LoadVehicleList();
            cbb_LOAIDV_SelectedIndexChanged(sender, e);
            txtTenKH.Text = bUS_KHACHHANG.getKhachHangFromTK(kh_tkCur).Ten;
            maNV = (int)bUS_NHANVIEN_TAIKHOAN.getNV_TK_QTV().MaNV;
        }

        private void btnTaoHopDong_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDCar.Text))
            {
                MessageBox.Show("Mã xe và mã khách hàng không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dtpNgayBatDau.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Ngày bắt đầu hợp đồng không được nhỏ hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dtpNgayKetThuc.Value.Date <= dtpNgayBatDau.Value.Date)
                    {
                        MessageBox.Show("Ngày kết thúc hợp đồng phải lớn hơn ngày bắt đầu hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show("An toàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HOPDONG HopDong = new HOPDONG();
                        int ContractID = bus_HopDong.getMaHDG_HT() + 1;
                        HopDong.MaHDG = ContractID;
                        HopDong.Maxe = int.Parse(txtIDCar.Text);
                        HopDong.MaKH = bUS_KHACHHANG.getKhachHangFromTK(kh_tkCur).MaKH;
                        HopDong.MaL = int.Parse(txtServiceID.Text);
                        HopDong.MaNV = maNV;
                        HopDong.NgayBD = dtpNgayBatDau.Value.Date;
                        HopDong.NgayKT = dtpNgayKetThuc.Value.Date;
                        HopDong.Trangthai = false;
                        if (bus_HopDong.AddContract(HopDong) == true)
                        {
                            int maHD = bUS_HOADON.getMaHDonHT() + 1;
                            TimeSpan kc = dtpNgayKetThuc.Value.Date - dtpNgayBatDau.Value.Date;
                            decimal sogio = decimal.Parse(kc.TotalHours.ToString());
                            decimal thanhtien = bUS_LOAIDV.getLOAIDV(cbb_LOAIDV.SelectedIndex + 1).Gia * (sogio / decimal.Parse("24"));
                            bus_Xe.setTTChoXeCoHD(int.Parse(txtIDCar.Text));
                            bUS_HOADON.addHoaDon(maHD, ContractID, sogio, thanhtien, false); ;
                            MessageBox.Show("Tạo hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnThoat_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Tạo hợp đồng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        public void LoadVehicleList()
        {
            bus_Xe = new BUS_XE();
            bus_Xe.ListVehicle(gridV_Xe, cbb_LOAIDV.SelectedIndex + 1);
            gridV_Xe.Columns[0].Width = (int)(gridV_Xe.Width * 0.1);
            gridV_Xe.Columns[1].Width = (int)(gridV_Xe.Width * 0.35);
            gridV_Xe.Columns[2].Width = (int)(gridV_Xe.Width * 0.15);
            gridV_Xe.Columns[3].Width = (int)(gridV_Xe.Width * 0.15);
            gridV_Xe.Columns[4].Width = (int)(gridV_Xe.Width * 0.15);
        }
        private void cbb_LOAIDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bUS_LOAIDV = new BUS_LOAIDV();
            try
            {
                LoadVehicleList();
                txtServiceID.Text = bUS_LOAIDV.getLOAIDV(cbb_LOAIDV.SelectedIndex + 1).MaL.ToString();
                txtPrice.Text = bUS_LOAIDV.getLOAIDV(cbb_LOAIDV.SelectedIndex + 1).Gia.ToString();
            }
            catch
            { }
        }

        private void gridV_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridV_Xe.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            string cell = gridV_Xe.Rows[index].Cells[0].Value.ToString().Trim();
            txtIDCar.Text = cell;
            txtCarName.Text = bus_Xe.getXe1(int.Parse(cell)).Tenxe;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }       
}

