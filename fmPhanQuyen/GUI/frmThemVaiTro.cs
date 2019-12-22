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
    public partial class frmThemVaiTro : DevExpress.XtraEditors.XtraForm
    {
        public frmThemVaiTro()
        {
            InitializeComponent();
            HienThiGridQuyenHan();
            //DuyetGridView();
        }

        public void HienThiGridQuyenHan()
        {
            gridQuyenHan.DataSource = XL_QUYENHAN.HienThiQuyenHan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {         
            VaiTro vt = ChuyenSangDTO();
            XL_VAITRO.ThemVaiTro(vt);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        VaiTro ChuyenSangDTO()
        {
            VaiTro kq = new VaiTro();
            kq.MaVaiTro = int.Parse(txtMaVaiTro.Text);
            kq.TenVaiTro = txtTenVaiTro.Text;
            kq.DienGiai = txtDienGiai.Text;
            kq.KichHoat = XL_NUTCHECK.Check(checkKichHoat);
            return kq;
        }


        public void DuyetGridView()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                //if (((CheckBox)row.FindControl("chkboxid")).Checked)
                //{
                //    //read the label            
                //}
                int rowHandle = gridView1.GetVisibleRowHandle(i);
                if (gridView1.IsGroupRow(rowHandle))
                {
                    string text = gridView1.GetGroupRowDisplayText(rowHandle);
                    MessageBox.Show("Đây là: " + text);
                    //...
                }
                if (gridView1.IsDataRow(rowHandle))
                {
                    for (int c = 0; c < gridView1.VisibleColumns.Count; c++)
                    {
                        object v = gridView1.GetRowCellValue(rowHandle, gridView1.VisibleColumns[c]);
                        //...
                        if (v.ToString() == "True")
                            
                            MessageBox.Show("Tới");
                        else
                            MessageBox.Show(v.ToString());
                        
                    }
                }
            }
        }
    }
}