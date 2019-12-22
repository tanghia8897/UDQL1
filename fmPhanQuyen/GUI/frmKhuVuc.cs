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
    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }
        
        private void LoadDuLieu()
        {
            gridKhuVuc.DataSource = XL_KHUVUC.LayDuLieuKhuVuc();
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemKhuVuc frm = new frmThemKhuVuc();
            frm.ShowDialog();
            LoadDuLieu();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có chắc chắn muốn xóa dòng dữ liệu đang chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                object value = gridView1.GetRowCellValue(row_index, "Ma");
                if (value != null)
                {
                    //xóa
                    XL_KHUVUC.XoaKhuVuc(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public KhuVuc LayDongHienTaiTrongGridView()
        {
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "Ma");
            object Ten = gridView1.GetRowCellValue(row_index, "Ten");
            object GhiChu = gridView1.GetRowCellValue(row_index, "GhiChu");
            object ConQL = gridView1.GetRowCellValue(row_index, "ConQuanLy");
            KhuVuc kq = new KhuVuc();
            kq.MaKhuVuc = Ma.ToString();
            kq.TenKhuVuc = Ten.ToString();
            kq.GhiChu = GhiChu.ToString();
            

               
            return kq;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhuVuc kq = TruyenDuLieu();
            frmSuaKhuVuc frm = new frmSuaKhuVuc(kq);
            frm.ShowDialog();
            LoadDuLieu();
        }
        private KhuVuc TruyenDuLieu()
        {
            KhuVuc kq = new KhuVuc();
            int row_index = gridView1.FocusedRowHandle;
            object Ma = gridView1.GetRowCellValue(row_index, "Ma");
            object Ten = gridView1.GetRowCellValue(row_index, "Ten");
            object GhiChu = gridView1.GetRowCellValue(row_index, "GhiChu");
            kq.MaKhuVuc = Ma.ToString();
            kq.TenKhuVuc = Ten.ToString();
            kq.GhiChu = GhiChu.ToString();
            return kq;
        }


    }
}