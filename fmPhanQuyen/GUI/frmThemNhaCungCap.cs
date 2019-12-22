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
    public partial class frmThemNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhaCungCap kq = ChuyenSangDTO();
            XL_NHACUNGCAP.ThemNhaCungCap(kq);
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

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadComboKhuVuc();
        }
    }
}