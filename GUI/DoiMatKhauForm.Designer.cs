namespace GUI
{
    partial class DoiMatKhauForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel2 = new Panel();
            luuButton = new Guna.UI2.WinForms.Guna2Button();
            huyBoButton = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            panel3 = new Panel();
            quayLaiButton = new FontAwesome.Sharp.IconButton();
            tieuDeFormLabel = new Label();
            label5 = new Label();
            label2 = new Label();
            matKhauMoiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            matKhauCuTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            label1 = new Label();
            xacNhanMatKhauMoiTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(xacNhanMatKhauMoiTextBox);
            panel2.Controls.Add(luuButton);
            panel2.Controls.Add(huyBoButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(matKhauMoiTextBox);
            panel2.Controls.Add(matKhauCuTextBox);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(484, 426);
            panel2.TabIndex = 5;
            // 
            // luuButton
            // 
            luuButton.BorderRadius = 5;
            luuButton.CustomizableEdges = customizableEdges3;
            luuButton.DisabledState.BorderColor = Color.DarkGray;
            luuButton.DisabledState.CustomBorderColor = Color.DarkGray;
            luuButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            luuButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            luuButton.FillColor = Color.FromArgb(0, 79, 111);
            luuButton.Font = new Font("Microsoft Sans Serif", 12F);
            luuButton.ForeColor = Color.White;
            luuButton.Location = new Point(274, 352);
            luuButton.Name = "luuButton";
            luuButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            luuButton.Size = new Size(160, 40);
            luuButton.TabIndex = 42;
            luuButton.Text = "Lưu";
            luuButton.Click += luuButton_Click;
            // 
            // huyBoButton
            // 
            huyBoButton.BorderColor = Color.FromArgb(0, 79, 111);
            huyBoButton.BorderRadius = 5;
            huyBoButton.BorderThickness = 1;
            huyBoButton.CustomizableEdges = customizableEdges5;
            huyBoButton.DisabledState.BorderColor = Color.DarkGray;
            huyBoButton.DisabledState.CustomBorderColor = Color.DarkGray;
            huyBoButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            huyBoButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            huyBoButton.FillColor = Color.White;
            huyBoButton.Font = new Font("Microsoft Sans Serif", 12F);
            huyBoButton.ForeColor = Color.FromArgb(0, 79, 111);
            huyBoButton.Location = new Point(108, 352);
            huyBoButton.Name = "huyBoButton";
            huyBoButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            huyBoButton.Size = new Size(160, 40);
            huyBoButton.TabIndex = 41;
            huyBoButton.Text = "Huỷ bỏ";
            huyBoButton.Click += huyBoButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 79, 111);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(tieuDeFormLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 54);
            panel1.TabIndex = 40;
            // 
            // panel3
            // 
            panel3.Controls.Add(quayLaiButton);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(414, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(70, 54);
            panel3.TabIndex = 1;
            // 
            // quayLaiButton
            // 
            quayLaiButton.Dock = DockStyle.Right;
            quayLaiButton.FlatAppearance.BorderSize = 0;
            quayLaiButton.FlatStyle = FlatStyle.Flat;
            quayLaiButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            quayLaiButton.IconColor = Color.White;
            quayLaiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quayLaiButton.Location = new Point(0, 0);
            quayLaiButton.Name = "quayLaiButton";
            quayLaiButton.Size = new Size(70, 54);
            quayLaiButton.TabIndex = 2;
            quayLaiButton.UseVisualStyleBackColor = true;
            quayLaiButton.Click += quayLaiButton_Click;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(5, 9);
            tieuDeFormLabel.Margin = new Padding(5, 0, 5, 0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(162, 32);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Đổi mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.ForeColor = Color.FromArgb(0, 79, 111);
            label5.Location = new Point(35, 154);
            label5.Name = "label5";
            label5.Size = new Size(122, 24);
            label5.TabIndex = 31;
            label5.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F);
            label2.ForeColor = Color.FromArgb(0, 79, 111);
            label2.Location = new Point(35, 72);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 28;
            label2.Text = "Mật khẩu cũ";
            // 
            // matKhauMoiTextBox
            // 
            matKhauMoiTextBox.BorderColor = Color.FromArgb(0, 79, 111);
            matKhauMoiTextBox.BorderRadius = 5;
            matKhauMoiTextBox.CustomizableEdges = customizableEdges7;
            matKhauMoiTextBox.DefaultText = "";
            matKhauMoiTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matKhauMoiTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matKhauMoiTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matKhauMoiTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matKhauMoiTextBox.FocusedState.BorderColor = SystemColors.Highlight;
            matKhauMoiTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            matKhauMoiTextBox.Location = new Point(35, 183);
            matKhauMoiTextBox.Margin = new Padding(5, 5, 5, 5);
            matKhauMoiTextBox.Name = "matKhauMoiTextBox";
            matKhauMoiTextBox.PasswordChar = '\0';
            matKhauMoiTextBox.PlaceholderText = "";
            matKhauMoiTextBox.SelectedText = "";
            matKhauMoiTextBox.ShadowDecoration.CustomizableEdges = customizableEdges8;
            matKhauMoiTextBox.Size = new Size(399, 40);
            matKhauMoiTextBox.TabIndex = 24;
            // 
            // matKhauCuTextBox
            // 
            matKhauCuTextBox.BorderColor = Color.FromArgb(0, 79, 111);
            matKhauCuTextBox.BorderRadius = 5;
            matKhauCuTextBox.CustomizableEdges = customizableEdges9;
            matKhauCuTextBox.DefaultText = "";
            matKhauCuTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            matKhauCuTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            matKhauCuTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            matKhauCuTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            matKhauCuTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            matKhauCuTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            matKhauCuTextBox.Location = new Point(35, 101);
            matKhauCuTextBox.Margin = new Padding(5, 5, 5, 5);
            matKhauCuTextBox.Name = "matKhauCuTextBox";
            matKhauCuTextBox.PasswordChar = '\0';
            matKhauCuTextBox.PlaceholderText = "";
            matKhauCuTextBox.SelectedText = "";
            matKhauCuTextBox.ShadowDecoration.CustomizableEdges = customizableEdges10;
            matKhauCuTextBox.Size = new Size(171, 40);
            matKhauCuTextBox.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F);
            label1.ForeColor = Color.FromArgb(0, 79, 111);
            label1.Location = new Point(35, 246);
            label1.Name = "label1";
            label1.Size = new Size(209, 24);
            label1.TabIndex = 46;
            label1.Text = "Xác nhận mật khẩu mới";
            // 
            // xacNhanMatKhauMoiTextBox
            // 
            xacNhanMatKhauMoiTextBox.BorderColor = Color.FromArgb(0, 79, 111);
            xacNhanMatKhauMoiTextBox.BorderRadius = 5;
            xacNhanMatKhauMoiTextBox.CustomizableEdges = customizableEdges1;
            xacNhanMatKhauMoiTextBox.DefaultText = "";
            xacNhanMatKhauMoiTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            xacNhanMatKhauMoiTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            xacNhanMatKhauMoiTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            xacNhanMatKhauMoiTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            xacNhanMatKhauMoiTextBox.FocusedState.BorderColor = SystemColors.Highlight;
            xacNhanMatKhauMoiTextBox.Font = new Font("Microsoft Sans Serif", 14.25F);
            xacNhanMatKhauMoiTextBox.Location = new Point(35, 275);
            xacNhanMatKhauMoiTextBox.Margin = new Padding(5, 5, 5, 5);
            xacNhanMatKhauMoiTextBox.Name = "xacNhanMatKhauMoiTextBox";
            xacNhanMatKhauMoiTextBox.PasswordChar = '\0';
            xacNhanMatKhauMoiTextBox.PlaceholderText = "";
            xacNhanMatKhauMoiTextBox.SelectedText = "";
            xacNhanMatKhauMoiTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            xacNhanMatKhauMoiTextBox.Size = new Size(399, 40);
            xacNhanMatKhauMoiTextBox.TabIndex = 45;
            // 
            // DoiMatKhauForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 426);
            Controls.Add(panel2);
            Name = "DoiMatKhauForm";
            Text = "DoiMatKhauForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox xacNhanMatKhauMoiTextBox;
        private Guna.UI2.WinForms.Guna2Button luuButton;
        private Guna.UI2.WinForms.Guna2Button huyBoButton;
        private Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton quayLaiButton;
        private Label tieuDeFormLabel;
        private Label label5;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox matKhauMoiTextBox;
        private Guna.UI2.WinForms.Guna2TextBox matKhauCuTextBox;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}