using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_NHANVIEN
    {
        DAO_NHANVIEN dAO_NHANVIEN;

        public BUS_NHANVIEN()
        {
            dAO_NHANVIEN = new DAO_NHANVIEN();
        }

        public NHANVIEN getNVFromTK(NHANVIEN_TAIKHOAN acc) 
        {
            NHANVIEN nv = dAO_NHANVIEN.getNhanVienFromTK(acc);
            return nv;
        }
        public int? getMaNVCurrent()
        {
            int? maCur = dAO_NHANVIEN.getMaNVCurrent();
            return maCur;
        }
        public int? addNhanVien(int? maNV, string ten, string cmnd, string gioitinh, DateTime ngaysinh, string diachi, string sdt)
        {
            int? checkadd = dAO_NHANVIEN.addNhanVien(maNV, ten, cmnd, gioitinh, ngaysinh, diachi, sdt);
            return checkadd;
        }
        public NHANVIEN getNV1(int maNV)
        {
            NHANVIEN nv = dAO_NHANVIEN.getNV1(maNV);
            return nv;
        }
        //////////////////////////////////////////
        public List<NHANVIEN> getNV()
        {
            List<NHANVIEN> listNV = dAO_NHANVIEN.getNV();
            return listNV;
        }
        public List<NHANVIEN> getNV(int maNV)
        {
            List<NHANVIEN> listNV = dAO_NHANVIEN.getNV(maNV);
            return listNV;
        }
        public List<NHANVIEN> getNV(string tenNV)
        {
            List<NHANVIEN> listNV = dAO_NHANVIEN.getNV(tenNV);
            return listNV;
        }
        public int getMaNVHT()
        {
            int maNVHT = dAO_NHANVIEN.getMaNVHT();
            return maNVHT;
        }
        public bool kTraMaNVTrung(int maNV)
        {
            bool exist = dAO_NHANVIEN.kTraMaNVTrung(maNV);
            return exist;
        }
        public bool kTraNVHopDong(int maNV)
        {
            bool exist = dAO_NHANVIEN.kTraNVHopDong(maNV);
            return exist;
        }
        public void suaNV(int maNV, string tenNV, string cmnd, string gioiTinh, DateTime ngaySinh, string diaChi, string sdt)
        {
            dAO_NHANVIEN.suaNV(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
        }
        public void xoaNV(int maNV)
        {
            dAO_NHANVIEN.xoaNV(maNV);
        }
    }
}
