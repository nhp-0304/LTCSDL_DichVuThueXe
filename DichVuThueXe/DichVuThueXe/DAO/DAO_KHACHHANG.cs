using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_KHACHHANG
    {
        HTTXDataContext conn;
        public DAO_KHACHHANG()
        {
            conn = new HTTXDataContext();
        }

        public KHACHHANG getKhachHangFromTK(KHACHHANG_TAIKHOAN acc)
        {
            KHACHHANG kh = conn.KHACHHANGs.FirstOrDefault(s => s.MaKH == acc.MaKH);
            return kh;
        }

        public int? getMaKHCurrent()
        {
            int? maCur = 0;
            conn.getMaKHCurrent(ref maCur);
            return maCur;
        }

        public int? addKhachHang(int? maKH, string ten, string cmnd, string gioitinh, DateTime ngaysinh,string diachi, string sdt) 
        {
            int? checkadd = 0;
            conn.SV_addKhachHang(maKH, ten, cmnd, gioitinh, ngaysinh, diachi, sdt, ref checkadd);
            return checkadd;
        }
        public KHACHHANG getKH1(int maKH)
        {
            var get = (from s in conn.KHACHHANGs where s.MaKH == maKH select s).First();
            return get;
        }
        
        ///////////////
        public dynamic ListCustomers()
        {
            dynamic ds = conn.KHACHHANGs.Select(s => new
            {
                s.MaKH,
                s.Ten,
                s.CMND,
                s.Gioitinh,
                s.Ngaysinh,
                s.Diachi,
                s.SDT
            }).ToList();
            return ds;
        }
        public dynamic SearchCustomer(String CustomerName)
        {
            dynamic ds = conn.KHACHHANGs.Where(s => s.Ten.Contains(CustomerName)).Select(s => new
            {
                s.MaKH,
                s.Ten,
                s.CMND,
                s.Gioitinh,
                s.Ngaysinh,
                s.Diachi,
                s.SDT
            }).ToList();
            return ds;
        }
        public void UpdateKH_fUser(int maKH, string ten, string diachi, string gioitinh,DateTime ngaysinh)
        {
            var sua = (from s in conn.KHACHHANGs where s.MaKH == maKH select s).First();
            sua.Ten = ten;
            sua.Diachi = diachi;
            sua.Gioitinh = gioitinh;
            sua.Ngaysinh = ngaysinh;
            conn.SubmitChanges();
        }

        public KHACHHANG getNV1(int maNV)
        {
            var get = (from s in conn.KHACHHANGs where s.MaKH == maNV select s).First();
            return get;
        }
        public List<KHACHHANG> getNV()
        {
            var get = from s in conn.KHACHHANGs select s;
            return get.ToList();
        }
        public List<KHACHHANG> getNV(int maNV)
        {
            var get = from s in conn.KHACHHANGs where s.MaKH == maNV select s;
            return get.ToList();
        }
        public List<KHACHHANG> getNV(string tenNV)
        {
            var get = from s in conn.KHACHHANGs where s.Ten.Contains(tenNV) select s;
            return get.ToList();
        }
        public int getMaNVHT()
        {
            try
            {
                return conn.KHACHHANGs.Select(s => s.MaKH).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }
        public bool kTraMaNVTrung(int maNV)
        {
            var exist = from s in conn.KHACHHANGs where s.MaKH == maNV select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
        public bool kTraNVHopDong(int maNV)
        {
            var exist = from s in conn.HOPDONGs where s.MaKH == maNV select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
        public void suaNV(int maNV, string tenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            conn.SP_SuaKH(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
        }
        public void xoaNV(int maNV)
        {
            conn.SP_XoaKH(maNV);
        }
    }
}
