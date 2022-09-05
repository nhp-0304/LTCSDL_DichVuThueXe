using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_HOPDONG
    {
        DAO_HOPDONG dAO_HOPDONG;

        public BUS_HOPDONG()
        {
            dAO_HOPDONG = new DAO_HOPDONG();
        }
        public int getMaHDG_HT()
        {
            return dAO_HOPDONG.getMaHDG_HT();
        }
        public HOPDONG getHopDongFromMaHDG(int ma)
        {
            HOPDONG hdg = dAO_HOPDONG.getHopDongFromMaHDG(ma);
            return hdg;
        }

        public void suaHDG_Xe(int maHDG, int maXe, DateTime ngayBD, DateTime ngayKT, int manv)
        {
            dAO_HOPDONG.suaHDG_Xe(maHDG, maXe,ngayBD,ngayKT,manv);
        }

        public void suaHDG_MaL_Xe(int maHDG, int maL, int maXe, DateTime ngayBD, DateTime ngayKT, int manv)
        {
            dAO_HOPDONG.suaHDG_MaL_Xe(maHDG, maL, maXe,ngayBD,ngayKT,manv);
        }

        public dynamic getHopDong()
        {
            return dAO_HOPDONG.getHopDong();
        }
        public void hopDong_Thanhtoan(int maHDG)
        {
            dAO_HOPDONG.hopDong_Thanhtoan(maHDG);
        }

        public int? GetMaxIDContract()
        {
            int? MaxID = dAO_HOPDONG.GetMaxContractID();
            return MaxID;
        }
        public bool AddContract(HOPDONG HopDong)
        {
            try
            {
                dAO_HOPDONG.AddContract(HopDong);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int? deleteHDG_HD(int maHDG)
        {
            return dAO_HOPDONG.deleteHDG_HD(maHDG);
        }
        public dynamic getVoHang(int maKH)
        {
            return dAO_HOPDONG.getVoHang(maKH);
        }
    }
}
