using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_KHACHHANG_TAIKHOAN
    {
        DAO_KHACHHANG_TAIKHOAN dAO_KHACHHANG_TAIKHOAN;

        public BUS_KHACHHANG_TAIKHOAN()
        {
            dAO_KHACHHANG_TAIKHOAN = new DAO_KHACHHANG_TAIKHOAN();
        }

        public int? getCheckDangNhap(String tk, String mk)
        {
            int? check = dAO_KHACHHANG_TAIKHOAN.getCheckTAIKHOANKH_DN(tk, mk);
            return check;
        }

        public KHACHHANG_TAIKHOAN getKH_TKLogin(String tk, String mk)
        {
            KHACHHANG_TAIKHOAN tkDN = dAO_KHACHHANG_TAIKHOAN.getKH_TKLogin(tk, mk);
            return tkDN;
        }

        public int? addKhachHang_TaiKhoan(int? makh, string taikhoan, string matkhau)
        {
            int? checkadd = dAO_KHACHHANG_TAIKHOAN.addKhachHang_TaiKhoan(makh, taikhoan, matkhau);
            return checkadd;
        }

        public int? SV_checkAccount_KH(int? makh, string taikhoan)
        {
            int? check = dAO_KHACHHANG_TAIKHOAN.SV_checkAccount_KH(makh, taikhoan);
            return check;
        }
        public void UpdateMatKhau_BUS(int maKH, string mk)
        {
            dAO_KHACHHANG_TAIKHOAN.UpdateMatKhau_DAO(maKH, mk);
        }
        public dynamic getListNV_TK()
        {
            var listNVTK = dAO_KHACHHANG_TAIKHOAN.getListNV_TK();
            return listNVTK;
        }
        public dynamic getListNV_TK(int maNV)
        {
            var listNVTK = dAO_KHACHHANG_TAIKHOAN.getListNV_TK(maNV);
            return listNVTK;
        }
        public dynamic getListNV_TK(string taiKhoan)
        {
            var listNVTK = dAO_KHACHHANG_TAIKHOAN.getListNV_TK(taiKhoan);
            return listNVTK;
        }
        public void doiMKNV(int maNV, string matKhau)
        {
            dAO_KHACHHANG_TAIKHOAN.doiMKNV(maNV, matKhau);
        }
        public void doiChucVu(int maNV, int viTri)
        {
            dAO_KHACHHANG_TAIKHOAN.doiChucVu(maNV, viTri);
        }
        public bool kTraMK(string matKhau)
        {
            bool exist = dAO_KHACHHANG_TAIKHOAN.kTraMK(matKhau);
            return exist;
        }
        public void xoaNVTaiKhoan(int maNV)
        {
            dAO_KHACHHANG_TAIKHOAN.xoaNVTaiKhoan(maNV);
        }
        public KHACHHANG_TAIKHOAN getListNV_TK1(int maNV)
        {
            return dAO_KHACHHANG_TAIKHOAN.getListNV_TK1(maNV);
        }
    }
}
