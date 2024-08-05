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
    public partial class SanPhamNhapHangUserControl : UserControl
    {
        SanPham sanPham;
        NhapHangForm nhapHangForm;

        public SanPhamNhapHangUserControl(SanPham sanPham, NhapHangForm nhapHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.nhapHangForm = nhapHangForm;
        }

        private void SanPhamNhapHangUserControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
        }

        private void anhSanPhamPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void chonButton_Click(object sender, EventArgs e)
        {
            if (nhapHangForm.listSanPhamNhapHang != null && nhapHangForm.listSanPhamNhapHang.Contains(sanPham))
            {
                foreach (Control control in nhapHangForm.chiTietDonHangFlowLayoutPanel.Controls)
                {
                    if (control is DonNhapHangUserControl)
                    {
                        DonNhapHangUserControl donNhapHangUserControl = (DonNhapHangUserControl)control;
                        if (donNhapHangUserControl.sanPham == sanPham)
                            donNhapHangUserControl.soLuongNumericUpDown.Value++;
                    }
                }
            }
            else
            {
                nhapHangForm.listSanPhamNhapHang.Add(sanPham);
                nhapHangForm.chiTietDonHangFlowLayoutPanel.Controls.Add(new DonNhapHangUserControl(sanPham, nhapHangForm));
            }
        }
    }
}
