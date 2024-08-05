namespace GUI
{
    partial class PhanQuyenForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            phanQuyenDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)phanQuyenDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timKiemTextBox
            // 
            timKiemTextBox.CustomizableEdges = customizableEdges1;
            timKiemTextBox.DefaultText = "";
            timKiemTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            timKiemTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            timKiemTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            timKiemTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            timKiemTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(5, 11);
            timKiemTextBox.Margin = new Padding(5, 5, 5, 5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(821, 36);
            timKiemTextBox.TabIndex = 29;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 70);
            panel2.TabIndex = 28;
            // 
            // lamMoiButton
            // 
            lamMoiButton.BackColor = Color.FromArgb(33, 31, 48);
            lamMoiButton.FlatAppearance.BorderSize = 0;
            lamMoiButton.FlatStyle = FlatStyle.Flat;
            lamMoiButton.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            lamMoiButton.IconColor = Color.White;
            lamMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            lamMoiButton.IconSize = 20;
            lamMoiButton.Location = new Point(883, 11);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 72;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // timKiemButton
            // 
            timKiemButton.BackColor = Color.FromArgb(226, 153, 48);
            timKiemButton.FlatAppearance.BorderSize = 0;
            timKiemButton.FlatStyle = FlatStyle.Flat;
            timKiemButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            timKiemButton.IconColor = Color.White;
            timKiemButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            timKiemButton.IconSize = 20;
            timKiemButton.Location = new Point(834, 11);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 71;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
            // 
            // xuatExcelButton
            // 
            xuatExcelButton.BackColor = Color.FromArgb(33, 31, 48);
            xuatExcelButton.FlatAppearance.BorderSize = 0;
            xuatExcelButton.FlatStyle = FlatStyle.Flat;
            xuatExcelButton.Font = new Font("Microsoft Sans Serif", 12F);
            xuatExcelButton.ForeColor = Color.White;
            xuatExcelButton.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            xuatExcelButton.IconColor = Color.White;
            xuatExcelButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            xuatExcelButton.IconSize = 20;
            xuatExcelButton.ImageAlign = ContentAlignment.MiddleLeft;
            xuatExcelButton.Location = new Point(932, 11);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(116, 36);
            xuatExcelButton.TabIndex = 70;
            xuatExcelButton.Text = "Xuất Excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(phanQuyenDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 70);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1143, 751);
            panel3.TabIndex = 29;
            // 
            // phanQuyenDataGridView
            // 
            phanQuyenDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            phanQuyenDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            phanQuyenDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            phanQuyenDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            phanQuyenDataGridView.ColumnHeadersHeight = 40;
            phanQuyenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            phanQuyenDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, Column1, Column3 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            phanQuyenDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            phanQuyenDataGridView.Dock = DockStyle.Fill;
            phanQuyenDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            phanQuyenDataGridView.Location = new Point(0, 0);
            phanQuyenDataGridView.Margin = new Padding(5);
            phanQuyenDataGridView.Name = "phanQuyenDataGridView";
            phanQuyenDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            phanQuyenDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            phanQuyenDataGridView.RowHeadersVisible = false;
            phanQuyenDataGridView.RowTemplate.DividerHeight = 3;
            phanQuyenDataGridView.RowTemplate.Height = 50;
            phanQuyenDataGridView.Size = new Size(1143, 751);
            phanQuyenDataGridView.TabIndex = 28;
            phanQuyenDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            phanQuyenDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            phanQuyenDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            phanQuyenDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            phanQuyenDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            phanQuyenDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            phanQuyenDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            phanQuyenDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            phanQuyenDataGridView.ThemeStyle.ReadOnly = true;
            phanQuyenDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            phanQuyenDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            phanQuyenDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            phanQuyenDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            phanQuyenDataGridView.ThemeStyle.RowsStyle.Height = 50;
            phanQuyenDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            phanQuyenDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            phanQuyenDataGridView.CellPainting += phanQuyenDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 43;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.FillWeight = 129.305817F;
            Column1.HeaderText = "Mã phân quyền";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên phân quyền";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 821);
            panel1.TabIndex = 3;
            // 
            // PhanQuyenForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 243, 252);
            ClientSize = new Size(1143, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "PhanQuyenForm";
            Text = "QUẢN LÝ PHÂN QUYỀN";
            Load += PhanQuyenForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)phanQuyenDataGridView).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Panel panel2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView phanQuyenDataGridView;
        private Panel panel1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
    }
}