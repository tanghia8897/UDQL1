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
using fmPhanQuyen.DTO;
using fmPhanQuyen.DAO;
using fmPhanQuyen.BUS;

namespace fmPhanQuyen.GUI
{
    public partial class frmSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaKhachHang()
        {
            InitializeComponent();
        }
        public frmSuaKhachHang(KhachHang kq)
        {
            InitializeComponent();
            LoadComboKhuVuc();
            txtMaKH.Text = kq.MaKH;
            txtTenKH.Text = kq.TenKH;
            cbKhuVuc.SelectedValue = kq.MaKhuVuc;
            txtDiaChi.Text = kq.DiaChi;
            txtMaSoThue.Text = kq.MaSoThue;
            txtDienThoai.Text = kq.DienThoai;
            txtEmail.Text = kq.Email;
            txtTaiKhoan.Text = kq.SoTaiKhoan;
            txtNguoiLienHe.Text = kq.NguoiLienHe;
            txtFax.Text = kq.Fax;
            txtWebsite.Text = kq.Website;
            txtMobile.Text = kq.DiDong;
            txtNganHang.Text = kq.TenNganHang;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnLuu_Click(object sender, EventArgs e)
        {

            KhachHang kh = ChuyenSangDTO();
            XL_KHACHHANG.SuaKhachHang(kh);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        KhachHang ChuyenSangDTO()
        {
            KhachHang kq = new KhachHang();
            kq.MaKH = txtMaKH.Text;
            kq.TenKH = txtTenKH.Text;
            kq.MaKhuVuc = cbKhuVuc.GetItemText(cbKhuVuc.SelectedValue);
            kq.DiaChi = txtDiaChi.Text;
            kq.MaSoThue = txtMaSoThue.Text;
            kq.Fax = txtFax.Text;
            kq.DienThoai = txtDienThoai.Text;
            kq.Email = txtEmail.Text;
            kq.SoTaiKhoan = txtTaiKhoan.Text;
            kq.NguoiLienHe = txtNguoiLienHe.Text;
            kq.DiDong = txtMobile.Text;
            kq.Website = txtWebsite.Text;
            kq.TenNganHang = txtNganHang.Text;
            kq.ConQuanLi = XL_NUTCHECK.Check(checkQuanLi);
            return kq;
        }

        public void LoadComboKhuVuc()
        {
            cbKhuVuc.DataSource = XL_KHACHHANG.LoadKhuVuc();
            cbKhuVuc.DisplayMember = "Ten";
            cbKhuVuc.ValueMember = "Ma";
        }
    }
}