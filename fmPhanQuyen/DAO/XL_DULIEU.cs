using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fmPhanQuyen.DAO
{
    class XL_DULIEU
    {
        static string chuoi_ket_noi = @"Data Source=NGHIAPC\SQLEXPRESS;Initial Catalog=NewSqlQLBH;Integrated Security=True";

        public static DataTable LayDuLieuTuBang(string tenBang)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Câu truy vấn
            string sql = "Select * from " + tenBang;
            //Tạo bộ chuyển đổi dữ liệu

            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);

            //Bảng chứa dữ liệu
            DataTable bang = new DataTable();
            //Đổ dữ liệu vào
            bo_chuyen_doi.Fill(bang);

            return bang;
        }

        public static DataTable LayDuLieu(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);

            //Tạo bộ chuyển đổi dữ liệu

            SqlDataAdapter bo_chuyen_doi = new SqlDataAdapter(sql, ket_noi);

            //Bảng chứa dữ liệu
            DataTable bang = new DataTable();
            //Đổ dữ liệu vào
            bo_chuyen_doi.Fill(bang);

            return bang;
        }

        public static int ThucThi(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi =
                new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int so_dong_anh_huong = lenh.ExecuteNonQuery();
            //Đóng kết nối
            ket_noi.Close();

            return so_dong_anh_huong;
        }

        public static int ThucThi(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            //Tạo kết nối
            SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand command = ket_noi.CreateCommand();
            command.CommandText = strSql;
            command.CommandType = cmdType;
            if (parameters != null && parameters.Length > 0)
                command.Parameters.AddRange(parameters);
            int nRow = command.ExecuteNonQuery();

            //Đóng kết nối
            ket_noi.Close();
            return nRow;

        }

        public static int ThucThiScalar(string sql)
        {
            //Tạo kết nối
            SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi);
            //Mở kết nối
            ket_noi.Open();
            SqlCommand lenh = new SqlCommand(sql, ket_noi);
            //Thực thi câu lệnh
            int dulieu = 0;
            object kq = lenh.ExecuteScalar();
            if (kq != null) dulieu = (int)kq;
            //Đóng kết nối
            ket_noi.Close();

            return dulieu;
        }
    }
}
