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

namespace DichVuThueXe.GUI.MENU_MAIN.NHANVIEN
{
    public partial class MENU_SuaHopDong : Form
    {
        BUS_LOAIDV bUS_LOAIDV;
        BUS_XE bUS_XE;
        BUS_KHACHHANG bUS_KHACHHANG;
        BUS_NHANVIEN bUS_NHANVIEN;
        BUS_HOPDONG bUS_HOPDONG;
        BUS_HOADON bUS_HOADON;
        private HOPDONG hdgCur = MENU_ChucNangMain.HopDongCurrentToEdit();
        private int maL_stamp = 0;
        private int maX_stamp = 0;
        private DateTime ngayBD_stamp;
        private DateTime ngayKT_stamp;
        private bool isSua = false;
        public MENU_SuaHopDong()
        {
            bUS_LOAIDV = new BUS_LOAIDV();
            bUS_XE = new BUS_XE();
            bUS_KHACHHANG = new BUS_KHACHHANG();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            bUS_HOPDONG = new BUS_HOPDONG();
            bUS_HOADON = new BUS_HOADON();
            maL_stamp = hdgCur.MaL;
            maX_stamp = hdgCur.Maxe;
            ngayBD_stamp = hdgCur.NgayBD;
            ngayKT_stamp = hdgCur.NgayKT;
            InitializeComponent();
        }

        private void MENU_SuaHopDong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTX_DataSet.LOAIDV' table. You can move, or remove it, as needed.
            this.lOAIDVTableAdapter.Fill(this.hTTX_DataSet.LOAIDV);

            loadFormSua();

        }

        private void loadFormSua()
        {
            lblMaHDG.Text = hdgCur.MaHDG.ToString();
            //Loai dv
            if(!bUS_LOAIDV.getLOAIDV(hdgCur.MaL).Tenloai.Equals(cbB_LoaiDV.SelectedItem.ToString()))
            {
                cbB_LoaiDV.Text = bUS_LOAIDV.getLOAIDV(hdgCur.MaL).Tenloai;
            }
            txtGiaDV.Text = bUS_LOAIDV.getLOAIDV(cbB_LoaiDV.SelectedIndex + 1).Gia.ToString();

            gridV_Xe.DataSource = bUS_XE.getXeTheoMaLoai(hdgCur.MaL);
            //Xe
            txtMaXe.Text = hdgCur.Maxe.ToString();
            txtTenXe.Text = bUS_XE.getXe1(hdgCur.Maxe).Tenxe;
            if (bUS_XE.getXe1(hdgCur.Maxe).Trangthai == false)
                txtTrangThaiXe.Text = "Xe chưa được thuê";
            else
                txtTrangThaiXe.Text = "Xe đã được thuê";
            //Khách hàng
            txtMaKH.Text = hdgCur.MaKH.ToString();
            txtTenKH.Text = bUS_KHACHHANG.getKH1(hdgCur.MaKH).Ten;
            //Nhân viên
            txtMaNV.Text = bUS_NHANVIEN.getNVFromTK(MENU_ChucNangMain.nv_tkCur).MaNV.ToString();
            txtTenNV.Text = bUS_NHANVIEN.getNVFromTK(MENU_ChucNangMain.nv_tkCur).TenNV.ToString();
            //Thời gian thuê
            dtP_BatDau.Value = hdgCur.NgayBD;
            dtP_KetThuc.Value = hdgCur.NgayKT;
        }

        private void cbB_LoaiDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGiaDV.Text = bUS_LOAIDV.getLOAIDV(cbB_LoaiDV.SelectedIndex + 1).Gia.ToString();
            gridV_Xe.DataSource = bUS_XE.getXeTheoMaLoai(cbB_LoaiDV.SelectedIndex + 1);
        }

        private void btnSuaHDG_Click(object sender, EventArgs e)
        {
            int? check = bUS_XE.CheckXeDaThue(int.Parse(txtMaXe.Text));
            TimeSpan kc = dtP_KetThuc.Value - dtP_BatDau.Value;
            decimal sogio = decimal.Parse(kc.TotalHours.ToString());
            decimal thanhtien = bUS_LOAIDV.getLOAIDV(cbB_LoaiDV.SelectedIndex + 1).Gia * (sogio/decimal.Parse("24"));
            if(isSua == false)
            {
                if (dtP_KetThuc.Value > dtP_BatDau.Value)
                {
                    if ((cbB_LoaiDV.SelectedIndex + 1) == maL_stamp && txtMaXe.Text.Equals(maX_stamp.ToString()) && (ngayBD_stamp != dtP_BatDau.Value || ngayKT_stamp != dtP_KetThuc.Value))
                    {
                        bUS_HOPDONG.suaHDG_MaL_Xe(hdgCur.MaHDG, cbB_LoaiDV.SelectedIndex + 1, int.Parse(txtMaXe.Text), dtP_BatDau.Value, dtP_KetThuc.Value, int.Parse(txtMaNV.Text));
                        bUS_HOADON.capNhatHoaDon(int.Parse(lblMaHDG.Text), sogio, thanhtien);
                        MessageBox.Show("Sửa thời gian thuê thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isSua = true;
                    }
                    else
                        if ((cbB_LoaiDV.SelectedIndex + 1) == maL_stamp)
                    {
                        if (!txtMaXe.Text.Equals(maX_stamp.ToString()))
                        {
                            if (check != 1)
                            {
                                bUS_HOPDONG.suaHDG_Xe(hdgCur.MaHDG, int.Parse(txtMaXe.Text), dtP_BatDau.Value, dtP_KetThuc.Value, int.Parse(txtMaNV.Text));
                                bUS_XE.setTTChoXeCoHD(int.Parse(txtMaXe.Text));
                                bUS_HOADON.capNhatHoaDon(int.Parse(lblMaHDG.Text), sogio, thanhtien);
                                resetGrid_xe();
                                MessageBox.Show("Sửa xe cho hợp đồng thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                bUS_XE.setTTChoXeHetHD(maX_stamp);
                                isSua = true;
                            }
                            else
                                MessageBox.Show("Xe này đã được thuê ở hợp đồng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Chưa có sự thay đổi của xe, hoặc loại dịch vụ khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                                if ((cbB_LoaiDV.SelectedIndex + 1) != maL_stamp)
                    {
                        if (!txtMaXe.Text.Equals(maX_stamp.ToString()))
                        {
                            if (check != 1)
                            {
                                bUS_HOPDONG.suaHDG_MaL_Xe(hdgCur.MaHDG, cbB_LoaiDV.SelectedIndex + 1, int.Parse(txtMaXe.Text), dtP_BatDau.Value, dtP_KetThuc.Value, int.Parse(txtMaNV.Text));
                                bUS_XE.setTTChoXeCoHD(int.Parse(txtMaXe.Text));
                                bUS_HOADON.capNhatHoaDon(int.Parse(lblMaHDG.Text), sogio, thanhtien);
                                resetGrid_xe();
                                MessageBox.Show("Sửa loại dịch vụ và xe cho hợp đồng thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                bUS_XE.setTTChoXeHetHD(maX_stamp);
                                isSua = true;
                            }
                            else
                                MessageBox.Show("Xe này đã được thuê ở hợp đồng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    MessageBox.Show("Ngày thuê không hợp lệ !! (Ngày kết thúc không được trước ngày Bắt đầu)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("CHỈNH SỬA HỢP ĐỒNG ĐÃ THÀNH CÔNG, KHÔNG THỂ CHỈNH SỬA TIẾP TỤC ĐƯỢC NỮA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridV_Xe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridV_Xe.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
            string cell = gridV_Xe.Rows[index].Cells[0].Value.ToString().Trim();
            txtMaXe.Text = cell;
            txtTenXe.Text = bUS_XE.getXe1(int.Parse(cell)).Tenxe;
        }

        private void resetGrid_xe()
        {
            bUS_XE = new BUS_XE();
            gridV_Xe.DataSource = bUS_XE.getXeTheoMaLoai(cbB_LoaiDV.SelectedIndex + 1);
        }

        private void btnKP_Click(object sender, EventArgs e)
        {
            if(isSua == false)
            {
                if ((cbB_LoaiDV.SelectedIndex + 1) != maL_stamp || !txtMaXe.Text.Equals(maX_stamp.ToString()) || dtP_BatDau.Value != ngayBD_stamp || dtP_KetThuc.Value != ngayKT_stamp)
                {
                    DialogResult dlr = MessageBox.Show("Đã có sự chỉnh sửa, bạn muốn khôi phục lại thông tin ban đầu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        //LOẠI DỊCH VỤ
                        cbB_LoaiDV.Text = bUS_LOAIDV.getLOAIDV(maL_stamp).Tenloai;
                        txtGiaDV.Text = bUS_LOAIDV.getLOAIDV(cbB_LoaiDV.SelectedIndex + 1).Gia.ToString();
                        //XE
                        txtMaXe.Text = maX_stamp.ToString();
                        txtTenXe.Text = bUS_XE.getXe1(maX_stamp).Tenxe;
                        if (bUS_XE.getXe1(maX_stamp).Trangthai == false)
                            txtTrangThaiXe.Text = "Xe chưa được thuê";
                        else
                            txtTrangThaiXe.Text = "Xe đã được thuê";
                        //Thời gian thuê
                        dtP_BatDau.Value = ngayBD_stamp;
                        dtP_KetThuc.Value = ngayKT_stamp;
                    }
                }
                else
                {
                    //LOẠI DỊCH VỤ
                    cbB_LoaiDV.Text = bUS_LOAIDV.getLOAIDV(maL_stamp).Tenloai;
                    txtGiaDV.Text = bUS_LOAIDV.getLOAIDV(cbB_LoaiDV.SelectedIndex + 1).Gia.ToString();
                    //XE
                    txtMaXe.Text = maX_stamp.ToString();
                    txtTenXe.Text = bUS_XE.getXe1(maX_stamp).Tenxe;
                    if (bUS_XE.getXe1(maX_stamp).Trangthai == false)
                        txtTrangThaiXe.Text = "Xe chưa được thuê";
                    else
                        txtTrangThaiXe.Text = "Xe đã được thuê";
                    //Thời gian thuê
                    //Thời gian thuê
                    dtP_BatDau.Value = ngayBD_stamp;
                    dtP_KetThuc.Value = ngayKT_stamp;
                }
            }
            else
                MessageBox.Show("CHỈNH SỬA HỢP ĐỒNG ĐÃ THÀNH CÔNG, KHÔNG THỂ PHỤC HỒI", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
