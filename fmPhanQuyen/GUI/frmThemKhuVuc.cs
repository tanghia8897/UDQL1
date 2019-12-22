﻿using System;
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
    public partial class frmThemKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmThemKhuVuc()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhuVuc kv = ChuyenSangDTO();
            XL_KHUVUC.ThemKhuVuc(kv);
            XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        KhuVuc ChuyenSangDTO()
        {
            KhuVuc kq = new KhuVuc();
            kq.MaKhuVuc = txtMaKV.Text;
            kq.TenKhuVuc = txtTenKV.Text;
            kq.GhiChu = txtGhichu.Text;
            kq.ConQuanLi = XL_NUTCHECK.Check(checkConQL);
            return kq;
        }
    }
}