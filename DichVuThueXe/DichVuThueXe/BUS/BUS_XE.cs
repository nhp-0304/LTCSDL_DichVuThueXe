using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.DAO;

namespace DichVuThueXe.BUS
{
    class BUS_XE
    {
        DAO_XE daoXe;
        public BUS_XE()
        {
            daoXe = new DAO_XE();
        }
        public dynamic getXe()
        {
            var listXe = daoXe.getXe();
            return listXe;
        }
        public dynamic getXe(int maXe)
        {
            var listXe = daoXe.getXe(maXe);
            return listXe;
        }
        public dynamic getXe(string tenXe)
        {
            var listXe = daoXe.getXe(tenXe);
            return listXe;
        }
        public List<XE> getXeTheoMaLoai(int maLoai)
        {
            List<XE> listXe = daoXe.getXeTheoMaLoai(maLoai);
            return listXe;
        }
        public XE getXe1(int maXe)
        {
            XE xe = daoXe.getXe1(maXe);
            return xe;
        }
        public int getMaXeHT()
        {
            int maXeHT = daoXe.getMaXeHT();
            return maXeHT;
        }
        public bool checkXeTonTai(int maXe)
        {
            bool exist = daoXe.checkXeTonTai(maXe);
            return exist;
        }
        public void themXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            daoXe.themXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void suaXe(int maXe, string tenXe, string bienSo, bool trangThai, int maLoai)
        {
            daoXe.suaXe(maXe, tenXe, bienSo, trangThai, maLoai);
        }
        public void xoaXe(int maXe)
        {
            daoXe.xoaXe(maXe);
        }
        public void setTTChoXeHetHD(int maXe)
        {
            daoXe.setTTChoXeHetHD(maXe);
        }
        public void setTTChoXeCoHD(int maXe)
        {
            daoXe.setTTChoXeCoHD(maXe);
        }
        public int? CheckXeDaThue(int maxe)
        {
            int? check = daoXe.CheckXeDaThue(maxe);
            return check;
        }
        public void ListVehicle(DataGridView dg, int TypeID)
        {
            dg.DataSource = daoXe.ListVehicle(TypeID);
        }
        /////////////////////////////////////////////////
        public bool kTraMaXeTrung(int maXe)
        {
            bool exist = daoXe.kTraMaXeTrung(maXe);
            return exist;
        }
        public bool kTraXeHopDong(int maXe)
        {
            bool exist = daoXe.kTraXeHopDong(maXe);
            return exist;
        }
    }
}
