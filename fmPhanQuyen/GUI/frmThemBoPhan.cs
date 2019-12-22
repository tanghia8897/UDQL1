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
    public partial class frmThemBoPhan : DevExpress.XtraEditors.XtraForm
    {
        public frmThemBoPhan()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            BoPhan kq = ChuyenSangDTO();
            XL_BOPHAN.ThemBoPhan(kq);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        BoPhan ChuyenSangDTO()
        {
            BoPhan kq = new BoPhan();
            kq.Ma = txtMa.Text;
            kq.Ten = txtTen.Text;
            kq.GhiChu = txtGhiChu.Text;
            kq.ConQL = XL_NUTCHECK.Check(checkConQL);
            return kq;
        }
    }
}