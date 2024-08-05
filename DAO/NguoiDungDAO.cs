using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NguoiDungDAO
    {
        public NguoiDungDAO() { }

        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            List<NguoiDung> listNguoiDung = new List<NguoiDung>();

            string query = "SELECT * FROM NguoiDung WHERE trangThai = N'Đang hoạt động';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NguoiDung nguoiDung = new NguoiDung();

                    nguoiDung.maNguoiDung = row["maNguoiDung"].ToString();
                    nguoiDung.maPhanQuyen = row["maPhanQuyen"].ToString();
                    nguoiDung.tenDangNhap = row["tenDangNhap"].ToString();
                    nguoiDung.matKhau = row["matKhau"].ToString();
                    nguoiDung.hoTen = row["hoTen"].ToString();
                    nguoiDung.gioiTinh = row["gioiTinh"].ToString();
                    try { nguoiDung.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nguoiDung.ngaySinh = null; }
                    nguoiDung.soDienThoai = row["soDienThoai"].ToString();
                    nguoiDung.email = row["email"].ToString();
                    nguoiDung.diaChi = row["diaChi"].ToString();
                    nguoiDung.trangThai = row["trangThai"].ToString();

                    listNguoiDung.Add(nguoiDung);
                }
            }

            return listNguoiDung;
        }

        public NguoiDung LayNguoiDungTheoMa(string maNguoiDung)
        {
            NguoiDung nguoiDung = new NguoiDung();

            string query = $"SELECT * FROM NguoiDUng WHERE maNguoiDung = '{maNguoiDung}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                nguoiDung.maNguoiDung = dataTable.Rows[0]["maNguoiDung"].ToString();
                nguoiDung.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
                nguoiDung.tenDangNhap = dataTable.Rows[0]["tenDangNhap"].ToString();
                nguoiDung.matKhau = dataTable.Rows[0]["matKhau"].ToString();
                nguoiDung.hoTen = dataTable.Rows[0]["hoTen"].ToString();
                nguoiDung.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
                try { nguoiDung.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
                catch { nguoiDung.ngaySinh = null; }
                nguoiDung.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
                nguoiDung.email = dataTable.Rows[0]["email"].ToString();
                nguoiDung.diaChi = dataTable.Rows[0]["diaChi"].ToString();
                nguoiDung.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            }

            return nguoiDung;
        }

        public NguoiDung LayNguoiDungTheoTenDangNhap(string tenDangNhap)
        {
            NguoiDung nguoiDung = new NguoiDung();

            string query = $"SELECT * FROM NguoiDUng WHERE tenDangNhap = '{tenDangNhap}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                nguoiDung.maNguoiDung = dataTable.Rows[0]["maNguoiDung"].ToString();
                nguoiDung.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
                nguoiDung.tenDangNhap = dataTable.Rows[0]["tenDangNhap"].ToString();
                nguoiDung.matKhau = dataTable.Rows[0]["matKhau"].ToString();
                nguoiDung.hoTen = dataTable.Rows[0]["hoTen"].ToString();
                nguoiDung.gioiTinh = dataTable.Rows[0]["gioiTinh"].ToString();
                try { nguoiDung.ngaySinh = (DateTime)dataTable.Rows[0]["ngaySinh"]; }
                catch { nguoiDung.ngaySinh = null; }
                nguoiDung.soDienThoai = dataTable.Rows[0]["soDienThoai"].ToString();
                nguoiDung.email = dataTable.Rows[0]["email"].ToString();
                nguoiDung.diaChi = dataTable.Rows[0]["diaChi"].ToString();
                nguoiDung.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            }

            return nguoiDung;
        }

        public bool KiemTraTenDangNhapTonTai(string tenDangNhap)
        {
            string query = $"SELECT * FROM NguoiDung WHERE tenDangNhap = '{tenDangNhap}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool KiemTraNguoiDungHoatDong(string tenDangNhap)
        {
            string query = $"SELECT * FROM NguoiDung WHERE tenDangNhap = '{tenDangNhap}' AND trangThai = N'Đang hoạt động';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public bool KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            string query = $"SELECT * FROM NguoiDung WHERE tenDangNhap = '{tenDangNhap}' AND matKhau = '{matKhau}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            return dataTable.Rows.Count > 0;
        }

        public int DemSoNguoiDungTheoPhanQuyen(string maPhanQuyen)
        {
            string query = $"SELECT COUNT(*) AS SoNguoiDung FROM NguoiDung WHERE maPhanQuyen = '{maPhanQuyen}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = 0;

            if (dataTable.Rows.Count > 0 )
            {
                count = (int)dataTable.Rows[0]["SoNguoiDung"];
            }

            return count;
        }

        public bool ThemNguoiDung(NguoiDung nguoiDung)
        {
            string ngaySinh;

            if (nguoiDung.ngaySinh.HasValue)
                ngaySinh = $"\'{nguoiDung.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"INSERT INTO NguoiDung VALUES('{nguoiDung.maNguoiDung}', '{nguoiDung.maPhanQuyen}', '{nguoiDung.tenDangNhap}', '{nguoiDung.matKhau}', N'{nguoiDung.hoTen}', N'{nguoiDung.gioiTinh}', {ngaySinh}, '{nguoiDung.soDienThoai}', '{nguoiDung.email}', N'{nguoiDung.diaChi}', N'{nguoiDung.trangThai}');";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool XoaNguoiDung(string maNguoiDung)
        {
            string query = $"UPDATE NguoiDung SET trangThai = N'Đã xóa' WHERE maNguoiDung = '{maNguoiDung}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool SuaNguoiDung(NguoiDung nguoiDung)
        {
            string ngaySinh;

            if (nguoiDung.ngaySinh.HasValue)
                ngaySinh = $"\'{nguoiDung.ngaySinh.ToString()}\'";
            else
                ngaySinh = "NULL";

            string query = $"UPDATE NguoiDung SET tenDangNhap = '{nguoiDung.tenDangNhap}', matKhau = '{nguoiDung.matKhau}', hoTen= N'{nguoiDung.hoTen}', gioiTinh = N'{nguoiDung.gioiTinh}', ngaySinh = {ngaySinh}, soDienThoai = '{nguoiDung.soDienThoai}', email = '{nguoiDung.email}', diaChi = N'{nguoiDung.diaChi}', trangThai = N'{nguoiDung.trangThai}' WHERE maNguoiDung = '{nguoiDung.maNguoiDung}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool DoiMatKhau(string maNguoiDung, string matKhau)
        {
            string query = $"UPDATE NguoiDung SET matKhau = '{matKhau}' WHERE maNguoiDung = '{maNguoiDung}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<NguoiDung> TimKiemNguoiDung(string tuKhoa, string maPhanQuyen, string gioiTinh, string trangThai)
        {

            List<NguoiDung> listNguoiDung = new List<NguoiDung>();

            string query = $"SELECT * FROM NguoiDung " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maNguoiDung) LIKE '%{tuKhoa}%' " +
                           $"OR tenDangNhap LIKE '%{tuKhoa}%' " +
                           $"OR hoTen COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%' " +
                           $"OR soDienThoai LIKE '%{tuKhoa}%' " +
                           $"OR LOWER(email) LIKE '%{tuKhoa}%' " +
                           $"OR diaChi COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%') " +
                           $"AND ('{maPhanQuyen}' = '' OR maPhanQuyen = N'{maPhanQuyen}') " +
                           $"AND ('{trangThai}' = '' OR trangThai = N'{trangThai}') " +
                           $"AND ('{gioiTinh}' = '' OR gioiTinh = N'{gioiTinh}')";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    NguoiDung nguoiDung = new NguoiDung();

                    nguoiDung.maNguoiDung = row["maNguoiDung"].ToString();
                    nguoiDung.maPhanQuyen = row["maPhanQuyen"].ToString();
                    nguoiDung.tenDangNhap = row["tenDangNhap"].ToString();
                    nguoiDung.matKhau = row["matKhau"].ToString();
                    nguoiDung.hoTen = row["hoTen"].ToString();
                    nguoiDung.gioiTinh = row["gioiTinh"].ToString();
                    try { nguoiDung.ngaySinh = (DateTime)row["ngaySinh"]; }
                    catch { nguoiDung.ngaySinh = null; }
                    nguoiDung.soDienThoai = row["soDienThoai"].ToString();
                    nguoiDung.email = row["email"].ToString();
                    nguoiDung.diaChi = row["diaChi"].ToString();
                    nguoiDung.trangThai = row["trangThai"].ToString();

                    listNguoiDung.Add(nguoiDung);
                }
            }

            return listNguoiDung;
        }
    }
}
