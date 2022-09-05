using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_KHACHHANG_TAIKHOAN
    {
        HTTXDataContext conn;

        public DAO_KHACHHANG_TAIKHOAN()
        {
            conn = new HTTXDataContext();
        }

        public KHACHHANG_TAIKHOAN getTAIKHOANKH_DN(KHACHHANG_TAIKHOAN account)
        {
            KHACHHANG_TAIKHOAN tk = conn.KHACHHANG_TAIKHOANs.FirstOrDefault(a => a.Taikhoan == account.Taikhoan && a.Matkhau == account.Matkhau);
            return tk;
        }

        public List<KHACHHANG_TAIKHOAN> getListKH_TK()
        {
            List<KHACHHANG_TAIKHOAN> ds = conn.KHACHHANG_TAIKHOANs.Select(s => s).ToList();
            return ds;
        }

        public int? getCheckTAIKHOANKH_DN(String tk, String mk)
        {
            int? check = 0;
            conn.SV_CheckDN_KH(tk, mk, ref check);
            return check;
        }

        public KHACHHANG_TAIKHOAN getKH_TKLogin(String tk, String mk)
        {
            KHACHHANG_TAIKHOAN tkDN = conn.KHACHHANG_TAIKHOANs.FirstOrDefault(s => s.Taikhoan == tk && s.Matkhau == mk);
            return tkDN;
        }

        public int? addKhachHang_TaiKhoan(int? makh, string taikhoan, string matkhau)
        {
            int? checkadd = 0;
            conn.SV_addKhachHang_TaiKhoan(makh, taikhoan, matkhau, ref checkadd);
            return checkadd;
        }

        public int? SV_checkAccount_KH(int? makh, string taikhoan)
        {
            int? check = 0;
            conn.SV_checkAccount_KH(makh, taikhoan, ref check);
            return check;
        }
        public void UpdateMatKhau_DAO(int maKH, string mk)
        {
            conn.sp_ThayDoiMatKhau(maKH, mk);
            conn.SubmitChanges();
        }
        public dynamic getListNV_TK()
        {
            var ds = conn.KHACHHANG_TAIKHOANs.Select(s => new {
                s.MaKH,
                s.Taikhoan,
                s.Vitri
            }).ToList();
            return ds;
        }
        public dynamic getListNV_TK(int maNV)
        {
            var ds = conn.KHACHHANG_TAIKHOANs.Select(s => new {
                s.MaKH,
                s.Taikhoan,
                s.Vitri
            }).Where(s => s.MaKH == maNV).ToList();
            return ds;
        }
        public dynamic getListNV_TK(string taiKhoan)
        {
            var ds = conn.KHACHHANG_TAIKHOANs.Select(s => new {
                s.MaKH,
                s.Taikhoan,
                s.Vitri
            }).Where(s => s.Taikhoan.Contains(taiKhoan)).ToList();
            return ds;
        }
        public void doiMKNV(int maNV, string matKhau)
        {
            conn.SP_DoiMatKhauKH(maNV, matKhau);
        }
        public void doiChucVu(int maNV, int viTri)
        {
            conn.SP_thayDoiChucVuKH(maNV, viTri);
        }
        public bool kTraMK(string matKhau)
        {
            var exist = from s in conn.KHACHHANG_TAIKHOANs where s.Matkhau == matKhau select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
        public void xoaNVTaiKhoan(int maNV)
        {
            conn.SP_XoaKHTaiKhoan(maNV);
        }
        public KHACHHANG_TAIKHOAN getListNV_TK1(int maNV)
        {
            KHACHHANG_TAIKHOAN get = (from s in conn.KHACHHANG_TAIKHOANs where s.MaKH == maNV select s).First();
            return get;
        }
    }
}
