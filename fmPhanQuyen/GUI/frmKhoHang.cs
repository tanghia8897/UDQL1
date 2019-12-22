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

namespace fmPhanQuyen.GUI
{
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            LoadDuLieu();
        }

        private void LoadDuLieu()
        {
            gridKhoHang.DataSource = XL_KHOHANG.LayDuLieuKhoHang();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemKhoHang frm = new frmThemKhoHang();
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
                    XL_KHOHANG.XoaKhoHang(value.ToString());
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDuLieu();
                }
                else
                    XtraMessageBox.Show("Bạn chưa chọn đối tượng xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}