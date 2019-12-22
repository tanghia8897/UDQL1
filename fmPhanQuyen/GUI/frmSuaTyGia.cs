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
    public partial class frmSuaTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmSuaTyGia()
        {
            InitializeComponent();
        }

        public frmSuaTyGia(TyGia kq)
        {
            InitializeComponent();
            txtMa.Text = kq.Ma;
            txtTen.Text = kq.Ten;
            txtTyGiaQuyDoi.Text = kq.TyGiaQuyDoi.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            TyGia kq = ChuyenSangDTO();
            XL_TYGIA.SuaTyGia(kq);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        TyGia ChuyenSangDTO()
        {
            TyGia kq = new TyGia();
            kq.Ma = txtMa.Text;
            kq.Ten = txtTen.Text;
            kq.TyGiaQuyDoi = float.Parse(txtTyGiaQuyDoi.Text);
            kq.ConQL = XL_NUTCHECK.Check(checkConQL);
            return kq;
        }
    }
}