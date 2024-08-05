namespace GUI
{
    partial class SanPhamControl
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            anhSanPhamPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            tenSanPhamLabel = new Label();
            giaBanLabel = new Label();
            chonButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)anhSanPhamPictureBox).BeginInit();
            SuspendLayout();
            // 
            // anhSanPhamPictureBox
            // 
            anhSanPhamPictureBox.CustomizableEdges = customizableEdges1;
            anhSanPhamPictureBox.Image = Properties.Resources._004_lock;
            anhSanPhamPictureBox.ImageRotate = 0F;
            anhSanPhamPictureBox.Location = new Point(3, 3);
            anhSanPhamPictureBox.Name = "anhSanPhamPictureBox";
            anhSanPhamPictureBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            anhSanPhamPictureBox.Size = new Size(80, 80);
            anhSanPhamPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            anhSanPhamPictureBox.TabIndex = 0;
            anhSanPhamPictureBox.TabStop = false;
            // 
            // tenSanPhamLabel
            // 
            tenSanPhamLabel.BackColor = Color.FromArgb(223, 243, 252);
            tenSanPhamLabel.Font = new Font("Segoe UI", 11.25F);
            tenSanPhamLabel.ForeColor = SystemColors.ActiveCaptionText;
            tenSanPhamLabel.Location = new Point(89, 3);
            tenSanPhamLabel.Name = "tenSanPhamLabel";
            tenSanPhamLabel.Size = new Size(91, 80);
            tenSanPhamLabel.TabIndex = 1;
            tenSanPhamLabel.Text = "cà phê chả trà sữa bún đá ";
            tenSanPhamLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // giaBanLabel
            // 
            giaBanLabel.BackColor = Color.FromArgb(223, 243, 252);
            giaBanLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            giaBanLabel.ForeColor = Color.FromArgb(0, 50, 90);
            giaBanLabel.Location = new Point(3, 86);
            giaBanLabel.Name = "giaBanLabel";
            giaBanLabel.Size = new Size(177, 25);
            giaBanLabel.TabIndex = 2;
            giaBanLabel.Text = "1.000.000 VNĐ";
            giaBanLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chonButton
            // 
            chonButton.BackColor = Color.FromArgb(0, 50, 90);
            chonButton.Dock = DockStyle.Bottom;
            chonButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            chonButton.ForeColor = Color.White;
            chonButton.IconChar = FontAwesome.Sharp.IconChar.None;
            chonButton.IconColor = Color.Black;
            chonButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            chonButton.Location = new Point(0, 114);
            chonButton.Name = "chonButton";
            chonButton.Size = new Size(183, 31);
            chonButton.TabIndex = 3;
            chonButton.Text = "Chọn";
            chonButton.UseVisualStyleBackColor = false;
            chonButton.Click += chonButton_Click;
            // 
            // SanPhamControl
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            Controls.Add(chonButton);
            Controls.Add(giaBanLabel);
            Controls.Add(tenSanPhamLabel);
            Controls.Add(anhSanPhamPictureBox);
            Font = new Font("Segoe UI", 14.25F);
            Margin = new Padding(5);
            Name = "SanPhamControl";
            Size = new Size(183, 145);
            Load += SanPhamControl_Load;
            ((System.ComponentModel.ISupportInitialize)anhSanPhamPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2PictureBox anhSanPhamPictureBox;
        private Label tenSanPhamLabel;
        private Label giaBanLabel;
        private FontAwesome.Sharp.IconButton chonButton;
    }
}
