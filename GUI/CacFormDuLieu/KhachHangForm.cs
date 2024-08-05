using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormThongBao;
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
    public partial class KhachHangForm : Form
    {
        KhachHangBUS khachHangBUS;
        List<KhachHang> listKhachHang;

        public KhachHangForm()
        {
            InitializeComponent();

            khachHangBUS = new KhachHangBUS();
            listKhachHang = khachHangBUS.LayDanhSachKhachHang();
        }

        private void KhachHangForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhachHang);

            hangThanhVienComboBox.SelectedIndex = -1;
        }

        private void LoadDataToDataGridView(List<KhachHang> listKhachHang)
        {
            khachHangDataGridView.Rows.Clear();

            for (int i = 0; i < listKhachHang.Count; i++)
            {
                khachHangDataGridView.Rows.Add(1);
                khachHangDataGridView.Rows[i].Cells[0].Value = i + 1;
                khachHangDataGridView.Rows[i].Cells[1].Value = listKhachHang[i].maKhachHang;
                khachHangDataGridView.Rows[i].Cells[2].Value = listKhachHang[i].hoTen;
                khachHangDataGridView.Rows[i].Cells[3].Value = listKhachHang[i].gioiTinh;
                khachHangDataGridView.Rows[i].Cells[4].Value = listKhachHang[i].soDienThoai;
                khachHangDataGridView.Rows[i].Cells[5].Value = listKhachHang[i].hangThanhVien;
                khachHangDataGridView.Rows[i].Cells[6].Value = listKhachHang[i].diemThanhVien;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string hangThanhVien = "";
            if (hangThanhVienComboBox.SelectedItem != null)
                hangThanhVien = hangThanhVienComboBox.SelectedItem.ToString();
            string gioiTinh = "";
            //CHỜ THÊM

            listKhachHang = khachHangBUS.TimKiemKhachHang(tuKhoa, hangThanhVien, gioiTinh);

            LoadDataToDataGridView(listKhachHang);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        private void hangThanhVienComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (hangThanhVienComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            hangThanhVienComboBox.SelectedItem = null;
            hangThanhVienComboBox.SelectedIndex = -1;

            listKhachHang = khachHangBUS.LayDanhSachKhachHang();

            LoadDataToDataGridView(listKhachHang);
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelKhachHang(listKhachHang);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new ChiTietKhachHangForm("Thêm", this).Show();
        }

        private void khachHangDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            KhachHang khachHang = khachHangBUS.LayKhachHangTheoMa(khachHangDataGridView["maKhachHangColumn", e.RowIndex].Value.ToString());

            string columnName = khachHangDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("infoButtonColumn"))
            {
                new ChiTietKhachHangForm(khachHang, "Chi tiết", this).Show();
            }

            if (columnName.Equals("editButtonColumn"))
            {
                new ChiTietKhachHangForm(khachHang, "Sửa", this).Show();
            }
        }

        private void khachHangDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8) && e.RowIndex >= 0)
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

        private void khachHangDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 2; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < khachHangDataGridView.Columns.Count - numberOfColumnsToSkip)
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

        
    }
}
