using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO chiTietPhieuNhapDAO;
        public ChiTietPhieuNhapBUS() 
        { 
            chiTietPhieuNhapDAO = new ChiTietPhieuNhapDAO();
        }

        public List<ChiTietPhieuNhap> LayDanhSachChiTietPhieuNhap(string maPhieuNhap)
        {
            return chiTietPhieuNhapDAO.LayDanhSachChiTietPhieuNhap(maPhieuNhap);
        }

        public ChiTietPhieuNhap LayChiTietPhieuNhap(string maPhieuNhap, string maSanPham)
        {
            return chiTietPhieuNhapDAO.LayChiTietPhieuNhap(maPhieuNhap, maSanPham);
        }

        public string SuaChiTietPhieuNhap(ChiTietPhieuNhap chiTietPhieuNhap)
        {
            if (chiTietPhieuNhapDAO.SuaChiTietPhieuNhap(chiTietPhieuNhap))
                return "Chỉnh sửa chi tiết phiếu nhập thành công!";
            else
                return "Chỉnh sửa chi tiết phiếu nhập thất bại!";
        }
    }
}
