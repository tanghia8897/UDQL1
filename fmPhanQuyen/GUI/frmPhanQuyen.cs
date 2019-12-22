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
    public partial class frmPhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmPhanQuyen()
        {
            InitializeComponent();
            hienthiTreeView();
            hienthiGridChucNang();
        }

        public void hienthiTreeView()
        {
            tvChucNang.Nodes.Clear();
            DataTable root = new DataTable();
            DataTable child = new DataTable();
            DataTable id = new DataTable();
            id = XL_DULIEU.LayDuLieu("select MaVaiTro from VAITRO");
            root = XL_DULIEU.LayDuLieu("select TenVaiTro from VAITRO");
            for (int i = 0; i < root.Rows.Count; i++)
            {
                tvChucNang.Nodes.Add(root.Rows[i][0].ToString());
                tvChucNang.Tag = "1";
                child = XL_DULIEU.LayDuLieu("select TenNguoiDung from  NGUOIDUNG where MaVaiTro = N'" + id.Rows[i][0] + "'");
                for (int j = 0; j < child.Rows.Count; j++)
                {
                    tvChucNang.Nodes[i].Nodes.Add(child.Rows[j][0].ToString());
                    tvChucNang.Nodes[i].Nodes[j].Tag = "2";
                }
            }
        }

        public void hienthiGridChucNang()
        {
            TreeNode curNode = tvChucNang.SelectedNode;
            gridChucNang.DataSource = XL_QUYENHAN.HienThiQuyenHan();
        }

        private void tvChucNang_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode curNode = tvChucNang.SelectedNode;
            if (curNode.Tag == "2")
            {
                string sql1 = "select nd.TenNguoiDung,vt.TenVaiTro from VAITRO vt,NGUOIDUNG nd where vt.MaVaiTro=nd.MaVaiTro and nd.TenNguoiDung=N'" + curNode.Text + "'";
                gridVaiTroChucNang.DataSource = XL_DULIEU.LayDuLieu(sql1);
                string sql2 = "select cn.TenChucNang,th.TatCa,th.TruyCap,th.Them,th.Xoa,th.Sua,th.InAn,th.Nhap,th.Xuat from VAITRO_CHUCNANG th,CHUCNANG cn,NGUOIDUNG nd where cn.ID=th.MaChucNang and nd.MaVaiTro = th.MaVaiTro and nd.TenNguoiDung = '" + curNode.Text + "'";
                gridChucNang.DataSource = XL_DULIEU.LayDuLieu(sql2);
            }
        }

        private void btnThemVaiTro_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemVaiTro frm = new frmThemVaiTro();
            frm.ShowDialog();
            hienthiTreeView();
        }

        private void btnThemNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemNguoiDung frm = new frmThemNguoiDung();
            frm.ShowDialog();
            hienthiTreeView();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


    }
}