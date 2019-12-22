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
    public partial class frmThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhachHang()
        {
            InitializeComponent();
            LoadComboKhuVuc();
        }

        public void LoadComboKhuVuc()
        {
            cbKhuVuc.DataSource = XL_KHACHHANG.LoadKhuVuc();
            cbKhuVuc.DisplayMember = "Ten";
            cbKhuVuc.ValueMember = "Ma";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = ChuyenSangDTO();
            XL_KHACHHANG.ThemKhachHang(kh);
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
    }
}