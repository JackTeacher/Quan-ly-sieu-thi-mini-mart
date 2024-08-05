using BUS;
using BUS.OtherFunctions;
using DTO;
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
    public partial class NhaCungCapForm : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;

        public NhaCungCapForm()
        {
            InitializeComponent();

            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();
        }

        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhaCungCap);
        }

        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            nhaCungCapDataGridView.Rows.Clear();

            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                nhaCungCapDataGridView.Rows.Add(1);
                nhaCungCapDataGridView.Rows[i].Cells[0].Value = i + 1;
                nhaCungCapDataGridView.Rows[i].Cells[1].Value = listNhaCungCap[i].maNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[2].Value = listNhaCungCap[i].tenNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[3].Value = listNhaCungCap[i].soDienThoai;
                nhaCungCapDataGridView.Rows[i].Cells[4].Value = listNhaCungCap[i].email;
                nhaCungCapDataGridView.Rows[i].Cells[5].Value = listNhaCungCap[i].diaChi;
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listNhaCungCap = nhaCungCapBUS.TimKiemNhaCungCap(tuKhoa);

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();

            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();

            LoadDataToDataGridView(listNhaCungCap);
        }

        private void themMoiButton_Click(object sender, EventArgs e)
        {
            new ChiTietNhaCungCapForm("Thêm", this).ShowDialog();
        }

        private void xuatExcelButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog.Title = "Chọn vị trí lưu file Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                new XuatExcel(filePath).XuatExcelNhaCungCap(listNhaCungCap);
                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nhaCungCapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(nhaCungCapDataGridView["maNhaCungCapColumn", e.RowIndex].Value.ToString());

            string columnName = nhaCungCapDataGridView.Columns[e.ColumnIndex].Name;

            if (columnName.Equals("infoButtonColumn"))
            {
                new ChiTietNhaCungCapForm(nhaCungCap, "Chi tiết", this).ShowDialog();
            }

            if (columnName.Equals("editButtonColumn"))
            {
                new ChiTietNhaCungCapForm(nhaCungCap, "Sửa", this).ShowDialog();
            }
        }

        private void nhaCungCapDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem cell đang được định dạng có phải là cell hình ảnh không.
            if ((e.ColumnIndex == 6 || e.ColumnIndex == 7) && e.RowIndex >= 0)
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

        private void nhaCungCapDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 2; // Số lượng cột cuối cùng không cần chia

            if (e.ColumnIndex > -1 && e.RowIndex >= 0 && e.ColumnIndex < nhaCungCapDataGridView.Columns.Count - numberOfColumnsToSkip)
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
