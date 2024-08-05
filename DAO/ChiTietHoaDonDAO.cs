using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public ChiTietHoaDonDAO() { }

        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

            string query = $"SELECT * FROM ChiTietHoaDon WHERE maHoaDon = '{maHoaDon}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();

                chiTietHoaDon.maHoaDon = row["maHoaDon"].ToString();
                chiTietHoaDon.maSanPham = row["maSanPham"].ToString();
                chiTietHoaDon.tenSanPham = row["tenSanPham"].ToString();
                chiTietHoaDon.donVi = row["donVi"].ToString();
                chiTietHoaDon.soLuong = (int)row["soLuong"];
                chiTietHoaDon.donGia = Decimal.Parse(row["donGia"].ToString());
                chiTietHoaDon.tongTien = Decimal.Parse(row["tongTien"].ToString());

                listChiTietHoaDon.Add(chiTietHoaDon);
            }

            return listChiTietHoaDon;
        }
    }
}
