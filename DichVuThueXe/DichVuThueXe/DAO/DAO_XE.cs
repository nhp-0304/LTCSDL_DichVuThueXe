using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_XE
    {
        HTTXDataContext conn;
        public DAO_XE()
        {
            conn = new HTTXDataContext();
        }
        public dynamic getXe()
        {
            var ds = conn.XEs.Select(s => new {
                s.Maxe,
                s.Tenxe,
                s.Bienso,
                s.Trangthai,
                s.MaL
            }).ToList();
            return ds;
        }
        public dynamic getXe(int maXe)
        {
            var ds = conn.XEs.Select(s => new {
                s.Maxe,
                s.Tenxe,
                s.Bienso,
                s.Trangthai,
                s.MaL
            }).Where(s => s.Maxe == maXe).ToList();
            return ds;
        }
        public dynamic getXe(string tenXe)
        {
            var ds = conn.XEs.Select(s => new {
                s.Maxe,
                s.Tenxe,
                s.Bienso,
                s.Trangthai,
                s.MaL
            }).Where(s => s.Tenxe.Contains(tenXe)).ToList();
            return ds;
        }
        public List<XE> getXeTheoMaLoai(int maLoai)
        {
            var get = from s in conn.XEs where s.MaL == maLoai select s;
            return get.ToList();
        }
        public XE getXe1(int maXe)
        {
            var get = (from s in conn.XEs where s.Maxe == maXe select s).First();
            return get;
        }
        public int getMaXeHT()
        {
            try
            {
                return conn.XEs.Select(s => s.Maxe).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }
        public bool checkXeTonTai(int maXe)
        {
            bool exist = false;
            conn.SP_CheckXeTonTai(maXe, exist);
            return exist;
        }
        public void themXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            conn.SP_ThemXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void suaXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            var sua = (from s in conn.XEs where s.Maxe == maXe select s).First();
            sua.Tenxe = tenXe;
            sua.Bienso = bienSo;
            sua.Trangthai = trangThai;
            sua.MaL = maLoai;
            conn.SubmitChanges();
        }
        public void xoaXe(int maXe)
        {
            conn.SP_XoaXe(maXe);
        }
        public void setTTChoXeHetHD(int maXe)
        {
            var sua = (from s in conn.XEs where s.Maxe == maXe select s).First();
            sua.Trangthai = false;
            conn.SubmitChanges();
        }
        public void setTTChoXeCoHD(int maXe)
        {
            var sua = (from s in conn.XEs where s.Maxe == maXe select s).First();
            sua.Trangthai = true;
            conn.SubmitChanges();
        }
        public int? CheckXeDaThue(int maxe)
        {
            int? check = 0;
            conn.SV_CheckXeDaThue(maxe, ref check);
            return check;
        }
        public dynamic ListVehicle(int TypeID)
        {
            dynamic ds = conn.XEs.Where(s => (s.Trangthai == false) && (s.MaL == TypeID)).Select(s => new
            {
                s.Maxe,
                s.Tenxe,
                s.Bienso,
                s.Trangthai,
                s.MaL
            }).ToList();
            return ds;
        }
        //////////////
        public bool kTraMaXeTrung(int maXe)
        {
            var exist = from s in conn.XEs where s.Maxe == maXe select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
        public bool kTraXeHopDong(int maXe)
        {
            var exist = from s in conn.HOPDONGs where s.Maxe == maXe select s;
            if (exist.Count() > 0)
                return true;
            return false;
        }
    }
}
