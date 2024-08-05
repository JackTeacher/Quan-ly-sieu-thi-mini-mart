using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        public HoaDonDAO() { }

        public List<HoaDon> LayDanhSachHoaDon()
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = "SELECT * FROM HoaDon;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.maHoaDon = row["maHoaDon"].ToString();
                    hoaDon.maNhanVien = row["maNhanVien"].ToString();
                    hoaDon.maKhachHang = row["maKhachHang"].ToString();
                    hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                    hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                    hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                    hoaDon.giamGia = Decimal.Parse(row["giamGia"].ToString());
                    hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                    hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }

        public HoaDon LayHoaDonTheoMa(string maHoaDon)
        {
            HoaDon hoaDon = new HoaDon();

            string query = $"SELECT * FROM HoaDon WHERE maHoaDon = '{maHoaDon}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            hoaDon.maHoaDon = dataTable.Rows[0]["maHoaDon"].ToString();
            hoaDon.maNhanVien = dataTable.Rows[0]["maNhanVien"].ToString();
            hoaDon.maKhachHang = dataTable.Rows[0]["maKhachHang"].ToString();
            hoaDon.maKhuyenMai = dataTable.Rows[0]["maKhuyenMai"].ToString();
            hoaDon.thoiGianTao = (DateTime)dataTable.Rows[0]["thoiGianTao"];
            hoaDon.tongTien = Decimal.Parse(dataTable.Rows[0]["tongTien"].ToString());
            hoaDon.giamGia = Decimal.Parse(dataTable.Rows[0]["giamGia"].ToString());
            hoaDon.thanhTien = Decimal.Parse(dataTable.Rows[0]["thanhTien"].ToString());
            hoaDon.tienNhan = Decimal.Parse(dataTable.Rows[0]["tienNhan"].ToString());
            hoaDon.tienThua = Decimal.Parse(dataTable.Rows[0]["tienThua"].ToString());

            return hoaDon;
        }

        public int DemSoHoaDon()
        {
            string query = $"SELECT COUNT(*) AS SoHoaDon FROM HoaDon;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoHoaDon"];

            return count;
        }

        public int DemSoHoaDonTheoNgay(DateTime ngay)
        {
            string query = $"SELECT COUNT(*) AS SoHoaDon FROM HoaDon WHERE CONVERT(DATE, thoiGianTao) = '{ngay.ToString("yyyy-MM-dd")}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            int count = (int)dataTable.Rows[0]["SoHoaDon"];

            return count;
        }

        public bool ThemHoaDon(HoaDon hoaDon, List<ChiTietHoaDon> listChiTietHoaDon)
        {
            int rowsAffected = 0;

            string hoaDonQuery = $"INSERT INTO HoaDon VALUES('{hoaDon.maHoaDon}', '{hoaDon.maNhanVien}', " +
                                 $"CASE WHEN '{hoaDon.maKhachHang}' = '' THEN NULL ELSE '{hoaDon.maKhachHang}' END, " +
                                 $"CASE WHEN '{hoaDon.maKhuyenMai}' = '' THEN NULL ELSE '{hoaDon.maKhuyenMai}' END, " +
                                 $"'{hoaDon.thoiGianTao}', {hoaDon.tongTien}, {hoaDon.giamGia}, {hoaDon.thanhTien}, {hoaDon.tienNhan}, {hoaDon.tienThua});";

            rowsAffected += KetNoiDB.ExecuteNonQuery(hoaDonQuery);

            foreach (ChiTietHoaDon chiTietHoaDon in listChiTietHoaDon)
            {
                string chiTietHoaDonQuery = $"INSERT INTO ChiTietHoaDon (maHoaDon, maSanPham, tenSanPham, donVi, soLuong, donGia, tongTien) " +
                                            $"SELECT '{hoaDon.maHoaDon}' AS maHoaDon, maSanPham, tenSanPham, donVi, {chiTietHoaDon.soLuong} AS soLuong, giaBan, giaBan * {chiTietHoaDon.soLuong} AS tongTien " +
                                            $"FROM SanPham WHERE maSanPham = '{chiTietHoaDon.maSanPham}';";

                rowsAffected += KetNoiDB.ExecuteNonQuery(chiTietHoaDonQuery);
            }

            return rowsAffected == listChiTietHoaDon.Count + 1;
        }

        public List<HoaDon> TimKiemHoaDon(string tuKhoa)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = $"SELECT * FROM HoaDon WHERE " +
                           $"LOWER(maHoaDon) LIKE '%{tuKhoa}%';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

           if (dataTable.Rows.Count >0)
           {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.maHoaDon = row["maHoaDon"].ToString();
                    hoaDon.maNhanVien = row["maNhanVien"].ToString();
                    hoaDon.maKhachHang = row["maKhachHang"].ToString();
                    hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                    hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                    hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                    hoaDon.giamGia = Decimal.Parse(row["giamGia"].ToString());
                    hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                    hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                    listHoaDon.Add(hoaDon);
                }
           }

            return listHoaDon;
        }

        public List<HoaDon> LayDanhSachHoaDonTheoNgay(DateTime ngay)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = $"SELECT * FROM HoaDon WHERE CONVERT(DATE, thoiGianTao) = '{ngay.ToString("yyyy-MM-dd")}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.maHoaDon = row["maHoaDon"].ToString();
                    hoaDon.maNhanVien = row["maNhanVien"].ToString();
                    hoaDon.maKhachHang = row["maKhachHang"].ToString();
                    hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                    hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                    hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                    hoaDon.giamGia = Decimal.Parse(row["giamGia"].ToString());
                    hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                    hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }

        public List<HoaDon> LayDanhSachHoaDonTheoKhoangThoiGian(DateTime ngayTruoc, DateTime ngaySau)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = $"SELECT * FROM HoaDon WHERE CONVERT(DATE, thoiGianTao) >= '{ngayTruoc.ToString("yyyy-MM-dd")}' AND CONVERT(DATE, thoiGianTao) <= '{ngaySau.ToString("yyyy-MM-dd")}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.maHoaDon = row["maHoaDon"].ToString();
                    hoaDon.maNhanVien = row["maNhanVien"].ToString();
                    hoaDon.maKhachHang = row["maKhachHang"].ToString();
                    hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                    hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                    hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                    hoaDon.giamGia = Decimal.Parse(row["giamGia"].ToString());
                    hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                    hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }

        public List<HoaDon> LayDanhSachHoaDonTheoNhanVien(string maNhanVien)
        {
            List<HoaDon> listHoaDon = new List<HoaDon>();

            string query = $"SELECT * FROM HoaDon WHERE maNhanVien = '{maNhanVien}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    HoaDon hoaDon = new HoaDon();

                    hoaDon.maHoaDon = row["maHoaDon"].ToString();
                    hoaDon.maNhanVien = row["maNhanVien"].ToString();
                    hoaDon.maKhachHang = row["maKhachHang"].ToString();
                    hoaDon.maKhuyenMai = row["maKhuyenMai"].ToString();
                    hoaDon.thoiGianTao = (DateTime)row["thoiGianTao"];
                    hoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());
                    hoaDon.giamGia = Decimal.Parse(row["giamGia"].ToString());
                    hoaDon.thanhTien = Decimal.Parse(row["thanhTien"].ToString());
                    hoaDon.tienNhan = Decimal.Parse(row["tienNhan"].ToString());
                    hoaDon.tienThua = Decimal.Parse(row["tienThua"].ToString());

                    listHoaDon.Add(hoaDon);
                }
            }

            return listHoaDon;
        }
    }
}
