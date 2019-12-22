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
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            gridTyGia.DataSource = XL_TYGIA.LayDuLieuTyGia();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemTyGia frm = new frmThemTyGia();
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
                    XL_TYGIA.XoaTyGia(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TyGia nv = TruyenDuLieu();
            frmSuaTyGia frm = new frmSuaTyGia(nv);
            frm.ShowDialog();
            LoadDuLieu();
        }
        private TyGia TruyenDuLieu()
        {
            TyGia kq = new TyGia();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "Ma");
            object Ten = gridView1.GetRowCellValue(row_index, "Ten");
            object TyGiaQuyDoi = gridView1.GetRowCellValue(row_index, "TyGiaQuyDoi");
            kq.Ma = Ma.ToString();
            kq.Ten = Ten.ToString();
            kq.TyGiaQuyDoi = float.Parse(TyGiaQuyDoi.ToString());        
            return kq;
        }
    }
}