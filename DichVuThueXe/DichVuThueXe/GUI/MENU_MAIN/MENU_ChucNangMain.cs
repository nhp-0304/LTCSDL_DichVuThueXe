using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DichVuThueXe.BUS;
using DichVuThueXe.GUI;
using DichVuThueXe.GUI.MENU_MAIN.NHANVIEN;
using DichVuThueXe.PRINT;

namespace DichVuThueXe.GUI
{
    public partial class MENU_ChucNangMain : Form
    {
        BUS_NHANVIEN_TAIKHOAN bUS_NHANVIEN_TAIKHOAN;
        BUS_NHANVIEN bUS_NHANVIEN;
        BUS_HOPDONG bUS_HOPDONG;
        BUS_HOADON bUS_HOADON;
        BUS_XE bUS_XE;
        public static NHANVIEN_TAIKHOAN nv_tkCur;
        private static HOPDONG hdgCur;
        private bool clickGridV_HDG = false;
        private bool clickGridV_HDon = false;
        private static int maNVHT = 0;
        private bool unCheckedAllNV = true;
        private CheckBox checkboxHeaderNV;
        BUS_KHACHHANG busNV;
        BUS_KHACHHANG_TAIKHOAN busNVTaiKhoan;

        public MENU_ChucNangMain()
        {
            InitializeComponent();
            bUS_NHANVIEN = new BUS_NHANVIEN();
            bUS_NHANVIEN_TAIKHOAN = new BUS_NHANVIEN_TAIKHOAN();
            bUS_HOPDONG = new BUS_HOPDONG();
            bUS_HOADON = new BUS_HOADON();
            bUS_XE = new BUS_XE();
            nv_tkCur = Form1.getTK_NVCur();
            //LOAD NHAN VIEN CUR LEN GIAO DIEN
            NHANVIEN nvCur = bUS_NHANVIEN.getNVFromTK(nv_tkCur);
            if(nv_tkCur.Vitri == 1)
                lblChucvuNVTruc.Text = "Nhân viên";
            else
                if (nv_tkCur.Vitri == 2)
                    lblChucvuNVTruc.Text = "Quản trị viên";
                else
                    if (nv_tkCur.Vitri == 0)
                        lblChucvuNVTruc.Text = "Nhân viên - BANNED";
            lblTenNVTruc.Text = nvCur.TenNV.ToString();

            busNV = new BUS_KHACHHANG();
            busNVTaiKhoan = new BUS_KHACHHANG_TAIKHOAN();

            /////////////////////////////////////////// KH
            this.txtTimKiemNV.ForeColor = Color.Gray;
            this.txtTimKiemNV.Text = " Tìm kiếm trên bảng";
            this.txtTimKiemNV.Leave += new System.EventHandler(this.txtTimKiemNV_Leave);
            this.txtTimKiemNV.Enter += new System.EventHandler(this.txtTimKiemNV_Enter);

        }

        private void MENU_ChucNangMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hTTX_DataSet.HOPDONG' table. You can move, or remove it, as needed.
            loadGrid_HOADON();
            // TODO: This line of code loads data into the 'hTTX_DataSet.HOADON' table. You can move, or remove it, as needed.
            loadGrid_HOPDONG();

            //Load report doanh thu
            this.rpV_DoanhThuTheoTG.RefreshReport();
            this.rpV_CTHDTheoNgay.RefreshReport();

            /////////////////////////////////////////// KH
            this.loadDataTableNV();
            this.initInputNV();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            DataGridViewCheckBoxColumn checkBoxColumnNV = new DataGridViewCheckBoxColumn();
            checkBoxColumnNV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumnNV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbNV.Columns.Insert(0, checkBoxColumnNV);
        }

        //ĐẶT XE
        private void btnDatXe_Click(object sender, EventArgs e)
        {

            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                this.Hide();
                MENU_ChucNang_DatXe FMenu_Datxe = new MENU_ChucNang_DatXe();
                FMenu_Datxe.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        //QUẢN TRỊ
        private void btnQuantri_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 2)
            {
                MENU_ChucNang_Quantrivien FMenu_Quantri = new MENU_ChucNang_Quantrivien();
                FMenu_Quantri.ShowDialog();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //THEO DÕI HOÁ ĐƠN
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                try
                {
                    if (clickGridV_HDon != false)
                    {
                        int index = gridV_HOADON.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                        string cell = gridV_HOADON.Rows[index].Cells[1].Value.ToString().Trim(); // Lấy mã hợp đồng
                        HOPDONG hdg = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(cell));
                        if (bUS_HOADON.getHoaDonFromMaHDG(hdg.MaHDG).Trangthai != true)
                        {
                            bUS_HOADON.capNhatNgayIn_ThanhToan(int.Parse(cell));
                            bUS_HOADON.hoaDon_Thanhtoan(int.Parse(cell));
                            bUS_HOPDONG.hopDong_Thanhtoan(int.Parse(cell));
                            Print pr = new Print(hdg);
                            loadGrid_HOADON();
                            loadGrid_HOPDONG();
                        }
                        else
                            MessageBox.Show("Hoá đơn đã được thanh toán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Chọn hoá đơn để thanh toán !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                { }
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //BÁO CÁO DOANH THU
        private void btn_xemBC_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                DateTime ngayBD = dtP_NgayBD.Value;
                DateTime ngayKT = dtP_NgayKT.Value;

                this.reportHDByNgayBDandNgayKTTableAdapter.Fill(this.dataSet.reportHDByNgayBDandNgayKT,ngayBD, ngayKT);
                this.rpV_DoanhThuTheoTG.RefreshReport();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //BÁO CÁO CHI TIẾT HỢP ĐỒNG THEO NGÀY
        private void btnXem_CTHDG_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                try
                {
                    DateTime ngayCTHDG = dtP_NgayCTHDG.Value;
                    this.reportChiTietHDG_TheoNgayTableAdapter.Fill(this.dataSet.reportChiTietHDG_TheoNgay, ngayCTHDG.Date);
                    this.rpV_CTHDTheoNgay.RefreshReport();
                }
                catch
                { }
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //SWITCH TAB
        private void btnQuanLyKH_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(2);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(3);
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            loadGrid_HOADON();
            tabControl_Main.SelectTab(0);
        }
        private void btnBC_CTHD_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectTab(4);
        }
        private void gridV_HOADON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clickGridV_HDon = true;
                int index = gridV_HOADON.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                string cell = gridV_HOADON.Rows[index].Cells[1].Value.ToString().Trim(); //xxx tương ứng với column trong datagridview của bạn, và column đầu tiên có thứ tự là 0.
                HOPDONG hdg = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(cell));
            }
            catch
            { }
        }

        //HOP DONG
        private void btnSuaHDG_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                if(clickGridV_HDG != false)
                    if (hdgCur.Trangthai != true)
                    {
                        try
                        {
                            MENU_SuaHopDong shd = new MENU_SuaHopDong();
                            shd.ShowDialog();
                        }
                        catch
                        {
                            MessageBox.Show("Chọn hợp đồng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                        MessageBox.Show("Hợp đồng này đã được thanh toán!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Chọn hợp đồng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXuLyHDG_Click(object sender, EventArgs e)
        {
            loadGrid_HOPDONG();
            tabControl_Main.SelectTab(1);
        }

        private void gridV_HOPDONG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                clickGridV_HDG = true; // LỖI KHI KO CLICK VÀO - fix
                int index = gridV_HOPDONG.CurrentCell.RowIndex; //lấy ra chỉ số của row đang đc chọn
                string cell = gridV_HOPDONG.Rows[index].Cells[0].Value.ToString().Trim();
                hdgCur = bUS_HOPDONG.getHopDongFromMaHDG(int.Parse(cell));
            } 
            catch
            {
            }
        }
        private void btnRefreshHD_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                loadGrid_HOPDONG();
                loadGrid_HOADON();
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnXoaHDG_Click(object sender, EventArgs e)
        {
            if (nv_tkCur.Vitri == 1 || nv_tkCur.Vitri == 2)
            {
                if (clickGridV_HDG != false)
                {
                    int maXe_stamp = hdgCur.Maxe;
                    if (bUS_HOPDONG.deleteHDG_HD(hdgCur.MaHDG) == 1)
                    {
                        bUS_XE.setTTChoXeHetHD(maXe_stamp);
                        MessageBox.Show("Hợp đồng này đã xoá thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        loadGrid_HOPDONG();
                        loadGrid_HOADON();
                    }
                    else
                        MessageBox.Show("Hợp đồng này đã được thanh toán, không thể xoá!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Chọn hợp đồng để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Bạn không đủ quyền để vào chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        //TRẢ VỀ HỢP ĐỒNG CẦN SỬA
        public static HOPDONG HopDongCurrentToEdit()
        {
            return hdgCur;
        }

        //Reload gridView HOADON
        public void loadGrid_HOADON()
        {
            bUS_HOADON = new BUS_HOADON();
            gridV_HOADON.DataSource = bUS_HOADON.getHoaDon();
            LoadGrid_HD();
        }
        public void loadGrid_HOPDONG()
        {
            bUS_HOPDONG = new BUS_HOPDONG();
            gridV_HOPDONG.DataSource = bUS_HOPDONG.getHopDong();
            loadGrid_HDG();
        }
        public void LoadGrid_HD()
        {
            gridV_HOADON.Columns[0].Width = (int)(gridV_HOADON.Width * 0.1);
            gridV_HOADON.Columns[1].Width = (int)(gridV_HOADON.Width * 0.15);
            gridV_HOADON.Columns[2].Width = (int)(gridV_HOADON.Width * 0.2);
            gridV_HOADON.Columns[3].Width = (int)(gridV_HOADON.Width * 0.2);
            gridV_HOADON.Columns[4].Width = (int)(gridV_HOADON.Width * 0.2);
            gridV_HOADON.Columns[5].Width = (int)(gridV_HOADON.Width * 0.12);
        }
        public void loadGrid_HDG()
        {
            gridV_HOPDONG.Columns[0].Width = (int)(gridV_HOPDONG.Width * 0.08);
            gridV_HOPDONG.Columns[1].Width = (int)(gridV_HOPDONG.Width * 0.08);
            gridV_HOPDONG.Columns[2].Width = (int)(gridV_HOPDONG.Width * 0.08);
            gridV_HOPDONG.Columns[3].Width = (int)(gridV_HOPDONG.Width * 0.1);
            gridV_HOPDONG.Columns[4].Width = (int)(gridV_HOPDONG.Width * 0.1);
            gridV_HOPDONG.Columns[5].Width = (int)(gridV_HOPDONG.Width * 0.2);
            gridV_HOPDONG.Columns[6].Width = (int)(gridV_HOPDONG.Width * 0.2);
            gridV_HOPDONG.Columns[7].Width = (int)(gridV_HOPDONG.Width * 0.12);
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }


        //////////////////////////////////////////////

        public void initInputNV()
        {
            maNVHT = busNV.getMaNVHT();
            var nv = busNV.getNV1(maNVHT);
            this.txtMaNV.Text = nv.MaKH.ToString();
            this.txtTenNV.Text = nv.Ten;
            this.txtCMND.Text = nv.CMND;
            this.txtGioiTinh.Text = nv.Gioitinh;
            this.dtpNgaySinh.Value = (DateTime)nv.Ngaysinh;
            this.txtDiaChi.Text = nv.Diachi;
            this.txtSDT.Text = nv.SDT;
        }

        public void loadDataTableNV()
        {
            this.busNV = new BUS_KHACHHANG();
            this.tbNV.DataSource = busNV.getNV();
        }

        public void loadDataTableNV(int maNV)
        {
            this.busNV = new BUS_KHACHHANG();
            this.tbNV.DataSource = busNV.getNV(maNV);
        }

        public void loadDataTableNV(string tenNV)
        {
            this.busNV = new BUS_KHACHHANG();
            this.tbNV.DataSource = busNV.getNV(tenNV);
        }

        private void tbNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.tbNV.SelectedCells.Count == 0)
            {
                if (e.RowIndex >= 0)
                {
                    if ((bool)this.tbNV[0, e.RowIndex].Value)
                    {
                        this.tbNV[0, e.RowIndex].Value = false;
                        foreach (DataGridViewRow r in this.tbNV.Rows)
                        {
                            if ((bool)r.Cells[0].Value)
                            {
                                unCheckedAllNV = false;
                                break;
                            }
                        }
                        checkboxHeaderNV.Checked = false;
                    }
                    else
                    {
                        this.tbNV[0, e.RowIndex].Value = true;
                        bool check = true;
                        foreach (DataGridViewRow r in this.tbNV.Rows)
                        {
                            if (!((bool)r.Cells[0].Value))
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check)
                        {
                            checkboxHeaderNV.Checked = true;
                        }
                    }
                }
            }

            try
            {
                DataGridViewRow row = this.tbNV.Rows[e.RowIndex];
                if (Convert.ToBoolean(row.Cells[0].Value) || row.Cells[0].Selected)
                {
                    this.tbNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                    this.tbNV.Rows[e.RowIndex].Selected = true;
                }
            }
            catch (Exception ex) { }

            try
            {
                if (this.tbNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    this.tbNV.CurrentRow.Selected = true;
                    this.txtMaNV.Text = this.tbNV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    this.txtTenNV.Text = this.tbNV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    this.txtCMND.Text = this.tbNV.Rows[e.RowIndex].Cells[3].Value.ToString();
                    this.txtGioiTinh.Text = this.tbNV.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.dtpNgaySinh.Value = (DateTime)this.tbNV.Rows[e.RowIndex].Cells[5].Value;
                    this.txtDiaChi.Text = this.tbNV.Rows[e.RowIndex].Cells[6].Value.ToString();
                    this.txtSDT.Text = this.tbNV.Rows[e.RowIndex].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chỉ chọn dòng tương ứng", "Cảnh báo!");
            }
        }

        private void txtTimKiemNV_Leave(object sender, EventArgs e)
        {
            if (this.txtTimKiemNV.Text == "")
            {
                this.txtTimKiemNV.Text = " Tìm kiếm trên bảng";
                this.txtTimKiemNV.ForeColor = Color.Gray;
            }
        }

        private void txtTimKiemNV_Enter(object sender, EventArgs e)
        {
            if (this.txtTimKiemNV.Text == " Tìm kiếm trên bảng")
            {
                this.txtTimKiemNV.Text = "";
                this.txtTimKiemNV.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemNV_MouseClick(object sender, MouseEventArgs e)
        {
            this.toolTipTimKiemNV.SetToolTip(this.txtTimKiemNV, "Nhấn Enter để tìm kiếm nếu chứa ký tự có dấu.");
        }

        private void txtTimKiemNV_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtTimKiemNV.Text) || string.IsNullOrEmpty(this.txtTimKiemNV.Text) && Convert.ToInt32(e.KeyCode) == 8)
                this.loadDataTableNV();
            if (!(string.IsNullOrWhiteSpace(this.txtTimKiemNV.Text) && string.IsNullOrEmpty(this.txtTimKiemNV.Text)))
            {
                if (this.IsNumber(this.txtTimKiemNV.Text))
                    this.loadDataTableNV(int.Parse(this.txtTimKiemNV.Text));
                if (!this.IsNumber(this.txtTimKiemNV.Text))
                    this.loadDataTableNV(this.txtTimKiemNV.Text.Trim());
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (this.isNVInputNotNull())
            {
                if (this.isNVInputExactly())
                {
                    if (this.busNV.kTraMaNVTrung(int.Parse(this.txtMaNV.Text)))
                    {
                        int maNV = int.Parse(this.txtMaNV.Text);
                        string tenNV = this.txtTenNV.Text;
                        string cmnd = this.txtCMND.Text;
                        string gioiTinh = this.txtGioiTinh.Text;
                        DateTime ngaySinh = this.dtpNgaySinh.Value;
                        string diaChi = this.txtDiaChi.Text;
                        string sdt = this.txtSDT.Text;
                        try
                        {
                            busNV.suaNV(maNV, tenNV, cmnd, gioiTinh, ngaySinh, diaChi, sdt);
                            MessageBox.Show("Sửa thành công!!!", "Thông báo");
                            this.resetTextBoxNV(maNV);
                            this.loadDataTableNV();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Sửa thất bại!!!", "Lỗi!");
                        }
                    }
                    else
                        MessageBox.Show("Mã khách hàng không tồn tại!", "Không thể sửa!");
                }
                else
                    MessageBox.Show("Thông tin không hợp lệ!", "Không thể sửa!");
            }
            else
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            bool checkBoxCells = false;
            bool checkNVHopDong = false;
            for (int i = this.tbNV.RowCount - 1; i >= 0; i--)
            {
                DataGridViewRow row = this.tbNV.Rows[i];
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkBoxCells = true;
                    if (this.busNV.kTraNVHopDong(Convert.ToInt32(row.Cells[1].Value)))
                    {
                        checkNVHopDong = true;
                        break;
                    }
                }
            }
            if (checkBoxCells)
            {
                if (!checkNVHopDong)
                {
                    bool checkXoa = true;
                    if (MessageBox.Show("Xác nhận xóa những khách hàng đã lựa chọn? (Bao gồm tài khoản của khách hàng đó)", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = this.tbNV.RowCount - 1; i >= 0; i--)
                        {
                            DataGridViewRow row = this.tbNV.Rows[i];
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                try
                                {
                                    int maNV = Convert.ToInt32(row.Cells[1].Value);
                                    busNVTaiKhoan.xoaNVTaiKhoan(maNV);
                                    busNV.xoaNV(maNV);
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show("Xóa thất bại!!!", "Lỗi!");
                                    checkXoa = false;
                                    this.btnRefreshNV_Click(sender, e);
                                }
                            }
                        }
                    }
                    if (checkXoa)
                    {
                        MessageBox.Show("Xóa thành công!!!", "Thông báo");
                        this.btnRefreshNV_Click(sender, e);
                    }
                }
                else
                    MessageBox.Show("Tồn tại khách hàng có hợp đồng trong các lựa chọn.", "Không thể xóa!");
            }
            else
                MessageBox.Show("Bạn chưa lựa chọn dòng để xóa!", "Thông báo");
        }

        private void btnRefreshNV_Click(object sender, EventArgs e)
        {
            this.txtTimKiemNV.ForeColor = Color.Gray;
            this.txtTimKiemNV.Text = " Tìm kiếm trên bảng";

            maNVHT = busNV.getMaNVHT();

            this.txtMaNV.Text = null;
            this.txtTenNV.Text = null;
            this.txtCMND.Text = null;
            this.txtGioiTinh.Text = null;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.txtDiaChi.Text = null;
            this.txtSDT.Text = null;

            this.loadDataTableNV();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            MENU_ChucNang_KHTaiKhoan FMenu_ChucNang_KHTaiKhoan = new MENU_ChucNang_KHTaiKhoan();
            FMenu_ChucNang_KHTaiKhoan.ShowDialog();
        }

        public void resetTextBoxNV(int maNV)
        {
            var nv = busNV.getNV(maNV).First();
            this.txtMaNV.Text = nv.MaKH.ToString();
            this.txtTenNV.Text = nv.Ten;
            this.txtCMND.Text = nv.CMND;
            this.txtGioiTinh.Text = nv.Gioitinh;
            this.dtpNgaySinh.Value = (DateTime)nv.Ngaysinh;
            this.txtDiaChi.Text = nv.Diachi;
            this.txtSDT.Text = nv.SDT;
        }

        public bool isNVInputNotNull()
        {
            if (string.IsNullOrWhiteSpace(this.txtMaNV.Text) || string.IsNullOrWhiteSpace(this.txtTenNV.Text) || string.IsNullOrWhiteSpace(this.txtCMND.Text) ||
                string.IsNullOrWhiteSpace(this.txtGioiTinh.Text) || string.IsNullOrWhiteSpace(this.txtDiaChi.Text) || string.IsNullOrWhiteSpace(this.txtSDT.Text))
                return false;
            return true;
        }

        public bool isNVInputExactly()
        {
            if (!this.IsNumber(this.txtCMND.Text) || this.dtpNgaySinh.Value > DateTime.Now || !this.IsNumber(this.txtSDT.Text))
                return false;
            return true;
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
