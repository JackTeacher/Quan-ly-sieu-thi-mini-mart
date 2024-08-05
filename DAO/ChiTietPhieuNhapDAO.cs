using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        public ChiTietPhieuNhapDAO() { }

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            List<ChiTietPhieuNhap> listChiTietPhieuNhap = new List<ChiTietPhieuNhap>();

            string query = $"SELECT * FROM ChiTietPhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

                chiTietPhieuNhap.maPhieuNhap = row["maPhieuNhap"].ToString();
                chiTietPhieuNhap.maSanPham = row["maSanPham"].ToString();
                chiTietPhieuNhap.tenSanPham = row["tenSanPham"].ToString();
                chiTietPhieuNhap.donVi = row["donVi"].ToString();
                chiTietPhieuNhap.soLuong = (int)row["soLuong"];
                chiTietPhieuNhap.giaBan = Decimal.Parse(row["giaBan"].ToString());
                chiTietPhieuNhap.giaNhap = Decimal.Parse(row["giaNhap"].ToString());
                chiTietPhieuNhap.tongTien = Decimal.Parse(row["tongTien"].ToString());

                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }

            return listChiTietPhieuNhap;
        }

        public ChiTietPhieuNhap LayChiTietPhieuNhap(string maPhieuNhap, string maSanPham)
        {
            ChiTietPhieuNhap chiTietPhieuNhap = new ChiTietPhieuNhap();

            string query = $"SELECT * FROM ChiTietPhieuNhap WHERE maPhieuNhap = '{maPhieuNhap}' AND maSanPham = '{maSanPham}'";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                chiTietPhieuNhap.maPhieuNhap = dataTable.Rows[0]["maPhieuNhap"].ToString();
                chiTietPhieuNhap.maSanPham = dataTable.Rows[0]["maSanPham"].ToString();
                chiTietPhieuNhap.tenSanPham = dataTable.Rows[0]["tenSanPham"].ToString();
                chiTietPhieuNhap.donVi = dataTable.Rows[0]["donVi"].ToString();
                chiTietPhieuNhap.soLuong = (int)dataTable.Rows[0]["soLuong"];
                chiTietPhieuNhap.giaBan = Decimal.Parse(dataTable.Rows[0]["giaBan"].ToString());
                chiTietPhieuNhap.giaNhap = Decimal.Parse(dataTable.Rows[0]["giaNhap"].ToString());
                chiTietPhieuNhap.tongTien = Decimal.Parse(dataTable.Rows[0]["tongTien"].ToString());
            }

            return chiTietPhieuNhap;
        }

        public bool SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            string query = $"UPDATE ChiTietPhieuNhap SET soLuong = {chiTietPhieuNhap.soLuong}, giaBan = {chiTietPhieuNhap.giaBan}, giaNhap = {chiTietPhieuNhap.giaNhap}, tongTien = {chiTietPhieuNhap.tongTien} WHERE maPhieuNhap = '{chiTietPhieuNhap.maPhieuNhap}' AND maSanPham = '{chiTietPhieuNhap.maSanPham}'";

            int rowsAffected = KetNoiDB.ExecuteNonQuery(query);

            return rowsAffected > 0;
        }
    }
}
