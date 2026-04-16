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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            lblAppName = new Label();
            txtLeftDir = new TextBox();
            lvwLeftDir = new ListView();
            lvwrightDir = new ListView();
            txtRightDir = new TextBox();
            btnCopyFromLeft = new Button();
            btnCopyFromRight = new Button();
            btnLeftDir = new Button();
            btnRightDir = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(1510, 742);
            splitContainer1.SplitterDistance = 753;
            splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(lblAppName);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 101);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Controls.Add(txtLeftDir);
            panel2.Location = new Point(12, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 142);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lvwLeftDir);
            panel3.Location = new Point(12, 278);
            panel3.Name = "panel3";
            panel3.Size = new Size(723, 452);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnCopyFromRight);
            panel4.Location = new Point(18, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 101);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnRightDir);
            panel5.Controls.Add(txtRightDir);
            panel5.Location = new Point(18, 130);
            panel5.Name = "panel5";
            panel5.Size = new Size(723, 142);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(lvwrightDir);
            panel6.Location = new Point(18, 278);
            panel6.Name = "panel6";
            panel6.Size = new Size(723, 452);
            panel6.TabIndex = 2;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(20, 15);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(349, 71);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // txtLeftDir
            // 
            txtLeftDir.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(20, 39);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(500, 65);
            txtLeftDir.TabIndex = 1;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Location = new Point(20, 14);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(687, 418);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Location = new Point(15, 14);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(687, 418);
            lvwrightDir.TabIndex = 1;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            // 
            // txtRightDir
            // 
            txtRightDir.Font = new Font("맑은 고딕", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(15, 39);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(500, 65);
            txtRightDir.TabIndex = 2;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Location = new Point(557, 30);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(150, 46);
            btnCopyFromLeft.TabIndex = 2;
            btnCopyFromLeft.Text = ">>>";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Location = new Point(15, 30);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(150, 46);
            btnCopyFromRight.TabIndex = 3;
            btnCopyFromRight.Text = "<<<";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Location = new Point(557, 55);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(150, 46);
            btnLeftDir.TabIndex = 4;
            btnLeftDir.Text = "폴더선택";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // btnRightDir
            // 
            btnRightDir.Location = new Point(552, 55);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(150, 46);
            btnRightDir.TabIndex = 5;
            btnRightDir.Text = "폴더선택";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // FileCompare
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1510, 742);
            Controls.Add(splitContainer1);
            Name = "FileCompare";
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label lblAppName;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private ListView lvwLeftDir;
        private TextBox txtLeftDir;
        private ListView lvwrightDir;
        private TextBox txtRightDir;
        private Button btnCopyFromRight;
        private Button btnCopyFromLeft;
        private Button btnLeftDir;
        private Button btnRightDir;
    }
}
