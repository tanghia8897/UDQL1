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

namespace fmPhanQuyen.GUI
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        private void LoadDuLieu()
        {
            gridDonViTinh.DataSource = XL_DONVITINH.LayDuLieuDonViTinh();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemDonViTinh frm = new frmThemDonViTinh();
            frm.ShowDialog();
            LoadDuLieu();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu đang chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                object value = gridView1.GetRowCellValue(row_index, "Ma");
                if (value != null)
                {
                    //xóa
                    XL_DONVITINH.XoaDonViTinh(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonViTinh kq = TruyenDuLieu();
            frmSuaDonViTinh frm = new frmSuaDonViTinh(kq);
            frm.ShowDialog();
            LoadDuLieu();
        }
        private DonViTinh TruyenDuLieu()
        {
            DonViTinh kq = new DonViTinh();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "Ma");
            object Ten = gridView1.GetRowCellValue(row_index, "Ten");
            object GhiChu = gridView1.GetRowCellValue(row_index, "GhiChu");
            kq.Ma = Ma.ToString();
            kq.Ten = Ten.ToString();
            kq.GhiChu = GhiChu.ToString();
            return kq;
        }

    }
}