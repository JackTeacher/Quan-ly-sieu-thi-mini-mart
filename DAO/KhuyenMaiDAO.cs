using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhuyenMaiDAO
    {
        public KhuyenMaiDAO() { }

        public List<KhuyenMai> LayDanhSachKhuyenMai()
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = "SELECT * FROM KhuyenMai WHERE thoiGianKetThuc > GETDATE() AND thoiGianBatDau < GETDATE();";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhuyenMai khuyenMai = new KhuyenMai();

                    khuyenMai.maKhuyenMai = row["maKhuyenMai"].ToString();
                    khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                    khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                    khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                    khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                    khuyenMai.giaTri = Decimal.Parse(row["giaTri"].ToString());

                    listKhuyenMai.Add(khuyenMai);
                }
            }

            return listKhuyenMai;
        }

        public KhuyenMai LayKhuyenMaiTheoMa (string maKhuyenMai)
        {
            KhuyenMai khuyenMai = new KhuyenMai();

            string query = $"SELECT * FROM KhuyenMai WHERE maKhuyenMai = '{maKhuyenMai}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                khuyenMai.maKhuyenMai = dataTable.Rows[0]["maKhuyenMai"].ToString();
                khuyenMai.tenKhuyenMai = dataTable.Rows[0]["tenKhuyenMai"].ToString();
                khuyenMai.thoiGianBatDau = (DateTime)dataTable.Rows[0]["thoiGianBatDau"];
                khuyenMai.thoiGianKetThuc = (DateTime)dataTable.Rows[0]["thoiGianKetThuc"];
                khuyenMai.loaiGiaTri = dataTable.Rows[0]["loaiGiaTri"].ToString();
                khuyenMai.giaTri = Decimal.Parse(dataTable.Rows[0]["giaTri"].ToString());
            }

            return khuyenMai;
        }

        public int DemSoKhuyenMai()
        {
            string query = "SELECT COUNT(*) AS SoKhuyenMai FROM KhuyenMai;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoKhuyenMai"];

            return count;
        }

        public bool ThemKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = $"INSERT INTO KhuyenMai VALUES ('{khuyenMai.maKhuyenMai}', N'{khuyenMai.tenKhuyenMai}', '{khuyenMai.thoiGianBatDau}', '{khuyenMai.thoiGianKetThuc}', N'{khuyenMai.loaiGiaTri}', '{khuyenMai.giaTri}');";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaKhuyenMai(string maKhuyenMai)
        {
            string query = $"UPDATE KhuyenMai SET thoiGianKetThuc = GETDATE() WHERE maKhuyenMai = '{maKhuyenMai}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaKhuyenMai(KhuyenMai khuyenMai)
        {
            string query = $"UPDATE KhuyenMai SET tenKhuyenMai = N'{khuyenMai.tenKhuyenMai}', thoiGianBatDau = '{khuyenMai.thoiGianBatDau}', thoiGianKetThuc = '{khuyenMai.thoiGianKetThuc}', loaiGiaTri = N'{khuyenMai.loaiGiaTri}', giaTri = '{khuyenMai.giaTri}' WHERE maKhuyenMai = '{khuyenMai.maKhuyenMai}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<KhuyenMai> TimKiemKhuyenMai(string tuKhoa, string trangThai, string loaiGiaTri, string sapXep, DateTime? thoiGianBatDau, DateTime? thoiGianKetThuc)
        {
            List<KhuyenMai> listKhuyenMai = new List<KhuyenMai>();

            string query = $"SELECT * FROM KhuyenMai " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maKhuyenMai) LIKE '%{tuKhoa}%' " +
                           $"OR tenKhuyenMai COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%') " +
                           $"AND ('{loaiGiaTri}' = '' OR loaiGiaTri = N'{loaiGiaTri}')";
            
            switch (trangThai)
            {
                case "Đang diễn ra":
                    query += $" AND thoiGianKetThuc > GETDATE() AND thoiGianBatDau < GETDATE()";
                    break;
                case "Đã kết thúc":
                    query += $" AND thoiGianKetThuc <= GETDATE()";
                    break;
                case "Chưa diễn ra":
                    query += $" AND thoiGianBatDau > GETDATE() AND thoiGianKetThuc > GETDATE()";
                    break;
            }

            if (thoiGianBatDau != null && thoiGianKetThuc != null)
                query += $" AND thoiGianBatDau >= '{thoiGianBatDau}' AND thoiGianKetThuc <= '{thoiGianKetThuc}'";

            switch (sapXep)
            {
                case "Giá trị tăng dần":
                    query += $" ORDER BY giaTri ASC";
                    break;
                case "Giá trị giảm dần":
                    query += $" ORDER BY giaTri DESC";
                    break;
            }

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhuyenMai khuyenMai = new KhuyenMai();

                    khuyenMai.maKhuyenMai = row["maKhuyenMai"].ToString();
                    khuyenMai.tenKhuyenMai = row["tenKhuyenMai"].ToString();
                    khuyenMai.thoiGianBatDau = (DateTime)row["thoiGianBatDau"];
                    khuyenMai.thoiGianKetThuc = (DateTime)row["thoiGianKetThuc"];
                    khuyenMai.loaiGiaTri = row["loaiGiaTri"].ToString();
                    khuyenMai.giaTri = Decimal.Parse(row["giaTri"].ToString());

                    listKhuyenMai.Add(khuyenMai);
                }
            }

            return listKhuyenMai;
        }

        public decimal ApDungKhuyenMai(KhuyenMai khuyenMai, decimal tongTien)
        {
            if (khuyenMai.loaiGiaTri.Equals("Phần trăm"))
                return tongTien * khuyenMai.giaTri / 100;
            else
            {
                if (tongTien - (tongTien - khuyenMai.giaTri) > tongTien * 70 / 100)
                    return tongTien * 70 / 100;
                else
                    return khuyenMai.giaTri;
            }
        }
    }
}
