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
using fmPhanQuyen.BUS;
using fmPhanQuyen.DAO;

namespace fmPhanQuyen.GUI
{
    public partial class frmThemDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmThemDonViTinh()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DonViTinh kq = ChuyenSangDTO();
            XL_DONVITINH.ThemDonViTinh(kq);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        DonViTinh ChuyenSangDTO()
        {
            DonViTinh kq = new DonViTinh();
            kq.Ma = txtMa.Text;
            kq.Ten = txtTen.Text;
            kq.GhiChu = txtGhiChu.Text;
            kq.ConQL = XL_NUTCHECK.Check(checkConQL);
            return kq;
        }
    }
}