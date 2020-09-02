namespace Serial_Comm_Tester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.comboBoxActiveComPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopSendFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSendBreak = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.checkBoxCRLF = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBoxSendHex = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxSendDec = new System.Windows.Forms.CheckBox();
            this.checkBox2DEC = new System.Windows.Forms.CheckBox();
            this.checkBox3DEC = new System.Windows.Forms.CheckBox();
            this.tx_num_panel = new System.Windows.Forms.Panel();
            this.send_delay = new System.Windows.Forms.NumericUpDown();
            this.send_repeat = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnClearSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkBoxSendNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxAutoSend = new System.Windows.Forms.CheckBox();
            this.richTextBoxSend = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripSend = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkBConvertToHexDec = new System.Windows.Forms.CheckBox();
            this.btnClearRecieve = new System.Windows.Forms.Button();
            this.chkBAutoRead = new System.Windows.Forms.CheckBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.richTextBoxRecieve = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRecieve = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnClearAllText = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBCurrentPortSet = new System.Windows.Forms.TextBox();
            this.btnRefreshComPorts = new System.Windows.Forms.Button();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxFlow = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRtsOn = new System.Windows.Forms.Button();
            this.btnRtsOff = new System.Windows.Forms.Button();
            this.textBoxRTS = new System.Windows.Forms.TextBox();
            this.textBoxReadTime = new System.Windows.Forms.TextBox();
            this.btnDtrOn = new System.Windows.Forms.Button();
            this.textBoxDTR = new System.Windows.Forms.TextBox();
            this.btnDtrOff = new System.Windows.Forms.Button();
            this.comboBoxReadTimeout = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDSR = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxCD = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxCTS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxWriteTimeout = new System.Windows.Forms.ComboBox();
            this.textBoxWriteTime = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxRI = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxBI = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.timerCTSETC = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxDec = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripDec = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxHex = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripHex = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.chkBAutoReadDec = new System.Windows.Forms.CheckBox();
            this.chkBAutoReadHex = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnClearInOutBuff = new System.Windows.Forms.Button();
            this.comboBoxDecodeFormat = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lblPortStatus = new System.Windows.Forms.Label();
            this.btnConversion = new System.Windows.Forms.Button();
            this.timerTextLenght = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxTX = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxRX = new System.Windows.Forms.TextBox();
            this.btnClearRecieveDec = new System.Windows.Forms.Button();
            this.btnClearRecieveHex = new System.Windows.Forms.Button();
            this.checkBoxBringToFront = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabSerialPortInfo = new System.Windows.Forms.TabPage();
            this.lblRxSent = new System.Windows.Forms.Label();
            this.lblTxSent = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.lblDataLogFilePath = new System.Windows.Forms.Label();
            this.ckBOverwriteLogs = new System.Windows.Forms.CheckBox();
            this.ckBAppendLogs = new System.Windows.Forms.CheckBox();
            this.ckBEnableLogs = new System.Windows.Forms.CheckBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabRecieve = new System.Windows.Forms.TabPage();
            this.tabHexRead = new System.Windows.Forms.TabPage();
            this.tabDecRead = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plotter_option_group = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.lblCountTX = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lblCountRX = new System.Windows.Forms.Label();
            this.ckBStartGraph = new System.Windows.Forms.CheckBox();
            this.graph_speed = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txRepeaterDelay = new System.Windows.Forms.Timer(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tx_num_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).BeginInit();
            this.contextMenuStripSend.SuspendLayout();
            this.contextMenuStripRecieve.SuspendLayout();
            this.contextMenuStripDec.SuspendLayout();
            this.contextMenuStripHex.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabSerialPortInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabRecieve.SuspendLayout();
            this.tabHexRead.SuspendLayout();
            this.tabDecRead.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.plotter_option_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxActiveComPorts
            // 
            this.comboBoxActiveComPorts.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxActiveComPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxActiveComPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActiveComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActiveComPorts.FormattingEnabled = true;
            this.comboBoxActiveComPorts.Location = new System.Drawing.Point(134, 21);
            this.comboBoxActiveComPorts.Name = "comboBoxActiveComPorts";
            this.comboBoxActiveComPorts.Size = new System.Drawing.Size(94, 21);
            this.comboBoxActiveComPorts.TabIndex = 0;
            this.toolTip1.SetToolTip(this.comboBoxActiveComPorts, "Choose an available Com Port here.");
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "75",
            "110",
            "134.5",
            "150",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "5787",
            "7200",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(11, 61);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(94, 21);
            this.comboBoxBaudRate.TabIndex = 2;
            this.comboBoxBaudRate.Text = "9600";
            this.toolTip1.SetToolTip(this.comboBoxBaudRate, "Set\'s the serial port Baud Rate.");
            this.comboBoxBaudRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxBaudRate_KeyPress);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(433, 169);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(314, 16);
            this.progressBar1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btnStopSendFile);
            this.groupBox1.Controls.Add(this.btnSendFile);
            this.groupBox1.Controls.Add(this.btnSendBreak);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.tx_num_panel);
            this.groupBox1.Controls.Add(this.btnClearSend);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.checkBoxSendNormal);
            this.groupBox1.Controls.Add(this.checkBoxAutoSend);
            this.groupBox1.Controls.Add(this.richTextBoxSend);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEND  ( TX )";
            // 
            // btnStopSendFile
            // 
            this.btnStopSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStopSendFile.BackColor = System.Drawing.Color.Red;
            this.btnStopSendFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopSendFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnStopSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopSendFile.Location = new System.Drawing.Point(182, 76);
            this.btnStopSendFile.Name = "btnStopSendFile";
            this.btnStopSendFile.Size = new System.Drawing.Size(112, 26);
            this.btnStopSendFile.TabIndex = 74;
            this.btnStopSendFile.Text = "Stop";
            this.btnStopSendFile.UseVisualStyleBackColor = false;
            this.btnStopSendFile.Click += new System.EventHandler(this.btnStopSendFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendFile.Location = new System.Drawing.Point(251, 106);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(161, 21);
            this.btnSendFile.TabIndex = 73;
            this.btnSendFile.Text = "Send From File";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSendBreak
            // 
            this.btnSendBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendBreak.BackColor = System.Drawing.Color.SlateGray;
            this.btnSendBreak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendBreak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSendBreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendBreak.Location = new System.Drawing.Point(182, 106);
            this.btnSendBreak.Name = "btnSendBreak";
            this.btnSendBreak.Size = new System.Drawing.Size(63, 21);
            this.btnSendBreak.TabIndex = 72;
            this.btnSendBreak.Text = "Break";
            this.btnSendBreak.UseVisualStyleBackColor = false;
            this.btnSendBreak.Click += new System.EventHandler(this.btnSendBreak_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.checkBoxCR);
            this.panel3.Controls.Add(this.checkBoxCRLF);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(11, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 23);
            this.panel3.TabIndex = 71;
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCR.Location = new System.Drawing.Point(100, 5);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(50, 17);
            this.checkBoxCR.TabIndex = 66;
            this.checkBoxCR.TabStop = false;
            this.checkBoxCR.Text = "+CR ";
            this.toolTip1.SetToolTip(this.checkBoxCR, "Send a command with a Carrige Return ending.");
            this.checkBoxCR.UseVisualStyleBackColor = true;
            this.checkBoxCR.CheckedChanged += new System.EventHandler(this.checkBoxCR_CheckedChanged);
            // 
            // checkBoxCRLF
            // 
            this.checkBoxCRLF.AutoSize = true;
            this.checkBoxCRLF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxCRLF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCRLF.Location = new System.Drawing.Point(3, 5);
            this.checkBoxCRLF.Name = "checkBoxCRLF";
            this.checkBoxCRLF.Size = new System.Drawing.Size(71, 17);
            this.checkBoxCRLF.TabIndex = 65;
            this.checkBoxCRLF.TabStop = false;
            this.checkBoxCRLF.Text = "+CR + LF";
            this.toolTip1.SetToolTip(this.checkBoxCRLF, "Send a command with a Carrige Return + Line Feed ending.");
            this.checkBoxCRLF.UseVisualStyleBackColor = true;
            this.checkBoxCRLF.CheckedChanged += new System.EventHandler(this.checkBoxCRLF_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.checkBoxSendHex);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(728, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 47);
            this.panel2.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(25, 28);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(54, 16);
            this.label27.TabIndex = 6;
            this.label27.Text = "x2 Hex";
            // 
            // checkBoxSendHex
            // 
            this.checkBoxSendHex.AutoSize = true;
            this.checkBoxSendHex.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSendHex.Enabled = false;
            this.checkBoxSendHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendHex.Location = new System.Drawing.Point(3, 5);
            this.checkBoxSendHex.Name = "checkBoxSendHex";
            this.checkBoxSendHex.Size = new System.Drawing.Size(115, 20);
            this.checkBoxSendHex.TabIndex = 5;
            this.checkBoxSendHex.TabStop = false;
            this.checkBoxSendHex.Text = "Send as Hex";
            this.toolTip1.SetToolTip(this.checkBoxSendHex, "Send in Hexadecimal format.");
            this.checkBoxSendHex.UseVisualStyleBackColor = true;
            this.checkBoxSendHex.CheckedChanged += new System.EventHandler(this.checkBoxSendHex_CheckedChanged);
            this.checkBoxSendHex.Click += new System.EventHandler(this.checkBoxSendHex_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.checkBoxSendDec);
            this.panel1.Controls.Add(this.checkBox2DEC);
            this.panel1.Controls.Add(this.checkBox3DEC);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(877, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 48);
            this.panel1.TabIndex = 67;
            this.toolTip1.SetToolTip(this.panel1, "Send as Decimal format either decimal value x2 or x3 characters long.");
            // 
            // checkBoxSendDec
            // 
            this.checkBoxSendDec.AutoSize = true;
            this.checkBoxSendDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSendDec.Enabled = false;
            this.checkBoxSendDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendDec.Location = new System.Drawing.Point(5, 3);
            this.checkBoxSendDec.Name = "checkBoxSendDec";
            this.checkBoxSendDec.Size = new System.Drawing.Size(116, 20);
            this.checkBoxSendDec.TabIndex = 6;
            this.checkBoxSendDec.TabStop = false;
            this.checkBoxSendDec.Text = "Send as Dec";
            this.toolTip1.SetToolTip(this.checkBoxSendDec, "Send as Decimal format either decimal value x2 or x3 characters long.");
            this.checkBoxSendDec.UseVisualStyleBackColor = true;
            this.checkBoxSendDec.CheckedChanged += new System.EventHandler(this.checkBoxSendDec_CheckedChanged);
            this.checkBoxSendDec.Click += new System.EventHandler(this.checkBoxSendDec_Click);
            // 
            // checkBox2DEC
            // 
            this.checkBox2DEC.AutoSize = true;
            this.checkBox2DEC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2DEC.Enabled = false;
            this.checkBox2DEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2DEC.Location = new System.Drawing.Point(5, 24);
            this.checkBox2DEC.Name = "checkBox2DEC";
            this.checkBox2DEC.Size = new System.Drawing.Size(74, 20);
            this.checkBox2DEC.TabIndex = 8;
            this.checkBox2DEC.TabStop = false;
            this.checkBox2DEC.Text = "x2 Dec";
            this.toolTip1.SetToolTip(this.checkBox2DEC, "Send as Decimal format either decimal value x2 or x3 characters long.");
            this.checkBox2DEC.UseVisualStyleBackColor = true;
            this.checkBox2DEC.CheckedChanged += new System.EventHandler(this.checkBox2DEC_CheckedChanged);
            this.checkBox2DEC.Click += new System.EventHandler(this.checkBox2DEC_Click);
            // 
            // checkBox3DEC
            // 
            this.checkBox3DEC.AutoSize = true;
            this.checkBox3DEC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3DEC.Enabled = false;
            this.checkBox3DEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3DEC.Location = new System.Drawing.Point(85, 22);
            this.checkBox3DEC.Name = "checkBox3DEC";
            this.checkBox3DEC.Size = new System.Drawing.Size(74, 20);
            this.checkBox3DEC.TabIndex = 9;
            this.checkBox3DEC.TabStop = false;
            this.checkBox3DEC.Text = "x3 Dec";
            this.toolTip1.SetToolTip(this.checkBox3DEC, "Send as Decimal format either decimal value x2 or x3 characters long.");
            this.checkBox3DEC.UseVisualStyleBackColor = true;
            this.checkBox3DEC.CheckedChanged += new System.EventHandler(this.checkBox3DEC_CheckedChanged);
            this.checkBox3DEC.Click += new System.EventHandler(this.checkBox3DEC_Click);
            // 
            // tx_num_panel
            // 
            this.tx_num_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tx_num_panel.BackColor = System.Drawing.Color.LightGray;
            this.tx_num_panel.Controls.Add(this.send_delay);
            this.tx_num_panel.Controls.Add(this.send_repeat);
            this.tx_num_panel.Controls.Add(this.label23);
            this.tx_num_panel.Controls.Add(this.label24);
            this.tx_num_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_num_panel.Location = new System.Drawing.Point(427, 98);
            this.tx_num_panel.Name = "tx_num_panel";
            this.tx_num_panel.Size = new System.Drawing.Size(295, 30);
            this.tx_num_panel.TabIndex = 64;
            this.toolTip1.SetToolTip(this.tx_num_panel, "Choose to repeat a command to send and how much of a delay between the sent comma" +
        "nd\'s.");
            // 
            // send_delay
            // 
            this.send_delay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_delay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_delay.Location = new System.Drawing.Point(228, 6);
            this.send_delay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.send_delay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_delay.Name = "send_delay";
            this.send_delay.Size = new System.Drawing.Size(53, 20);
            this.send_delay.TabIndex = 21;
            this.send_delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_delay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // send_repeat
            // 
            this.send_repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_repeat.Location = new System.Drawing.Point(72, 7);
            this.send_repeat.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.send_repeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.send_repeat.Name = "send_repeat";
            this.send_repeat.Size = new System.Drawing.Size(53, 20);
            this.send_repeat.TabIndex = 22;
            this.send_repeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.send_repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(10, 10);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 23;
            this.label23.Text = "Repeat :";
            this.toolTip1.SetToolTip(this.label23, "Set\' how many times a command should be sent.");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(148, 9);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 13);
            this.label24.TabIndex = 24;
            this.label24.Text = "Delay (ms) :";
            this.toolTip1.SetToolTip(this.label24, "Set\'s the delay between sent commands.");
            // 
            // btnClearSend
            // 
            this.btnClearSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSend.BackColor = System.Drawing.Color.Yellow;
            this.btnClearSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSend.Location = new System.Drawing.Point(300, 76);
            this.btnClearSend.Name = "btnClearSend";
            this.btnClearSend.Size = new System.Drawing.Size(112, 26);
            this.btnClearSend.TabIndex = 63;
            this.btnClearSend.Text = "Clear ";
            this.btnClearSend.UseVisualStyleBackColor = false;
            this.btnClearSend.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Enabled = false;
            this.btnSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(11, 76);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(165, 26);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // checkBoxSendNormal
            // 
            this.checkBoxSendNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxSendNormal.AutoSize = true;
            this.checkBoxSendNormal.BackColor = System.Drawing.Color.Coral;
            this.checkBoxSendNormal.Checked = true;
            this.checkBoxSendNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSendNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSendNormal.Enabled = false;
            this.checkBoxSendNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSendNormal.Location = new System.Drawing.Point(427, 76);
            this.checkBoxSendNormal.Name = "checkBoxSendNormal";
            this.checkBoxSendNormal.Size = new System.Drawing.Size(112, 17);
            this.checkBoxSendNormal.TabIndex = 7;
            this.checkBoxSendNormal.TabStop = false;
            this.checkBoxSendNormal.Text = "Send Encoding";
            this.toolTip1.SetToolTip(this.checkBoxSendNormal, "Send a command using the selected encoding type.");
            this.checkBoxSendNormal.UseVisualStyleBackColor = false;
            this.checkBoxSendNormal.CheckedChanged += new System.EventHandler(this.checkBoxSendNormal_CheckedChanged);
            this.checkBoxSendNormal.Click += new System.EventHandler(this.checkBoxSendNormal_Click);
            // 
            // checkBoxAutoSend
            // 
            this.checkBoxAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoSend.AutoSize = true;
            this.checkBoxAutoSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoSend.Enabled = false;
            this.checkBoxAutoSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAutoSend.Location = new System.Drawing.Point(567, 76);
            this.checkBoxAutoSend.Name = "checkBoxAutoSend";
            this.checkBoxAutoSend.Size = new System.Drawing.Size(155, 17);
            this.checkBoxAutoSend.TabIndex = 4;
            this.checkBoxAutoSend.TabStop = false;
            this.checkBoxAutoSend.Text = "Auto Send Typed Keys";
            this.toolTip1.SetToolTip(this.checkBoxAutoSend, "Send each keyboard key as they are typed.");
            this.checkBoxAutoSend.UseVisualStyleBackColor = true;
            this.checkBoxAutoSend.CheckedChanged += new System.EventHandler(this.checkBoxAutoSend_CheckedChanged);
            this.checkBoxAutoSend.Click += new System.EventHandler(this.checkBoxAutoSend_Click);
            // 
            // richTextBoxSend
            // 
            this.richTextBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSend.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.richTextBoxSend.ContextMenuStrip = this.contextMenuStripSend;
            this.richTextBoxSend.Enabled = false;
            this.richTextBoxSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSend.HideSelection = false;
            this.richTextBoxSend.Location = new System.Drawing.Point(11, 18);
            this.richTextBoxSend.Name = "richTextBoxSend";
            this.richTextBoxSend.Size = new System.Drawing.Size(1029, 52);
            this.richTextBoxSend.TabIndex = 0;
            this.richTextBoxSend.Text = "";
            this.richTextBoxSend.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBoxSend_KeyDown);
            this.richTextBoxSend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBoxSend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBoxSend_MouseUp);
            // 
            // contextMenuStripSend
            // 
            this.contextMenuStripSend.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.contextMenuStripSend.Name = "contextMenuStripSend";
            this.contextMenuStripSend.Size = new System.Drawing.Size(103, 48);
            this.contextMenuStripSend.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripSend_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(536, 38);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 24);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Readings";
            this.toolTip1.SetToolTip(this.btnSave, "Save the current received information to a file.");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkBConvertToHexDec
            // 
            this.chkBConvertToHexDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBConvertToHexDec.AutoSize = true;
            this.chkBConvertToHexDec.Enabled = false;
            this.chkBConvertToHexDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBConvertToHexDec.Location = new System.Drawing.Point(515, 209);
            this.chkBConvertToHexDec.Name = "chkBConvertToHexDec";
            this.chkBConvertToHexDec.Size = new System.Drawing.Size(373, 20);
            this.chkBConvertToHexDec.TabIndex = 4;
            this.chkBConvertToHexDec.TabStop = false;
            this.chkBConvertToHexDec.Text = "Convert Text To Hexadecimal and Decimal values";
            this.toolTip1.SetToolTip(this.chkBConvertToHexDec, "Automatically convert the received text to Hexadecimal and decimal formats.");
            this.chkBConvertToHexDec.UseVisualStyleBackColor = true;
            this.chkBConvertToHexDec.CheckedChanged += new System.EventHandler(this.chkBConvertToHexDec_CheckedChanged);
            // 
            // btnClearRecieve
            // 
            this.btnClearRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRecieve.BackColor = System.Drawing.Color.Yellow;
            this.btnClearRecieve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearRecieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecieve.Location = new System.Drawing.Point(182, 206);
            this.btnClearRecieve.Name = "btnClearRecieve";
            this.btnClearRecieve.Size = new System.Drawing.Size(112, 24);
            this.btnClearRecieve.TabIndex = 64;
            this.btnClearRecieve.Text = "Clear ";
            this.btnClearRecieve.UseVisualStyleBackColor = false;
            this.btnClearRecieve.Click += new System.EventHandler(this.btnClearRecieve_Click);
            // 
            // chkBAutoRead
            // 
            this.chkBAutoRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBAutoRead.AutoSize = true;
            this.chkBAutoRead.BackColor = System.Drawing.Color.Coral;
            this.chkBAutoRead.Checked = true;
            this.chkBAutoRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBAutoRead.Enabled = false;
            this.chkBAutoRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBAutoRead.Location = new System.Drawing.Point(300, 209);
            this.chkBAutoRead.Name = "chkBAutoRead";
            this.chkBAutoRead.Size = new System.Drawing.Size(209, 20);
            this.chkBAutoRead.TabIndex = 3;
            this.chkBAutoRead.TabStop = false;
            this.chkBAutoRead.Text = "Auto Read Encoding Type";
            this.chkBAutoRead.UseVisualStyleBackColor = false;
            this.chkBAutoRead.CheckedChanged += new System.EventHandler(this.chkBAutoRead_CheckedChanged);
            // 
            // btnRead
            // 
            this.btnRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRead.BackColor = System.Drawing.Color.Chartreuse;
            this.btnRead.Enabled = false;
            this.btnRead.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(11, 206);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(165, 24);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Manual Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // richTextBoxRecieve
            // 
            this.richTextBoxRecieve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRecieve.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxRecieve.ContextMenuStrip = this.contextMenuStripRecieve;
            this.richTextBoxRecieve.Enabled = false;
            this.richTextBoxRecieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxRecieve.HideSelection = false;
            this.richTextBoxRecieve.Location = new System.Drawing.Point(11, 6);
            this.richTextBoxRecieve.Name = "richTextBoxRecieve";
            this.richTextBoxRecieve.ReadOnly = true;
            this.richTextBoxRecieve.Size = new System.Drawing.Size(1025, 194);
            this.richTextBoxRecieve.TabIndex = 1;
            this.richTextBoxRecieve.TabStop = false;
            this.richTextBoxRecieve.Text = "";
            this.richTextBoxRecieve.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // contextMenuStripRecieve
            // 
            this.contextMenuStripRecieve.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.contextMenuStripRecieve.Name = "contextMenuStripRecieve";
            this.contextMenuStripRecieve.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.BackColor = System.Drawing.Color.Chartreuse;
            this.btnOpenPort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPort.Location = new System.Drawing.Point(768, 60);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(289, 39);
            this.btnOpenPort.TabIndex = 9;
            this.btnOpenPort.Text = "Open Serial Port";
            this.toolTip1.SetToolTip(this.btnOpenPort, "Open the serial port once a Com Port has been chosen and setup.");
            this.btnOpenPort.UseVisualStyleBackColor = false;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.BackColor = System.Drawing.Color.Red;
            this.btnClosePort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePort.Enabled = false;
            this.btnClosePort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClosePort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClosePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePort.Location = new System.Drawing.Point(769, 118);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(289, 38);
            this.btnClosePort.TabIndex = 5;
            this.btnClosePort.TabStop = false;
            this.btnClosePort.Text = "Close Serial Port";
            this.toolTip1.SetToolTip(this.btnClosePort, "Close an active serial port connection.");
            this.btnClosePort.UseVisualStyleBackColor = false;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Active COM Ports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Port Status :";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnClearAllText
            // 
            this.btnClearAllText.BackColor = System.Drawing.Color.Yellow;
            this.btnClearAllText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAllText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearAllText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllText.Location = new System.Drawing.Point(290, 33);
            this.btnClearAllText.Name = "btnClearAllText";
            this.btnClearAllText.Size = new System.Drawing.Size(217, 47);
            this.btnClearAllText.TabIndex = 9;
            this.btnClearAllText.TabStop = false;
            this.btnClearAllText.Text = "Clear All";
            this.toolTip1.SetToolTip(this.btnClearAllText, "Clears All Text Boxes.");
            this.btnClearAllText.UseVisualStyleBackColor = false;
            this.btnClearAllText.Click += new System.EventHandler(this.btnClearAllText_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(768, 12);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(103, 39);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.toolTip1.SetToolTip(this.btnAbout, "About this awesome software and designer Philip Murray.");
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(133, 61);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(94, 21);
            this.comboBoxParity.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxParity, "Set\'s the serial port Parity Bit.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Parity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DataBits";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxDataBits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(269, 61);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(94, 21);
            this.comboBoxDataBits.TabIndex = 4;
            this.toolTip1.SetToolTip(this.comboBoxDataBits, "Set\'s the serial port Data Bits");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "StopBits";
            // 
            // txtBCurrentPortSet
            // 
            this.txtBCurrentPortSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBCurrentPortSet.Location = new System.Drawing.Point(3, 3);
            this.txtBCurrentPortSet.Name = "txtBCurrentPortSet";
            this.txtBCurrentPortSet.ReadOnly = true;
            this.txtBCurrentPortSet.Size = new System.Drawing.Size(721, 20);
            this.txtBCurrentPortSet.TabIndex = 17;
            this.txtBCurrentPortSet.TabStop = false;
            this.toolTip1.SetToolTip(this.txtBCurrentPortSet, "Current selected serial port setting\'s.");
            // 
            // btnRefreshComPorts
            // 
            this.btnRefreshComPorts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefreshComPorts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshComPorts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRefreshComPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshComPorts.Location = new System.Drawing.Point(251, 6);
            this.btnRefreshComPorts.Name = "btnRefreshComPorts";
            this.btnRefreshComPorts.Size = new System.Drawing.Size(126, 36);
            this.btnRefreshComPorts.TabIndex = 19;
            this.btnRefreshComPorts.Text = "Refresh COM Ports";
            this.toolTip1.SetToolTip(this.btnRefreshComPorts, "Refresh the Com Ports");
            this.btnRefreshComPorts.UseVisualStyleBackColor = false;
            this.btnRefreshComPorts.Click += new System.EventHandler(this.btnRefreshComPorts_Click);
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two",
            "OnePointFive"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(12, 101);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(94, 21);
            this.comboBoxStopBits.TabIndex = 5;
            this.toolTip1.SetToolTip(this.comboBoxStopBits, "Set\'s the serial port Stop Bit.");
            // 
            // comboBoxFlow
            // 
            this.comboBoxFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFlow.FormattingEnabled = true;
            this.comboBoxFlow.Items.AddRange(new object[] {
            "None",
            "RTS/CTS",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.comboBoxFlow.Location = new System.Drawing.Point(134, 101);
            this.comboBoxFlow.Name = "comboBoxFlow";
            this.comboBoxFlow.Size = new System.Drawing.Size(229, 21);
            this.comboBoxFlow.TabIndex = 6;
            this.toolTip1.SetToolTip(this.comboBoxFlow, resources.GetString("comboBoxFlow.ToolTip"));
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Flow / Handshake";
            // 
            // btnRtsOn
            // 
            this.btnRtsOn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRtsOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRtsOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRtsOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtsOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtsOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRtsOn.Location = new System.Drawing.Point(86, 30);
            this.btnRtsOn.Name = "btnRtsOn";
            this.btnRtsOn.Size = new System.Drawing.Size(75, 22);
            this.btnRtsOn.TabIndex = 22;
            this.btnRtsOn.TabStop = false;
            this.btnRtsOn.Text = "RTS  On";
            this.btnRtsOn.UseVisualStyleBackColor = false;
            this.btnRtsOn.Click += new System.EventHandler(this.btnRtsOn_Click);
            // 
            // btnRtsOff
            // 
            this.btnRtsOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRtsOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRtsOff.Enabled = false;
            this.btnRtsOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnRtsOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRtsOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRtsOff.Location = new System.Drawing.Point(5, 29);
            this.btnRtsOff.Name = "btnRtsOff";
            this.btnRtsOff.Size = new System.Drawing.Size(75, 22);
            this.btnRtsOff.TabIndex = 23;
            this.btnRtsOff.TabStop = false;
            this.btnRtsOff.Text = "RTS  Off";
            this.btnRtsOff.UseVisualStyleBackColor = false;
            this.btnRtsOff.Click += new System.EventHandler(this.btnRtsOff_Click);
            // 
            // textBoxRTS
            // 
            this.textBoxRTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRTS.Location = new System.Drawing.Point(174, 30);
            this.textBoxRTS.Name = "textBoxRTS";
            this.textBoxRTS.ReadOnly = true;
            this.textBoxRTS.Size = new System.Drawing.Size(75, 20);
            this.textBoxRTS.TabIndex = 24;
            this.textBoxRTS.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxRTS, "Ready To Send.\r\nPin 7 on the RS232 DB9.");
            // 
            // textBoxReadTime
            // 
            this.textBoxReadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReadTime.Location = new System.Drawing.Point(651, 101);
            this.textBoxReadTime.Name = "textBoxReadTime";
            this.textBoxReadTime.ReadOnly = true;
            this.textBoxReadTime.Size = new System.Drawing.Size(60, 20);
            this.textBoxReadTime.TabIndex = 25;
            this.textBoxReadTime.TabStop = false;
            // 
            // btnDtrOn
            // 
            this.btnDtrOn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDtrOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDtrOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDtrOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtrOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtrOn.Location = new System.Drawing.Point(86, 56);
            this.btnDtrOn.Name = "btnDtrOn";
            this.btnDtrOn.Size = new System.Drawing.Size(75, 22);
            this.btnDtrOn.TabIndex = 26;
            this.btnDtrOn.TabStop = false;
            this.btnDtrOn.Text = "DTR  On";
            this.btnDtrOn.UseVisualStyleBackColor = false;
            this.btnDtrOn.Click += new System.EventHandler(this.btnDtrOn_Click);
            // 
            // textBoxDTR
            // 
            this.textBoxDTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDTR.Location = new System.Drawing.Point(174, 56);
            this.textBoxDTR.Name = "textBoxDTR";
            this.textBoxDTR.ReadOnly = true;
            this.textBoxDTR.Size = new System.Drawing.Size(75, 20);
            this.textBoxDTR.TabIndex = 27;
            this.textBoxDTR.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxDTR, "Data Terminal Ready.\r\nPin 4 on the RS232 DB9.");
            // 
            // btnDtrOff
            // 
            this.btnDtrOff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDtrOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDtrOff.Enabled = false;
            this.btnDtrOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDtrOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDtrOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDtrOff.Location = new System.Drawing.Point(5, 56);
            this.btnDtrOff.Name = "btnDtrOff";
            this.btnDtrOff.Size = new System.Drawing.Size(75, 22);
            this.btnDtrOff.TabIndex = 28;
            this.btnDtrOff.TabStop = false;
            this.btnDtrOff.Text = "DTR Off";
            this.btnDtrOff.UseVisualStyleBackColor = false;
            this.btnDtrOff.Click += new System.EventHandler(this.btnDtrOff_Click);
            // 
            // comboBoxReadTimeout
            // 
            this.comboBoxReadTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxReadTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReadTimeout.FormattingEnabled = true;
            this.comboBoxReadTimeout.Items.AddRange(new object[] {
            "500",
            "1000",
            "2000"});
            this.comboBoxReadTimeout.Location = new System.Drawing.Point(484, 101);
            this.comboBoxReadTimeout.MaxLength = 10;
            this.comboBoxReadTimeout.Name = "comboBoxReadTimeout";
            this.comboBoxReadTimeout.Size = new System.Drawing.Size(60, 21);
            this.comboBoxReadTimeout.TabIndex = 8;
            this.comboBoxReadTimeout.Text = "500";
            this.toolTip1.SetToolTip(this.comboBoxReadTimeout, "Serial Readout time.");
            this.comboBoxReadTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxReadTimeout_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(464, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Read Timeout (ms)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(646, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Read Default";
            // 
            // textBoxDSR
            // 
            this.textBoxDSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDSR.Location = new System.Drawing.Point(338, 102);
            this.textBoxDSR.Name = "textBoxDSR";
            this.textBoxDSR.ReadOnly = true;
            this.textBoxDSR.Size = new System.Drawing.Size(65, 20);
            this.textBoxDSR.TabIndex = 32;
            this.textBoxDSR.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxDSR, "Data Set Ready.\r\nPin 6 on the RS232 DB9.");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(323, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Data Set Ready";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(224, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Carrier Detect";
            // 
            // textBoxCD
            // 
            this.textBoxCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCD.Location = new System.Drawing.Point(235, 102);
            this.textBoxCD.Name = "textBoxCD";
            this.textBoxCD.ReadOnly = true;
            this.textBoxCD.Size = new System.Drawing.Size(65, 20);
            this.textBoxCD.TabIndex = 34;
            this.textBoxCD.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxCD, "Carrier Detect.\r\nPin 1 on the RS232 DB9.");
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(431, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Clear To Send";
            // 
            // textBoxCTS
            // 
            this.textBoxCTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCTS.Location = new System.Drawing.Point(443, 102);
            this.textBoxCTS.Name = "textBoxCTS";
            this.textBoxCTS.ReadOnly = true;
            this.textBoxCTS.Size = new System.Drawing.Size(65, 20);
            this.textBoxCTS.TabIndex = 36;
            this.textBoxCTS.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxCTS, "Clear To Send.\r\nPin 8 on the RS232 DB9.");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(565, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Write Default";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(370, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Write Timeout (ms)";
            // 
            // comboBoxWriteTimeout
            // 
            this.comboBoxWriteTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxWriteTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWriteTimeout.FormattingEnabled = true;
            this.comboBoxWriteTimeout.Items.AddRange(new object[] {
            "500",
            "1000",
            "2000"});
            this.comboBoxWriteTimeout.Location = new System.Drawing.Point(389, 101);
            this.comboBoxWriteTimeout.MaxLength = 10;
            this.comboBoxWriteTimeout.Name = "comboBoxWriteTimeout";
            this.comboBoxWriteTimeout.Size = new System.Drawing.Size(60, 21);
            this.comboBoxWriteTimeout.TabIndex = 7;
            this.comboBoxWriteTimeout.Text = "500";
            this.toolTip1.SetToolTip(this.comboBoxWriteTimeout, "Serial writout time.");
            this.comboBoxWriteTimeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxWriteTimeout_KeyPress);
            // 
            // textBoxWriteTime
            // 
            this.textBoxWriteTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWriteTime.Location = new System.Drawing.Point(569, 101);
            this.textBoxWriteTime.Name = "textBoxWriteTime";
            this.textBoxWriteTime.ReadOnly = true;
            this.textBoxWriteTime.Size = new System.Drawing.Size(60, 20);
            this.textBoxWriteTime.TabIndex = 38;
            this.textBoxWriteTime.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(531, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 43;
            this.label16.Text = "Ring Indicator";
            // 
            // textBoxRI
            // 
            this.textBoxRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRI.Location = new System.Drawing.Point(542, 102);
            this.textBoxRI.Name = "textBoxRI";
            this.textBoxRI.ReadOnly = true;
            this.textBoxRI.Size = new System.Drawing.Size(65, 20);
            this.textBoxRI.TabIndex = 42;
            this.textBoxRI.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxRI, "Ring Indicator.\r\nPin 9 on the RS232 DB9.");
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(627, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Break Indicator";
            // 
            // textBoxBI
            // 
            this.textBoxBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBI.Location = new System.Drawing.Point(642, 102);
            this.textBoxBI.Name = "textBoxBI";
            this.textBoxBI.ReadOnly = true;
            this.textBoxBI.Size = new System.Drawing.Size(65, 20);
            this.textBoxBI.TabIndex = 44;
            this.textBoxBI.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(383, 6);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox11.Size = new System.Drawing.Size(335, 69);
            this.textBox11.TabIndex = 47;
            this.textBox11.TabStop = false;
            this.toolTip1.SetToolTip(this.textBox11, "Current active Com port\'s.");
            // 
            // btnEXIT
            // 
            this.btnEXIT.BackColor = System.Drawing.Color.Red;
            this.btnEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXIT.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(920, 12);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(137, 39);
            this.btnEXIT.TabIndex = 49;
            this.btnEXIT.Text = "EXIT";
            this.btnEXIT.UseVisualStyleBackColor = false;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // timerCTSETC
            // 
            this.timerCTSETC.Enabled = true;
            this.timerCTSETC.Interval = 50;
            this.timerCTSETC.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBoxDec
            // 
            this.richTextBoxDec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDec.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxDec.ContextMenuStrip = this.contextMenuStripDec;
            this.richTextBoxDec.Enabled = false;
            this.richTextBoxDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDec.HideSelection = false;
            this.richTextBoxDec.Location = new System.Drawing.Point(11, 6);
            this.richTextBoxDec.Name = "richTextBoxDec";
            this.richTextBoxDec.ReadOnly = true;
            this.richTextBoxDec.Size = new System.Drawing.Size(1025, 194);
            this.richTextBoxDec.TabIndex = 52;
            this.richTextBoxDec.TabStop = false;
            this.richTextBoxDec.Text = "";
            // 
            // contextMenuStripDec
            // 
            this.contextMenuStripDec.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem3});
            this.contextMenuStripDec.Name = "contextMenuStripDec";
            this.contextMenuStripDec.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem3
            // 
            this.copyToolStripMenuItem3.Name = "copyToolStripMenuItem3";
            this.copyToolStripMenuItem3.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem3.Text = "Copy";
            this.copyToolStripMenuItem3.Click += new System.EventHandler(this.copyToolStripMenuItem3_Click);
            // 
            // richTextBoxHex
            // 
            this.richTextBoxHex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxHex.BackColor = System.Drawing.SystemColors.ControlLight;
            this.richTextBoxHex.ContextMenuStrip = this.contextMenuStripHex;
            this.richTextBoxHex.Enabled = false;
            this.richTextBoxHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxHex.HideSelection = false;
            this.richTextBoxHex.Location = new System.Drawing.Point(10, 6);
            this.richTextBoxHex.Name = "richTextBoxHex";
            this.richTextBoxHex.ReadOnly = true;
            this.richTextBoxHex.Size = new System.Drawing.Size(1025, 194);
            this.richTextBoxHex.TabIndex = 53;
            this.richTextBoxHex.TabStop = false;
            this.richTextBoxHex.Text = "";
            // 
            // contextMenuStripHex
            // 
            this.contextMenuStripHex.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem2});
            this.contextMenuStripHex.Name = "contextMenuStripHex";
            this.contextMenuStripHex.Size = new System.Drawing.Size(103, 26);
            this.contextMenuStripHex.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripHex_Opening);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // chkBAutoReadDec
            // 
            this.chkBAutoReadDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBAutoReadDec.AutoSize = true;
            this.chkBAutoReadDec.Enabled = false;
            this.chkBAutoReadDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBAutoReadDec.Location = new System.Drawing.Point(12, 213);
            this.chkBAutoReadDec.Name = "chkBAutoReadDec";
            this.chkBAutoReadDec.Size = new System.Drawing.Size(227, 20);
            this.chkBAutoReadDec.TabIndex = 54;
            this.chkBAutoReadDec.TabStop = false;
            this.chkBAutoReadDec.Text = "Auto Read Bytes To Decimal";
            this.chkBAutoReadDec.UseVisualStyleBackColor = true;
            this.chkBAutoReadDec.CheckedChanged += new System.EventHandler(this.chkBAutoReadDec_CheckedChanged);
            // 
            // chkBAutoReadHex
            // 
            this.chkBAutoReadHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBAutoReadHex.AutoSize = true;
            this.chkBAutoReadHex.Enabled = false;
            this.chkBAutoReadHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBAutoReadHex.Location = new System.Drawing.Point(11, 213);
            this.chkBAutoReadHex.Name = "chkBAutoReadHex";
            this.chkBAutoReadHex.Size = new System.Drawing.Size(197, 20);
            this.chkBAutoReadHex.TabIndex = 55;
            this.chkBAutoReadHex.TabStop = false;
            this.chkBAutoReadHex.Text = "Auto Read Bytes To Hex";
            this.chkBAutoReadHex.UseVisualStyleBackColor = true;
            this.chkBAutoReadHex.CheckedChanged += new System.EventHandler(this.chkBAutoReadHex_CheckedChanged);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(409, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 20);
            this.label19.TabIndex = 56;
            this.label19.Text = "Decimal Read";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(424, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(159, 20);
            this.label20.TabIndex = 57;
            this.label20.Text = "Hexadecimal Read";
            // 
            // btnClearInOutBuff
            // 
            this.btnClearInOutBuff.BackColor = System.Drawing.Color.Orange;
            this.btnClearInOutBuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearInOutBuff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearInOutBuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInOutBuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInOutBuff.Location = new System.Drawing.Point(523, 34);
            this.btnClearInOutBuff.Name = "btnClearInOutBuff";
            this.btnClearInOutBuff.Size = new System.Drawing.Size(195, 46);
            this.btnClearInOutBuff.TabIndex = 58;
            this.btnClearInOutBuff.TabStop = false;
            this.btnClearInOutBuff.Text = "Clear Serial In / Out Buffers";
            this.toolTip1.SetToolTip(this.btnClearInOutBuff, "Clear\'s the serial port\'s inbound and outbound  storage buffer\'s.");
            this.btnClearInOutBuff.UseVisualStyleBackColor = false;
            this.btnClearInOutBuff.Click += new System.EventHandler(this.btnClearInOutBuff_Click);
            // 
            // comboBoxDecodeFormat
            // 
            this.comboBoxDecodeFormat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDecodeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDecodeFormat.DropDownWidth = 105;
            this.comboBoxDecodeFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDecodeFormat.FormattingEnabled = true;
            this.comboBoxDecodeFormat.Items.AddRange(new object[] {
            "utf-8",
            "utf-16",
            "utf-16-BigEndian",
            "utf-32",
            "utf-32-BigEndian",
            "us-ASCII",
            "windows-1252",
            "extended-ASCII",
            "IBM-437",
            "iso-8859-1"});
            this.comboBoxDecodeFormat.Location = new System.Drawing.Point(12, 21);
            this.comboBoxDecodeFormat.Name = "comboBoxDecodeFormat";
            this.comboBoxDecodeFormat.Size = new System.Drawing.Size(94, 21);
            this.comboBoxDecodeFormat.TabIndex = 1;
            this.toolTip1.SetToolTip(this.comboBoxDecodeFormat, "Set\'s the displayed text format / Encoding type.");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Coral;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Encoding Type";
            // 
            // lblPortStatus
            // 
            this.lblPortStatus.AutoSize = true;
            this.lblPortStatus.BackColor = System.Drawing.Color.Red;
            this.lblPortStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortStatus.Location = new System.Drawing.Point(293, 169);
            this.lblPortStatus.Name = "lblPortStatus";
            this.lblPortStatus.Size = new System.Drawing.Size(91, 16);
            this.lblPortStatus.TabIndex = 61;
            this.lblPortStatus.Text = "Port Is Closed";
            // 
            // btnConversion
            // 
            this.btnConversion.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConversion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConversion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConversion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversion.Location = new System.Drawing.Point(536, 70);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(169, 24);
            this.btnConversion.TabIndex = 62;
            this.btnConversion.Text = "Conversion Tables";
            this.toolTip1.SetToolTip(this.btnConversion, "Extra features");
            this.btnConversion.UseVisualStyleBackColor = false;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // timerTextLenght
            // 
            this.timerTextLenght.Enabled = true;
            this.timerTextLenght.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 92);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 64;
            this.label18.Text = "TX";
            // 
            // textBoxTX
            // 
            this.textBoxTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTX.Location = new System.Drawing.Point(32, 89);
            this.textBoxTX.Name = "textBoxTX";
            this.textBoxTX.ReadOnly = true;
            this.textBoxTX.Size = new System.Drawing.Size(65, 20);
            this.textBoxTX.TabIndex = 63;
            this.textBoxTX.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxTX, "Transmitted Information.");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(117, 90);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(24, 13);
            this.label22.TabIndex = 66;
            this.label22.Text = "RX";
            // 
            // textBoxRX
            // 
            this.textBoxRX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRX.Location = new System.Drawing.Point(142, 89);
            this.textBoxRX.Name = "textBoxRX";
            this.textBoxRX.ReadOnly = true;
            this.textBoxRX.Size = new System.Drawing.Size(65, 20);
            this.textBoxRX.TabIndex = 65;
            this.textBoxRX.TabStop = false;
            this.toolTip1.SetToolTip(this.textBoxRX, "Received Information.");
            // 
            // btnClearRecieveDec
            // 
            this.btnClearRecieveDec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRecieveDec.BackColor = System.Drawing.Color.Yellow;
            this.btnClearRecieveDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearRecieveDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecieveDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecieveDec.Location = new System.Drawing.Point(245, 206);
            this.btnClearRecieveDec.Name = "btnClearRecieveDec";
            this.btnClearRecieveDec.Size = new System.Drawing.Size(132, 27);
            this.btnClearRecieveDec.TabIndex = 66;
            this.btnClearRecieveDec.Text = "Clear ";
            this.btnClearRecieveDec.UseVisualStyleBackColor = false;
            this.btnClearRecieveDec.Click += new System.EventHandler(this.btnClearRecieveDec_Click);
            // 
            // btnClearRecieveHex
            // 
            this.btnClearRecieveHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearRecieveHex.BackColor = System.Drawing.Color.Yellow;
            this.btnClearRecieveHex.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnClearRecieveHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRecieveHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecieveHex.Location = new System.Drawing.Point(214, 206);
            this.btnClearRecieveHex.Name = "btnClearRecieveHex";
            this.btnClearRecieveHex.Size = new System.Drawing.Size(132, 27);
            this.btnClearRecieveHex.TabIndex = 65;
            this.btnClearRecieveHex.Text = "Clear";
            this.btnClearRecieveHex.UseVisualStyleBackColor = false;
            this.btnClearRecieveHex.Click += new System.EventHandler(this.btnClearRecieveHex_Click);
            // 
            // checkBoxBringToFront
            // 
            this.checkBoxBringToFront.AutoSize = true;
            this.checkBoxBringToFront.BackColor = System.Drawing.Color.DarkGray;
            this.checkBoxBringToFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBringToFront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBringToFront.Location = new System.Drawing.Point(930, 169);
            this.checkBoxBringToFront.Name = "checkBoxBringToFront";
            this.checkBoxBringToFront.Size = new System.Drawing.Size(125, 20);
            this.checkBoxBringToFront.TabIndex = 67;
            this.checkBoxBringToFront.Text = "Bring To Front";
            this.toolTip1.SetToolTip(this.checkBoxBringToFront, "Keep this form on top always.");
            this.checkBoxBringToFront.UseVisualStyleBackColor = false;
            this.checkBoxBringToFront.CheckedChanged += new System.EventHandler(this.checkBoxBringToFront_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabSerialPortInfo);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(735, 161);
            this.tabControl1.TabIndex = 68;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.DarkGray;
            this.tabSettings.Controls.Add(this.textBox11);
            this.tabSettings.Controls.Add(this.btnRefreshComPorts);
            this.tabSettings.Controls.Add(this.comboBoxActiveComPorts);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Controls.Add(this.comboBoxDecodeFormat);
            this.tabSettings.Controls.Add(this.label21);
            this.tabSettings.Controls.Add(this.comboBoxBaudRate);
            this.tabSettings.Controls.Add(this.label2);
            this.tabSettings.Controls.Add(this.comboBoxParity);
            this.tabSettings.Controls.Add(this.label4);
            this.tabSettings.Controls.Add(this.comboBoxDataBits);
            this.tabSettings.Controls.Add(this.label5);
            this.tabSettings.Controls.Add(this.comboBoxStopBits);
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Controls.Add(this.comboBoxFlow);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.comboBoxWriteTimeout);
            this.tabSettings.Controls.Add(this.textBoxReadTime);
            this.tabSettings.Controls.Add(this.comboBoxReadTimeout);
            this.tabSettings.Controls.Add(this.label9);
            this.tabSettings.Controls.Add(this.label10);
            this.tabSettings.Controls.Add(this.textBoxWriteTime);
            this.tabSettings.Controls.Add(this.label15);
            this.tabSettings.Controls.Add(this.label14);
            this.tabSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(727, 132);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            // 
            // tabSerialPortInfo
            // 
            this.tabSerialPortInfo.BackColor = System.Drawing.Color.DarkGray;
            this.tabSerialPortInfo.Controls.Add(this.lblRxSent);
            this.tabSerialPortInfo.Controls.Add(this.lblTxSent);
            this.tabSerialPortInfo.Controls.Add(this.textBoxDSR);
            this.tabSerialPortInfo.Controls.Add(this.label11);
            this.tabSerialPortInfo.Controls.Add(this.textBoxCD);
            this.tabSerialPortInfo.Controls.Add(this.label12);
            this.tabSerialPortInfo.Controls.Add(this.textBoxCTS);
            this.tabSerialPortInfo.Controls.Add(this.label13);
            this.tabSerialPortInfo.Controls.Add(this.textBoxRI);
            this.tabSerialPortInfo.Controls.Add(this.label22);
            this.tabSerialPortInfo.Controls.Add(this.label16);
            this.tabSerialPortInfo.Controls.Add(this.textBoxBI);
            this.tabSerialPortInfo.Controls.Add(this.btnClearInOutBuff);
            this.tabSerialPortInfo.Controls.Add(this.textBoxRX);
            this.tabSerialPortInfo.Controls.Add(this.label17);
            this.tabSerialPortInfo.Controls.Add(this.label18);
            this.tabSerialPortInfo.Controls.Add(this.textBoxTX);
            this.tabSerialPortInfo.Controls.Add(this.btnDtrOn);
            this.tabSerialPortInfo.Controls.Add(this.btnRtsOn);
            this.tabSerialPortInfo.Controls.Add(this.btnRtsOff);
            this.tabSerialPortInfo.Controls.Add(this.textBoxRTS);
            this.tabSerialPortInfo.Controls.Add(this.btnClearAllText);
            this.tabSerialPortInfo.Controls.Add(this.btnDtrOff);
            this.tabSerialPortInfo.Controls.Add(this.txtBCurrentPortSet);
            this.tabSerialPortInfo.Controls.Add(this.textBoxDTR);
            this.tabSerialPortInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabSerialPortInfo.Location = new System.Drawing.Point(4, 25);
            this.tabSerialPortInfo.Name = "tabSerialPortInfo";
            this.tabSerialPortInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialPortInfo.Size = new System.Drawing.Size(727, 132);
            this.tabSerialPortInfo.TabIndex = 1;
            this.tabSerialPortInfo.Text = "Serial Port Info";
            // 
            // lblRxSent
            // 
            this.lblRxSent.AutoSize = true;
            this.lblRxSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRxSent.Location = new System.Drawing.Point(117, 112);
            this.lblRxSent.Name = "lblRxSent";
            this.lblRxSent.Size = new System.Drawing.Size(36, 13);
            this.lblRxSent.TabIndex = 68;
            this.lblRxSent.Text = "RX  :";
            this.toolTip1.SetToolTip(this.lblRxSent, "Receive counter.");
            // 
            // lblTxSent
            // 
            this.lblTxSent.AutoSize = true;
            this.lblTxSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxSent.Location = new System.Drawing.Point(6, 114);
            this.lblTxSent.Name = "lblTxSent";
            this.lblTxSent.Size = new System.Drawing.Size(35, 13);
            this.lblTxSent.TabIndex = 67;
            this.lblTxSent.Text = "TX  :";
            this.toolTip1.SetToolTip(this.lblTxSent, "Transmit counter.");
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnFont);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnConversion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(727, 132);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Extra Features & Logging";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(536, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 24);
            this.button1.TabIndex = 72;
            this.button1.Text = "Checksum Calc";
            this.toolTip1.SetToolTip(this.button1, "Save the current received information to a file.");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lblDataLogFilePath);
            this.groupBox2.Controls.Add(this.ckBOverwriteLogs);
            this.groupBox2.Controls.Add(this.ckBAppendLogs);
            this.groupBox2.Controls.Add(this.ckBEnableLogs);
            this.groupBox2.Location = new System.Drawing.Point(14, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 120);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Logger";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(13, 97);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(118, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "Logging File Path : ";
            // 
            // lblDataLogFilePath
            // 
            this.lblDataLogFilePath.AutoSize = true;
            this.lblDataLogFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataLogFilePath.Location = new System.Drawing.Point(137, 97);
            this.lblDataLogFilePath.Name = "lblDataLogFilePath";
            this.lblDataLogFilePath.Size = new System.Drawing.Size(14, 13);
            this.lblDataLogFilePath.TabIndex = 3;
            this.lblDataLogFilePath.Text = "?";
            // 
            // ckBOverwriteLogs
            // 
            this.ckBOverwriteLogs.AutoSize = true;
            this.ckBOverwriteLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBOverwriteLogs.Location = new System.Drawing.Point(17, 71);
            this.ckBOverwriteLogs.Name = "ckBOverwriteLogs";
            this.ckBOverwriteLogs.Size = new System.Drawing.Size(129, 17);
            this.ckBOverwriteLogs.TabIndex = 2;
            this.ckBOverwriteLogs.Text = "Overwrite Log File";
            this.ckBOverwriteLogs.UseVisualStyleBackColor = true;
            this.ckBOverwriteLogs.CheckedChanged += new System.EventHandler(this.ckBOverwriteLogs_CheckedChanged);
            // 
            // ckBAppendLogs
            // 
            this.ckBAppendLogs.AutoSize = true;
            this.ckBAppendLogs.Checked = true;
            this.ckBAppendLogs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBAppendLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBAppendLogs.Location = new System.Drawing.Point(17, 45);
            this.ckBAppendLogs.Name = "ckBAppendLogs";
            this.ckBAppendLogs.Size = new System.Drawing.Size(118, 17);
            this.ckBAppendLogs.TabIndex = 1;
            this.ckBAppendLogs.Text = "Append Log File";
            this.ckBAppendLogs.UseVisualStyleBackColor = true;
            this.ckBAppendLogs.CheckedChanged += new System.EventHandler(this.ckBAppendLogs_CheckedChanged);
            // 
            // ckBEnableLogs
            // 
            this.ckBEnableLogs.AutoSize = true;
            this.ckBEnableLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckBEnableLogs.Location = new System.Drawing.Point(17, 19);
            this.ckBEnableLogs.Name = "ckBEnableLogs";
            this.ckBEnableLogs.Size = new System.Drawing.Size(108, 17);
            this.ckBEnableLogs.TabIndex = 0;
            this.ckBEnableLogs.Text = "Enable Logger";
            this.ckBEnableLogs.UseVisualStyleBackColor = true;
            this.ckBEnableLogs.CheckedChanged += new System.EventHandler(this.ckBEnableLogs_CheckedChanged);
            this.ckBEnableLogs.CheckStateChanged += new System.EventHandler(this.ckBEnableLogs_CheckStateChanged);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.PowderBlue;
            this.btnFont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(536, 6);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(169, 24);
            this.btnFont.TabIndex = 65;
            this.btnFont.Text = "Set Font Size";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabRecieve);
            this.tabControl2.Controls.Add(this.tabHexRead);
            this.tabControl2.Controls.Add(this.tabDecRead);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(8, 191);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1050, 266);
            this.tabControl2.TabIndex = 69;
            // 
            // tabRecieve
            // 
            this.tabRecieve.BackColor = System.Drawing.Color.Silver;
            this.tabRecieve.Controls.Add(this.richTextBoxRecieve);
            this.tabRecieve.Controls.Add(this.chkBConvertToHexDec);
            this.tabRecieve.Controls.Add(this.btnRead);
            this.tabRecieve.Controls.Add(this.chkBAutoRead);
            this.tabRecieve.Controls.Add(this.btnClearRecieve);
            this.tabRecieve.Location = new System.Drawing.Point(4, 25);
            this.tabRecieve.Name = "tabRecieve";
            this.tabRecieve.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecieve.Size = new System.Drawing.Size(1042, 237);
            this.tabRecieve.TabIndex = 0;
            this.tabRecieve.Text = "RECEIVE  (RX)";
            // 
            // tabHexRead
            // 
            this.tabHexRead.BackColor = System.Drawing.Color.Silver;
            this.tabHexRead.Controls.Add(this.richTextBoxHex);
            this.tabHexRead.Controls.Add(this.chkBAutoReadHex);
            this.tabHexRead.Controls.Add(this.label20);
            this.tabHexRead.Controls.Add(this.btnClearRecieveHex);
            this.tabHexRead.Location = new System.Drawing.Point(4, 25);
            this.tabHexRead.Name = "tabHexRead";
            this.tabHexRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabHexRead.Size = new System.Drawing.Size(1042, 237);
            this.tabHexRead.TabIndex = 1;
            this.tabHexRead.Text = "HEX READ";
            // 
            // tabDecRead
            // 
            this.tabDecRead.BackColor = System.Drawing.Color.Silver;
            this.tabDecRead.Controls.Add(this.richTextBoxDec);
            this.tabDecRead.Controls.Add(this.chkBAutoReadDec);
            this.tabDecRead.Controls.Add(this.label19);
            this.tabDecRead.Controls.Add(this.btnClearRecieveDec);
            this.tabDecRead.Location = new System.Drawing.Point(4, 25);
            this.tabDecRead.Name = "tabDecRead";
            this.tabDecRead.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecRead.Size = new System.Drawing.Size(1042, 237);
            this.tabDecRead.TabIndex = 2;
            this.tabDecRead.Text = "DECIMAL READ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.plotter_option_group);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1042, 237);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "GRAPH";
            // 
            // plotter_option_group
            // 
            this.plotter_option_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plotter_option_group.Controls.Add(this.label30);
            this.plotter_option_group.Controls.Add(this.lblCountTX);
            this.plotter_option_group.Controls.Add(this.label28);
            this.plotter_option_group.Controls.Add(this.lblCountRX);
            this.plotter_option_group.Controls.Add(this.ckBStartGraph);
            this.plotter_option_group.Controls.Add(this.graph_speed);
            this.plotter_option_group.Controls.Add(this.label29);
            this.plotter_option_group.Location = new System.Drawing.Point(872, 71);
            this.plotter_option_group.Name = "plotter_option_group";
            this.plotter_option_group.Size = new System.Drawing.Size(167, 164);
            this.plotter_option_group.TabIndex = 26;
            this.plotter_option_group.TabStop = false;
            this.plotter_option_group.Text = "Options";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(6, 122);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(86, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Samples TX : ";
            // 
            // lblCountTX
            // 
            this.lblCountTX.AutoSize = true;
            this.lblCountTX.Location = new System.Drawing.Point(104, 122);
            this.lblCountTX.Name = "lblCountTX";
            this.lblCountTX.Size = new System.Drawing.Size(39, 13);
            this.lblCountTX.TabIndex = 29;
            this.lblCountTX.Text = "count";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 96);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 13);
            this.label28.TabIndex = 28;
            this.label28.Text = "Samples RX : ";
            // 
            // lblCountRX
            // 
            this.lblCountRX.AutoSize = true;
            this.lblCountRX.Location = new System.Drawing.Point(101, 96);
            this.lblCountRX.Name = "lblCountRX";
            this.lblCountRX.Size = new System.Drawing.Size(39, 13);
            this.lblCountRX.TabIndex = 27;
            this.lblCountRX.Text = "count";
            // 
            // ckBStartGraph
            // 
            this.ckBStartGraph.AutoSize = true;
            this.ckBStartGraph.Location = new System.Drawing.Point(6, 35);
            this.ckBStartGraph.Name = "ckBStartGraph";
            this.ckBStartGraph.Size = new System.Drawing.Size(91, 17);
            this.ckBStartGraph.TabIndex = 19;
            this.ckBStartGraph.Text = "Start Graph";
            this.ckBStartGraph.UseVisualStyleBackColor = true;
            this.ckBStartGraph.CheckedChanged += new System.EventHandler(this.ckBStartGraph_CheckedChanged);
            // 
            // graph_speed
            // 
            this.graph_speed.AllowDrop = true;
            this.graph_speed.AutoSize = true;
            this.graph_speed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graph_speed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.graph_speed.Location = new System.Drawing.Point(101, 66);
            this.graph_speed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.graph_speed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.graph_speed.Name = "graph_speed";
            this.graph_speed.Size = new System.Drawing.Size(58, 20);
            this.graph_speed.TabIndex = 17;
            this.graph_speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.graph_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(6, 68);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 13);
            this.label29.TabIndex = 18;
            this.label29.Text = "Interval (Sec) :";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 6);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "SeriesRX";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SeriesTX";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1025, 225);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // txRepeaterDelay
            // 
            this.txRepeaterDelay.Tick += new System.EventHandler(this.txRepeaterDelay_Tick);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.DarkGray;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(13, 169);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 16);
            this.label25.TabIndex = 70;
            this.label25.Text = "RECEIVE  ( RX )";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // timerGraph
            // 
            this.timerGraph.Interval = 1000;
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1066, 613);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBoxBringToFront);
            this.Controls.Add(this.lblPortStatus);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClosePort);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Comm Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tx_num_panel.ResumeLayout(false);
            this.tx_num_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_repeat)).EndInit();
            this.contextMenuStripSend.ResumeLayout(false);
            this.contextMenuStripRecieve.ResumeLayout(false);
            this.contextMenuStripDec.ResumeLayout(false);
            this.contextMenuStripHex.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabSerialPortInfo.ResumeLayout(false);
            this.tabSerialPortInfo.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabRecieve.ResumeLayout(false);
            this.tabRecieve.PerformLayout();
            this.tabHexRead.ResumeLayout(false);
            this.tabHexRead.PerformLayout();
            this.tabDecRead.ResumeLayout(false);
            this.tabDecRead.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.plotter_option_group.ResumeLayout(false);
            this.plotter_option_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActiveComPorts;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox richTextBoxSend;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox richTextBoxRecieve;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkBAutoRead;
        private System.Windows.Forms.Button btnClearAllText;
        private System.Windows.Forms.CheckBox checkBoxAutoSend;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBCurrentPortSet;
        private System.Windows.Forms.Button btnRefreshComPorts;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxFlow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRtsOn;
        private System.Windows.Forms.Button btnRtsOff;
        private System.Windows.Forms.TextBox textBoxRTS;
        private System.Windows.Forms.TextBox textBoxReadTime;
        private System.Windows.Forms.Button btnDtrOn;
        private System.Windows.Forms.TextBox textBoxDTR;
        private System.Windows.Forms.Button btnDtrOff;
        private System.Windows.Forms.ComboBox comboBoxReadTimeout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDSR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxCD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxCTS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxWriteTimeout;
        private System.Windows.Forms.TextBox textBoxWriteTime;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxRI;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btnEXIT;
        public System.Windows.Forms.TextBox textBoxBI;
        private System.Windows.Forms.Timer timerCTSETC;
        private System.Windows.Forms.RichTextBox richTextBoxDec;
        private System.Windows.Forms.RichTextBox richTextBoxHex;
        private System.Windows.Forms.CheckBox chkBAutoReadDec;
        private System.Windows.Forms.CheckBox chkBAutoReadHex;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnClearInOutBuff;
        private System.Windows.Forms.CheckBox chkBConvertToHexDec;
        private System.Windows.Forms.ComboBox comboBoxDecodeFormat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblPortStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripSend;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRecieve;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripHex;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDec;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem3;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.CheckBox checkBoxSendHex;
        private System.Windows.Forms.CheckBox checkBoxSendDec;
        private System.Windows.Forms.CheckBox checkBoxSendNormal;
        private System.Windows.Forms.Timer timerTextLenght;
        private System.Windows.Forms.CheckBox checkBox3DEC;
        private System.Windows.Forms.CheckBox checkBox2DEC;
        private System.Windows.Forms.Button btnClearSend;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTX;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBoxRX;
        private System.Windows.Forms.Button btnClearRecieve;
        private System.Windows.Forms.Button btnClearRecieveDec;
        private System.Windows.Forms.Button btnClearRecieveHex;
        private System.Windows.Forms.CheckBox checkBoxBringToFront;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabSerialPortInfo;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabRecieve;
        private System.Windows.Forms.TabPage tabHexRead;
        private System.Windows.Forms.TabPage tabDecRead;
        private System.Windows.Forms.Panel tx_num_panel;
        private System.Windows.Forms.NumericUpDown send_delay;
        private System.Windows.Forms.NumericUpDown send_repeat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Timer txRepeaterDelay;
        private System.Windows.Forms.CheckBox checkBoxCRLF;
        private System.Windows.Forms.CheckBox checkBoxCR;
        private System.Windows.Forms.Label lblRxSent;
        private System.Windows.Forms.Label lblTxSent;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSendBreak;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnStopSendFile;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckBOverwriteLogs;
        private System.Windows.Forms.CheckBox ckBAppendLogs;
        private System.Windows.Forms.CheckBox ckBEnableLogs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblDataLogFilePath;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox plotter_option_group;
        private System.Windows.Forms.NumericUpDown graph_speed;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblCountRX;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox ckBStartGraph;
        private System.Windows.Forms.Timer timerGraph;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblCountTX;
        private System.Windows.Forms.Button button1;
    }
}

