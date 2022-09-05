using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNang_DatXe : Form
    {
        BUS_HOADON bUS_HOADON;
        BUS_LOAIDV bUS_LOAIDV;
        BUS_XE busXe;
        BUS_KHACHHANG busKhachHang;
        BUS_NHANVIEN busNhanVien;
        BUS_HOPDONG busHopDong;
        private NHANVIEN NhanVienCurrent;
        public MENU_ChucNang_DatXe()
        {
            InitializeComponent();
            bUS_LOAIDV = new BUS_LOAIDV();
            busXe = new BUS_XE();
            busKhachHang = new BUS_KHACHHANG();
            busNhanVien = new BUS_NHANVIEN();
            busHopDong = new BUS_HOPDONG();
            bUS_HOADON = new BUS_HOADON();
            NhanVienCurrent = busNhanVien.getNVFromTK(MENU_ChucNangMain.nv_tkCur);
        }

        private void MENU_ChucNang_DatXe_Load(object sender, EventArgs e)
        {
            LoadCustomersList();
            bUS_LOAIDV.ListServiceType(cbb_LOAIDV);
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date;
        }

        private void cbb_LOAIDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadVehicleList();
            LOAIDV dv = bUS_LOAIDV.getLOAIDV((int)cbb_LOAIDV.SelectedValue);
            txtServiceID.Text = dv.MaL.ToString();
            txtPrice.Text = dv.Gia.ToString();
        }
        public void LoadVehicleList()
        {
            busXe.ListVehicle(dataViewVehicle, (int)cbb_LOAIDV.SelectedValue);
            dataViewVehicle.Columns[0].Width = (int)(dataViewVehicle.Width * 0.1);
            dataViewVehicle.Columns[1].Width = (int)(dataViewVehicle.Width * 0.35);
            dataViewVehicle.Columns[2].Width = (int)(dataViewVehicle.Width * 0.15);
            dataViewVehicle.Columns[3].Width = (int)(dataViewVehicle.Width * 0.15);
            dataViewVehicle.Columns[4].Width = (int)(dataViewVehicle.Width * 0.15);
        }
        public void LoadCustomersList()
        {
            busKhachHang.ListCustomers(dataViewCustomer);
            dataViewCustomer.Columns[0].Width = (int)(dataViewCustomer.Width * 0.1);
            dataViewCustomer.Columns[1].Width = (int)(dataViewCustomer.Width * 0.15);
            dataViewCustomer.Columns[2].Width = (int)(dataViewCustomer.Width * 0.1);
            dataViewCustomer.Columns[3].Width = (int)(dataViewCustomer.Width * 0.1);
            dataViewCustomer.Columns[4].Width = (int)(dataViewCustomer.Width * 0.1);
            dataViewCustomer.Columns[5].Width = (int)(dataViewCustomer.Width * 0.2);
            dataViewCustomer.Columns[6].Width = (int)(dataViewCustomer.Width * 0.1);
        }
        private void dataViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataViewCustomer.Rows.Count)
            {
                txtIDCustomer.Text = dataViewCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameCustomer.Text = dataViewCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCMND.Text = dataViewCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = dataViewCustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }

        private void dataViewVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataViewVehicle.Rows.Count)
            {
                txtIDCar.Text = dataViewVehicle.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCarName.Text = dataViewVehicle.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            busKhachHang.SearchCustomer(dataViewCustomer, txtSearchName.Text);
        }

        private void btnCreateContract_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDCar.Text) || String.IsNullOrEmpty(txtIDCustomer.Text))
            {
                MessageBox.Show("Mã xe và mã khách hàng không được trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dtpStart.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("Ngày bắt đầu hợp đồng không được nhỏ hơn ngày hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (dtpEnd.Value.Date <= dtpStart.Value.Date)
                    {
                        MessageBox.Show("Ngày kết thúc hợp đồng phải lớn hơn ngày bắt đầu hợp đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //MessageBox.Show("An toàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HOPDONG HopDong = new HOPDONG();
                        int ContractID = busHopDong.getMaHDG_HT() + 1;
                        HopDong.MaHDG = ContractID;
                        HopDong.Maxe = int.Parse(txtIDCar.Text);
                        HopDong.MaKH = int.Parse(txtIDCustomer.Text);
                        HopDong.MaL = int.Parse(txtServiceID.Text);
                        HopDong.MaNV = NhanVienCurrent.MaNV;
                        HopDong.NgayBD = dtpStart.Value.Date;
                        HopDong.NgayKT = dtpEnd.Value.Date;
                        HopDong.Trangthai = false;
                        if (busHopDong.AddContract(HopDong) == true)
                        {
                            int maHD = bUS_HOADON.getMaHDonHT() + 1;
                            TimeSpan kc = dtpEnd.Value.Date - dtpStart.Value.Date;
                            decimal sogio = decimal.Parse(kc.TotalHours.ToString());
                            decimal thanhtien = bUS_LOAIDV.getLOAIDV(cbb_LOAIDV.SelectedIndex + 1).Gia * (sogio / decimal.Parse("24"));
                            busXe.setTTChoXeCoHD(int.Parse(txtIDCar.Text));
                            bUS_HOADON.addHoaDon(maHD, ContractID, sogio, thanhtien,false); ;
                            MessageBox.Show("Tạo hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            initTextbox();
                        }
                        else
                        {
                            MessageBox.Show("Tạo hợp đồng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU_ChucNangMain cnm = new MENU_ChucNangMain();
            cnm.ShowDialog();
            this.Close();
        }
        private void initTextbox()
        {
            txtIDCar.Text = null;
            txtCarName.Text = null;
            txtIDCustomer.Text = null;
            txtNameCustomer.Text = null;
            txtPhone.Text = null;
            txtCMND.Text = null;
            txtSearchName.Text = null;
            txtServiceID.Text = null;
            txtPrice.Text = null;
            dtpStart.Value = DateTime.Now.Date;
            dtpEnd.Value = DateTime.Now.Date;
        }
    }
}
