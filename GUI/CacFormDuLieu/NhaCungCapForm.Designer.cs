namespace GUI
{
    partial class NhaCungCapForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nhaCungCapDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            maNhaCungCapColumn = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            infoButtonColumn = new DataGridViewImageColumn();
            editButtonColumn = new DataGridViewImageColumn();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            xuatExcelButton = new FontAwesome.Sharp.IconButton();
            themMoiButton = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nhaCungCapDataGridView
            // 
            nhaCungCapDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            nhaCungCapDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            nhaCungCapDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            nhaCungCapDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            nhaCungCapDataGridView.ColumnHeadersHeight = 40;
            nhaCungCapDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nhaCungCapDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column2, maNhaCungCapColumn, Column3, Column4, Column5, Column6, infoButtonColumn, editButtonColumn });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            nhaCungCapDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            nhaCungCapDataGridView.Dock = DockStyle.Fill;
            nhaCungCapDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.Location = new Point(0, 0);
            nhaCungCapDataGridView.Name = "nhaCungCapDataGridView";
            nhaCungCapDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            nhaCungCapDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            nhaCungCapDataGridView.RowHeadersVisible = false;
            nhaCungCapDataGridView.RowTemplate.DividerHeight = 3;
            nhaCungCapDataGridView.RowTemplate.Height = 50;
            nhaCungCapDataGridView.Size = new Size(1183, 761);
            nhaCungCapDataGridView.TabIndex = 28;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            nhaCungCapDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            nhaCungCapDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            nhaCungCapDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            nhaCungCapDataGridView.ThemeStyle.ReadOnly = true;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.Height = 50;
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            nhaCungCapDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            nhaCungCapDataGridView.CellContentClick += nhaCungCapDataGridView_CellContentClick;
            nhaCungCapDataGridView.CellFormatting += nhaCungCapDataGridView_CellFormatting;
            nhaCungCapDataGridView.CellPainting += nhaCungCapDataGridView_CellPainting;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.HeaderText = "#";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 46;
            // 
            // maNhaCungCapColumn
            // 
            maNhaCungCapColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maNhaCungCapColumn.FillWeight = 129.305817F;
            maNhaCungCapColumn.HeaderText = "Mã nhà cung cấp";
            maNhaCungCapColumn.Name = "maNhaCungCapColumn";
            maNhaCungCapColumn.ReadOnly = true;
            maNhaCungCapColumn.Resizable = DataGridViewTriState.True;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.FillWeight = 155.167023F;
            Column3.HeaderText = "Tên nhà cung cấp";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.FillWeight = 155.167023F;
            Column4.HeaderText = "Số điện thoại";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Địa chỉ";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // infoButtonColumn
            // 
            infoButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            infoButtonColumn.FillWeight = 30F;
            infoButtonColumn.HeaderText = "";
            infoButtonColumn.Image = Properties.Resources._003_info1;
            infoButtonColumn.Name = "infoButtonColumn";
            infoButtonColumn.ReadOnly = true;
            infoButtonColumn.Width = 5;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            editButtonColumn.FillWeight = 30F;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Image = Properties.Resources._002_pencil1;
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Width = 5;
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
            timKiemButton.Location = new Point(592, 12);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 32;
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
            xuatExcelButton.Location = new Point(690, 12);
            xuatExcelButton.Name = "xuatExcelButton";
            xuatExcelButton.Size = new Size(116, 36);
            xuatExcelButton.TabIndex = 31;
            xuatExcelButton.Text = "Xuất Excel";
            xuatExcelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            xuatExcelButton.UseVisualStyleBackColor = false;
            xuatExcelButton.Click += xuatExcelButton_Click;
            // 
            // themMoiButton
            // 
            themMoiButton.BackColor = Color.FromArgb(226, 153, 48);
            themMoiButton.FlatAppearance.BorderSize = 0;
            themMoiButton.FlatStyle = FlatStyle.Flat;
            themMoiButton.Font = new Font("Microsoft Sans Serif", 12F);
            themMoiButton.ForeColor = Color.White;
            themMoiButton.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            themMoiButton.IconColor = Color.White;
            themMoiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            themMoiButton.IconSize = 20;
            themMoiButton.ImageAlign = ContentAlignment.MiddleLeft;
            themMoiButton.Location = new Point(812, 12);
            themMoiButton.Name = "themMoiButton";
            themMoiButton.Size = new Size(115, 36);
            themMoiButton.TabIndex = 30;
            themMoiButton.Text = "Thêm mới";
            themMoiButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            themMoiButton.UseVisualStyleBackColor = false;
            themMoiButton.Click += themMoiButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(xuatExcelButton);
            panel2.Controls.Add(themMoiButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 60);
            panel2.TabIndex = 28;
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
            timKiemTextBox.Font = new Font("Segoe UI", 12F);
            timKiemTextBox.ForeColor = Color.FromArgb(84, 155, 255);
            timKiemTextBox.HoverState.BorderColor = Color.FromArgb(0, 192, 192);
            timKiemTextBox.Location = new Point(14, 12);
            timKiemTextBox.Margin = new Padding(5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderForeColor = Color.FromArgb(186, 215, 255);
            timKiemTextBox.PlaceholderText = "Nhập tên để tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(570, 36);
            timKiemTextBox.TabIndex = 69;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
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
            lamMoiButton.Location = new Point(641, 12);
            lamMoiButton.Name = "lamMoiButton";
            lamMoiButton.Size = new Size(43, 36);
            lamMoiButton.TabIndex = 68;
            lamMoiButton.UseVisualStyleBackColor = false;
            lamMoiButton.Click += lamMoiButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(nhaCungCapDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(1183, 761);
            panel3.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1183, 821);
            panel1.TabIndex = 3;
            // 
            // NhaCungCapForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 821);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "NhaCungCapForm";
            Text = "QUẢN LÝ NHÀ CUNG CẤP";
            Load += NhaCungCapForm_Load;
            ((System.ComponentModel.ISupportInitialize)nhaCungCapDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView nhaCungCapDataGridView;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private FontAwesome.Sharp.IconButton xuatExcelButton;
        private FontAwesome.Sharp.IconButton themMoiButton;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private Panel panel3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn maNhaCungCapColumn;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn infoButtonColumn;
        private DataGridViewImageColumn editButtonColumn;
    }
}