using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        public PhieuNhapDAO() { }

        public int DemSoPhieuNhapTheoNgay(DateTime ngay)
        {
            string query = $"SELECT COUNT(*) AS SoPhieuNhap FROM PhieuNhap WHERE CONVERT(DATE, thoiGianTao) = '{ngay.ToString("yyyy-MM-dd")}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoPhieuNhap"];

            return count;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapChuaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap> ();

            string query = "SELECT * FROM PhieuNhap WHERE trangThai = N'Chưa duyệt';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNguoiTao = dataTable.Rows[0]["maNguoiTao"].ToString();
                    phieuNhap.maNguoiDuyet = dataTable.Rows[0]["maNguoiDuyet"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThai = dataTable.Rows[0]["trangThai"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }
            
            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhap()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap WHERE trangThai = N'Chưa duyệt' OR trangThai = N'Đã duyệt';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = row["maNhaCungCap"].ToString();
                    phieuNhap.maNguoiTao =row["maNguoiTao"].ToString();
                    phieuNhap.maNguoiDuyet = row["maNguoiDuyet"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)row["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)row["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    phieuNhap.trangThai = row["trangThai"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaDuyet()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap WHERE trangThai = N'Đã duyệt';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNguoiTao = dataTable.Rows[0]["maNguoiTao"].ToString();
                    phieuNhap.maNguoiDuyet = dataTable.Rows[0]["maNguoiDuyet"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThai = dataTable.Rows[0]["trangThai"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public List<PhieuNhap> LayDanhSachPhieuNhapDaTuChoi()
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap>();

            string query = "SELECT * FROM PhieuNhap WHERE trangThai = N'Không duyệt';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                    phieuNhap.maNguoiTao = dataTable.Rows[0]["maNguoiTao"].ToString();
                    phieuNhap.maNguoiDuyet = dataTable.Rows[0]["maNguoiDuyet"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                    phieuNhap.trangThai = dataTable.Rows[0]["trangThai"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }

            return listPhieuNhap;
        }

        public PhieuNhap LayPhieuNhapTheoMa(string maPhieuNhap)
        {
            PhieuNhap phieuNhap = new PhieuNhap();

            string query = $"SELECT * FROM PhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                phieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                phieuNhap.maNhaCungCap = dataTable.Rows[0]["maNhaCungCap"].ToString();
                phieuNhap.maNguoiTao = dataTable.Rows[0]["maNguoiTao"].ToString();
                phieuNhap.maNguoiDuyet = dataTable.Rows[0]["maNguoiDuyet"].ToString();
                phieuNhap.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
                try { phieuNhap.thoiGianDuyet = (DateTime)dataTable.Rows[0]["thoiGianDuyet"]; }
                catch { phieuNhap.thoiGianDuyet = null; }
                phieuNhap.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
                phieuNhap.trangThai = dataTable.Rows[0]["trangThai"].ToString();
            }

            return phieuNhap;
        }

        public bool ThemPhieuNhap(PhieuNhap phieuNhap, List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            int rowsAffected = 0;

            string phieuNhapQuery = $"INSERT INTO PhieuNhap VALUES('{phieuNhap.maPhieuNhap}', '{phieuNhap.maNhaCungCap}', '{phieuNhap.maNguoiTao}', NULL, '{phieuNhap.thoiGianTao}', NULL, {phieuNhap.thanhTien}, N'Chưa duyệt');";
                                 
            rowsAffected += KetNoiDB.ExecuteNonQuery(phieuNhapQuery);

            foreach (ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                string chiTietPhieuNhapQuery = $"INSERT INTO ChiTietPhieuNhap (maPhieuNhap, maSanPham, tenSanPham, soLuong, donVi, giaBan, giaNhap, tongTien) " +
                                               $"SELECT '{phieuNhap.maPhieuNhap}' AS maPhieuNhap, maSanPham, tenSanPham,{chiTietPhieuNhap.soLuong} AS soLuong, donVi, {chiTietPhieuNhap.giaBan} AS giaBan, {chiTietPhieuNhap.giaNhap} AS giaNhap,  {chiTietPhieuNhap.giaNhap} * {chiTietPhieuNhap.soLuong} AS tongTien " +
                                               $"FROM SanPham WHERE maSanPham = '{chiTietPhieuNhap.maSanPham}';";

                rowsAffected += KetNoiDB.ExecuteNonQuery(chiTietPhieuNhapQuery);
            }

            return rowsAffected == listChiTietPhieuNhap.Count + 1;
        }

        public bool SuaPhieuNhapChuaDuyet(List<ChiTietPhieuNhap> listChiTietPhieuNhap)
        {
            string query;
            int rowsAffected = 0;
            decimal thanhTien = 0;

            foreach(ChiTietPhieuNhap chiTietPhieuNhap in listChiTietPhieuNhap)
            {
                query = $"UPDATE ChiTietPhieuNhap SET soLuong = {chiTietPhieuNhap.soLuong}, giaBan = {chiTietPhieuNhap.giaBan}, giaNhap = {chiTietPhieuNhap.giaNhap}, tongTien = {chiTietPhieuNhap.tongTien} WHERE maPhieuNhap = '{chiTietPhieuNhap.maPhieuNhap}' AND maSanPham = '{chiTietPhieuNhap.maSanPham}';";

                rowsAffected += KetNoiDB.ExecuteNonQuery(query);

                thanhTien += chiTietPhieuNhap.tongTien;
            }

            query = $"UPDATE PhieuNhap SET thanhTien = {thanhTien} WHERE maPhieuNhap = '{listChiTietPhieuNhap[0].maPhieuNhap}';";

            rowsAffected += KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected == listChiTietPhieuNhap.Count + 1;
        }

        public bool DuyetPhieuNhap(string maPhieuNhap, string maNguoiDuyet, DateTime thoiGianDuyet)
        {
            string query = $"UPDATE PhieuNhap SET maNguoiDuyet = '{maNguoiDuyet}', thoiGianDuyet = '{thoiGianDuyet}', trangThai = N'Đã duyệt' WHERE maPhieuNhap = '{maPhieuNhap}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public bool TuChoiDuyetPhieuNhap(string maPhieuNhap)
        {
            string query = $"UPDATE PhieuNhap SET trangThai = N'Không duyệt' WHERE maPhieuNhap = '{maPhieuNhap}';";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }

        public List<PhieuNhap> TimKiemPhieuNhap(string tuKhoa, string trangThai, string thoiGianBatDau, string thoiGianKetThuc)
        {
            List<PhieuNhap> listPhieuNhap = new List<PhieuNhap> ();

            string query = $"SELECT * FROM PhieuNhap " +
                           $"WHERE ('{tuKhoa}' = '' OR LOWER(maPhieuNhap) LIKE '%{tuKhoa}%' OR LOWER(maNhaCungCap) LIKE '%{tuKhoa}%' OR LOWER(maNguoiDuyet) LIKE '%{tuKhoa}%' OR LOWER(maNguoiTao) LIKE '%{tuKhoa}%') AND ('{trangThai}' = '' OR trangThai = N'{trangThai}') ";
            if (!string.IsNullOrEmpty(thoiGianBatDau) && !string.IsNullOrEmpty(thoiGianKetThuc))
            {
                query += $"AND thoiGianTao BETWEEN '{thoiGianBatDau}' AND '{thoiGianKetThuc}';";
            }
                

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhieuNhap phieuNhap = new PhieuNhap();

                    phieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                    phieuNhap.maNhaCungCap = row["maNhaCungCap"].ToString();
                    phieuNhap.maNguoiTao = row["maNguoiTao"].ToString();
                    phieuNhap.maNguoiDuyet = row["maNguoiDuyet"].ToString();
                    phieuNhap.thoiGianTao = (DateTime)row["thoiGianTao"];
                    try { phieuNhap.thoiGianDuyet = (DateTime)row["thoiGianDuyet"]; }
                    catch { phieuNhap.thoiGianDuyet = null; }
                    phieuNhap.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    phieuNhap.trangThai = row["trangThai"].ToString();

                    listPhieuNhap.Add(phieuNhap);
                }
            }
            else
                Debug.WriteLine("Lỗi gì đó datatable rỗng");

            return listPhieuNhap;
        }
    }
}
