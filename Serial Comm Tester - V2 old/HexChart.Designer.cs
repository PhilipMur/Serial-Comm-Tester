namespace Serial_Comm_Tester
{
    partial class HexChart
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copySelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHexChart = new System.Windows.Forms.Button();
            this.btnUnicodeChart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.checkBoxBringToFront = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(706, 561);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Press a Button Below To See Selected Charts .";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // copySelectedToolStripMenuItem
            // 
            this.copySelectedToolStripMenuItem.Name = "copySelectedToolStripMenuItem";
            this.copySelectedToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.copySelectedToolStripMenuItem.Text = "Copy ";
            this.copySelectedToolStripMenuItem.Click += new System.EventHandler(this.copySelectedToolStripMenuItem_Click);
            // 
            // btnHexChart
            // 
            this.btnHexChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHexChart.BackColor = System.Drawing.Color.Yellow;
            this.btnHexChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHexChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHexChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHexChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexChart.Location = new System.Drawing.Point(12, 579);
            this.btnHexChart.Name = "btnHexChart";
            this.btnHexChart.Size = new System.Drawing.Size(229, 32);
            this.btnHexChart.TabIndex = 1;
            this.btnHexChart.Text = "Hex / Dec / Bin / ASCII";
            this.btnHexChart.UseVisualStyleBackColor = false;
            this.btnHexChart.Click += new System.EventHandler(this.btnHexChart_Click);
            // 
            // btnUnicodeChart
            // 
            this.btnUnicodeChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUnicodeChart.BackColor = System.Drawing.Color.Yellow;
            this.btnUnicodeChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnicodeChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnUnicodeChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnicodeChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnicodeChart.Location = new System.Drawing.Point(247, 579);
            this.btnUnicodeChart.Name = "btnUnicodeChart";
            this.btnUnicodeChart.Size = new System.Drawing.Size(128, 32);
            this.btnUnicodeChart.TabIndex = 2;
            this.btnUnicodeChart.Text = "Unicode";
            this.btnUnicodeChart.UseVisualStyleBackColor = false;
            this.btnUnicodeChart.Click += new System.EventHandler(this.btnUnicodeChart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(603, 579);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "CLOSE";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkBoxBringToFront
            // 
            this.checkBoxBringToFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxBringToFront.AutoSize = true;
            this.checkBoxBringToFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBringToFront.Location = new System.Drawing.Point(419, 589);
            this.checkBoxBringToFront.Name = "checkBoxBringToFront";
            this.checkBoxBringToFront.Size = new System.Drawing.Size(89, 17);
            this.checkBoxBringToFront.TabIndex = 4;
            this.checkBoxBringToFront.Text = "Bring to Front";
            this.checkBoxBringToFront.UseVisualStyleBackColor = true;
            this.checkBoxBringToFront.CheckedChanged += new System.EventHandler(this.checkBoxBringToFront_CheckedChanged);
            // 
            // HexChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(730, 623);
            this.Controls.Add(this.checkBoxBringToFront);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnicodeChart);
            this.Controls.Add(this.btnHexChart);
            this.Controls.Add(this.richTextBox1);
            this.Name = "HexChart";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnHexChart;
        private System.Windows.Forms.Button btnUnicodeChart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copySelectedToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxBringToFront;
    }
}