using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_NHANVIEN
    {
        HTTXDataContext conn;
        public DAO_NHANVIEN()
        {
            conn = new HTTXDataContext();
        }

        public NHANVIEN getNhanVienFromTK(NHANVIEN_TAIKHOAN acc)
        {
            NHANVIEN nv = conn.NHANVIENs.FirstOrDefault(s => s.MaNV == acc.MaNV);
            return nv;
        }

        public int? getMaNVCurrent() 
        {
            int? maCur = 0;
            conn.getMaNVCurrent(ref maCur);
            return maCur;
        }

        public int? addNhanVien(int? maNV, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = 0;
            conn.SV_addNhanVien(maNV, ten, cmnd, gioitinh, ngaysinh, diachi, sdt, ref checkadd);
            return checkadd;
        }
        public NHANVIEN getNV1(int maNV)
        {
            var get = (from s in conn.NHANVIENs where s.MaNV == maNV select s).First();
            return get;
        }
        //////////////////////////////////////////
        public List<NHANVIEN> getNV()
        {
            var get = from s in conn.NHANVIENs select s;
            return get.ToList();
        }
        public List<NHANVIEN> getNV(int maNV)
        {
            var get = from s in conn.NHANVIENs where s.MaNV == maNV select s;
            return get.ToList();
        }
        public List<NHANVIEN> getNV(string tenNV)
        {
            var get = from s in conn.NHANVIENs where s.TenNV.Contains(tenNV) select s;
            return get.ToList();
        }
        public int getMaNVHT()
        {
            try
            {
                return conn.NHANVIENs.Select(s => s.MaNV).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }
        public bool kTraMaNVTrung(int maNV)
        {
            var exist = from s in conn.NHANVIENs where s.MaNV == maNV select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
        public bool kTraNVHopDong(int maNV)
        {
            var exist = from s in conn.HOPDONGs where s.MaNV == maNV select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }

        public void suaNV(int maNV, string tenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            conn.SP_SuaNV(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
        }
        public void xoaNV(int maNV)
        {
            conn.SP_XoaNV(maNV);
        }
    }
}
