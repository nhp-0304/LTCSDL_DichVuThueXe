using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DichVuThueXe.DAO
{
    class DAO_HOADON
    {
        HTTXDataContext conn;
        public DAO_HOADON()
        {
            conn = new HTTXDataContext();
        }

        public HOADON getHoaDonFromMaHD(int ma)
        {
            HOADON hd = conn.HOADONs.FirstOrDefault(s => s.MaHDG == ma);
            return hd;
        }
        public int getMaHDonHT()
        {
            try
            {
                return conn.HOADONs.Select(s => s.MaHD).Max();
            }
            catch
            {
                int ma = 0;
                return ma;
            }
        }

        public int? addHoaDon(int mahd, int? mahdg, decimal sogio, decimal thanhtien, bool trangthai)
        {
            int? checkadd = 0;
            conn.SV_addHoaDon(mahd, mahdg, sogio, thanhtien, trangthai, ref checkadd);
            return checkadd;
        }
        public dynamic getHoaDon()
        {
            var ds = conn.HOADONs.Select(s => new {
                s.MaHD,
                s.MaHDG,
                s.SogioSD,
                s.Thanhtien,
                s.Ngayin,
                s.Trangthai
            }).ToList();
            return ds;
        }
        //CẬP NHẬT LẠI SỐ GIỜ VÀ TIỀN KHI HỢP ĐỒNG ĐƯỢC SỬA
        public void capNhatHoaDon(int maHDG, decimal sogio, decimal thanhtien)
        {
            var sua = (from s in conn.HOADONs where s.MaHDG == maHDG select s).First();
            sua.SogioSD = sogio;
            sua.Thanhtien = thanhtien;
            conn.SubmitChanges();
        }
        //CẬP NHẬT LẠI NGÀY IN KHI THANH TOÁN
        public void capNhatNgayIn_ThanhToan(int mahdg)
        {
            DateTime dt = DateTime.Now;
            var sua = (from s in conn.HOADONs where s.MaHDG == mahdg select s).First();
            sua.Ngayin = dt;
            conn.SubmitChanges();
        }
        //LẤY HOÁ ĐƠN CÓ MÃ HỢP ĐỒNG
        public HOADON getHoaDonFromMaHDG(int maHDG)
        {
            var get = (from s in conn.HOADONs where s.MaHDG == maHDG select s).First();
            return get;
        }
        //THANH TOÁN HOÁ ĐƠN XONG CẬP NHẬT TRẠNG THÁI HOÁ ĐƠN: Tìm bằng mã hợp đồng
        public void hoaDon_Thanhtoan(int maHDG)
        {
            var sua = (from s in conn.HOADONs where s.MaHDG == maHDG select s).First();
            sua.Trangthai = true;
            conn.SubmitChanges();
        }
    }
}
