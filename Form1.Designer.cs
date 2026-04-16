namespace FileCompare
{
    partial class FileCompare
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            pan3 = new Panel();
            lvwLeftDir = new ListView();
            columnHeader１ = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            pan2 = new Panel();
            btnLeftDir = new Button();
            txtLeftDir = new TextBox();
            pan1 = new Panel();
            btnCopyFromLeft = new Button();
            lblAppName = new Label();
            pan6 = new Panel();
            lvwrightDir = new ListView();
            columnHeader４ = new ColumnHeader();
            columnHeader５ = new ColumnHeader();
            columnHeader６ = new ColumnHeader();
            pan5 = new Panel();
            btnRightDir = new Button();
            txtRightDir = new TextBox();
            pan4 = new Panel();
            btnCopyFromRight = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pan3.SuspendLayout();
            pan2.SuspendLayout();
            pan1.SuspendLayout();
            pan6.SuspendLayout();
            pan5.SuspendLayout();
            pan4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(20, 20);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pan3);
            splitContainer1.Panel1.Controls.Add(pan2);
            splitContainer1.Panel1.Controls.Add(pan1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pan6);
            splitContainer1.Panel2.Controls.Add(pan5);
            splitContainer1.Panel2.Controls.Add(pan4);
            splitContainer1.Size = new Size(1519, 734);
            splitContainer1.SplitterDistance = 757;
            splitContainer1.SplitterWidth = 25;
            splitContainer1.TabIndex = 0;
            // 
            // pan3
            // 
            pan3.BackColor = SystemColors.Control;
            pan3.Controls.Add(lvwLeftDir);
            pan3.Dock = DockStyle.Fill;
            pan3.Location = new Point(0, 254);
            pan3.Name = "pan3";
            pan3.Size = new Size(757, 480);
            pan3.TabIndex = 1;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Columns.AddRange(new ColumnHeader[] { columnHeader１, columnHeader2, columnHeader3 });
            lvwLeftDir.Dock = DockStyle.Fill;
            lvwLeftDir.FullRowSelect = true;
            lvwLeftDir.GridLines = true;
            lvwLeftDir.Location = new Point(0, 0);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(757, 480);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            lvwLeftDir.View = View.Details;
            // 
            // columnHeader１
            // 
            columnHeader１.Text = "이름";
            columnHeader１.Width = 450;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "크기";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "수정일";
            columnHeader3.Width = 160;
            // 
            // pan2
            // 
            pan2.Controls.Add(btnLeftDir);
            pan2.Controls.Add(txtLeftDir);
            pan2.Dock = DockStyle.Top;
            pan2.Location = new Point(0, 152);
            pan2.Name = "pan2";
            pan2.Padding = new Padding(20);
            pan2.Size = new Size(757, 102);
            pan2.TabIndex = 1;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Location = new Point(570, 27);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(150, 46);
            btnLeftDir.TabIndex = 4;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            btnLeftDir.Click += btnLeftDir_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Font = new Font("맑은 고딕", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(23, 36);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(524, 43);
            txtLeftDir.TabIndex = 1;
            // 
            // pan1
            // 
            pan1.Controls.Add(btnCopyFromLeft);
            pan1.Controls.Add(lblAppName);
            pan1.Dock = DockStyle.Top;
            pan1.Location = new Point(0, 0);
            pan1.Name = "pan1";
            pan1.Padding = new Padding(20);
            pan1.Size = new Size(757, 152);
            pan1.TabIndex = 0;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top;
            btnCopyFromLeft.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromLeft.Location = new Point(538, 63);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(184, 71);
            btnCopyFromLeft.TabIndex = 2;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(12, 27);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(491, 100);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // pan6
            // 
            pan6.Controls.Add(lvwrightDir);
            pan6.Dock = DockStyle.Fill;
            pan6.Location = new Point(0, 254);
            pan6.Name = "pan6";
            pan6.Size = new Size(737, 480);
            pan6.TabIndex = 2;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Columns.AddRange(new ColumnHeader[] { columnHeader４, columnHeader５, columnHeader６ });
            lvwrightDir.Dock = DockStyle.Fill;
            lvwrightDir.FullRowSelect = true;
            lvwrightDir.GridLines = true;
            lvwrightDir.Location = new Point(0, 0);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(737, 480);
            lvwrightDir.TabIndex = 1;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            lvwrightDir.View = View.Details;
            // 
            // columnHeader４
            // 
            columnHeader４.Text = "이름";
            columnHeader４.Width = 350;
            // 
            // columnHeader５
            // 
            columnHeader５.Text = "크기";
            columnHeader５.Width = 120;
            // 
            // columnHeader６
            // 
            columnHeader６.Text = "수정일";
            columnHeader６.Width = 300;
            // 
            // pan5
            // 
            pan5.Controls.Add(btnRightDir);
            pan5.Controls.Add(txtRightDir);
            pan5.Dock = DockStyle.Top;
            pan5.Location = new Point(0, 152);
            pan5.Name = "pan5";
            pan5.Size = new Size(737, 102);
            pan5.TabIndex = 2;
            // 
            // btnRightDir
            // 
            btnRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRightDir.Location = new Point(566, 27);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(150, 46);
            btnRightDir.TabIndex = 5;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            btnRightDir.Click += btnRightDir_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Font = new Font("맑은 고딕", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(12, 32);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(548, 43);
            txtRightDir.TabIndex = 2;
            // 
            // pan4
            // 
            pan4.Controls.Add(btnCopyFromRight);
            pan4.Dock = DockStyle.Top;
            pan4.Location = new Point(0, 0);
            pan4.Name = "pan4";
            pan4.Size = new Size(737, 152);
            pan4.TabIndex = 1;

            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top;
            btnCopyFromRight.Font = new Font("맑은 고딕", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCopyFromRight.Location = new Point(24, 63);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(163, 71);
            btnCopyFromRight.TabIndex = 3;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // FileCompare
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1559, 774);
            Controls.Add(splitContainer1);
            Name = "FileCompare";
            Padding = new Padding(20);
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pan3.ResumeLayout(false);
            pan2.ResumeLayout(false);
            pan2.PerformLayout();
            pan1.ResumeLayout(false);
            pan1.PerformLayout();
            pan6.ResumeLayout(false);
            pan5.ResumeLayout(false);
            pan5.PerformLayout();
            pan4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel pan1;
        private Panel pan3;
        private Panel pan2;
        private Label lblAppName;
        private Panel pan6;
        private Panel pan5;
        private Panel pan4;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private ListView lvwrightDir;
        private TextBox txtRightDir;
        private Button btnCopyFromRight;
        private Button btnCopyFromLeft;
        private Button btnLeftDir;
        internal Button btnRightDir;
        private ColumnHeader columnHeader１;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader４;
        private ColumnHeader columnHeader５;
        private ColumnHeader columnHeader６;
    }
}
