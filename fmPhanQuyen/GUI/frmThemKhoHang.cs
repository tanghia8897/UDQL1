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
    public partial class frmThemKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhoHang()
        {
            InitializeComponent();
            LoaCbNguoiQL();
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhoHang kh = ChuyenSangDTO();
            XL_HANGHOA.ThemKhoHang(kh);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        KhoHang ChuyenSangDTO()
        {
            KhoHang kq = new KhoHang();
            kq.MaKho = txtMaKho.Text;
            kq.KyHieu = txtKyHieu.Text;
            kq.TenKho = txtTenKho.Text;
            kq.MaNguoiQuanLi = cbNguoiQL.GetItemText(cbNguoiQL.SelectedValue);
            kq.NguoiLienHe = txtNguoiLienHe.Text;
            kq.DiaChi = txtDiaChi.Text;
            kq.DienThoai = txtDienThoai.Text;
            kq.Fax = txtFax.Text;
            kq.Email = txtEmail.Text;
            kq.GhiChu = txtDienGiai.Text;
            kq.ConQuanLi = XL_NUTCHECK.Check(checkConQuanLi);
            return kq;
        }

        public void LoaCbNguoiQL()
        {
            cbNguoiQL.DataSource = XL_NHANVIEN.LoadNhanVien();
            cbNguoiQL.DisplayMember = "Ten";
            cbNguoiQL.ValueMember = "Ma";
        }
    }
}