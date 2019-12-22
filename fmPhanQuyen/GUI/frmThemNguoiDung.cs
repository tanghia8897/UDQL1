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
    public partial class frmThemNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNguoiDung()
        {
            InitializeComponent();
            LoadComboVaiTro();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguoiDung nd = ChuyenSangDTO();
            XL_NGUOIDUNG.ThemNguoiDung(nd);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        NguoiDung ChuyenSangDTO()
        {
            NguoiDung kq = new NguoiDung();
            kq.TenNguoiDung = txtTaiKhoan.Text;
            kq.TenHienThi = txtTenNV.Text;
            kq.MatKhau = txtMatKhau.Text;
            kq.MaVaiTro = (int)cbVaiTro.SelectedValue;
            kq.KichHoat = XL_NUTCHECK.Check(checkQuanLi);
            return kq;
        }


        public void LoadComboVaiTro()
        {
            cbVaiTro.DataSource = XL_DULIEU.LayDuLieuTuBang("VAITRO");
            cbVaiTro.DisplayMember = "TenVaiTro";
            cbVaiTro.ValueMember = "MaVaiTro";
        }

       
    }
}