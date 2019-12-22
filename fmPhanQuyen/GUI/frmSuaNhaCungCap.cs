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
    public partial class frmSuaNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaNhaCungCap()
        {
            InitializeComponent();
        }
        public frmSuaNhaCungCap(NhaCungCap kq)
        {
            InitializeComponent();
            txtMaNCC.Text=kq.MaNCC;
            txtTenNCC.Text=kq.TenNCC;
            txtNguoiLienHe.Text=kq.NguoiLienHe;
            txtChucVu.Text=kq.ChucVu;
            txtDiaChi.Text=kq.DiaChi;
            txtDienThoai.Text=kq.DienThoai;
            txtDiDong.Text=kq.DiDong;
            txtFax.Text=kq.Fax;
            LoadComboKhuVuc();
            cbKhuVuc.Text = kq.MaKhuVuc;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCap kq = ChuyenSangDTO();
            XL_NHACUNGCAP.SuaNhaCungCap(kq);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        NhaCungCap ChuyenSangDTO()
        {
            NhaCungCap kq = new NhaCungCap();
            kq.MaNCC = txtMaNCC.Text;
            kq.TenNCC = txtTenNCC.Text;
            kq.NguoiLienHe = txtNguoiLienHe.Text;
            kq.ChucVu = txtChucVu.Text;
            kq.DiaChi = txtDiaChi.Text;
            kq.DienThoai = txtDienThoai.Text;
            kq.DiDong = txtDiDong.Text;
            kq.Fax = txtFax.Text;
            kq.MaKhuVuc = cbKhuVuc.GetItemText(cbKhuVuc.SelectedValue);
            kq.ConQL = XL_NUTCHECK.Check(checkConQL);
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