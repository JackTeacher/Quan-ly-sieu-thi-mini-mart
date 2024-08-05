using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        public LoaiSanPhamDAO() { }

        public List<LoaiSanPham> LayDanhSachLoaiSanPham()
        {
            List<LoaiSanPham> listLoaiSanPham = new List<LoaiSanPham>();

            string query = "SELECT * FROM LoaiSanPham WHERE trangThai = N'Đang sử dụng';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();
                    loaiSanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                    loaiSanPham.tenLoaiSanPham = row["tenLoaiSanPham"].ToString();
                    loaiSanPham.trangThai = row["trangThai"].ToString();

                    listLoaiSanPham.Add(loaiSanPham);
                }
            }

            return listLoaiSanPham;
        }

        public LoaiSanPham LayLoaiSanPhamTheoMa(string maLoaiSanPham)
        {
            LoaiSanPham loaiSanPham = new LoaiSanPham();

            string query = $"SELECT * FROM LoaiSanPham WHERE maLoaiSanPham = '{maLoaiSanPham}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                loaiSanPham.maLoaiSanPham = dataTable.Rows[0]["maLoaiSanPham"].ToString();
                loaiSanPham.tenLoaiSanPham = dataTable.Rows[0]["tenLoaiSanPham"].ToString();
                loaiSanPham.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            }

            return loaiSanPham;
        }

        public int DemSoLoaiSanPham()
        {
            string query = "SELECT COUNT(*) AS SoLoaiSanPham FROM LoaiSanPham;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoLoaiSanPham"];

            return count;
        }

        public bool KiemTraLoaiSanPhamDaTonTai(string tenLoaiSanPham)
        {
            string query = $"SELECT tenLoaiSanPham FROM LoaiSanPham WHERE LOWER(tenLoaiSanPham) = N'{tenLoaiSanPham}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool ThemLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = $"INSERT INTO LoaiSanPham VALUES ('{loaiSanPham.maLoaiSanPham}', N'{loaiSanPham.tenLoaiSanPham}', N'Đang sử dụng');";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaLoaiSanPham(string maLoaiSanPham)
        {
            string query = $"UPDATE LoaiSanPham SET trangThai = N'Đã xóa' WHERE maLoaiSanPham = '{maLoaiSanPham}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaLoaiSanPham(LoaiSanPham loaiSanPham)
        {
            string query = $"UPDATE LoaiSanPham SET tenLoaiSanPham = N'{loaiSanPham.tenLoaiSanPham}', trangThai = N'{loaiSanPham.trangThai}' WHERE maLoaiSanPham = '{loaiSanPham.maLoaiSanPham}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<LoaiSanPham> TimKiemLoaiSanPham(string tuKhoa, string trangThai)
        {
            List<LoaiSanPham> listLoaiSanPham = new List<LoaiSanPham>();

            string query = $"SELECT * FROM LoaiSanPham " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maLoaiSanPham) LIKE '%{tuKhoa}%' OR tenLoaiSanPham COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%') " +
                           $"AND ('{trangThai}' = '' OR trangThai = N'{trangThai}');";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    LoaiSanPham LoaiSanPham = new LoaiSanPham();

                    LoaiSanPham.maLoaiSanPham = row["maLoaiSanPham"].ToString();
                    LoaiSanPham.tenLoaiSanPham = row["tenLoaiSanPham"].ToString();
                    LoaiSanPham.trangThai = row["trangThai"].ToString();

                    listLoaiSanPham.Add(LoaiSanPham);
                }
            }

            return listLoaiSanPham;
        }      
    }
}
