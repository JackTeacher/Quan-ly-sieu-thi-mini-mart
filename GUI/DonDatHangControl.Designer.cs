namespace GUI
{
    partial class DonDatHangControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            soLuongNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            xoaButton = new FontAwesome.Sharp.IconButton();
            tongGiaLabel = new Label();
            tenSanPhamLabel = new Label();
            guna2ShadowPanel1.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2CustomGradientPanel1);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 15;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(575, 53);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BorderRadius = 5;
            guna2CustomGradientPanel1.Controls.Add(soLuongNumericUpDown);
            guna2CustomGradientPanel1.Controls.Add(xoaButton);
            guna2CustomGradientPanel1.Controls.Add(tongGiaLabel);
            guna2CustomGradientPanel1.Controls.Add(tenSanPhamLabel);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges3;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor2 = Color.WhiteSmoke;
            guna2CustomGradientPanel1.FillColor4 = Color.WhiteSmoke;
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2CustomGradientPanel1.Size = new Size(575, 53);
            guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // soLuongNumericUpDown
            // 
            soLuongNumericUpDown.BackColor = Color.Transparent;
            soLuongNumericUpDown.BorderRadius = 5;
            soLuongNumericUpDown.CustomizableEdges = customizableEdges1;
            soLuongNumericUpDown.Font = new Font("Segoe UI", 9F);
            soLuongNumericUpDown.Location = new Point(254, 9);
            soLuongNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            soLuongNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.Name = "soLuongNumericUpDown";
            soLuongNumericUpDown.ShadowDecoration.CustomizableEdges = customizableEdges2;
            soLuongNumericUpDown.Size = new Size(72, 34);
            soLuongNumericUpDown.TabIndex = 13;
            soLuongNumericUpDown.UpDownButtonFillColor = Color.FromArgb(0, 50, 90);
            soLuongNumericUpDown.UpDownButtonForeColor = Color.White;
            soLuongNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            soLuongNumericUpDown.ValueChanged += soLuongNumericUpDown_ValueChanged;
            // 
            // xoaButton
            // 
            xoaButton.BackColor = Color.Transparent;
            xoaButton.FlatAppearance.BorderSize = 0;
            xoaButton.FlatAppearance.MouseOverBackColor = Color.MistyRose;
            xoaButton.FlatStyle = FlatStyle.Flat;
            xoaButton.Font = new Font("Microsoft Sans Serif", 14.25F);
            xoaButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            xoaButton.IconColor = Color.IndianRed;
            xoaButton.IconFont = FontAwesome.Sharp.IconFont.Solid;
            xoaButton.IconSize = 20;
            xoaButton.Location = new Point(542, 11);
            xoaButton.Name = "xoaButton";
            xoaButton.Padding = new Padding(0, 3, 0, 0);
            xoaButton.Size = new Size(30, 30);
            xoaButton.TabIndex = 12;
            xoaButton.UseVisualStyleBackColor = false;
            xoaButton.Click += xoaButton_Click;
            // 
            // tongGiaLabel
            // 
            tongGiaLabel.AutoSize = true;
            tongGiaLabel.BackColor = Color.Transparent;
            tongGiaLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            tongGiaLabel.ForeColor = Color.FromArgb(0, 50, 90);
            tongGiaLabel.Location = new Point(354, 11);
            tongGiaLabel.Name = "tongGiaLabel";
            tongGiaLabel.Size = new Size(173, 30);
            tongGiaLabel.TabIndex = 8;
            tongGiaLabel.Text = "10.000.000 VNĐ";
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.BackColor = Color.Transparent;
            tenSanPhamLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tenSanPhamLabel.ForeColor = SystemColors.ActiveCaptionText;
            tenSanPhamLabel.Location = new Point(3, 0);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(236, 53);
            tenSanPhamLabel.TabIndex = 7;
            tenSanPhamLabel.Text = "Sữa tắm bảo vệ khỏi vi khuẩn lifebuoy chăm sóc da 980ml";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DonDatHangControl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Font = new Font("Segoe UI", 14.25F);
            Name = "DonDatHangControl";
            Size = new Size(575, 53);
            Load += DonDatHangControl_Load;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDown1;
        private FontAwesome.Sharp.IconButton iconButton8;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton xoaButton;
        private Label tenSanPhamLabel;
        internal Guna.UI2.WinForms.Guna2NumericUpDown soLuongNumericUpDown;
        internal Label tongGiaLabel;
    }
}
