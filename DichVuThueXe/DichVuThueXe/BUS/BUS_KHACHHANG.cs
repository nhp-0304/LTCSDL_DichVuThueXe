using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_KHACHHANG
    {
        DAO_KHACHHANG dAO_KHACHHANG;

        public BUS_KHACHHANG()
        {
            dAO_KHACHHANG = new DAO_KHACHHANG();
        }

        public int? getMaKHCurrent()
        {
            int? maCur = dAO_KHACHHANG.getMaKHCurrent();
            return maCur;
        }

        public KHACHHANG getKhachHangFromTK(KHACHHANG_TAIKHOAN acc)
        {
            KHACHHANG kh = dAO_KHACHHANG.getKhachHangFromTK(acc);
            return kh;
        }

        public int? addKhachHang(int? maKH, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = dAO_KHACHHANG.addKhachHang(maKH, ten, cmnd, gioitinh, ngaysinh, diachi, sdt);
            return checkadd;
        }
        public KHACHHANG getKH1(int maKH)
        {
            KHACHHANG kh = dAO_KHACHHANG.getKH1(maKH);
            return kh;
        }
        public void ListCustomers(DataGridView dg)
        {
            dg.DataSource = dAO_KHACHHANG.ListCustomers();
        }
        public void SearchCustomer(DataGridView dg, String CustomerName)
        {
            dg.DataSource = dAO_KHACHHANG.SearchCustomer(CustomerName);
        }
        public void UpdateKH_fUser(int maKH, string ten, string diachi, string gioitinh, DateTime ngaysinh)
        {
            dAO_KHACHHANG.UpdateKH_fUser(maKH, ten, diachi, gioitinh,ngaysinh);
        }
        //////
        //////////////////////////////////////////////////////////////////////////

        public KHACHHANG getNV1(int maNV)
        {
            KHACHHANG nv = dAO_KHACHHANG.getNV1(maNV);
            return nv;
        }
        public List<KHACHHANG> getNV()
        {
            List<KHACHHANG> listNV = dAO_KHACHHANG.getNV();
            return listNV;
        }
        public List<KHACHHANG> getNV(int maNV)
        {
            List<KHACHHANG> listNV = dAO_KHACHHANG.getNV(maNV);
            return listNV;
        }
        public List<KHACHHANG> getNV(string tenNV)
        {
            List<KHACHHANG> listNV = dAO_KHACHHANG.getNV(tenNV);
            return listNV;
        }
        public int getMaNVHT()
        {
            int maNVHT = dAO_KHACHHANG.getMaNVHT();
            return maNVHT;
        }
        public bool kTraMaNVTrung(int maNV)
        {
            bool exist = dAO_KHACHHANG.kTraMaNVTrung(maNV);
            return exist;
        }
        public bool kTraNVHopDong(int maNV)
        {
            bool exist = dAO_KHACHHANG.kTraNVHopDong(maNV);
            return exist;
        }
        public void suaNV(int maNV, string tenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            dAO_KHACHHANG.suaNV(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
        }
        public void xoaNV(int maNV)
        {
            dAO_KHACHHANG.xoaNV(maNV);
        }
    }
}
