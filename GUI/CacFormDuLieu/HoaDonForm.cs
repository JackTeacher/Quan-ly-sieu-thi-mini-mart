using BUS;
using DTO;
using GUI.CacFormChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HoaDonForm : Form
    {
        HoaDonBUS hoaDonBUS;
        List<HoaDon> listHoaDon;

        public HoaDonForm()
        {
            InitializeComponent();

            hoaDonBUS = new HoaDonBUS();
            listHoaDon = hoaDonBUS.LayDanhSachHoaDon();
        }

        private void HoaDonForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listHoaDon);
        }

        private void LoadDataToDataGridView(List<HoaDon> listHoaDon)
        {
            hoaDonDataGridView.Rows.Clear();

            if (listHoaDon.Count > 0)
            {
                for (int i = 0; i < listHoaDon.Count; i++)
                {
                    hoaDonDataGridView.Rows.Add(1);
                    hoaDonDataGridView.Rows[i].Cells[0].Value = i + 1;
                    hoaDonDataGridView.Rows[i].Cells[1].Value = listHoaDon[i].maHoaDon;
                    hoaDonDataGridView.Rows[i].Cells[2].Value = listHoaDon[i].maNhanVien;
                    hoaDonDataGridView.Rows[i].Cells[3].Value = listHoaDon[i].maKhachHang;
                    hoaDonDataGridView.Rows[i].Cells[4].Value = listHoaDon[i].maKhuyenMai;
                    hoaDonDataGridView.Rows[i].Cells[5].Value = listHoaDon[i].thoiGianTao.ToString("dd/MM/yyyy HH:mm:ss");
                    hoaDonDataGridView.Rows[i].Cells[6].Value = listHoaDon[i].tongTien.ToString("#,##0") + " VNĐ";
                    hoaDonDataGridView.Rows[i].Cells[7].Value = listHoaDon[i].giamGia.ToString("#,##0") + " VNĐ";
                    hoaDonDataGridView.Rows[i].Cells[8].Value = listHoaDon[i].thanhTien.ToString("#,##0") + " VNĐ";
                    hoaDonDataGridView.Rows[i].Cells[9].Value = listHoaDon[i].tienNhan.ToString("#,##0") + " VNĐ";
                    hoaDonDataGridView.Rows[i].Cells[10].Value = listHoaDon[i].tienThua.ToString("#,##0") + " VNĐ";
                }
            }
        }

        private void hoaDonDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 11) && e.RowIndex >= 0)
            {
                // Kiểm tra giá trị của cell có phải là hình ảnh không.
                if (e.Value is Image)
                {
                    // Thiết lập kích thước mới cho hình ảnh.
                    int newWidth = 25; // Kích thước mới theo chiều rộng
                    int newHeight = 25; // Kích thước mới theo chiều cao

                    // Đổi kích thước hình ảnh.
                    Image originalImage = (Image)e.Value;
                    Image resizedImage = new Bitmap(originalImage, new Size(newWidth, newHeight));

                    // Gán hình ảnh mới vào cell.
                    e.Value = resizedImage;
                }
            }
        }

        private void hoaDonDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < hoaDonDataGridView.Columns.Count - numberOfColumnsToSkip)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Đặt màu cho đường kẻ giữa các cột (nếu không thuộc vào cột cuối cùng)
                using (Pen pen = new Pen(Color.FromArgb(242, 245, 250), 5))
                {
                    int x = e.CellBounds.Right - 1;
                    int y1 = e.CellBounds.Top;
                    int y2 = e.CellBounds.Bottom;
                    e.Graphics.DrawLine(pen, x, y1, x, y2);
                }

                e.Handled = true;
            }
        }

        private void hoaDonDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <  hoaDonDataGridView.Columns.Count -1)
            {
                HoaDon hoaDon = hoaDonBUS.LayHoaDonTheoMa(hoaDonDataGridView.Rows[e.RowIndex].Cells["maHoaDonColumn"].Value.ToString());

                string columnName = hoaDonDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("infoButtonColumn"))
                {
                    new ChiTietHoaDonForm(hoaDon.maHoaDon).Show();
                }
            }
        }
    }
}
