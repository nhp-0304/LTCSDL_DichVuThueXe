using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_HOADON
    {
        DAO_HOADON dAO_HOADON;

        public BUS_HOADON()
        {
            dAO_HOADON = new DAO_HOADON();
        }

        public HOADON getHoaDonFromMaHD(int ma)
        {
            HOADON hd = dAO_HOADON.getHoaDonFromMaHD(ma);
            return hd;
        }

        public int getMaHDonHT()
        {
            return dAO_HOADON.getMaHDonHT();
        }

        public int? addHoaDon(int mahd, int? mahdg, decimal sogio, decimal thanhtien, bool trangthai)
        {
            int? checkadd = dAO_HOADON.addHoaDon(mahd, mahdg, sogio, thanhtien, trangthai);
            return checkadd;
        }
        public dynamic getHoaDon()
        {
            return dAO_HOADON.getHoaDon();
        }
        public void capNhatHoaDon(int maHD, decimal sogio, decimal thanhtien)
        {
            dAO_HOADON.capNhatHoaDon(maHD, sogio, thanhtien);
        }
        public void capNhatNgayIn_ThanhToan(int mahdg)
        {
            dAO_HOADON.capNhatNgayIn_ThanhToan(mahdg);
        }
        public HOADON getHoaDonFromMaHDG(int maHDG)
        {
            HOADON get = dAO_HOADON.getHoaDonFromMaHDG(maHDG);
            return get;
        }
        public void hoaDon_Thanhtoan(int maHDG)
        {
            dAO_HOADON.hoaDon_Thanhtoan(maHDG);
        }
    }
}
