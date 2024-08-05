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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI
{
    public partial class SanPhamControl : UserControl
    {
        SanPham sanPham;
        BanHangForm banHangForm;

        public SanPhamControl(SanPham sanPham, BanHangForm banHangForm)
        {
            InitializeComponent();

            this.sanPham = sanPham;
            this.banHangForm = banHangForm;
        }

        private void SanPhamControl_Load(object sender, EventArgs e)
        {
            tenSanPhamLabel.Text = sanPham.tenSanPham;
            giaBanLabel.Text = sanPham.giaBan.ToString("#,##0") + " VNĐ";
            anhSanPhamPictureBox.Image = ImageHelper.ByteArrayToImage(sanPham.duLieuAnh);
        }

        private void chonButton_Click(object sender, EventArgs e)
        {
            if (banHangForm.listSanPhamDonHang.Contains(sanPham))
            {
                foreach(Control control in banHangForm.chiTietDonHangFlowLayoutPanel.Controls)
                {
                    if (control is DonDatHangControl)
                    {
                        DonDatHangControl donDatHangControl = (DonDatHangControl)control;
                        if (donDatHangControl.sanPham == sanPham)
                            donDatHangControl.soLuongNumericUpDown.Value++;
                    }
                }
            }
            else
            {
                banHangForm.listSanPhamDonHang.Add(sanPham);
                banHangForm.chiTietDonHangFlowLayoutPanel.Controls.Add(new DonDatHangControl(sanPham, banHangForm));
            }
        }
    }
}
