using BUS;
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

namespace GUI.CacFormChon
{
    public partial class ChonNhaCungCap : Form
    {
        NhaCungCapBUS nhaCungCapBUS;
        List<NhaCungCap> listNhaCungCap;
        ChiTietSanPhamForm chiTietSanPhamForm;
        NhapHangForm nhapHangForm;
        public ChonNhaCungCap(ChiTietSanPhamForm chiTietSanPhamForm)
        {
            InitializeComponent();
            CenterToParent();
            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();
            this.chiTietSanPhamForm = chiTietSanPhamForm;
        }

        public ChonNhaCungCap(NhapHangForm nhapHangForm)
        {
            InitializeComponent();
            CenterToParent();
            nhaCungCapBUS = new NhaCungCapBUS();
            listNhaCungCap = nhaCungCapBUS.LayDanhSachNhaCungCap();
            this.nhapHangForm = nhapHangForm;
        }
        private void TestChonNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listNhaCungCap);
        }
        private void LoadDataToDataGridView(List<NhaCungCap> listNhaCungCap)
        {
            nhaCungCapDataGridView.Rows.Clear();

            for (int i = 0; i < listNhaCungCap.Count; i++)
            {
                nhaCungCapDataGridView.Rows.Add(1);
                nhaCungCapDataGridView.Rows[i].Cells[0].Value = listNhaCungCap[i].maNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[1].Value = listNhaCungCap[i].tenNhaCungCap;
                nhaCungCapDataGridView.Rows[i].Cells[2].Value = listNhaCungCap[i].soDienThoai;
                nhaCungCapDataGridView.Rows[i].Cells[3].Value = listNhaCungCap[i].email;
                nhaCungCapDataGridView.Rows[i].Cells[4].Value = listNhaCungCap[i].diaChi;
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

        private void nhaCungCapDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                NhaCungCap nhaCungCap = nhaCungCapBUS.LayNhaCungCapTheoMa(nhaCungCapDataGridView["maNhaCungCapColumn", e.RowIndex].Value.ToString());

                string columnName = nhaCungCapDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chonNhaCungCapButtonColumn"))
                {
                    if (nhapHangForm != null)
                    {
                        nhapHangForm.nhaCungCap = nhaCungCap;
                        nhapHangForm.maNhaCungCapTextBox.Text = nhaCungCap.maNhaCungCap;
                        nhapHangForm.tenNhaCungCapTextBox.Text = nhaCungCap.tenNhaCungCap;
                        nhapHangForm.canhBaoLabel.Visible = false;
                    }

                    this.Close();
                }
            }
        }
        private void phanQuyenDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int numberOfColumnsToSkip = 0; // Số lượng cột cuối cùng không cần chia

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

        private void quayLaiButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
