/*
 *   This file is part of Serial-Comm-Tester source code.  All Rights Reserved.
 *
 *  Serial-Comm-Tetster is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License.
 *
 *  This software is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this software; if not, write to the Free Software
 *  Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307,
 *  USA.
 */


/*
 *     Author: Philip Murray
 *     Project Homepage: https://github.com/PhilipMur/Serial-Comm-Tester
 */

using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serial_Comm_Tester
{
    public partial class Form1 : Form
    {
        // public Conversion_Table conTable = null;

        private int send_repeat_counter = 0;
        private int RXcounter = 0;
        private int TXcounter = 0;
        private int rXChartCount = 0;
        private int tXChartCount = 0;

        public Form1()
        {
            InitializeComponent();
            //starts the system to look for available ports
            getAvailablePorts();




        }

        private void SerialEncoding()
        {
            Invoke((MethodInvoker)delegate ()
            {
                comBoBoxformatText = comboBoxDecodeFormat.Text;


            });

            //  serialPort1.Encoding = Encoding.GetEncoding(1252); //US-ASCII
            //  serialPort1.Encoding = Encoding.GetEncoding(28591);  //EXTENDED ASCII  USED FOR  ISO 8859-1
            //new code with unicode encoding iso-8859-1
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "windows-1252")
            {
                serialPort1.Encoding = Encoding.GetEncoding("windows-1252");
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "utf-8")
            {
                serialPort1.Encoding = Encoding.GetEncoding("utf-8");
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "utf-16")
            {
                serialPort1.Encoding = Encoding.GetEncoding("utf-16");
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "us-ASCII")
            {
                serialPort1.Encoding = Encoding.GetEncoding("us-ASCII");
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "extended-ASCII")
            {
                serialPort1.Encoding = Encoding.GetEncoding(28591);
            }

            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "IBM-437")
            {
                serialPort1.Encoding = Encoding.GetEncoding(437);
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "iso-8859-1")
            {
                serialPort1.Encoding = Encoding.GetEncoding("iso-8859-1");
            }
         
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "utf-32")
            {
                serialPort1.Encoding = Encoding.GetEncoding("utf-32");
            }

            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "utf-16-BigEndian")
            {
                serialPort1.Encoding = Encoding.BigEndianUnicode;
            }
            if (serialPort1.IsOpen && btnOpenPort.Enabled == false && comBoBoxformatText == "utf-32-BigEndian")
            {
                serialPort1.Encoding = new  UTF32Encoding(true,true);
            }
          



        }
        //this code reads the serial port but catches a timeout exception
        private async void btnRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {


                    SerialEncoding();


                    string s = serialPort1.ReadExisting();


                    richTextBoxRecieve.Text += s;


                    if(s != "")
                    {
                        rXChartCount++; //update the samples per interval
                       

                        RXcounter++;
                        lblRxSent.Update();
                        lblRxSent.Text = "RX :" + RXcounter;
                        //flash up rx
                        RX = true;
                    }
                    


                    //this is the original///////////////////////////
                    //richTextBox2.Text += serialPort1.ReadExisting();

                    // serialPort1.DiscardInBuffer();

                   

                }
                catch (Exception ex)
                {
                    ComPortClosed();
                    MessageBox.Show(ex.Message, "Read Timeout Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!serialPort1.IsOpen)
            {

                ComPortClosed();
            }
            richTextBoxSend.Focus();

            await Task.Delay(100);
            RX = false;
        }

        //this code just finds the available ports to use
        void getAvailablePorts()
        {
            //this code gets the name of the port and port number
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports2 = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());

                var portList = portnames.Select(n => n + " - " + ports2.FirstOrDefault(s => s.Contains(n))).ToList();
                //this code displays the values in a list form in the textbox
                foreach (string s in portList)
                {
                    textBox11.Text += s.ToString() + "\r\n";
                }
            }
            //this code only gets the com port number
            string[] ports = SerialPort.GetPortNames();
            comboBoxActiveComPorts.Items.AddRange(ports);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxDecodeFormat.SelectedIndex = 0;
            comboBoxParity.SelectedIndex = 0;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxStopBits.SelectedIndex = 0;
            comboBoxFlow.SelectedIndex = 0;
        }

        //this code on button 3 click it checks to see if combobox1&2 are empty ,else combobox1 = port name
        //it also catches a throw exception if the port is busy already and access denied
        //also it re-enables the buttons and textboxes and buttons if the port is open
        public void btnOpenPort_Click(object sender, EventArgs e)
        {

            try
            {
                if (comboBoxActiveComPorts.Text == "" || comboBoxBaudRate.Text == "" || comboBoxParity.Text == "" || comboBoxDataBits.Text == "" || comboBoxStopBits.Text == "" || comboBoxFlow.Text == "" || comboBoxDecodeFormat.Text == "" && !serialPort1.IsOpen)
                {
                    richTextBoxRecieve.Text = "Select Port Settings First";

                }


                else
                {
                    richTextBoxDec.Text = "";
                    richTextBoxHex.Text = "";
                    richTextBoxSend.Text = "";

                   

                    progressBar1.Value = 25;

                    tabControl1.SelectedIndex = 1;
                    tabControl2.SelectedIndex = 0;

                    lblRxSent.Text = "RX :" + RXcounter;
                    lblTxSent.Text = "TX :" + TXcounter;

                    SerialEncoding();

                    txRepeaterDelay.Tick += new EventHandler(SendData);

                    //enable logging
                    ckBAppendLogs.Enabled = false;
                    ckBEnableLogs.Enabled = false;
                    ckBOverwriteLogs.Enabled = false;


                    //this sets the possible comport settings from items in comboboxes collections
                    serialPort1.PortName = comboBoxActiveComPorts.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParity.Text);
                    serialPort1.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);

                    if(comboBoxFlow.Text == "RTS/CTS")
                    {
                        serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), "None");
                       
                        serialPort1.RtsEnable = true;
                        textBoxRTS.BackColor = Color.Lime;
                        textBoxRTS.Text = "Rts ON";
                        btnRtsOn.Enabled = false;
                        btnRtsOff.Enabled = true;
                    }
                    else
                    {
                        serialPort1.Handshake = (Handshake)Enum.Parse(typeof(Handshake), comboBoxFlow.Text);
                    }
                   

                    if (comboBoxFlow.Text != "None" | comboBoxFlow.Text != "XOnXOff")
                    {
                        chkBAutoRead.Enabled = false;
                        checkBoxAutoSend.Enabled = false;
                      
                       
                        chkBAutoReadDec.Checked = false;
                        chkBAutoReadHex.Checked = false;
                        chkBAutoReadDec.Enabled = false;
                        chkBAutoReadHex.Enabled = false;

                        


                        chkBConvertToHexDec.Enabled = true; /////////

                        checkBoxSendHex.Enabled = true;
                        checkBoxSendDec.Enabled = true;
                        checkBoxSendNormal.Enabled = true;
                        checkBox2DEC.Enabled = true;
                        checkBox3DEC.Enabled = true;
                        //checkBoxSendBinary.Enabled = true;
                        //checkBoxSendOct.Enabled = true;

                    }
                

                    //this code checks that readtimeout is set and if not it defaults to -1
                    if (comboBoxReadTimeout.Text != "")
                    {
                        serialPort1.ReadTimeout = Convert.ToInt32(comboBoxReadTimeout.Text);
                    }
                    if (comboBoxReadTimeout.Text == "")
                    {
                        serialPort1.ReadTimeout = 500;
                    }

                    //this code checks that writetimeout is set and if not it defaults to -1
                    if (comboBoxWriteTimeout.Text != "")
                    {
                        serialPort1.WriteTimeout = Convert.ToInt32(comboBoxWriteTimeout.Text);
                    }
                    if (comboBoxWriteTimeout.Text == "")
                    {
                        serialPort1.WriteTimeout = 500;
                    }

                    progressBar1.Value = 50;

                    //finally it opens the serial port here if its not open
                    serialPort1.Open();

                    //MODIFIED 24/01/17 COMMENTED OUT GOING FOR LABEL INSTEAD
                    //  richTextBox2.Text = "Serial Port Is Open";

                    lblPortStatus.Text = "Port is Open";
                    lblPortStatus.BackColor = Color.Lime;

                    richTextBoxRecieve.Text = "";

                    //this gets the current port settings and displays in the textbox1
                    txtBCurrentPortSet.Text = "Port :" + Convert.ToString(serialPort1.PortName) + "\t" + "Baud Rate :"
                        + Convert.ToInt32(serialPort1.BaudRate) + "\t\t" + "Parity :" + serialPort1.Parity +
                       "\t" + "Data Bits :" + Convert.ToInt32(serialPort1.DataBits) + "\t" + "StopBits :" + serialPort1.StopBits + "\t" +
                       "Handshake :" + serialPort1.Handshake;

                    txtBCurrentPortSet.BackColor = Color.Chartreuse;

                    progressBar1.Value = 75;

                    //this sets the boxes to enabled or disabled
                    richTextBoxDec.Clear();
                    richTextBoxHex.Clear();
                    richTextBoxSend.Enabled = true;
                    richTextBoxRecieve.Enabled = true;
                    richTextBoxDec.Enabled = true;
                    richTextBoxHex.Enabled = true;

                    btnSend.Enabled = true;
                    btnRead.Enabled = true;
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                    btnRefreshComPorts.Enabled = false;

                   
                    btnDtrOn.Enabled = true;
                    btnRtsOn.Enabled = true;
                    btnDtrOff.Enabled = false;
                    //if(comboBoxFlow.Text == "RTS/CTS") //-----------------------------14/7/17
                    //{
                    //    textBoxRTS.BackColor = Color.Lime;
                    //    textBoxRTS.Text = "Rts ON";
                    //}
                    //else
                    //{
                    //    textBoxRTS.BackColor = Color.Red;
                    //    textBoxRTS.Text = "Rts Off";
                    //}
                    
                    serialPort1.DtrEnable = false;
                    textBoxDTR.BackColor = Color.Red;
                    textBoxDTR.Text = "Dtr Off";

                    //modified 24/01/17 disable COMBOboxes
                    comboBoxActiveComPorts.Enabled = false;
                    comboBoxBaudRate.Enabled = false;
                    comboBoxDataBits.Enabled = false;
                    comboBoxDecodeFormat.Enabled = false;
                    comboBoxFlow.Enabled = false;
                    comboBoxParity.Enabled = false;
                    comboBoxReadTimeout.Enabled = false;
                    comboBoxStopBits.Enabled = false;
                    comboBoxWriteTimeout.Enabled = false;

                 


                    //this gets the current value of read and write timeouts and displays in the textbox
                    textBoxReadTime.Text = serialPort1.ReadTimeout.ToString();
                    textBoxWriteTime.Text = serialPort1.WriteTimeout.ToString();

                    progressBar1.Value = 100;
                    richTextBoxSend.Focus();

                    //this code checks if combobox has None enabled and is not using XOnXOff etc.....
                    if (serialPort1.IsOpen && comboBoxFlow.Text == "None" | comboBoxFlow.Text == "XOnXOff" )
                    {
                        btnRtsOn.Enabled = true;

                    }
                    chkBAutoRead.Enabled = true;
                    checkBoxAutoSend.Enabled = true;
                    chkBAutoReadDec.Enabled = true;
                    chkBAutoReadHex.Enabled = true;
                    chkBConvertToHexDec.Enabled = true;

                    checkBoxSendNormal.Checked = true;
                    chkBAutoRead.Checked = true;

                    checkBoxSendHex.Enabled = true;
                    checkBoxSendDec.Enabled = true;
                    checkBoxSendNormal.Enabled = true;
                    checkBox2DEC.Enabled = true;
                    checkBox3DEC.Enabled = true;

                    btnSave.Enabled = true;
                    //checkBoxSendBinary.Enabled = true;
                    //checkBoxSendOct.Enabled = true;

                 

                }
              


            }

            catch (Exception ex)
            {

                progressBar1.Value = 0;
                tabControl1.SelectedIndex = 0;
                MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //this code uses async to delay closing the port untill auto reads are disabled
        //this code when the close serial port is clicked it disabled the buttons again untill the port is opened again
        private async void btnClosePort_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)

            {
                ckBAppendLogs.Enabled = true;
                ckBEnableLogs.Enabled = true;
                ckBOverwriteLogs.Enabled = true;

                if(comboBoxFlow.Text == "RTS/CTS")
                {
                    serialPort1.RtsEnable = false;
                    textBoxRTS.BackColor = Color.Red;
                    // serialPort1.RtsEnable = false;  //---------------------------------------17/6/17
                    textBoxRTS.Text = "Rts Off";
                }

                richTextBoxSend.Enabled = false;
                btnRefreshComPorts.Enabled = true;
                if(comboBoxFlow.Text == "None" | comboBoxFlow.Text == "XOnXOff") 
                {
                    serialPort1.RtsEnable = false;
                }
                if(serialPort1.DtrEnable)
                {
                    serialPort1.DtrEnable = false;
                }
                textBoxRTS.BackColor = Color.Red;
               // serialPort1.RtsEnable = false;  //---------------------------------------17/6/17
                textBoxRTS.Text = "Rts Off";
                
                textBoxDTR.BackColor = Color.Red;
                textBoxDTR.Text = "Dtr Off";
                textBoxDSR.BackColor = Color.LightSkyBlue;
                textBoxDSR.Text = "Dsr Off";
                textBoxCD.BackColor = Color.LightSkyBlue;
                textBoxCD.Text = "CD Off";
                textBoxCTS.BackColor = Color.LightSkyBlue;
                textBoxCTS.Text = "Cts Off";

                RXcounter = 0;
                TXcounter = 0;
                send_repeat_counter = 0;



                chkBAutoRead.Checked = false;
                checkBoxAutoSend.Checked = false;
                chkBAutoRead.Enabled = false;
                checkBoxAutoSend.Enabled = false;
                chkBAutoReadDec.Checked = false;
                chkBAutoReadHex.Checked = false;
                chkBAutoReadDec.Enabled = false;
                chkBAutoReadHex.Enabled = false;
                chkBConvertToHexDec.Enabled = false;
                chkBConvertToHexDec.Checked = false;
                checkBoxSendHex.Enabled = false;
                checkBoxSendHex.Checked = false;
                checkBoxSendDec.Enabled = false;
                checkBoxSendDec.Checked = false;
                checkBoxSendNormal.Enabled = false;
                checkBoxSendNormal.Checked = false;
                checkBox2DEC.Enabled = false;
                checkBox2DEC.Checked = false;
                checkBox3DEC.Enabled = false;
                checkBox3DEC.Checked = false;
                //checkBoxSendBinary.Enabled = false;
                //checkBoxSendOct.Enabled = false;

                //modified 24/01/17 disable COMBOboxes
                comboBoxActiveComPorts.Enabled = true;
                comboBoxBaudRate.Enabled = true;
                comboBoxDataBits.Enabled = true;
                comboBoxDecodeFormat.Enabled = true;
                comboBoxFlow.Enabled = true;
                comboBoxParity.Enabled = true;
                comboBoxReadTimeout.Enabled = true;
                comboBoxStopBits.Enabled = true;
                comboBoxWriteTimeout.Enabled = true;

                txtBCurrentPortSet.BackColor = Color.DarkGray;

                tabControl1.SelectedIndex = 0;

                txRepeaterDelay.Stop();

                send_repeat_counter = 0;


               txRepeaterDelay.Tick -= new EventHandler(SendData); //this removes the event handler
                txRepeaterDelay.Dispose(); //dispose of the new event handler

                if (timerGraph.Enabled)
                {
                    ckBStartGraph.Checked = false;
                    graph_speed.Enabled = true;
                    timerGraph.Stop();
                }

                // serialPort1.DiscardInBuffer();
                //  serialPort1.DiscardOutBuffer();
                //serialPort1.Close();

                //serialPort1.Dispose();

                await Button1ClickAsync();

            }
        }

        public async Task Button1ClickAsync()
        {
            // Do asynchronous work and wait untill (a set time)
            await Task.Delay(500);


            if (serialPort1.IsOpen)
                try
                {

                    //this code closes the port and enables or disables the neccessary buttons

                    //richTextBox2.Enabled = false;
                    //richTextBox3.Enabled = false;
                    //richTextBox4.Enabled = false;

                    //MODIFIED 24/01/17 wont clear boxes untill re opened
                    //richTextBoxDec.Text = "";
                    //richTextBoxHex.Text = "";
                    //richTextBoxSend.Text = "";

                    //MODIFIED 24/01/17 LABEL INSTEAD
                    //  richTextBox2.Text = "Serial Port Is Closed";
                    lblPortStatus.Text = "Port is Closed";
                    lblPortStatus.BackColor = Color.Red;

                    textBoxRI.Text = "";
                    textBoxRI.BackColor = Color.LightSkyBlue;
                    textBoxBI.BackColor = Color.LightSkyBlue;
                    textBoxBI.Text = "";
                    progressBar1.Value = 0;
                    btnSend.Enabled = false;
                    btnRead.Enabled = false;
                    btnClosePort.Enabled = false;
                    btnOpenPort.Enabled = true;
                    //rts dtr buttons
                    btnRtsOn.Enabled = true;
                    btnDtrOn.Enabled = true;
                    btnRtsOff.Enabled = false;
                    btnDtrOff.Enabled = false;
                    chkBAutoRead.Checked = false;
                    checkBoxAutoSend.Checked = false;
                    chkBAutoRead.Enabled = false;
                    checkBoxAutoSend.Enabled = false;
                    chkBAutoReadDec.Checked = false;
                    chkBAutoReadHex.Checked = false;
                    chkBAutoReadDec.Enabled = false;
                    chkBAutoReadHex.Enabled = false;
                    chkBConvertToHexDec.Enabled = false;
                    chkBConvertToHexDec.Checked = false;
                    checkBoxSendHex.Enabled = false;
                    checkBoxSendHex.Checked = false;
                    checkBoxSendDec.Enabled = false;
                    checkBoxSendDec.Checked = false;
                    checkBoxSendNormal.Enabled = false;
                    checkBoxSendNormal.Checked = false;
                    //checkBoxSendBinary.Enabled = false;
                    //checkBoxSendOct.Enabled = false;


                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();

                    serialPort1.Close();
                    serialPort1.Dispose();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message");
                    tabControl1.SelectedIndex = 0;
                }

            if (!serialPort1.IsOpen && btnClosePort.Enabled == true)
                try
                {

                    ComPortClosed();
                }
                catch (Exception ex)
                {
                    ComPortClosed();
                    tabControl1.SelectedIndex = 0;
                    MessageBox.Show(ex.Message, "Message");
                }
        }
        //THIS IS FOR CLOSING THE COM PORT
        private void ComPortClosed()
        {

            richTextBoxSend.Text = "";
            richTextBoxSend.Text = "COM Port Closed Unexpectedly";

            lblPortStatus.Text = "Port is Closed";
            lblPortStatus.BackColor = Color.Red;

            //  richTextBoxSend.Text = "";
            textBoxRI.Text = "";
            textBoxRI.BackColor = Color.LightSkyBlue;
            textBoxBI.Text = "";
            textBoxBI.BackColor = Color.LightSkyBlue;
            progressBar1.Value = 0;
            btnSend.Enabled = false;
            btnRead.Enabled = false;
            btnClosePort.Enabled = false;
            btnOpenPort.Enabled = true;
            richTextBoxSend.Enabled = false;
            btnRefreshComPorts.Enabled = true;
            textBoxRTS.BackColor = Color.Red;
            textBoxRTS.Text = "Rts Off";
            serialPort1.DtrEnable = false;
            textBoxDTR.BackColor = Color.Red;
            textBoxDTR.Text = "Dtr Off";
            //DTR AND RTS
            btnRtsOn.Enabled = true;
            btnDtrOn.Enabled = true;
            btnRtsOff.Enabled = false;
            btnDtrOff.Enabled = false;

            textBoxDSR.BackColor = Color.LightSkyBlue;
            textBoxDSR.Text = "Dsr Off";
            textBoxCD.BackColor = Color.LightSkyBlue;
            textBoxCD.Text = "CD Off";
            textBoxCTS.BackColor = Color.LightSkyBlue;
            textBoxCTS.Text = "Cts Off";
            chkBAutoRead.Checked = false;
            checkBoxAutoSend.Checked = false;
            chkBAutoRead.Enabled = false;
            checkBoxAutoSend.Enabled = false;
            chkBAutoReadDec.Checked = false;
            chkBAutoReadHex.Checked = false;
            chkBAutoReadDec.Enabled = false;
            chkBAutoReadHex.Enabled = false;
            chkBConvertToHexDec.Enabled = false;
            chkBConvertToHexDec.Checked = false;
            checkBoxSendHex.Enabled = false;
            checkBoxSendHex.Checked = false;
            checkBoxSendDec.Enabled = false;
            checkBoxSendDec.Checked = false;
            checkBoxSendNormal.Enabled = false;
            checkBoxSendNormal.Checked = false;
            checkBox2DEC.Enabled = false;
            checkBox2DEC.Checked = false;
            checkBox3DEC.Enabled = false;
            checkBox3DEC.Checked = false;
            //checkBoxSendBinary.Enabled = false;
            //checkBoxSendOct.Enabled = false;



            //modified 24/01/17 disable COMBOboxes
            comboBoxActiveComPorts.Enabled = true;
            comboBoxBaudRate.Enabled = true;
            comboBoxDataBits.Enabled = true;
            comboBoxDecodeFormat.Enabled = true;
            comboBoxFlow.Enabled = true;
            comboBoxParity.Enabled = true;
            comboBoxReadTimeout.Enabled = true;
            comboBoxStopBits.Enabled = true;
            comboBoxWriteTimeout.Enabled = true;

            txtBCurrentPortSet.BackColor = Color.DarkGray;

            tabControl1.SelectedIndex = 0;
        }


        //this code writes whatever is in richtextbox1 to the serial port and then clears the textbox
        //this bastard was transfering return key as 0a hex
        private string comBoBoxformatText;

        private static bool DecSend = false;

        private static bool sendDataNoError = true;

        private async void SendData(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && sendDataNoError == true)
            {
                string tx_data = "";

                if (send_repeat_counter < (int)send_repeat.Value)
                {
                        

                         tx_data = richTextBoxSend.Text;
                    //progressBar1.Value = send_repeat_counter;
                    //progressBar1.Update();
                    try
                    {
                        //THIS SEND NORMAL ENCODING EXAMPLE ASCII UTF-8 ETC
                        if (checkBoxSendHex.Checked == false && checkBoxSendDec.Checked == false)
                        {
                            if (boolCarrigeReturnLF == true)
                            {
                                serialPort1.Write(tx_data + "\r\n");
                              //  TX = true;
                            }
                            // serialPort1.Write(tx_data.Replace("\\n", Environment.NewLine));
                            if (boolCarrigeReturn == true)
                            {
                                serialPort1.Write(tx_data + "\r");
                              //  TX = true;
                            }
                            if (boolCarrigeReturn == false && boolCarrigeReturnLF == false)
                            {
                                serialPort1.Write(tx_data);
                              //  TX = true;
                            }

                            // tx_terminal.AppendText("[TX]> " + tx_data + "\n");

                            TX = true;

                         //   send_repeat_counter++;

                            tXChartCount++;//tx chart values per interval

                            TXcounter++;
                            lblTxSent.Update();
                            lblTxSent.Text = "TX :" + TXcounter;
                        }

                            //this is to send the values as hexadecimal with or without carrige return and line feed
                            if (checkBoxSendHex.Checked == true)
                            {
                            string asciiToHexSend2 = ConvertHex(tx_data);
                            if (boolCarrigeReturnLF == true)
                            {
                               
                                serialPort1.Write(asciiToHexSend2 + "\r\n");
                               // TX = true;
                            }
                            if (boolCarrigeReturn == true)
                            {
                               
                                serialPort1.Write(asciiToHexSend2 + "\r");
                              //  TX = true;
                            }

                            if (boolCarrigeReturn == false && boolCarrigeReturnLF == false)
                            {
                              //  SerialEncoding();

                             
                                serialPort1.Write(asciiToHexSend2);
                                
                               
                            }
                            //for lighting up tx
                            TX = true;
                           // send_repeat_counter++;

                            tXChartCount++;//tx chart values per interval

                            TXcounter++;
                            lblTxSent.Update();
                            lblTxSent.Text = "TX :" + TXcounter;
                        }

                        
                        if (checkBoxSendDec.Checked == true)
                        {
                            string asciiToHexSend = ConvertDec(tx_data);

                            if (boolCarrigeReturnLF == true)
                            {
                               

                                serialPort1.Write(asciiToHexSend + "\r\n");
                              //  TX = true;
                            }
                            if (boolCarrigeReturn == true)
                            {
                                serialPort1.Write(asciiToHexSend + "\r");
                               // TX = true;
                            }

                            if (boolCarrigeReturn == false && boolCarrigeReturnLF == false)
                            {
                               // SerialEncoding();



                                serialPort1.Write(asciiToHexSend);

                                

                               
                            }
                            TX = true;
                          //  send_repeat_counter++;

                            tXChartCount++;//tx chart values per interval

                            TXcounter++;
                            lblTxSent.Update();
                            lblTxSent.Text = "TX :" + TXcounter;
                        }
                        send_repeat_counter++;
                    }
                    catch
                    {
                      
                       // ComPortClosed();

                        txRepeaterDelay.Stop();
                        send_repeat_counter = 0;
                        MessageBox.Show( "Can't write to " + serialPort1.PortName + " port is in use already!!");
                    }
                }

            }
            if(send_repeat_counter == (int)send_repeat.Value)
            {
                txRepeaterDelay.Stop();
                
                // sendData.Text = "Send";
                //send_repeat_counter = 1;
            }

            if (!serialPort1.IsOpen)
            {

                ComPortClosed();
                txRepeaterDelay.Stop();
                
                send_repeat_counter = 0;
            }

            //if(send_repeat_counter == (int)send_repeat.Value)
            //{
            //    txRepeaterDelay.Stop();
            //    // sendData.Text = "Send";
            //    send_repeat_counter = 0;
            //}
            await Task.Delay(100);
            TX = false;
        }

        private  void btnSend_Click(object sender, EventArgs e)   ///>>>>>>>>>>>>bool decsend
        {
            send_repeat_counter = 0; //put this here as closing the form and reopening the form would dounble up on the send

            sendDataNoError = true;

            richTextBoxSend.Focus();
            //string removeSpaces = richTextBoxSend.Text.Replace(" " , "");   ///THIS WORKS BY SEEING IF THE STRING TO INT IS DIVISABLE BY 2 TO >>>>>>>>>>GENIUS I AM
            //int removeSpacesLenght = removeSpaces.Length;
            //if (removeSpacesLenght % 2 == 0 )
            if (checkBox2DEC.Checked | checkBoxSendHex.Checked)
            {
                // MessageBox.Show("send is even");
                DecSend = true;
            }
            //  cout << "String length is even" << endl;
            // else
            if (checkBox3DEC.Checked)
            {
                //  MessageBox.Show("send is odd");
                DecSend = false;
            }
            // cout << "String length is odd" 

            //THIS IS USED TO CONVERT THE SEND TEXT TO HEX AND SEND THROUGH THE SERIAL PORT////////
            if (serialPort1.IsOpen && richTextBoxSend.Text != "" && btnSend.Enabled)
                try
                {
                    SerialEncoding();

                    if (checkBoxSendHex.Checked == true)
                    {
                       

                        txRepeaterDelay.Interval = (int)send_delay.Value;
                        txRepeaterDelay.Start();

                    }
                    //this writes decimal to the serial port
                    if (checkBoxSendDec.Checked == true)
                    {
                        

                        txRepeaterDelay.Interval = (int)send_delay.Value;
                        txRepeaterDelay.Start();
                      

                    }

                    ////this allows access to the value of comboBox1 cross threading
                    if (checkBoxSendHex.Checked == false && checkBoxSendDec.Checked == false)
                    {
                       

                        SerialEncoding();

                        txRepeaterDelay.Interval = (int)send_delay.Value;
                        txRepeaterDelay.Start();

                      
                    }
                }
                catch (Exception ex)
                {
                    // ComPortClosed();
                    //  MessageBox.Show("if sending as hex use hex values example 01 not 1 by itself","Message for a newbie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // richTextBox2.Text = "Unauthorized Access Exception Thrown";
                    MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            if (!serialPort1.IsOpen)
            {

                ComPortClosed();

            }
        

        }
        //this code makes sure on exit that the port closes too
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
           

        }
        //this code gets the received data from the serial port and displya it in richtextbox2
        private string richbox2string;
        private string richboxHexString;
        private string richboxDecString;

        public async void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)

        {
            
            //this allows access to the value of comboBox1 cross threading
            Invoke((MethodInvoker)delegate ()
            {
                comBoBoxformatText = comboBoxDecodeFormat.Text;
                
             
            });


            SerialEncoding();


            //this code displays the hex values to richtextbox4 you cannot directly call data from the port as its a seperate thread
            if (serialPort1.IsOpen && chkBAutoReadHex.Checked)
                try {
                    //this is the original ////////////////////////////////
                    // richbox4string = serialPort1.ReadByte().ToString("X2") + "  ";


                    richboxHexString = toHex(serialPort1.ReadExisting()); //>>>>>>>>>>>>>>>>>i changed this 2017
                                                                        // richbox4string = ConvertHex(serialPort1.ReadExisting());
                    Invoke(new EventHandler(displayAutoHex));

                  

                    RX = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //this code gets the decimal value and displays it to richtextbox3
            if (serialPort1.IsOpen && chkBAutoReadDec.Checked)
                try {
                    //this is the original
                    //  richbox3string = serialPort1.ReadByte().ToString("") + "  ";

                    richboxDecString = toDec(serialPort1.ReadExisting());

                    this.Invoke(new EventHandler(displayAutoDec));

                   

                    RX = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //this checks first to see if the port is open and the checked box is checked to read existing serial data
            if (chkBAutoRead.Checked && serialPort1.IsOpen && chkBAutoReadDec.Checked == false && chkBAutoReadHex.Checked == false)
            {
                try
                {
                    //////////////////////////////////////////
                    ////this code can read any desired encoding once its specified in the brackets
                    //Modified 24/01/17 commented out
                    //this allows access to the value of comboBox1 cross threading
                    Invoke((MethodInvoker)delegate ()
                    {
                        comBoBoxformatText = comboBoxDecodeFormat.Text;


                    });



                    SerialEncoding();


                    string s = serialPort1.ReadExisting();
                    richbox2string = s;


                    this.Invoke(new EventHandler(displayAutoText));

                   

                    RX = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!serialPort1.IsOpen && chkBAutoRead.Checked)
                {

                    ComPortClosed();

                }

            }
            await Task.Delay(100);
            RX = false;
        }
       
        //this code gets the hex value from the com port and drops to a new line if carrige return or line feed is displayed
        private void displayAutoHex(object o, EventArgs e)
        {
          

            //richTextBoxHex.AppendText(SB.ToString());
            string[] hexSeparators = { "0A" };
            string hexValue = richboxHexString;
            string[] hexWords = hexValue.Split(hexSeparators, StringSplitOptions.None);

            string[] hexSeparators2 = { "0D" };
            string hexValue2 = richboxHexString;
            string[] hexWords2 = hexValue2.Split(hexSeparators2, StringSplitOptions.None);


            if (hexValue.Contains("0A"))
            {

                foreach (var word in hexWords)
                {

                    richTextBoxHex.AppendText(word + "0A" + "\n");

                    writeLogsToFile(word + "0A" + Environment.NewLine);
                }

            }
            else if (hexValue2.Contains("0D"))
            {

                foreach (var word in hexWords2)
                {

                    richTextBoxHex.AppendText(word + "0D" + "\n");

                    writeLogsToFile(word + "0D" + Environment.NewLine);
                }

            }
            else if(!hexValue.Contains("0A") | !hexValue.Contains("0D"))
            {
                richTextBoxHex.AppendText(richboxHexString);


                writeLogsToFile(richboxHexString);
              
            }

            // richTextBoxHex.AppendText(richbox4string);

            rXChartCount++; //update the samples per interval
          

            RXcounter++;
            lblRxSent.Update();
            lblRxSent.Text = "RX :" + RXcounter;

        }
        //THIS WRITES THE LOG FILES
        private void writeLogsToFile(string input)
        {
            //this will write to log file
            if (ckBEnableLogs.Checked)
            {
                try
                {
                    // loggingFile.WriteAsync("Hello wtf");
                    using (StreamWriter tw = new StreamWriter(lblDataLogFilePath.Text, ckBAppendLogs.Checked))
                    {
                        // write a line of text to the file
                        tw.Write(input);
                        tw.Flush();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        //this code gets the dec value from com port and drops to a new line if carrige return or line feed is displayed
        private void displayAutoDec(object o, EventArgs e)
        {
            // richTextBoxDec.AppendText(richbox3string);

            string[] decSeparators = { "010" };

            string decValue = richboxDecString;
            string[] decWords = decValue.Split(decSeparators, StringSplitOptions.None);

            string[] decSeparators2 = { "013" };

            string decValue2 = richboxDecString;
            string[] decWords2 = decValue2.Split(decSeparators2, StringSplitOptions.None);

            if (decValue.Contains("010"))
            {

                foreach (var word in decWords)
                {

                    richTextBoxDec.AppendText(word + "010" + "\n");

                    writeLogsToFile(word + "010" + Environment.NewLine);
                }

            }
           
           else if (decValue2.Contains("013"))
            {

                foreach (var word in decWords2)
                {

                    richTextBoxDec.AppendText(word + "013" + "\n");

                    writeLogsToFile(word + "013" + Environment.NewLine);
                }

            }

            else if(!decValue.Contains("010") && !decValue2.Contains("013"))
            {
                richTextBoxDec.AppendText(richboxDecString);

                writeLogsToFile(richboxDecString);
            }
            rXChartCount++; //update the samples per interval
           

            RXcounter++;
            lblRxSent.Update();
            lblRxSent.Text = "RX :" + RXcounter;
        }
       
        //this code sends the received data to richtextbox2 and doesnt overwrite it
        private void displayAutoText(object o, EventArgs e)
        {
            string[] textSeparators = { "\n" };

            string textValue = richbox2string;
            string[] textWords = textValue.Split(textSeparators, StringSplitOptions.None);

            string[] textSeparators2 = { "\r" };

            string textValue2 = richbox2string;
            string[] textWords2 = textValue2.Split(textSeparators2, StringSplitOptions.None);

            richTextBoxRecieve.AppendText(richbox2string);

            rXChartCount++; //update the samples per interval
           

            RXcounter++;
            lblRxSent.Update();
            lblRxSent.Text = "RX :" + RXcounter;

            if (textValue.Contains("\r")) //if it has a carrige return go to a newline  
            {
                foreach (var word in textWords)
                {

                    writeLogsToFile(word + Environment.NewLine);

                }
            }
           else if (textValue2.Contains("\n")) //if it has a linefeed go to a newline  
            {
                foreach (var word in textWords2)
                {

                    writeLogsToFile(word + Environment.NewLine);

                }
            }

            else if(!textValue.Contains("\n") && !textValue2.Contains("\r"))
            {
                writeLogsToFile(richbox2string);

            }
             

          

        }
        //when the clear button is pressed it will clear both text boxes and clears in/out serial buffers
        private void btnClearAllText_Click(object sender, EventArgs e)
        {

            richTextBoxSend.Clear();
            richTextBoxRecieve.Clear();
            richTextBoxDec.Clear();
            richTextBoxHex.Clear();

            richTextBoxSend.Focus();

            RXcounter = 0;
            TXcounter = 0;

            lblRxSent.Text = "RX :" + RXcounter;
            lblTxSent.Text = "TX :" + TXcounter;
            //if (serialPort1.IsOpen)
            //{
            //    serialPort1.DiscardInBuffer();
            //    serialPort1.DiscardOutBuffer();
            //}

        }
        //this code sends the data in realtime when checkedbox2 is checked
        private async void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (checkBoxSendHex.Checked || checkBoxSendDec.Checked)
            {

                char ch = e.KeyChar;
                if (richTextBoxSend.Text.Length <= 5 && char.IsControl(ch) && ch == 8)
                {
                    richTextBoxSend.Clear();
                    t = 1;
                    j = 2;
                }
                //THIS REMOVES A CHUNK OF TEXT FROM THE TEXTBOX SEND IF HEX OR DEC IS CHOOSEN
                if (richTextBoxSend.Text.Length > 5 && char.IsControl(ch) && ch == 8 && checkBox3DEC.Checked)
                {
                    //this removes the next 5 chars when the backspace button is hit
                    richTextBoxSend.Text = richTextBoxSend.Text.Substring(0, richTextBoxSend.Text.Length - 4);

                    //this resets the cursor position to the end of the text
                    richTextBoxSend.Select(richTextBoxSend.Text.Length, 0);

                    j = j - 4;


                }
                if (richTextBoxSend.Text.Length > 5 && char.IsControl(ch) && ch == 8 && checkBox2DEC.Checked | checkBoxSendHex.Checked)
                {
                    richTextBoxSend.Text = richTextBoxSend.Text.Substring(0, richTextBoxSend.Text.Length - 3);
                    richTextBoxSend.Select(richTextBoxSend.Text.Length, 0);

                    t = t - 3;


                }
            }
            if (serialPort1.IsOpen)
                try
                {


                    if (serialPort1.IsOpen && checkBoxAutoSend.Checked)

                    {
                        //this code just sends out a character key from keyboard
                        // char[] ch = new char[1];
                        // ch[0] = e.KeyChar;
                        //serialPort1.Write(ch, 0, 1);

                        //MODIFIED 24/1/17 COMMENTED OUT
                        ////this code sends the new serial encoding type but only through reading the textbox so one charcter delay
                        //this allows access to the value of comboBox1 cross threading
                        Invoke((MethodInvoker)delegate ()
                        {
                            comBoBoxformatText = comboBoxDecodeFormat.Text;


                        });


                        SerialEncoding();

                        serialPort1.Write(richTextBoxSend.Text);

                        richTextBoxSend.Clear();
                        serialPort1.DiscardOutBuffer();

                        TX = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Original Error :" + ex.Message, "Clear To Send Is Not Active ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            if (!serialPort1.IsOpen && checkBoxAutoSend.Checked)
                try
                {


                    ComPortClosed();

                }


                catch (Exception ex)
                {
                    ComPortClosed();

                    MessageBox.Show("Original Error :" + ex.Message, "Clear To Send Is Not Active ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            await Task.Delay(100);
            TX = false;

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 openabout = new AboutBox1();
            openabout.ShowDialog();
        }
        //this code checks to see if comport is in use before restart/refreshing the system iterases the previous items 
        //before adding current new item port names
        public void btnRefreshComPorts_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)

                try {
                    comboBoxActiveComPorts.Items.Clear();
                    textBox11.Clear();

                    getAvailablePorts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Serial Port is Busy Or Open", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
            {
                MessageBox.Show("Close The Current Port Before Refreshing","Message" , MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void btnRtsOn_Click(object sender, EventArgs e)
        {
            // RTS cannot be accessed if readyToSend readyToSend xonxoff is enable etc..
            if(comboBoxFlow.SelectedIndex != 3 && comboBoxFlow.SelectedIndex != 4)
            {
                if (serialPort1.IsOpen && serialPort1.RtsEnable == false)
                {

                    serialPort1.RtsEnable = true;
                    textBoxRTS.BackColor = Color.Lime;
                    textBoxRTS.Text = "Rts ON";
                    btnRtsOn.Enabled = false;
                    btnRtsOff.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show( "Cannot enable RTS when using this Handshaking Flow control","Message" , MessageBoxButtons.OK , MessageBoxIcon.Information);
            }
          

        }

        private void btnRtsOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.RtsEnable == true)
            {
                serialPort1.RtsEnable = false;
                textBoxRTS.BackColor = Color.Red;
                textBoxRTS.Text = "Rts Off";
                btnRtsOff.Enabled = false;
                btnRtsOn.Enabled = true;
            }
        }

        private void btnDtrOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.DtrEnable == false)
            {

                serialPort1.DtrEnable = true;
                textBoxDTR.BackColor = Color.Lime;
                textBoxDTR.Text = "Dtr ON";
                btnDtrOn.Enabled = false;
                btnDtrOff.Enabled = true;
            }
        }

        private void btnDtrOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen && serialPort1.DtrEnable == true)
            {
                serialPort1.DtrEnable = false;
                textBoxDTR.BackColor = Color.Red;
                textBoxDTR.Text = "Dtr Off";
                btnDtrOff.Enabled = false;
                btnDtrOn.Enabled = true;
            }
        }


        int t = 1;
        int j = 2;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            sendDataNoError = true; //this is a switch to restart the send function after it being stopped by an error trying to convert and send an invalid hex dec char from the user

            //THIS IS THE METHOD FOR ADDING A SPACE IN THE RICHTEXTBOX SEND IF HEX OR 2DEC IS CHECKED
            if (checkBoxSendHex.Checked)
            {
                int textLen = 0;

                textLen = richTextBoxSend.Text.Length;



                if (textLen > t)
                {
                    t = textLen;
                    richTextBoxSend.AppendText("  ");
                    // textLen = 0;
                    t = t + 3;
                    // t++;
                }


                if (textLen == 0)
                {
                    t = textLen;
                    t++;
                }
            }
            if (checkBoxSendDec.Checked && checkBox2DEC.Checked)
            {
                int textLen = 0;

                textLen = richTextBoxSend.Text.Length;



                if (textLen > t)
                {
                    t = textLen;
                    richTextBoxSend.AppendText("  ");
                    // textLen = 0;
                    t = t + 3;
                    // t++;
                }


                if (textLen == 0)
                {
                    t = textLen;
                    t++;
                }
            }



            if (checkBox3DEC.Checked && checkBoxSendDec.Checked)
            {
                int textLen = richTextBoxSend.Text.Length;



                if (textLen > j)
                {

                    j = textLen;
                    richTextBoxSend.AppendText("  ");
                    // textLen = 0;
                    j = j + 4;
                    // t++;
                    //if (textLen > 0 && Keys.KeyCode == Keys.Back)
                    //{
                    //  richTextBoxSend.Text = richTextBoxSend.Text.Remove(textLen - 1);
                    //    MessageBox.Show("removed 1");
                    //}
                }
                if (textLen == 0)
                {
                    j = textLen;
                    j++;
                    j++;
                }
            }
        }

        private bool TX = false;
        private bool RX = false;
       

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            serialPort1.Close();

            Form1.ActiveForm.Close();
            Process.GetCurrentProcess().Kill();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                try
                {



                    textBoxRI.Text = "";
                    textBoxBI.Text = "";
                    if (serialPort1.DsrHolding == true)
                    {
                        textBoxDSR.BackColor = Color.Lime;
                        textBoxDSR.Text = "Dsr On";
                    }
                    if (serialPort1.DsrHolding == false)
                    {
                        textBoxDSR.BackColor = Color.LightSkyBlue;
                        textBoxDSR.Text = "Dsr Off";
                    }
                    if (serialPort1.CDHolding == true)
                    {
                        textBoxCD.BackColor = Color.Lime;
                        textBoxCD.Text = "CD On";
                    }
                    if (serialPort1.CDHolding == false)
                    {
                        textBoxCD.BackColor = Color.LightSkyBlue;
                        textBoxCD.Text = "CD Off";

                    }
                    if (serialPort1.CtsHolding == true)
                    {
                        textBoxCTS.BackColor = Color.Lime;
                        textBoxCTS.Text = "Cts On";
                    }
                    if (serialPort1.CtsHolding == false)
                    {
                        textBoxCTS.BackColor = Color.LightSkyBlue;
                        textBoxCTS.Text = "Cts Off";

                    }
                    //this code gets the the serial ring value
                    textBoxRI.Text = SerialPinChange.Ring.ToString();
                    if (textBoxRI.Text == "Ring")
                    {
                        textBoxRI.BackColor = Color.Lime;

                    }
                    // textBox9.Text = SerialPinChange.Ring.ToString();
                    if (textBoxRI.Text != "Ring")
                    {
                        textBoxRI.BackColor = Color.LightSkyBlue;

                    }
                    //this code gets the current state of a break point
                    textBoxBI.Text = SerialPinChange.Break.ToString();
                    if (textBoxBI.Text == "Break")
                    {
                        textBoxBI.BackColor = Color.Lime;

                    }
                    // textBox10.Text = SerialPinChange.Break.ToString();
                    if (textBoxBI.Text != "Break")
                    {
                        textBoxBI.BackColor = Color.LightSkyBlue;

                    }

                    if (TX == true)
                    {
                        textBoxTX.BackColor = Color.Lime;
                        textBoxTX.Text = "TX On";
                        //TXcounter++;
                        //lblTxSent.Update();
                        //lblTxSent.Text = "TX :" + TXcounter;

                    }
                    if (TX == false)
                    {
                        textBoxTX.BackColor = Color.LightSkyBlue;
                        textBoxTX.Text = "TX Off";
                    }

                    if (RX == true)
                    {
                        textBoxRX.BackColor = Color.Lime;
                        textBoxRX.Text = "RX On";

                        //rXcharCount++;
                        //RXcounter++;
                        //lblRxSent.Update();
                        //lblRxSent.Text = "RX :" + RXcounter;

                    }
                    if (RX == false)
                    {
                        textBoxRX.BackColor = Color.LightSkyBlue;
                        textBoxRX.Text = "RX Off";
                    }
                    if(comboBoxFlow.Text != "RequestToSendXOnXOff" && comboBoxFlow.Text != "RequestToSend") // added this as it was trying to access thr rts even though it cannot be access with these flow settings
                    {

                        if (serialPort1.RtsEnable)
                        {
                            textBoxRTS.BackColor = Color.Lime;
                            textBoxRTS.Text = "Rts ON";
                            //  timerCTSETC.Stop();
                        }
                        if (serialPort1.RtsEnable == false)
                        {
                            textBoxRTS.BackColor = Color.Red;
                            textBoxRTS.Text = "Rts Off";
                            // timerCTSETC.Stop();
                        }
                        
                    }
                   if(comboBoxFlow.Text == "RequestToSendXOnXOff" | comboBoxFlow.Text == "RequestToSend")
                            {
                        textBoxRTS.BackColor = Color.Red;
                        textBoxRTS.Text = "Rts Off";

                    }

                }

                catch (Exception ex)
                {
                    ComPortClosed();
                    MessageBox.Show("This COM Port Closed Unexpectedly . Original error :" + ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



        }




        //this code gets the value of richtextbox2 and displays it in hex in RTB4
        public string toHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();

            foreach (char L in value)
            {
                int v = Convert.ToInt32(L);
                
                outp += string.Format("{0:X2}" + "  ", v);
                
            }
          
            return outp;

        }
        //this code gets the value of richtextbox2 and displays it in Decimal in RTB3
        public string toDec(string inp2)
        {


            string outp2 = string.Empty;
            char[] value = inp2.ToCharArray();

            foreach (char L in value)
            {

                int v2 = Convert.ToInt32(L);
                //long v2 = Convert.ToInt64(L);
                
                outp2 += string.Format("{0:000}" + "  ", v2);
                
            }
            return outp2;
        }
        //hex to ascii
        public static string ConvertHex(string hexString) //>>>>>>>>>>>>>>>>>>new the textbox can only accept 2 characters
        {
            try
            {
                string ascii = string.Empty;

                // hexString = hexString.Replace("  ", ""); //this make sure no white space is trying to get converted//-------------------------------------18/5/17

                StringBuilder sb = new StringBuilder(hexString); //-------------------------------------18/5/17
                sb.Replace(" ", "");
                sb.Replace("  ", "");
                hexString = sb.ToString();

                for (int i = 0; i < hexString.Length; i += 2)
                {
                    string hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                    //uint decval = Convert.ToUInt32(hs, 16);
                    // char character = Convert.ToChar(decval); //-------------------------------------18/5/17

                    char character = Convert.ToChar(Convert.ToUInt32(hs, 16)); //-------------------------------------18/5/17
                    // string character = decval.ToString("x2");
                    ascii += character;
                    // ascii += decval;

                }

                return ascii;

            }
            catch (Exception ex)
            {

                sendDataNoError = false;
                //Form1 f1 = new Form1();
                //f1.txRepeaterDelay.Stop();
                //f1.send_repeat_counter = 100;
                //f1.richTextBoxSend.Text = "";

                MessageBox.Show("Enter a Valid Hexadecimal Value. Original error :  " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }

            return string.Empty;
        }

        //THIS IS FOR SENDING AS DECIMAL
        public static string ConvertDec(string decString) //>>>>>>>>>>>>>>>>>>new the textbox can only accept 2 characters
        {
            int decSpace = 2;

            if (DecSend == true)  //see if the string is divisable by 2
            {
                // MessageBox.Show("2");
                decSpace = 2;
            }
            if (DecSend == false)  //see if the string is divisable by 2
            {
                //  MessageBox.Show("3");
                decSpace = 3;
            }
            //  decString.Replace(" ", "");
            try
            {



                string dec = string.Empty;



                //if (decString.Contains(" "))
                //{
                // decString = decString.Replace("  ", "");
                StringBuilder sb = new StringBuilder(decString);  //-------------------------------------18/5/17
                sb.Replace(" ", "");
                sb.Replace("  ", "");
                decString = sb.ToString();


                // for (int i = 0; i < decString.Length; i += 2)
                for (int i = 0; i < decString.Length; i += decSpace)
                //  for (int i = 0; i < decString.Length; i++)
                {
                    string hs = string.Empty;
                    // hs = decString;
                    //  hs = decString.Substring(i, 2);
                    hs = decString.Substring(i, decSpace);
                    uint decval = Convert.ToUInt32(hs);
                    char character = Convert.ToChar(decval);
                    dec += character;
                    // dec += decval;

                }
                //  }




                return dec;
            }


            catch (Exception ex)
            {
                sendDataNoError = false;
                //Form1 f1 = new Form1();
                //f1.txRepeaterDelay.Stop();
                //f1.send_repeat_counter = 100;
                //f1.richTextBoxSend.Text = "";

                MessageBox.Show("Enter a Valid Decimal Value. Original error : " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

               
            }


            return string.Empty;
        }


        //this code appends the text from richtextbox2 and converts it to hex and decimal
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen && chkBConvertToHexDec.Checked && richTextBoxRecieve.Text != "")
            {
                richTextBoxHex.Clear();
                richTextBoxDec.Clear();

                //string[] separators = { "0A", "0D" };
                string[] hexSeparators = { "0A" };
                string hexValue = toHex(richTextBoxRecieve.Text);
                string[] hexWords = hexValue.Split(hexSeparators, StringSplitOptions.None);
                foreach (var word in hexWords)
                {
                    // Console.WriteLine(word);
                    richTextBoxHex.AppendText(word + "0A"  + "\n");
                }


                string[] decSeparators = { "010" };
                string decValue = toDec(richTextBoxRecieve.Text);
                string[] decWords = decValue.Split(decSeparators, StringSplitOptions.None);
                foreach (var word in decWords)
                {
                    // Console.WriteLine(word);
                    richTextBoxDec.AppendText(word + "010" + "\n");
                }

                //richTextBoxHex.Text += toHex(richTextBoxRecieve.Text);
                //  richTextBoxHex.Text = ConvertHex(richTextBoxRecieve.Text);
              //  richTextBoxDec.Text += toDec(richTextBoxRecieve.Text);

            }


        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                try
                {
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardInBuffer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        //RIGHT CLICK TO COPY AND PASTE TO CLIPBOARD
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxSend.SelectedText == "" && richTextBoxSend.Text != "")
            {
                Clipboard.SetText(richTextBoxSend.Text);
            }
            if (richTextBoxSend.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxSend.SelectedText);
            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxSend.Text += Clipboard.GetText();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBoxRecieve.SelectedText == "" && richTextBoxRecieve.Text != "")
            {
                Clipboard.SetText(richTextBoxRecieve.Text);
            }
            if (richTextBoxRecieve.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxRecieve.SelectedText);
            }

        }



        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (richTextBoxHex.SelectedText == "" && richTextBoxHex.Text != "")
            {
                Clipboard.SetText(richTextBoxHex.Text);
            }
            if (richTextBoxHex.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxHex.SelectedText);
            }

        }

        //private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        //{
        //    richTextBoxHex.Text += Clipboard.GetText();
        //}

        private void contextMenuStripHex_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void copyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (richTextBoxDec.SelectedText == "" && richTextBoxDec.Text != "")
            {
                Clipboard.SetText(richTextBoxDec.Text);
            }
            if (richTextBoxDec.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxDec.SelectedText);
            }

        }
        //THIS IS USED TO OPEN ONLY ONE INSTANCE OF THE CONVERSION TABLE AND IF ITS CREATED BRING TO FRONT
        //  Conversion_Table conTable = null;
        private Conversion_Table conTable;

        private void btnConversion_Click(object sender, EventArgs e)
        {
            // Conversion_Table conTable = new Conversion_Table();
            if (conTable == null || (conTable != null && conTable.IsDisposed))
            {
                conTable = new Conversion_Table();
                conTable.Show();
                //   MessageBox.Show("disposed");
            }
            if (conTable.WindowState == FormWindowState.Minimized)
            {
                conTable.WindowState = FormWindowState.Normal;
            }
            else
            {
                conTable.BringToFront();
                //  MessageBox.Show("bring to front");
            }

        }
        //SETS THE CHECK STATE AND GIVES FOCUS TO THE SEND BOX AND DOESNT ALLOW KEYBOARD SHORTCUTS WHEN HEX OR DEC OR SUB DEC ARE CHOSEN
        private void checkBoxSendHex_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSendHex.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.ShortcutsEnabled = false;
                richTextBoxSend.Text = "";
                checkBox3DEC.Checked = false;

                checkBoxAutoSend.Checked = false;
                checkBoxSendDec.Checked = false;
                checkBoxSendNormal.Checked = false;
            }
        }

        private void checkBoxAutoSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoSend.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.ShortcutsEnabled = false;
                richTextBoxSend.Text = "";

                checkBoxSendHex.Checked = false;
                checkBoxSendDec.Checked = false;
                checkBoxSendNormal.Checked = false;
            }
        }

        private void checkBoxSendDec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSendDec.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.ShortcutsEnabled = false;
                richTextBoxSend.Text = "";

                checkBoxSendHex.Checked = false;
                checkBoxAutoSend.Checked = false;
                checkBoxSendNormal.Checked = false;
                checkBox2DEC.Checked = true;
                // checkBoxSendDec.Checked = true;
            }
            if (checkBoxSendDec.Checked == false)
            {
                richTextBoxSend.Focus();
                checkBox2DEC.Checked = false;
                checkBox3DEC.Checked = false;
            }
        }
        private void checkBox2DEC_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBoxSendDec.Checked)
            //{
            //    checkBox2DEC.Checked = true;
            //}
            if (checkBox2DEC.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.Text = "";

                checkBoxSendDec.Checked = true;
                checkBox3DEC.Checked = false;
                checkBox2DEC.Checked = true;
            }
        }

        private void checkBox3DEC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3DEC.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.Text = "";

                checkBoxSendDec.Checked = true;
                checkBox2DEC.Checked = false;
                checkBox3DEC.Checked = true;
            }
        }

        private void checkBoxSendNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSendNormal.Checked)
            {
                richTextBoxSend.Focus();
                richTextBoxSend.ShortcutsEnabled = true;
                richTextBoxSend.Text = "";

                checkBoxSendHex.Checked = false;
                checkBoxSendDec.Checked = false;
                checkBoxAutoSend.Checked = false;
                checkBoxSendNormal.Checked = true;
            }
        }

        private void chkBAutoReadHex_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBAutoReadHex.Checked)

            {
                richTextBoxSend.Focus();
                chkBAutoReadDec.Checked = false;
                chkBAutoRead.Checked = false;
                chkBConvertToHexDec.Checked = false;
            }

        }

        private void chkBAutoReadDec_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBAutoReadDec.Checked)
            {
                richTextBoxSend.Focus();
                chkBAutoRead.Checked = false;
                chkBConvertToHexDec.Checked = false;
                chkBAutoReadHex.Checked = false;
            }


        }

        private void chkBAutoRead_CheckedChanged(object sender, EventArgs e)
        {

            chkBAutoReadHex.Checked = false;
            chkBAutoReadDec.Checked = false;
        }

        private void chkBConvertToHexDec_CheckedChanged(object sender, EventArgs e)
        {
            chkBAutoRead.Checked = true;
            chkBAutoReadHex.Checked = false;
            chkBAutoReadDec.Checked = false;
        }

        //private void chkBAutoReadHex_Click(object sender, EventArgs e)
        //{
        //   // chkBAutoReadHex.Checked = true;
        //}

        //private void chkBAutoReadDec_Click(object sender, EventArgs e)
        //{
        //   // chkBAutoReadDec.Checked = true;
        //}

        //private void chkBAutoRead_Click(object sender, EventArgs e)
        //{
        //   // chkBAutoRead.Checked = true;
        //}

        //this is to limit the size of the the text captured in the richtextboxes
        bool stopMessage = false;


        //TICK EVENT FOR MAX CHARACTERS RECIEVED

        private async void timer2_Tick(object sender, EventArgs e)
        {
            if(ckBEnableLogs.Checked && richTextBoxRecieve.Lines.Length > 20 )
            {
                // richTextBoxRecieve.Lines.Skip(10);
                 richTextBoxRecieve.Text = richTextBoxRecieve.Text.Remove(0, richTextBoxRecieve.Lines.Length);
               // richTextBoxRecieve.Clear();

            }
            if (ckBEnableLogs.Checked &&  richTextBoxHex.Lines.Length > 20 )
            {

                richTextBoxHex.Text = richTextBoxHex.Text.Remove(0, richTextBoxHex.Lines.Length);
               // richTextBoxHex.Clear();
               
            }
            if (ckBEnableLogs.Checked &&  richTextBoxDec.Lines.Length > 20)
            {
                richTextBoxDec.Text = richTextBoxDec.Text.Remove(0, richTextBoxDec.Lines.Length);
              //  richTextBoxDec.Clear();
            }
            // if (richTextBoxRecieve.Text.Length > 10000 | richTextBoxHex.Text.Length > 10000 | richTextBoxDec.Text.Length > 10000 && stopMessage == false)
            if (richTextBoxRecieve.Lines.Length > 5000 | richTextBoxHex.Lines.Length > 5000 | richTextBoxDec.Lines.Length > 5000 && stopMessage == false)
                {
                //stop capturing the inbound data
                chkBAutoRead.Checked = false;
                chkBAutoReadDec.Checked = false;
                chkBAutoReadHex.Checked = false;

                stopMessage = true;
                DialogResult messageBoxResult = MessageBox.Show("Capturing Data for too long , Choose YES to Save or NO to Clear", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (messageBoxResult == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();

                    sfd.Title = "Save To a File";
                    sfd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";
                   

                    string recieve = string.Empty;
                    recieve = richTextBoxRecieve.Text;

                    string hexRecieve = string.Empty;
                    hexRecieve = richTextBoxHex.Text;

                    string decRecieve = string.Empty;
                    decRecieve = richTextBoxDec.Text;



                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {

                            using (StreamWriter sw = new StreamWriter(sfd.FileName, true))
                            {

                                await sw.WriteLineAsync($"{"Normal Encoding : "}{"\n"}{recieve} {"\n\n"}{"Hex : "}{"\n"} {hexRecieve}{"\n\n"}{"Dec : "} {"\n"}{decRecieve}{"\n\n"} { "---------------------"} { DateTime.Now.ToString() }");

                                sw.Close();

                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: Could not write file. Original error: " + ex.Message);
                        }
                    }

                    richTextBoxRecieve.Clear();
                    richTextBoxDec.Clear();
                    richTextBoxHex.Clear();
                    RXcounter = 0;
                    TXcounter = 0;

                    lblRxSent.Text = "RX :" + RXcounter;
                    lblTxSent.Text = "TX :" + TXcounter;
                    stopMessage = false; //switch

                }
                if (messageBoxResult == DialogResult.No)
                {
                    //if(richTextBoxRecieve.Text.Length > 1000 | richTextBoxHex.Text.Length > 1000 | richTextBoxDec.Text.Length > 1000)
                    //{
                    richTextBoxRecieve.Clear();
                    richTextBoxDec.Clear();
                    richTextBoxHex.Clear();

                    RXcounter = 0;
                    TXcounter = 0;

                    lblRxSent.Text = "RX :" + RXcounter;
                    lblTxSent.Text = "TX :" + TXcounter;
                    // }

                    stopMessage = false;
                }

            }
        }
        //these are make sure that the only keys allowed are numbers/digits or backspace or delete key
        private void comboBoxBaudRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only");


            }
        }

        private void comboBoxWriteTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only");


            }
        }

        private void comboBoxReadTimeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 110)
            {
                e.Handled = true;
                MessageBox.Show("Please enter numbers only");


            }
        }
        //THIS IS THE HANDLER FOR SURPRESSING THE DELETE KEY AND BACKSPACE KEY ON THE SEND BOX
        private void richTextBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (checkBoxSendHex.Checked || checkBoxSendDec.Checked)
            {
                if (richTextBoxSend.Text != "")
                {
                    //SURPRESS THE USE OF THE DELETE KEY
                    if (e.KeyCode == Keys.Delete)
                    {
                        // t--;

                        // MessageBox.Show("minus t");
                        e.SuppressKeyPress = true;

                    }
                    string checkStringHEX = string.Empty;
                    checkStringHEX = richTextBoxSend.Text;


                    //if (e.KeyCode == Keys.Back && richTextBoxRecieve.Text.Substring(richTextBoxRecieve.Text.Length).Contains(" ") == true )
                    // if (e.KeyCode == Keys.Back && checkString.TrimEnd() == " ") //&& checkString.Trim().EndsWith(check) == true) 

                    //THIS WILL CHECK TO SEE IF THE END OF THE STRING DOESNT CONTAIN A SPACE AND THEN APPEND IT
                    if (e.KeyCode == Keys.Back && checkStringHEX.EndsWith(" ") == false)
                    {

                        t--;
                        t--;

                    }
                    if (e.KeyCode == Keys.Back)
                    {

                        // e.SuppressKeyPress = true;
                        t--;

                    }
                }
            }

            if (checkBox3DEC.Checked && checkBoxSendDec.Checked && richTextBoxSend.Text != "")
            {
                string checkStringDEC = string.Empty;
                checkStringDEC = richTextBoxSend.Text;

                if (e.KeyCode == Keys.Delete)
                {
                    // j--;
                    e.SuppressKeyPress = true;

                }
                if (e.KeyCode == Keys.Back && checkStringDEC.EndsWith("  ") == false)
                {
                    // j = j - 3;
                    j--;
                    j--;
                }
                if (e.KeyCode == Keys.Back)
                {
                    // e.SuppressKeyPress = true;
                    j--;


                }
            }

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBoxSend.Clear();
            richTextBoxSend.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Current Readings in a File";
            sfd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            string recieve = string.Empty;
            recieve = richTextBoxRecieve.Text;

            string hexRecieve = string.Empty;
            hexRecieve = richTextBoxHex.Text;

            string decRecieve = string.Empty;
            decRecieve = richTextBoxDec.Text;



            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    using (StreamWriter sw = new StreamWriter(sfd.FileName, true))
                    {

                        await sw.WriteLineAsync($"{"Normal Encoding :"}{"\n"}{recieve} {"\n\n"}{"Hex :"}{"\n"} {hexRecieve}{"\n\n"}{"Dec :"} {"\n"}{decRecieve}{"\n\n"} { "---------------------"} { DateTime.Now.ToString() }");

                        sw.Close();

                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file. Original error: " + ex.Message);
                }
            }

            richTextBoxRecieve.Clear();
            richTextBoxDec.Clear();
            richTextBoxHex.Clear();
            stopMessage = false; //switch

        }

        private void richTextBoxSend_SelectionChanged(object sender, EventArgs e)
        {

        }
        //THIS IS USED TO REMOVE THE SELECTED TEXT HIGHLIGHTED BY THE USER IF HEX OR DEC IS ENABLED
        private void richTextBoxSend_MouseUp(object sender, MouseEventArgs e)
        {
           
            //this will unselect the mouse selected text and remove the mouse patse function or enable it if hex or dec is not selected
            if (checkBoxSendHex.Checked || checkBoxSendDec.Checked)
            {
                //this sets the cursor position to the end of the text
                richTextBoxSend.Select(richTextBoxSend.Text.Length, 0);

                RemoveSelection(sender);

                pasteToolStripMenuItem.Enabled = false;
            }
            if (!checkBoxSendHex.Checked && !checkBoxSendDec.Checked)
            {
                pasteToolStripMenuItem.Enabled = true;
            }
        }
        private void RemoveSelection(Object obj)
        {
            RichTextBox textbox = obj as RichTextBox;
            if (textbox != null)
            {
                textbox.SelectionLength = 0;
            }
        }

        private void contextMenuStripSend_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void checkBoxSendDec_Click(object sender, EventArgs e)
        {

            checkBoxSendDec.Checked = true;
            t = 1;
            richTextBoxSend.Focus();
        }

        private void checkBox2DEC_Click(object sender, EventArgs e)
        {
            checkBox2DEC.Checked = true;
            richTextBoxSend.Focus();
        }

        private void checkBox3DEC_Click(object sender, EventArgs e)
        {
            checkBox3DEC.Checked = true;
            richTextBoxSend.Focus();
        }

        private void checkBoxSendHex_Click(object sender, EventArgs e)
        {
            checkBoxSendHex.Checked = true;
            richTextBoxSend.Focus();
        }

        private void checkBoxSendNormal_Click(object sender, EventArgs e)
        {
            checkBoxSendNormal.Checked = true;
            richTextBoxSend.Focus();
        }

        private void checkBoxAutoSend_Click(object sender, EventArgs e)
        {
            checkBoxAutoSend.Checked = true;
            richTextBoxSend.Focus();
        }

        private void btnClearRecieve_Click(object sender, EventArgs e)
        {
            richTextBoxRecieve.Clear();
            richTextBoxSend.Focus();
        }

        private void btnClearRecieveDec_Click(object sender, EventArgs e)
        {
            richTextBoxDec.Clear();
            richTextBoxSend.Focus();
        }

        private void btnClearRecieveHex_Click(object sender, EventArgs e)
        {
            richTextBoxHex.Clear();
            richTextBoxSend.Focus();
        }

        private void btnClearInOutBuff_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
            richTextBoxSend.Focus();
        }

        private void checkBoxBringToFront_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBringToFront.Checked == true)
            {
                TopMost = true;
            }
            if (checkBoxBringToFront.Checked == false)
            {
                TopMost = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        { 
             if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    serialPort1.DiscardInBuffer();
                    serialPort1.DiscardOutBuffer();
                }
                catch {/*ignore*/}
            }
        }
        //this will append the send data with a carrige return or not
        private bool boolCarrigeReturnLF = false;
        private void checkBoxCRLF_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxCRLF.Checked)
            {
                checkBoxCR.Checked = false;
                boolCarrigeReturnLF = true;
            }
            if(checkBoxCRLF.Checked == false)
            {
                boolCarrigeReturnLF = false;
            }
        }
        private bool boolCarrigeReturn = false;
        private void checkBoxCR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCR.Checked)
            {
                checkBoxCRLF.Checked = false;
                boolCarrigeReturn = true;
            }
            if (checkBoxCR.Checked == false)
            {
                boolCarrigeReturn = false;
            }
        }

        private void btnSendBreak_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                int v2 = Convert.ToInt32("3");

                string sendBreak = string.Format("{0:X2}" , v2);
                serialPort1.Write(sendBreak);
            }
        }
        //font selection and colours
        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBoxRecieve.Font;
            fontDialog1.Color = richTextBoxRecieve.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBoxRecieve.Font = fontDialog1.Font;
                richTextBoxRecieve.ForeColor = fontDialog1.Color;

                richTextBoxSend.Font = fontDialog1.Font;
                richTextBoxSend.ForeColor = fontDialog1.Color;

                richTextBoxHex.Font = fontDialog1.Font;
                richTextBoxHex.ForeColor = fontDialog1.Color;

                richTextBoxDec.Font = fontDialog1.Font;
                richTextBoxDec.ForeColor = fontDialog1.Color;
            }
        }

        private string inputString = "";
        private async void btnSendFile_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";


                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sw = new StreamReader(ofd.OpenFile(), true))
                        {
                            
                            inputString = await (sw.ReadToEndAsync());

                            richTextBoxSend.Text += inputString;
                           
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                    
                }
                
            }
        }

        private void btnStopSendFile_Click(object sender, EventArgs e)
        {
            sendDataNoError = false;
        }

        private void ckBEnableLogs_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckBEnableLogs.Checked)
            //{
            //    OpenFileDialog ofd = new OpenFileDialog();

            //    ofd.Title = "Enable Logging To a File";
            //    ofd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            //    if (ofd.ShowDialog() == DialogResult.OK)
            //    {
            //        lblDataLogFilePath.Text = ofd.FileName;

            //    }
            //    else
            //    {
            //        ckBEnableLogs.Checked = false;
            //    }
            //}  if (ckBEnableLogs.Checked)
            //if (ckBEnableLogs.Checked)
            //{
            //    SaveFileDialog sfd = new SaveFileDialog();

            //    sfd.Title = "Enable Logging To a File";
            //    sfd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        lblDataLogFilePath.Text = sfd.FileName;

            //    }
            //    if (sfd.ShowDialog() == DialogResult.Cancel)
            //    {
            //        ckBEnableLogs.Checked = false;
            //    }
            //}
        
        }

        private void ckBAppendLogs_CheckedChanged(object sender, EventArgs e)
        {
            if(ckBAppendLogs.Checked)
            {
                ckBOverwriteLogs.Checked = false;
            }
        }

        private void ckBOverwriteLogs_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBOverwriteLogs.Checked)
            {
                ckBAppendLogs.Checked = false;
            }
        }
      
        //This adds points to the chart graph
        private void GetChartPoint(int input )
        {
            lblCountRX.Update();
            lblCountRX.Text = rXChartCount.ToString();

            lblCountTX.Update();
            lblCountTX.Text = tXChartCount.ToString();

            for (int i = 0; i < rXChartCount; i++)
            {
                chart1.Series["SeriesRX"].Points.AddY(rXChartCount);
                chart1.Series["SeriesRX"].Points.RemoveAt(0);
                chart1.Series["SeriesRX"].Points.Add(rXChartCount);



            }

            for (int i = 0; i < tXChartCount; i++)
            {

                chart1.Series["SeriesTX"].Points.AddY(tXChartCount);
                chart1.Series["SeriesTX"].Points.RemoveAt(0);
                chart1.Series["SeriesTX"].Points.Add(tXChartCount);
            }
            //just keep the chart moving with added value of zero if no counts available
            if(rXChartCount == 0)
            {
                chart1.Series["SeriesRX"].Points.AddY(0);
                chart1.Series["SeriesRX"].Points.RemoveAt(0);
                chart1.Series["SeriesRX"].Points.Add(0);

               
            }
            if(tXChartCount == 0)
            {
                chart1.Series["SeriesTX"].Points.AddY(0);
                chart1.Series["SeriesTX"].Points.RemoveAt(0);
                chart1.Series["SeriesTX"].Points.Add(0);
            }
          
            chart1.ResetAutoValues();
            
        }

        private void ckBStartGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBStartGraph.Checked)
            {
                if(serialPort1.IsOpen)
                {
                    timerGraph.Interval = (int)graph_speed.Value * 1000;
                    timerGraph.Start();

                    graph_speed.Enabled = false;

                }
               
                    
            }
            if (ckBStartGraph.Checked == false)
            {
                timerGraph.Stop();
                graph_speed.Enabled = true;
            }
        }

        private void timerGraph_Tick(object sender, EventArgs e)
        {
            GetChartPoint(rXChartCount);
            
            rXChartCount = 0;
            tXChartCount = 0;
        }
        //THIS IS USED TO OPEN ONLY ONE INSTANCE OF THE CONVERSION TABLE AND IF ITS CREATED BRING TO FRONT
        //  Conversion_Table conTable = null;
        private ChecksumCalc crcTable;
        private void button1_Click(object sender, EventArgs e)
        {
            // Conversion_Table conTable = new Conversion_Table();
            if (crcTable == null || (crcTable != null && crcTable.IsDisposed))
            {
                crcTable = new ChecksumCalc();
                crcTable.Show();
                //   MessageBox.Show("disposed");
            }
            if (crcTable.WindowState == FormWindowState.Minimized)
            {
                crcTable.WindowState = FormWindowState.Normal;
            }
            else
            {
                crcTable.BringToFront();
                //  MessageBox.Show("bring to front");
            }
        }

        private void ckBEnableLogs_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckBEnableLogs.Checked)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                sfd.Title = "Enable Logging To a File";
                sfd.Filter = "text files (*.txt)|*.txt|Richtext files (*.rtf)|*.rtf";

                if (sfd.ShowDialog() != DialogResult.Cancel)
                {
                    lblDataLogFilePath.Text = sfd.FileName;

                }
                else
                {
                    ckBEnableLogs.Checked = false;
                }
            }
        }

        private void txRepeaterDelay_Tick(object sender, EventArgs e)
        {

        }
    }
 }
