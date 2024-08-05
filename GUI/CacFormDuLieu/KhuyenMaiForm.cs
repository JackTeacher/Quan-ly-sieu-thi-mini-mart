using BUS;
using BUS.OtherFunctions;
using DTO;
using GUI.CacFormChiTiet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class KhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        List<KhuyenMai> listKhuyenMai;

        public KhuyenMaiForm()
        {
            InitializeComponent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();
        }

        private void KhuyenMaiForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhuyenMai);

            trangThaiComboBox.SelectedIndex = 0;
            loaiGiaTriComboBox.SelectedIndex = -1;
            sapXepComboBox.SelectedIndex = -1;
            thoiGianCheckBox.Checked = false;
            thoiGianBatDauDateTimePicker.Enabled = false;
            thoiGianKetThucDateTimePicker.Enabled = false;
        }

        private void LoadDataToDataGridView(List<KhuyenMai> listKhuyenMai)
        {
            khuyenMaiDataGridView.Rows.Clear();

            for (int i = 0; i < listKhuyenMai.Count; i++)
            {
                khuyenMaiDataGridView.Rows.Add(1);
                khuyenMaiDataGridView.Rows[i].Cells[0].Value = i + 1;
                khuyenMaiDataGridView.Rows[i].Cells[1].Value = listKhuyenMai[i].maKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[2].Value = listKhuyenMai[i].tenKhuyenMai;
                khuyenMaiDataGridView.Rows[i].Cells[3].Value = listKhuyenMai[i].thoiGianBatDau.ToString("dd/MM/yyyy HH:mm:ss");
                khuyenMaiDataGridView.Rows[i].Cells[4].Value = listKhuyenMai[i].thoiGianKetThuc.ToString("dd/MM/yyyy HH:mm:ss");
                khuyenMaiDataGridView.Rows[i].Cells[5].Value = listKhuyenMai[i].loaiGiaTri;
                khuyenMaiDataGridView.Rows[i].Cells[6].Value = listKhuyenMai[i].giaTri;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;
            string trangThai = "";
            if (trangThaiComboBox.SelectedItem != null)
                trangThai = trangThaiComboBox.SelectedItem.ToString();
            string loaiGiaTri = "";
            if (loaiGiaTriComboBox.SelectedItem != null)
                loaiGiaTri = loaiGiaTriComboBox.SelectedItem.ToString();
            string sapXep = "";
            if (sapXepComboBox.SelectedItem != null)
                sapXep = sapXepComboBox.SelectedItem.ToString();
            string thoiGianBatDau = "";
            string thoiGianKetThuc = "";
            if (thoiGianCheckBox.Checked)
            {
                thoiGianBatDau = thoiGianBatDauDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
                thoiGianKetThuc = thoiGianKetThucDateTimePicker.Value.ToString("dd/MM/yyyy HH:mm:ss");
            }

            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai(tuKhoa, trangThai, loaiGiaTri, sapXep, thoiGianBatDau, thoiGianKetThuc);

            LoadDataToDataGridView(listKhuyenMai);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();
            trangThaiComboBox.SelectedItem = null;
            trangThaiComboBox.SelectedIndex = 0;
            loaiGiaTriComboBox.SelectedItem = null;
            loaiGiaTriComboBox.SelectedIndex = -1;
            sapXepComboBox.SelectedItem = null;
            sapXepComboBox.SelectedIndex = -1;
            thoiGianCheckBox.Checked = false;
            thoiGianBatDauDateTimePicker.Enabled = false;
            thoiGianKetThucDateTimePicker.Enabled = false;

            listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();

            LoadDataToDataGridView(listKhuyenMai);
        }

        private void trangThaiComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (trangThaiComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void loaiGiaTriComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (loaiGiaTriComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void sapXepComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sapXepComboBox.SelectedIndex != -1)
            {
                timKiemTextBox.Clear();
                timKiemButton_Click(sender, e);
            }
        }

        private void thoiGianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (thoiGianCheckBox.Checked)
            {
                thoiGianBatDauDateTimePicker.Enabled = true;
                thoiGianKetThucDateTimePicker.Enabled = true;
            }
            else
            {
                thoiGianBatDauDateTimePicker.Enabled = false;
                thoiGianKetThucDateTimePicker.Enabled = false;
            }
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelKhuyenMai(listKhuyenMai);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new TestChiTietKhuyenMaiForm("Thêm", this).Show();
        }

        private void khuyenMaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                KhuyenMai khuyenMai = khuyenMaiBUS.LayKhuyenMaiTheoMa(khuyenMaiDataGridView.Rows[e.RowIndex].Cells["maKhuyenMaiColumn"].Value.ToString());

                string columnName = khuyenMaiDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("infoButtonColumn"))
                {
                    new TestChiTietKhuyenMaiForm(khuyenMai, "Chi tiết", this).Show();
                }

                if (columnName.Equals("editButtonColumn"))
                {
                    new TestChiTietKhuyenMaiForm(khuyenMai, "Sửa", this).Show();
                }

                if (columnName.Equals("deleteButtonColumn"))
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa khuyến mãi không?", "Xác nhận", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        string maKhuyenMai = khuyenMaiDataGridView.Rows[e.RowIndex].Cells["maKhuyenMaiColumn"].Value.ToString();

                        MessageBox.Show(khuyenMaiBUS.XoaKhuyenMai(maKhuyenMai));

                        lamMoiButton_Click(sender, e);
                    }
                }
            }
        }

        private void xoaTatCaButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa các khuyến mãi đã chọn không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                bool hoanTat = true;

                for (int i = 0; i < khuyenMaiDataGridView.SelectedRows.Count; i++)
                {
                    string maKhuyenMai = khuyenMaiDataGridView.SelectedRows[i].Cells["maKhuyenMaiColumn"].Value.ToString();

                    if (!khuyenMaiBUS.XoaKhuyenMai(maKhuyenMai).Equals("Xóa Khuyến mãi thành công!"))
                    {
                        hoanTat = false;
                        break;
                    }
                }

                if (hoanTat)
                {
                    MessageBox.Show("Đã xóa tất cả khuyến mãi đã chọn!");
                    lamMoiButton_Click(sender, e);
                }
                else
                    MessageBox.Show("Quá trình xóa xảy ra lỗi!");
            }
        }

        private void khuyenMaiDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (khuyenMaiDataGridView.SelectedRows.Count > 1)
            {
                xoaTatCaButton.Visible = true;
            }
            else
            {
                xoaTatCaButton.Visible = false;
            }
        }

        private void khuyenMaiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9) && e.RowIndex >= 0)
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

        private void khuyenMaiDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 3; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < khuyenMaiDataGridView.Columns.Count - numberOfColumnsToSkip)
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
