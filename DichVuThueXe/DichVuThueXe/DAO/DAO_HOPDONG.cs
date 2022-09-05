using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_HOPDONG
    {
        HTTXDataContext conn;
        public DAO_HOPDONG()
        {
            conn = new HTTXDataContext();
        }
        public int getMaHDG_HT()
        {
            try 
            {
                return conn.HOPDONGs.Select(s => s.MaHDG).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }
        public HOPDONG getHopDongFromMaHDG(int ma)
        {
            HOPDONG hdg = conn.HOPDONGs.FirstOrDefault(s => s.MaHDG == ma);
            return hdg;
        }

        public void suaHDG_Xe(int maHDG,int maXe, DateTime ngayBD, DateTime ngayKT, int manv)
        {
            var sua = (from s in conn.HOPDONGs where s.MaHDG == maHDG select s).First();
            sua.Maxe = maXe;
            sua.NgayBD = ngayBD;
            sua.NgayKT = ngayKT;
            sua.MaNV = manv;
            conn.SubmitChanges();
        }

        public void suaHDG_MaL_Xe(int maHDG,int maL ,int maXe,DateTime ngayBD, DateTime ngayKT,int manv)
        {
            var sua = (from s in conn.HOPDONGs where s.MaHDG == maHDG select s).First();
            sua.MaL = maL;
            sua.Maxe = maXe;
            sua.NgayBD = ngayBD;
            sua.NgayKT = ngayKT;
            sua.MaNV = manv;
            conn.SubmitChanges();
        }
        public dynamic getHopDong()
        {
            var ds = conn.HOPDONGs.Select(s => new {
                s.MaHDG,
                s.Maxe,
                s.MaKH,
                s.MaL,
                s.MaNV,
                s.NgayBD,
                s.NgayKT,
                s.Trangthai
            }).ToList();
            return ds;
        }
        public void hopDong_Thanhtoan(int maHDG)
        {
            var sua = (from s in conn.HOPDONGs where s.MaHDG == maHDG select s).First();
            sua.Trangthai = true;
            conn.SubmitChanges();
        }
        public int? GetMaxContractID()
        {
            int? MaxID = 0;
            conn.GetMaxContractID(ref MaxID);
            return MaxID;
        }
        public void AddContract(HOPDONG HopDong)
        {
            conn.AddContract(HopDong.MaHDG, HopDong.Maxe, HopDong.MaKH, HopDong.MaL, HopDong.MaNV, HopDong.NgayBD, HopDong.NgayKT, HopDong.Trangthai);
            conn.SubmitChanges();
        }

        public int? deleteHDG_HD(int maHDG)
        {
            int? check = 0;
            conn.deleteHDG_HD(maHDG, ref check);
            return check;
        }
        public dynamic getVoHang(int maKH)
        {
            var ds = conn.dsHopDongOfMaKH(maKH).ToList();
            return ds;
        }

    }
}
