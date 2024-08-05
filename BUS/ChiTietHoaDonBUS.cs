using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        ChiTietHoaDonDAO chiTietHoaDonDAO;
        public ChiTietHoaDonBUS() 
        { 
            chiTietHoaDonDAO = new ChiTietHoaDonDAO();
        }

        public List<ChiTietHoaDon> LayDanhSachChiTietHoaDon(string maHoaDon)
        {
            return chiTietHoaDonDAO.LayDanhSachChiTietHoaDon(maHoaDon);
        }
    }
}
