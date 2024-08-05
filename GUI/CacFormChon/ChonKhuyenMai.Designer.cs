namespace GUI.CacFormChon
{
    partial class ChonKhuyenMai
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel4 = new Panel();
            quayLaiButton = new FontAwesome.Sharp.IconButton();
            tieuDeFormLabel = new Label();
            lamMoiButton = new FontAwesome.Sharp.IconButton();
            timKiemButton = new FontAwesome.Sharp.IconButton();
            timKiemTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            khuyenMaiDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            panel3 = new Panel();
            panel1 = new Panel();
            maKhuyenMaiColumn = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            chonKhuyenMaiButtonColumn = new DataGridViewButtonColumn();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(223, 243, 252);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(lamMoiButton);
            panel2.Controls.Add(timKiemButton);
            panel2.Controls.Add(timKiemTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 99);
            panel2.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 79, 111);
            panel4.Controls.Add(quayLaiButton);
            panel4.Controls.Add(tieuDeFormLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(910, 44);
            panel4.TabIndex = 73;
            // 
            // quayLaiButton
            // 
            quayLaiButton.Dock = DockStyle.Right;
            quayLaiButton.FlatAppearance.BorderSize = 0;
            quayLaiButton.FlatStyle = FlatStyle.Flat;
            quayLaiButton.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            quayLaiButton.IconColor = Color.White;
            quayLaiButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quayLaiButton.Location = new Point(827, 0);
            quayLaiButton.Name = "quayLaiButton";
            quayLaiButton.Size = new Size(83, 44);
            quayLaiButton.TabIndex = 1;
            quayLaiButton.UseVisualStyleBackColor = true;
            quayLaiButton.Click += quayLaiButton_Click;
            // 
            // tieuDeFormLabel
            // 
            tieuDeFormLabel.AutoSize = true;
            tieuDeFormLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            tieuDeFormLabel.ForeColor = Color.White;
            tieuDeFormLabel.Location = new Point(40, 9);
            tieuDeFormLabel.Margin = new Padding(5, 0, 5, 0);
            tieuDeFormLabel.Name = "tieuDeFormLabel";
            tieuDeFormLabel.Size = new Size(212, 29);
            tieuDeFormLabel.TabIndex = 0;
            tieuDeFormLabel.Text = "Chọn khuyến mãi";
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
            lamMoiButton.Location = new Point(864, 52);
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
            timKiemButton.Location = new Point(815, 52);
            timKiemButton.Name = "timKiemButton";
            timKiemButton.Size = new Size(43, 36);
            timKiemButton.TabIndex = 71;
            timKiemButton.UseVisualStyleBackColor = false;
            timKiemButton.Click += timKiemButton_Click;
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
            timKiemTextBox.Location = new Point(5, 52);
            timKiemTextBox.Margin = new Padding(5, 5, 5, 5);
            timKiemTextBox.Name = "timKiemTextBox";
            timKiemTextBox.PasswordChar = '\0';
            timKiemTextBox.PlaceholderText = "Tìm kiếm";
            timKiemTextBox.SelectedText = "";
            timKiemTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            timKiemTextBox.Size = new Size(802, 36);
            timKiemTextBox.TabIndex = 29;
            timKiemTextBox.TextChanged += timKiemTextBox_TextChanged;
            // 
            // khuyenMaiDataGridView
            // 
            khuyenMaiDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            khuyenMaiDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            khuyenMaiDataGridView.BackgroundColor = Color.FromArgb(242, 245, 250);
            khuyenMaiDataGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.LightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(30, 110, 142);
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            khuyenMaiDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            khuyenMaiDataGridView.ColumnHeadersHeight = 40;
            khuyenMaiDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            khuyenMaiDataGridView.Columns.AddRange(new DataGridViewColumn[] { maKhuyenMaiColumn, Column2, Column5, Column1, Column3, Column4, chonKhuyenMaiButtonColumn });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 248, 251);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            khuyenMaiDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            khuyenMaiDataGridView.Dock = DockStyle.Fill;
            khuyenMaiDataGridView.GridColor = Color.FromArgb(242, 245, 250);
            khuyenMaiDataGridView.Location = new Point(0, 0);
            khuyenMaiDataGridView.Margin = new Padding(5);
            khuyenMaiDataGridView.Name = "khuyenMaiDataGridView";
            khuyenMaiDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            khuyenMaiDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            khuyenMaiDataGridView.RowHeadersVisible = false;
            khuyenMaiDataGridView.RowTemplate.DividerHeight = 3;
            khuyenMaiDataGridView.RowTemplate.Height = 50;
            khuyenMaiDataGridView.Size = new Size(910, 403);
            khuyenMaiDataGridView.TabIndex = 28;
            khuyenMaiDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            khuyenMaiDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new Font("Segoe UI", 9F);
            khuyenMaiDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = SystemColors.ControlText;
            khuyenMaiDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            khuyenMaiDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            khuyenMaiDataGridView.ThemeStyle.BackColor = Color.FromArgb(242, 245, 250);
            khuyenMaiDataGridView.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.ForeColor = Color.DimGray;
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            khuyenMaiDataGridView.ThemeStyle.HeaderStyle.Height = 40;
            khuyenMaiDataGridView.ThemeStyle.ReadOnly = true;
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.BackColor = Color.White;
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.Font = new Font("Microsoft Sans Serif", 14.25F);
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.Height = 50;
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(0, 80, 112);
            khuyenMaiDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            khuyenMaiDataGridView.CellContentClick += khuyenMaiDataGridView_CellContentClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(khuyenMaiDataGridView);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 99);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(910, 403);
            panel3.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 502);
            panel1.TabIndex = 5;
            // 
            // maKhuyenMaiColumn
            // 
            maKhuyenMaiColumn.FillWeight = 80F;
            maKhuyenMaiColumn.HeaderText = "Mã khuyến mãi";
            maKhuyenMaiColumn.Name = "maKhuyenMaiColumn";
            maKhuyenMaiColumn.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 140F;
            Column2.HeaderText = "Tên khuyến mãi";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Thời gian bắt đầu";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Thời gian kết thúc";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 80F;
            Column3.HeaderText = "Loại giá trị";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Giá trị áp dụng";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // chonKhuyenMaiButtonColumn
            // 
            chonKhuyenMaiButtonColumn.FillWeight = 50F;
            chonKhuyenMaiButtonColumn.FlatStyle = FlatStyle.Flat;
            chonKhuyenMaiButtonColumn.HeaderText = "Chọn";
            chonKhuyenMaiButtonColumn.Name = "chonKhuyenMaiButtonColumn";
            chonKhuyenMaiButtonColumn.ReadOnly = true;
            chonKhuyenMaiButtonColumn.Resizable = DataGridViewTriState.True;
            chonKhuyenMaiButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            chonKhuyenMaiButtonColumn.Text = "Chọn";
            chonKhuyenMaiButtonColumn.UseColumnTextForButtonValue = true;
            // 
            // ChonKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 502);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "ChonKhuyenMai";
            Text = "ChonKhuyenMai";
            FormClosed += TestChonKhuyenMaiForm_FormClosed;
            Load += TestChonKhuyenMaiForm_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)khuyenMaiDataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton quayLaiButton;
        private Label tieuDeFormLabel;
        private FontAwesome.Sharp.IconButton lamMoiButton;
        private FontAwesome.Sharp.IconButton timKiemButton;
        private Guna.UI2.WinForms.Guna2TextBox timKiemTextBox;
        private Guna.UI2.WinForms.Guna2DataGridView khuyenMaiDataGridView;
        private Panel panel3;
        private Panel panel1;
        private DataGridViewTextBoxColumn maKhuyenMaiColumn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn chonKhuyenMaiButtonColumn;
    }
}