using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_NHANVIEN_TAIKHOAN
    {
        DAO_NHANVIEN_TAIKHOAN dAO_NHANVIEN_TAIKHOAN;

        public BUS_NHANVIEN_TAIKHOAN()
        {
            dAO_NHANVIEN_TAIKHOAN = new DAO_NHANVIEN_TAIKHOAN();
        }

        public int? getCheckDangNhap(String tk, String mk) 
        {
            int? check = dAO_NHANVIEN_TAIKHOAN.getCheckTAIKHOAN_DN(tk, mk);
            return check;
        }

        public NHANVIEN_TAIKHOAN getNV_TKLogin(String tk, String mk) 
        {
            NHANVIEN_TAIKHOAN tkDN = dAO_NHANVIEN_TAIKHOAN.getNV_TKLogin(tk, mk);
            return tkDN;
        }

        public int? SV_checkAccount_NV(int? makh, string taikhoan)
        {
            int? check = dAO_NHANVIEN_TAIKHOAN.SV_checkAccount_NV(makh, taikhoan);
            return check;
        }

        public int? addNhanVien_TaiKhoan(int? manv, string taikhoan, string matkhau)
        {
            int? checkadd = dAO_NHANVIEN_TAIKHOAN.addNhanVien_TaiKhoan(manv, taikhoan, matkhau);
            return checkadd;
        }
        public NHANVIEN_TAIKHOAN getNV_TK_QTV()
        {
            return dAO_NHANVIEN_TAIKHOAN.getNV_TK_QTV();
        }
        public dynamic getListNV_TK()
        {
            var listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK();
            return listNVTK;
        }
        public dynamic getListNV_TK(int maNV)
        {
            var listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK(maNV);
            return listNVTK;
        }
        public dynamic getListNV_TK(string taiKhoan)
        {
            var listNVTK = dAO_NHANVIEN_TAIKHOAN.getListNV_TK(taiKhoan);
            return listNVTK;
        }

        public void doiMKNV(int maNV, string matKhau)
        {
            dAO_NHANVIEN_TAIKHOAN.doiMKNV(maNV, matKhau);
        }
        public void doiChucVu(int maNV, int viTri)
        {
            dAO_NHANVIEN_TAIKHOAN.doiChucVu(maNV, viTri);
        }
        public bool kTraMK(string matKhau)
        {
            bool exist = dAO_NHANVIEN_TAIKHOAN.kTraMK(matKhau);
            return exist;
        }
        public void xoaNVTaiKhoan(int maNV)
        {
            dAO_NHANVIEN_TAIKHOAN.xoaNVTaiKhoan(maNV);
        }
        public NHANVIEN_TAIKHOAN getListNV_TK1(int maNV)
        {
            return dAO_NHANVIEN_TAIKHOAN.getListNV_TK1(maNV);
        }
    }
}
