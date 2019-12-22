using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fmPhanQuyen.DTO;
using System.Data.SqlClient;

namespace fmPhanQuyen.DAO
{
    public class XL_KHACHHANG
    {
        public static DataTable LoadMaKhachHang()
        {
            string sql = "select MaKH,TenKH from KhachHang";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static DataTable LayDuLieuKhachHang()
        {
            return XL_DULIEU.LayDuLieuTuBang("KhachHang");
        }

        public static DataTable LoadKhuVuc()
        {
            string sql = "select Ma,Ten from KhuVuc";
            return XL_DULIEU.LayDuLieu(sql);
        }

        public static void ThemKhachHang(KhachHang kh)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemKhachHang",
                 new SqlParameter { ParameterName = "@makh", Value = kh.MaKH },
                 new SqlParameter { ParameterName = "@tenkh", Value = kh.TenKH },
                 new SqlParameter { ParameterName = "@nguoilienhe", Value = kh.NguoiLienHe },
                 new SqlParameter { ParameterName = "@diachi", Value = kh.DiaChi },
                 new SqlParameter { ParameterName = "@dienthoai", Value = kh.DienThoai },
                 new SqlParameter { ParameterName = "@didong", Value = kh.DiDong },
                 new SqlParameter { ParameterName = "@fax", Value = kh.Fax },
                 new SqlParameter { ParameterName = "@email", Value = kh.Email },
                 new SqlParameter { ParameterName = "@website", Value = kh.Website },
                 new SqlParameter { ParameterName = "@masothue", Value = kh.MaSoThue },
                 new SqlParameter { ParameterName = "@sotaikhoan", Value = kh.SoTaiKhoan },
                 new SqlParameter { ParameterName = "@tennganhang", Value = kh.TenNganHang },
                 new SqlParameter { ParameterName = "@quanli", Value = kh.ConQuanLi },
                 new SqlParameter { ParameterName = "@makhuvuc", Value = kh.MaKhuVuc });
        }

        public static void XoaKhachHang(string MaKH)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "XoaKhachHang",
                 new SqlParameter { ParameterName = "@ma", Value = MaKH });
        }

        public static void SuaKhachHang(KhachHang kh)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "SuaKhachHang",
                 new SqlParameter { ParameterName = "@ma", Value = kh.MaKH },
                 new SqlParameter { ParameterName = "@ten", Value = kh.TenKH },
                 new SqlParameter { ParameterName = "@nguoilienhe", Value = kh.NguoiLienHe },
                 new SqlParameter { ParameterName = "@diachi", Value = kh.DiaChi },
                 new SqlParameter { ParameterName = "@dienthoai", Value = kh.DienThoai },
                 new SqlParameter { ParameterName = "@didong", Value = kh.DiDong },
                 new SqlParameter { ParameterName = "@fax", Value = kh.Fax },
                 new SqlParameter { ParameterName = "@email", Value = kh.Email },
                 new SqlParameter { ParameterName = "@website", Value = kh.Website },
                 new SqlParameter { ParameterName = "@masothue", Value = kh.MaSoThue },
                 new SqlParameter { ParameterName = "@nganhang", Value = kh.TenNganHang },
                 new SqlParameter { ParameterName = "@conquanly", Value = kh.ConQuanLi },
                 new SqlParameter { ParameterName = "@makhuvuc", Value = kh.MaKhuVuc },
                 new SqlParameter { ParameterName = "@sotaikhoan", Value = kh.SoTaiKhoan });
        }

    }
}
