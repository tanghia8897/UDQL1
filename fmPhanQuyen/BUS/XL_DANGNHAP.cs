using fmPhanQuyen.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.BUS
{
    class XL_DANGNHAP
    {
        public static int KiemTraDangNhap(string username, string password)
        {
            string sql = "KTDangNhap";
            SqlParameter kq = new SqlParameter("@kq", SqlDbType.Int);
            kq.Direction = ParameterDirection.Output;
            XL_DULIEU.ThucThi(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@username", Value = username },
                new SqlParameter { ParameterName = "@passwword", Value = password }, kq);

            return (int)kq.Value;//trả ra kq 1 và 0 theo stored
        }
    }
}
