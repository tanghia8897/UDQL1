using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using fmPhanQuyen.DAO;
using fmPhanQuyen.DTO;
using fmPhanQuyen.BUS;

namespace fmPhanQuyen.GUI
{
    public partial class frmSuaHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaHangHoa()
        {
            InitializeComponent();
        }

        public frmSuaHangHoa(HangHoa kq)
        {
            InitializeComponent();
            txtMaHang.Text = kq.MaHang;
            txtMaVach.Text = kq.MaVach;
            txtTenHang.Text = kq.TenHang;
            txtSoLuong.Text = kq.SoLuong.ToString();
            txtGiaMua.Text = kq.GiaMua.ToString();
            txtGiaBanSi.Text = kq.GiaBanLe.ToString();
            txtGiaBanLe.Text = kq.GiaBanLe.ToString();
        }

        private void frmSuaHangHoa_Load(object sender, EventArgs e)
        {
            LoadComboLoaiHang();
            LoadComboKhoHang();
            LoadComboDonVi();
            LoadComboNhaCungCap();
        }

        public void LoadComboLoaiHang()
        {
            cbLoaiHangHoa.DataSource = XL_HANGHOA.LoadTenNhomHang();
            cbLoaiHangHoa.DisplayMember = "Ten";
            cbLoaiHangHoa.ValueMember = "Ma";
        }


        public void LoadComboKhoHang()
        {
            cbKhoMacDinh.DataSource = XL_HANGHOA.LoadKhoHang();
            cbKhoMacDinh.DisplayMember = "Ten";
            cbKhoMacDinh.ValueMember = "Ma";
        }


        public void LoadComboDonVi()
        {
            cbDonVi.DataSource = XL_HANGHOA.LoadDonVi();
            cbDonVi.DisplayMember = "Ten";
            cbDonVi.ValueMember = "Ma";
        }



        public void LoadComboNhaCungCap()
        {
            cbNCC.DataSource = XL_HANGHOA.LoadNhaCungCap();
            cbNCC.DisplayMember = "TenNhaCungCap";
            cbNCC.ValueMember = "MaSo";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HangHoa hh = ChuyenSangDTO();
            XL_HANGHOA.SuaHangHoa(hh);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        HangHoa ChuyenSangDTO()
        {
            HangHoa kq = new HangHoa();
            kq.MaHang = txtMaHang.Text;
            kq.TinhChat = cbTinhChat.GetItemText(cbTinhChat.SelectedItem);
            kq.MaKhoHang = cbKhoMacDinh.GetItemText(cbKhoMacDinh.SelectedValue);
            kq.MaNhomHang = cbLoaiHangHoa.GetItemText(cbLoaiHangHoa.SelectedValue);
            kq.MaVach = txtMaVach.Text;
            kq.TenHang = txtTenHang.Text;
            kq.MaDonViTinh = cbDonVi.GetItemText(cbDonVi.SelectedValue);
            kq.TonKhoToiThieu = int.Parse(cbTonKhoToiThieu.Text);
            kq.SoLuongTon = int.Parse(cbTonHienTai.Text);
            kq.MaNCC = cbNCC.GetItemText(cbNCC.SelectedValue);
            kq.GiaMua = float.Parse(txtGiaMua.Text);
            kq.GiaBanSi = float.Parse(txtGiaBanSi.Text);
            kq.GiaBanLe = float.Parse(txtGiaBanLe.Text);
            kq.ConQuanLi = XL_NUTCHECK.Check(checkConQL);
            kq.SoLuong = int.Parse(txtSoLuong.Text);
            return kq;
        }
    }
}