namespace Serial_Comm_Tester
{
    partial class ChecksumCalc
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.CRC_Version = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRC_Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculateCRC = new System.Windows.Forms.Button();
            this.txtBCalculateValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBringToFront = new System.Windows.Forms.CheckBox();
            this.ckBHexValueCRC = new System.Windows.Forms.CheckBox();
            this.ckBStringValueCRC = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoCRC8 = new System.Windows.Forms.ComboBox();
            this.comBoCRC16 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoCRC32 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckBWhiteSpaceCharacters = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CRC_Version,
            this.CRC_Result});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(11, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(593, 267);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CRC_Version
            // 
            this.CRC_Version.Text = "CRC Version / Checksum";
            this.CRC_Version.Width = 247;
            // 
            // CRC_Result
            // 
            this.CRC_Result.Text = "CRC Result / Checksum";
            this.CRC_Result.Width = 349;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(481, 633);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "CLOSE";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(220, 633);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculateCRC
            // 
            this.btnCalculateCRC.BackColor = System.Drawing.Color.Chartreuse;
            this.btnCalculateCRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateCRC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnCalculateCRC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCRC.Location = new System.Drawing.Point(11, 633);
            this.btnCalculateCRC.Name = "btnCalculateCRC";
            this.btnCalculateCRC.Size = new System.Drawing.Size(193, 40);
            this.btnCalculateCRC.TabIndex = 7;
            this.btnCalculateCRC.Text = "Calculate CRC";
            this.btnCalculateCRC.UseVisualStyleBackColor = false;
            this.btnCalculateCRC.Click += new System.EventHandler(this.btnCalculateCRC_Click);
            // 
            // txtBCalculateValue
            // 
            this.txtBCalculateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCalculateValue.Location = new System.Drawing.Point(10, 509);
            this.txtBCalculateValue.Name = "txtBCalculateValue";
            this.txtBCalculateValue.Size = new System.Drawing.Size(593, 22);
            this.txtBCalculateValue.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calculate Value";
            // 
            // checkBoxBringToFront
            // 
            this.checkBoxBringToFront.AutoSize = true;
            this.checkBoxBringToFront.BackColor = System.Drawing.Color.DarkGray;
            this.checkBoxBringToFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBringToFront.Location = new System.Drawing.Point(369, 646);
            this.checkBoxBringToFront.Name = "checkBoxBringToFront";
            this.checkBoxBringToFront.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBringToFront.TabIndex = 35;
            this.checkBoxBringToFront.Text = "Bring To Front";
            this.checkBoxBringToFront.UseVisualStyleBackColor = false;
            this.checkBoxBringToFront.CheckedChanged += new System.EventHandler(this.checkBoxBringToFront_CheckedChanged);
            // 
            // ckBHexValueCRC
            // 
            this.ckBHexValueCRC.AutoSize = true;
            this.ckBHexValueCRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckBHexValueCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBHexValueCRC.Location = new System.Drawing.Point(10, 557);
            this.ckBHexValueCRC.Name = "ckBHexValueCRC";
            this.ckBHexValueCRC.Size = new System.Drawing.Size(369, 20);
            this.ckBHexValueCRC.TabIndex = 37;
            this.ckBHexValueCRC.Text = "Get Hex Value     (example : 1 hex is a 0x01 value)";
            this.ckBHexValueCRC.UseVisualStyleBackColor = true;
            // 
            // ckBStringValueCRC
            // 
            this.ckBStringValueCRC.AutoSize = true;
            this.ckBStringValueCRC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckBStringValueCRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBStringValueCRC.Location = new System.Drawing.Point(10, 587);
            this.ckBStringValueCRC.Name = "ckBStringValueCRC";
            this.ckBStringValueCRC.Size = new System.Drawing.Size(380, 20);
            this.ckBStringValueCRC.TabIndex = 38;
            this.ckBStringValueCRC.Text = "Get String Value  (This will convert the text to bytes)";
            this.ckBStringValueCRC.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "CRC 8 polynomial : ";
            // 
            // comBoCRC8
            // 
            this.comBoCRC8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoCRC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoCRC8.FormattingEnabled = true;
            this.comBoCRC8.Items.AddRange(new object[] {
            "CRC8 = 0x07",
            "CRC8_DVB = 0xD5",
            "CRC8_SAE_J1850 = 0x1D"});
            this.comBoCRC8.Location = new System.Drawing.Point(200, 285);
            this.comBoCRC8.Name = "comBoCRC8";
            this.comBoCRC8.Size = new System.Drawing.Size(377, 24);
            this.comBoCRC8.TabIndex = 40;
            this.comBoCRC8.SelectedIndexChanged += new System.EventHandler(this.comBoCRC8_SelectedIndexChanged);
            // 
            // comBoCRC16
            // 
            this.comBoCRC16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoCRC16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoCRC16.FormattingEnabled = true;
            this.comBoCRC16.Items.AddRange(new object[] {
            "CRC_16_CCITT_ZERO = 0x1021",
            "CRC_16_XMODEM = 0x1021",
            "CRC_16_CCITT_FALSE = 0x1021",
            "CRC_16_AUG_CCITT = 0x1021",
            "CRC_16_TELEDISK = 0xAO97",
            "CRC_16_T10_DIF = 0x8BB7",
            "CRC_16_DECT_X = 0x589",
            "CRC_16_DDS_110 = 0x8005",
            "CRC_16_CDMA2000 = 0xC867",
            "CRC_16_BUYPASS = Ox8005",
            "CRC_16_MODBUS = 0xA001"});
            this.comBoCRC16.Location = new System.Drawing.Point(200, 315);
            this.comBoCRC16.Name = "comBoCRC16";
            this.comBoCRC16.Size = new System.Drawing.Size(377, 24);
            this.comBoCRC16.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "CRC 16  polynomial : ";
            // 
            // comBoCRC32
            // 
            this.comBoCRC32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comBoCRC32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoCRC32.FormattingEnabled = true;
            this.comBoCRC32.Items.AddRange(new object[] {
            "CRC32 = 0x04C11DB7"});
            this.comBoCRC32.Location = new System.Drawing.Point(200, 345);
            this.comBoCRC32.Name = "comBoCRC32";
            this.comBoCRC32.Size = new System.Drawing.Size(377, 24);
            this.comBoCRC32.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "CRC 32 polynomial : ";
            // 
            // ckBWhiteSpaceCharacters
            // 
            this.ckBWhiteSpaceCharacters.AutoSize = true;
            this.ckBWhiteSpaceCharacters.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ckBWhiteSpaceCharacters.Location = new System.Drawing.Point(415, 557);
            this.ckBWhiteSpaceCharacters.Name = "ckBWhiteSpaceCharacters";
            this.ckBWhiteSpaceCharacters.Size = new System.Drawing.Size(188, 17);
            this.ckBWhiteSpaceCharacters.TabIndex = 45;
            this.ckBWhiteSpaceCharacters.Text = "Calculate white spaces characters";
            this.ckBWhiteSpaceCharacters.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "2s Complement : 8bit ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "2s Complement : 16bit ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Block Check Character : 8bit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Modulo 256 : 8bit";
            // 
            // ChecksumCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(635, 685);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckBWhiteSpaceCharacters);
            this.Controls.Add(this.comBoCRC32);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBoCRC16);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comBoCRC8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckBStringValueCRC);
            this.Controls.Add(this.ckBHexValueCRC);
            this.Controls.Add(this.checkBoxBringToFront);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBCalculateValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculateCRC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChecksumCalc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChecksumCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CRC_Version;
        private System.Windows.Forms.ColumnHeader CRC_Result;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculateCRC;
        private System.Windows.Forms.TextBox txtBCalculateValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBringToFront;
        private System.Windows.Forms.CheckBox ckBHexValueCRC;
        private System.Windows.Forms.CheckBox ckBStringValueCRC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBoCRC8;
        private System.Windows.Forms.ComboBox comBoCRC16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comBoCRC32;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckBWhiteSpaceCharacters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}