using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachHang> LayDanhSachKhachHang()
        {
            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = "SELECT * FROM KhachHang;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang khachHang = new KhachHang();

                    khachHang.maKhachHang = row["maKhachHang"].ToString();
                    khachHang.hangThanhVien = row["hangThanhVien"].ToString();
                    khachHang.diemThanhVien = (int)row["diemThanhVien"];
                    khachHang.hoTen = row["hoTen"].ToString();
                    khachHang.gioiTinh = row["gioiTinh"].ToString();
                    try { khachHang.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { khachHang.ngaySinh = null; }
                    khachHang.soDienThoai = row["soDienThoai"].ToString();
                    khachHang.email = row["email"].ToString();
                    khachHang.diaChi = row["diaChi"].ToString();
                    
                    listKhachHang.Add(khachHang);
                }
            }

            return listKhachHang;
        }

        public KhachHang LayKhachHangTheoMa(string maKhachHang)
        {
            KhachHang khachHang = new KhachHang();

            string query = $"SELECT * FROM KhachHang WHERE maKhachHang = '{maKhachHang}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);
           
            if (dataTable.Rows.Count > 0 )
            {
                khachHang.maKhachHang = dataTable.Rows[0]["maKhachHang"].ToString();
                khachHang.hangThanhVien = dataTable.Rows[0]["hangThanhVien"].ToString();
                khachHang.diemThanhVien = (int)dataTable.Rows[0]["diemThanhVien"];
                khachHang.hoTen = dataTable.Rows[0]["hoTen"].ToString();
                khachHang.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
                catch { khachHang.ngaySinh = null; }
                khachHang.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
                khachHang.email = dataTable.Rows[0]["email"].ToString();
                khachHang.diaChi = dataTable.Rows[0]["diaChi"].ToString();
            }

            return khachHang;
        }

        public KhachHang LayKhachHangTheoSoDienThoai(string soDienThoai)
        {
            KhachHang khachHang = new KhachHang();

            string query = $"SELECT * FROM KhachHang WHERE soDienThoai = '{soDienThoai}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);
            
            if (dataTable.Rows.Count > 0 )
            {
                khachHang.maKhachHang = dataTable.Rows[0]["maKhachHang"].ToString();
                khachHang.hangThanhVien = dataTable.Rows[0]["hangThanhVien"].ToString();
                khachHang.diemThanhVien = (int)dataTable.Rows[0]["diemThanhVien"];
                khachHang.hoTen = dataTable.Rows[0]["hoTen"].ToString();
                khachHang.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
                try { khachHang.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
                catch { khachHang.ngaySinh = null; }
                khachHang.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
                khachHang.email = dataTable.Rows[0]["email"].ToString();
                khachHang.diaChi = dataTable.Rows[0]["diaChi"].ToString();
                
            }

            return khachHang;
        }

        public int DemSoKhachHang()
        {
            string query = $"SELECT COUNT(*) AS SoKhachHang FROM KhachHang;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoKhachHang"];

            return count;
        }

        public bool KiemTraSoDienThoaiDaTonTai(string soDienThoai)
        {
            string query = $"SELECT maKhachHang FROM KhachHang WHERE soDienThoai = '{soDienThoai}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool ThemKhachHang(KhachHang khachHang)
        {
            string ngaySinh;

            if (khachHang.ngaySinh.HasValue)
                ngaySinh = $"\'{khachHang.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"INSERT INTO KhachHang VALUES('{khachHang.maKhachHang}', N'{khachHang.hangThanhVien}', {khachHang.diemThanhVien}, N'{khachHang.hoTen}', N'{khachHang.gioiTinh}', {ngaySinh}, '{khachHang.soDienThoai}', '{khachHang.email}', N'{khachHang.diaChi}');";
            
            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaKhachHang(KhachHang khachHang)
        {
            string ngaySinh;

            if (khachHang.ngaySinh.HasValue)
                ngaySinh = $"\'{khachHang.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"UPDATE KhachHang SET hoTen = N'{khachHang.hoTen}', gioiTinh = N'{khachHang.gioiTinh}', ngaySinh = {ngaySinh}, soDienThoai = '{khachHang.soDienThoai}', email = '{khachHang.email}', diaChi = N'{khachHang.diaChi}' WHERE maKhachHang = '{khachHang.maKhachHang}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<KhachHang> TimKiemKhachHang(string tuKhoa, string hangThanhVien, string gioiTinh)
        {

            List<KhachHang> listKhachHang = new List<KhachHang>();

            string query = $"SELECT * FROM KhachHang " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maKhachHang) LIKE '%{tuKhoa}%' " +
                           $"OR hoTen COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%' " +
                           $"OR soDienThoai LIKE '%{tuKhoa}%' " +
                           $"OR LOWER(email) LIKE '%{tuKhoa}%' " +
                           $"OR diaChi COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%') " +
                           $"AND ('{hangThanhVien}' = '' OR hangThanhVien = N'{hangThanhVien}') " +
                           $"AND ('{gioiTinh}' = '' OR gioiTinh = N'{gioiTinh}')";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    KhachHang khachHang = new KhachHang();

                    khachHang.maKhachHang = row["maKhachHang"].ToString();
                    khachHang.hangThanhVien = row["hangThanhVien"].ToString();
                    khachHang.diemThanhVien = (int)row["diemThanhVien"];
                    khachHang.hoTen = row["hoTen"].ToString();
                    khachHang.gioiTinh = row["gioiTinh"].ToString();
                    try { khachHang.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { khachHang.ngaySinh = null; }
                    khachHang.soDienThoai = row["soDienThoai"].ToString();
                    khachHang.email = row["email"].ToString();
                    khachHang.diaChi = row["diaChi"].ToString();
                    

                    listKhachHang.Add(khachHang);
                }
            }

            return listKhachHang;
        }

        public decimal TichDiem(KhachHang khachHang, decimal tongTien)
        {
            int diemTichLuy = 0;

            switch(khachHang.hangThanhVien)
            {
                case "Đồng":
                    diemTichLuy = (int)(tongTien * 0.5m / 100);
                    khachHang.diemThanhVien += diemTichLuy;

                    if (khachHang.diemThanhVien >= 5000 && khachHang.diemThanhVien < 10000)
                        khachHang.hangThanhVien = "Bạc";
                    else if (khachHang.diemThanhVien >= 10000)
                        khachHang.hangThanhVien = "Vàng";

                    break;

                case "Bạc":
                    diemTichLuy = (int)(tongTien * 0.25m / 100);
                    khachHang.diemThanhVien += diemTichLuy;
                    
                    if (khachHang.diemThanhVien >= 10000)
                        khachHang.hangThanhVien = "Vàng";

                    break;
            }

            string query = $"UPDATE KhachHang SET hangThanhVien = N'{khachHang.hangThanhVien}',  " +
                $"diemThanhVien = CASE WHEN diemThanhVien > 10000 THEN 10000 ELSE {khachHang.diemThanhVien} END " +
                $"WHERE maKhachHang = '{khachHang.maKhachHang}';";

            KetNoiDB.ExecuteNonQuery(query);

            return diemTichLuy;
        }

        public decimal GiamGiaThanhVien(KhachHang khachHang, decimal tongTien)
        {
            decimal giamGia = 0;

            if (khachHang.hangThanhVien.Equals("Đồng"))
                giamGia = tongTien * 2 / 100;
            else if (khachHang.hangThanhVien.Equals("Bạc"))
                giamGia = tongTien * 5 / 100;
            else 
                giamGia = tongTien * 7 / 100;

            return giamGia;
        }
    }
}
