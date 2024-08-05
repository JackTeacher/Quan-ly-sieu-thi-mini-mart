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

namespace GUI.CacFormChon
{
    public partial class TestChonKhuyenMaiForm : Form
    {
        KhuyenMaiBUS khuyenMaiBUS;
        List<KhuyenMai> listKhuyenMai;
        BanHangForm banHangForm;

        public TestChonKhuyenMaiForm(BanHangForm banHangForm)
        {
            InitializeComponent();
            CenterToParent();

            khuyenMaiBUS = new KhuyenMaiBUS();
            listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();
            this.banHangForm = banHangForm;
        }

        private void TestChonKhuyenMaiForm_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView(listKhuyenMai);
        }

        private void LoadDataToDataGridView(List<KhuyenMai> listKhuyenMai)
        {
            khuyenMaiDataGridView.Rows.Clear();

            if(listKhuyenMai.Count > 0)
            {
                for (int i = 0; i < listKhuyenMai.Count; i++)
                {
                    khuyenMaiDataGridView.Rows.Add(1);
                    khuyenMaiDataGridView.Rows[i].Cells[0].Value = listKhuyenMai[i].maKhuyenMai;
                    khuyenMaiDataGridView.Rows[i].Cells[1].Value = listKhuyenMai[i].tenKhuyenMai;
                    khuyenMaiDataGridView.Rows[i].Cells[2].Value = listKhuyenMai[i].thoiGianBatDau.ToString("dd/MM/yyyy HH:mm:ss");
                    khuyenMaiDataGridView.Rows[i].Cells[3].Value = listKhuyenMai[i].thoiGianKetThuc.ToString("dd/MM/yyyy HH:mm:ss");
                    khuyenMaiDataGridView.Rows[i].Cells[4].Value = listKhuyenMai[i].loaiGiaTri;
                    khuyenMaiDataGridView.Rows[i].Cells[5].Value = listKhuyenMai[i].giaTri;
                }
            }
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            string tuKhoa = timKiemTextBox.Text;

            listKhuyenMai = khuyenMaiBUS.TimKiemKhuyenMai(tuKhoa, "", "", "", "", "");

            LoadDataToDataGridView(listKhuyenMai);
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            timKiemButton_Click(sender, e);
        }

        internal void lamMoiButton_Click(object sender, EventArgs e)
        {
            timKiemTextBox.Clear();

            listKhuyenMai = khuyenMaiBUS.LayDanhSachKhuyenMai();

            LoadDataToDataGridView(listKhuyenMai);
        }

        private void khuyenMaiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex > 0)
            {
                KhuyenMai khuyenMai = khuyenMaiBUS.LayKhuyenMaiTheoMa(khuyenMaiDataGridView.Rows[e.RowIndex].Cells["maKhuyenMaiColumn"].Value.ToString());

                string columnName = khuyenMaiDataGridView.Columns[e.ColumnIndex].Name;

                if (columnName.Equals("chonKhuyenMaiButtonColumn"))
                {
                    banHangForm.khuyenMai = khuyenMai;
                    this.Close();
                }
            }
        }

        private void TestChonKhuyenMaiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            decimal tongTien = Decimal.Parse((banHangForm.tongTienLabel.Text.Where(char.IsDigit).ToArray()));
            decimal giamGia = Decimal.Parse((banHangForm.chietKhauLabel.Text.Where(char.IsDigit).ToArray()));

            if (banHangForm.khuyenMai != null)
            {
                banHangForm.tenKhuyenMaiLabel.Text = string.Empty;
                banHangForm.chietKhauLabel.Text = "0 VNĐ";

                giamGia = new KhuyenMaiBUS().ApDungKhuyenMai(banHangForm.khuyenMai.maKhuyenMai, tongTien.ToString());
                banHangForm.chietKhauLabel.Text = giamGia.ToString("#,##0") + " VNĐ";
                banHangForm.tenKhuyenMaiLabel.Text = "(" + banHangForm.khuyenMai.tenKhuyenMai + ")";
            }
        }
    }
}
