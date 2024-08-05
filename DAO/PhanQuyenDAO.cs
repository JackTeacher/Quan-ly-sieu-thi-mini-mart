using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhanQuyenDAO
    {
        public PhanQuyenDAO() { }

        public List<PhanQuyen> LayDanhSachPhanQuyen()
        {
            List<PhanQuyen> listPhanQuyen = new List<PhanQuyen>();

            string query = "SELECT * FROM PhanQuyen;";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0 )
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhanQuyen phanQuyen = new PhanQuyen();
                    phanQuyen.maPhanQuyen = row["maPhanQuyen"].ToString();
                    phanQuyen.tenPhanQuyen = row["tenPhanQuyen"].ToString();

                    listPhanQuyen.Add(phanQuyen);
                }
            }

            return listPhanQuyen;
        }

        public PhanQuyen LayPhanQuyenTheoTenTaiKhoan(string tenTaiKhoan)
        {
            PhanQuyen phanQuyen = new PhanQuyen();

            string query = $"SELECT PhanQuyen.* " +
                           "FROM PhanQuyen " +
                           "JOIN TaiKhoan ON PhanQuyen.maPhanQuyen = TaiKhoan.maPhanQuyen " +
                           $"WHERE TaiKhoan.tenTaiKhoan = '{tenTaiKhoan}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                phanQuyen.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
                phanQuyen.tenPhanQuyen = dataTable.Rows[0]["tenPhanQuyen"].ToString();
            }

            return phanQuyen;
        }

        public PhanQuyen LayPhanQuyenTheoMa(string maPhanQuyen)
        {
            PhanQuyen phanQuyen = new PhanQuyen();

            string query = $"SELECT * FROM PhanQuyen WHERE maPhanQuyen = '{maPhanQuyen}';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                phanQuyen.maPhanQuyen = dataTable.Rows[0]["maPhanQuyen"].ToString();
                phanQuyen.tenPhanQuyen = dataTable.Rows[0]["tenPhanQuyen"].ToString();
            }

            return phanQuyen;
        }

        public List<PhanQuyen> TimKiemPhanQuyen(string tuKhoa)
        {
            List<PhanQuyen> listPhanQuyen = new List<PhanQuyen>();

            string query = $"SELECT * FROM PhanQuyen " +
                           $"WHERE LOWER(maPhanQuyen) LIKE '%{tuKhoa}%' " +
                           $"OR tenPhanQuyen COLLATE Latin1_General_CI_AI LIKE N'%{tuKhoa}%';";

            DataTable dataTable = KetNoiDB.ExecuteQuery(query);          

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    PhanQuyen phanQuyen = new PhanQuyen();
                    phanQuyen.maPhanQuyen = row["maPhanQuyen"].ToString();
                    phanQuyen.tenPhanQuyen = row["tenPhanQuyen"].ToString();

                    listPhanQuyen.Add(phanQuyen);
                }
            }

            return listPhanQuyen;
        }
    }
}
