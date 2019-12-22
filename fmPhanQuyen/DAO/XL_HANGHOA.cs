using fmPhanQuyen.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    public class XL_HANGHOA
    {
        public static DataTable LoadTenNhomHang()
        {
            string sql = "select Ma,Ten from NhomHang";
            return XL_DULIEU.LayDuLieu(sql);
        }


        public static DataTable LoadKhoHang()
        {
            string sql = "select Ma,Ten from KhoHang";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LoadDonVi()
        {
            string sql = "select Ma,Ten from DonViTinh";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LoadNhaCungCap()
        {
            string sql = "select MaSo,TenNhaCungCap from NhaCungCap";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LoadNhomHang()
        {
            string sql = "select Ma,Ten from NhomHang";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LoadHangHoa()
        {
            return XL_DULIEU.LayDuLieuTuBang("HangHoa");
        }

        public static void ThemKhoHang(KhoHang kho)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemKhoHang",
                new SqlParameter { ParameterName = "@makho", Value = kho.MaKho },
                new SqlParameter { ParameterName = "@tenkho", Value = kho.TenKho },
                new SqlParameter { ParameterName = "@nguoilienhe", Value = kho.NguoiLienHe },
                new SqlParameter { ParameterName = "@diachi", Value = kho.DiaChi },
                new SqlParameter { ParameterName = "@dienthoai", Value = kho.DienThoai },
                new SqlParameter { ParameterName = "@fax", Value = kho.Fax },
                new SqlParameter { ParameterName = "@email", Value = kho.Email },
                new SqlParameter { ParameterName = "@kyhieu", Value = kho.KyHieu },
                new SqlParameter { ParameterName = "@conquanli", Value = kho.ConQuanLi },
                new SqlParameter { ParameterName = "@manguoiquanli", Value = kho.MaNguoiQuanLi },
                new SqlParameter { ParameterName = "@ghichu", Value = kho.GhiChu });
        }


        public static void ThemHangHoa(HangHoa h)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemHangHoa",
                new SqlParameter { ParameterName = "@ma", Value = h.MaHang },
                new SqlParameter { ParameterName = "@ten", Value = h.TenHang },
                new SqlParameter { ParameterName = "@giamua", Value = h.GiaMua },
                new SqlParameter { ParameterName = "@giabansi", Value = h.GiaBanSi},
                new SqlParameter { ParameterName = "@giabanle", Value = h.GiaBanLe },
                new SqlParameter { ParameterName = "@tinhchat", Value = h.TinhChat },
                new SqlParameter { ParameterName = "@conquanli", Value = h.ConQuanLi },
                new SqlParameter { ParameterName = "@mavach", Value = h.MaVach },
                new SqlParameter { ParameterName = "@manhomhang", Value = h.MaNhomHang },
                new SqlParameter { ParameterName = "@makhohang", Value = h.MaKhoHang },
                new SqlParameter { ParameterName = "@madonvi", Value = h.MaDonViTinh },
                new SqlParameter { ParameterName = "@soluong", Value = h.SoLuong },
                new SqlParameter { ParameterName = "@soluongton", Value = h.SoLuongTon },
                new SqlParameter { ParameterName = "@tonkhotoithieu", Value = h.TonKhoToiThieu },
                new SqlParameter { ParameterName = "@maNCC", Value = h.MaNCC });
        }

        public static void XoaHangHoa(string Ma)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaHangHoa",
                 new SqlParameter { ParameterName = "@ma", Value = Ma });
        }

        public static void SuaHangHoa(HangHoa h)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaHangHoa",
                new SqlParameter { ParameterName = "@ma", Value = h.MaHang },
                new SqlParameter { ParameterName = "@ten", Value = h.TenHang },
                new SqlParameter { ParameterName = "@giamua", Value = h.GiaMua },
                new SqlParameter { ParameterName = "@giabansi", Value = h.GiaBanSi },
                new SqlParameter { ParameterName = "@giabanle", Value = h.GiaBanLe },
                new SqlParameter { ParameterName = "@tinhchat", Value = h.TinhChat },
                new SqlParameter { ParameterName = "@conquanly", Value = h.ConQuanLi },
                new SqlParameter { ParameterName = "@mavach", Value = h.MaVach },
                new SqlParameter { ParameterName = "@manhomhang", Value = h.MaNhomHang },
                new SqlParameter { ParameterName = "@makhohang", Value = h.MaKhoHang },
                new SqlParameter { ParameterName = "@madonvitinh", Value = h.MaDonViTinh },
                new SqlParameter { ParameterName = "@soluong", Value = h.SoLuong },
                new SqlParameter { ParameterName = "@soluongton", Value = h.SoLuongTon },
                new SqlParameter { ParameterName = "@tonkhotoithieu", Value = h.TonKhoToiThieu },
                new SqlParameter { ParameterName = "@manhacungcap", Value = h.MaNCC });
        }

    }
}
