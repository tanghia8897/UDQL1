using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fmPhanQuyen.DAO;
using System.Data.SqlClient;
using fmPhanQuyen.DTO;


namespace fmPhanQuyen.DAO
{
    class XL_NGUOIDUNG
    {
        public DataTable LayDuLieuNguoiDung()
        {
            return XL_DULIEU.LayDuLieuTuBang("NGUOIDUNG");
        }
        public static void ThemNguoiDung(NguoiDung nd)
        {
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, "ThemNguoiDung",
               new SqlParameter { ParameterName = "@tennd", Value = nd.TenNguoiDung },
               new SqlParameter { ParameterName = "@tenhienthi", Value = nd.TenHienThi },
               new SqlParameter { ParameterName = "@matkhau", Value = nd.MatKhau },
               new SqlParameter { ParameterName = "@kichhoat", Value = nd.KichHoat },
               new SqlParameter { ParameterName = "@mavaitro", Value = nd.MaVaiTro });
        }

        //lấy mã vai trò người dùng khi đã đăng nhập thành công
        public static int LayMaVaiTroNguoiDung(string username,string passwword)
        {
            string sql = "select nd.MaVaiTro from NGUOIDUNG nd where nd.TenNguoiDung='" + username + "' and nd.MatKhau='" + passwword + "'";
            return XL_DULIEU.ThucThiScalar(sql);
        }

    }
}
