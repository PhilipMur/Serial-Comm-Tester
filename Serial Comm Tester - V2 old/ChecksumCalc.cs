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
using System.Text;
using System.Windows.Forms;

namespace Serial_Comm_Tester
{
    public partial class ChecksumCalc : Form
    {
        public   byte getpolynominalCRC8  ;

        
        public ushort getpolynominalCRC16;
        public ushort getIntialValue;
       // public ushort getCalcByte;

        public byte getpolynominalCRC32;



        public ChecksumCalc()
        {
            InitializeComponent();

            comBoCRC8.SelectedIndex = 0;
            comBoCRC16.SelectedIndex = 0;
            comBoCRC32.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            txtBCalculateValue.Clear();

        }

        private void btnCalculateCRC_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear(); //clear the rows and start by adding a blank row
            ListViewItem row3 = new ListViewItem();         
            listView1.Items.Add(row3);
            //crc8
            string textboxString = "";
            textboxString = txtBCalculateValue.Text;

            if(ckBWhiteSpaceCharacters.Checked == false)
            {
                StringBuilder sb = new StringBuilder(textboxString);  //---get rid of null or white space
                sb.Replace(" ", "");
                sb.Replace("  ", "");
                textboxString = sb.ToString();

            }
           


            string textboxString2 = "";
            textboxString2 = txtBCalculateValue.Text;
            if (ckBWhiteSpaceCharacters.Checked == false)
            {
                StringBuilder sb2 = new StringBuilder(textboxString2);  //---get rid of null or white space
                sb2.Replace(" ", "");
                sb2.Replace("  ", "");
                textboxString2 = sb2.ToString();
            }


            if (textboxString2.Length % 2 != 0 && txtBCalculateValue.Text != "" && ckBHexValueCRC.Checked) //fi its a hex value and not divsable by 2 append a 0 to the start
            {
                textboxString2 = "0" + textboxString2;
                // txtBCalculateValue.Text = txtBCalculateValue.Text + "0";
            }


          


            if (txtBCalculateValue.Text != "" ) //-----------------------14/7/17
                {

               
                    try
                    {
                        // getpolynominal = 0xd5;

                         if (comBoCRC8.Text == "CRC8 = 0x07")
                        {

                            getpolynominalCRC8 = 0x07;

                        }



                        else if (comBoCRC8.Text == "CRC8_DVB = 0xD5")
                        {
                            getpolynominalCRC8 = 0xD5;

                        }
                        //else if (comBoCRC8.Text == "CRC8_DALLAS_MAXIM = 0x31")
                        //{
                        //    getpolynominal = 0x31;


                        //}
                        else if (comBoCRC8.Text == "CRC8_SAE_J1850 = 0x1D")
                        {
                            getpolynominalCRC8 = 0x1D;


                        }
                        //else if (comBoCRC8.Text == "CRC_8_WCDMA = 0x9b")
                        //{

                        //    getpolynominal = 0x9b;

                        //}
                       

                       

                        if( ckBHexValueCRC.Checked)  //get bytes from hex values
                        {
                            Crc8 checkSum = new Crc8(getpolynominalCRC8);

                        // string input = txtBCalculateValue.Text; //must be hex values ie: ff or 01
                        string input = textboxString2;
                        var bytes = checkSum.HexToBytes(input);
                        string hex = checkSum.ComputeChecksum(bytes).ToString("x2");

                      

                        //ListViewItem row = new ListViewItem("CRC 8");
                        ListViewItem row = new ListViewItem(comBoCRC8.Text);
                            row.SubItems.Add(hex.ToString().ToUpper());
                            listView1.Items.Add(row);

                        }
                        if(ckBStringValueCRC.Checked)  //getbytes from string text
                        {
                            Crc8 checkSum = new Crc8(getpolynominalCRC8);

                          //  int count = txtBCalculateValue.TextLength;

                            int count = textboxString.Length;

                            var myBuffer = new byte[count];
                          
                            myBuffer = Encoding.ASCII.GetBytes(textboxString);
                         
                            string hex = checkSum.ComputeChecksum(myBuffer).ToString("x2");

                            ListViewItem row = new ListViewItem(comBoCRC8.Text);
                            row.SubItems.Add(hex.ToString().ToUpper());
                            listView1.Items.Add(row);


                        }

                    }
                
                    catch
                    {
                        MessageBox.Show("Error Not A Value" , "ERROR" ,MessageBoxButtons.OK , MessageBoxIcon.Error);
                        return;
                    }


                }
         

            if (textboxString2.Length % 2 != 0 && txtBCalculateValue.Text != "" && ckBHexValueCRC.Checked)
            {
                textboxString2 = "0" + textboxString2;
                // txtBCalculateValue.Text = txtBCalculateValue.Text + "0";
            }

          


            if (txtBCalculateValue.Text != "")
                {
                    try
                    {
                        // getpolynominal = 0xd5;

                        if (comBoCRC16.Text == "CRC_16_CCITT_ZERO = 0x1021")
                        {

                            getpolynominalCRC16 = 0x1021;
                            getIntialValue = 0x0000;
                          //  getCalcByte = 0x8000;
                        }
                        //CRC_16_CCITT_ZERO = 0X1021
                        //CRC_16_XMODEM = 0X1021
                        //CRC_16_CCITT_FALSE = 0X1021
                        //CRC_16_AUG_CCITT = 0X1021
                        //CRC_16_TELEDISK = 0XAO97
                        //CRC_16_T10_DIF = 0X8BB7
                        //CRC_16_DECT_X = 0X589
                        //CRC_16_DDS_110 = 0X8005
                        //CRC_16_CDMA2000 = 0X867
                        //CRC_16_BUYPASS = OX8005

                        else if (comBoCRC16.Text == "CRC_16_XMODEM = 0x1021")
                        {
                            getpolynominalCRC16 = 0x1021;
                            getIntialValue = 0x0000;
                        CRC16.IsitModbus = false;
                        // getCalcByte = 0x8000;
                    }
                      
                        else if (comBoCRC16.Text == "CRC_16_CCITT_FALSE = 0x1021")
                        {
                            getpolynominalCRC16 = 0x1021;
                            getIntialValue = 0xFFFF;
                        CRC16.IsitModbus = false;
                        // getCalcByte = 0x8000;


                    }
                        else if (comBoCRC16.Text == "CRC_16_AUG_CCITT = 0x1021")
                        {
                            getpolynominalCRC16 = 0x1021;
                            getIntialValue = 0x1D0F;
                        CRC16.IsitModbus = false;
                        //  getCalcByte = 0x8000;

                    }
                        else if (comBoCRC16.Text == "CRC_16_TELEDISK = 0xAO97")
                        {
                            getpolynominalCRC16 = 0xA097;
                            getIntialValue = 0x0000;
                        CRC16.IsitModbus = false;
                        // getCalcByte = 0x8000;


                    }
                        else if (comBoCRC16.Text == "CRC_16_T10_DIF = 0x8BB7")
                        {
                            getpolynominalCRC16 = 0x8BB7;
                            getIntialValue = 0x0000;
                        CRC16.IsitModbus = false;
                        //  getCalcByte = 0x8000;


                    }
                        else if (comBoCRC16.Text == "CRC_16_DECT_X = 0x589")
                        {
                            getpolynominalCRC16 = 0x589;
                            getIntialValue = 0x0000;
                        CRC16.IsitModbus = false;
                        //   getCalcByte = 0x8000;

                    }
                        else if (comBoCRC16.Text == "CRC_16_DDS_110 = 0x8005")
                        {
                            getpolynominalCRC16 = 0x8005;
                            getIntialValue = 0x800D;
                        CRC16.IsitModbus = false;
                        //  getCalcByte = 0x8000;

                    }
                        else if (comBoCRC16.Text == "CRC_16_CDMA2000 = 0xC867")
                        {
                            getpolynominalCRC16 = 0xC867;
                            getIntialValue = 0xFFFF;
                        CRC16.IsitModbus = false;
                        //  getCalcByte = 0x8000;

                    }
                        else if (comBoCRC16.Text == "CRC_16_BUYPASS = Ox8005")
                        {
                            getpolynominalCRC16 = 0x8005;
                            getIntialValue = 0x0000;
                        CRC16.IsitModbus = false;
                        //  getCalcByte = 0x8000;

                    }

                    else if (comBoCRC16.Text == "CRC_16_MODBUS = 0xA001")
                    {
                        getpolynominalCRC16 = 0xA001;
                        getIntialValue = 0xFFFF;
                        CRC16.IsitModbus = true;
                      //  getCalcByte = 0x0001;

                    }
                   


                    // listView1.Items.Clear();

                    if (ckBHexValueCRC.Checked)  //get bytes from hex values
                        {
                        //CRC16 checkSum = new CRC16(getpolynominalCRC16 , getIntialValue , getCalcByte);
                        CRC16 checkSum = new CRC16(getpolynominalCRC16, getIntialValue);

                        //string input = txtBCalculateValue.Text; //must be hex values ie: ff or 01
                        string input = textboxString2;
                            var bytes = checkSum.HexToBytes(input);
                            string hex = checkSum.ComputeChecksum(bytes).ToString("x4");

                           
                            ListViewItem row = new ListViewItem(comBoCRC16.Text);
                            row.SubItems.Add(hex.ToString().ToUpper());
                            listView1.Items.Add(row);
                        
                        }
                        if (ckBStringValueCRC.Checked)  //getbytes from string text
                        {
                        //CRC16 checkSum = new CRC16(getpolynominalCRC16, getIntialValue , getCalcByte);
                        CRC16 checkSum = new CRC16(getpolynominalCRC16, getIntialValue);

                        // int count = txtBCalculateValue.TextLength;

                        int count = textboxString.Length;

                            var myBuffer = new byte[count];
                            
                            myBuffer = Encoding.ASCII.GetBytes(textboxString);
                           
                            string hex = checkSum.ComputeChecksum(myBuffer).ToString("x4");

                            ListViewItem row = new ListViewItem(comBoCRC16.Text);
                            row.SubItems.Add(hex.ToString().ToUpper());
                            listView1.Items.Add(row);


                    }
                    if (ckBHexValueCRC.Checked)  //get bytes from hex values CRC32
                    {

                          Crc32 crc32 = new Crc32(0xedb88320);
                        //Crc32 crc32 = new Crc32(0x1EDC6F41);

                       

                        string input = textboxString2;
                        var bytes = crc32.HexToBytes(input);
                        string hex = Crc32.ComputeChecksum(bytes).ToString("X8");

                        //ListViewItem row = new ListViewItem("CRC 8");
                        ListViewItem row = new ListViewItem(comBoCRC32.Text);
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);

                    }


                        if (ckBStringValueCRC.Checked)  //getbytes from string text crc32
                    {
                        //CRC32
                        Crc32 crc32 = new Crc32(0xedb88320);

                      
                        string textVal = textboxString;
                        byte[] newByte = Encoding.ASCII.GetBytes(textVal);
                        //  var bytes = checkSum.HexToBytes(input);
                        string hex2 = Crc32.ComputeChecksum(newByte).ToString("x8").ToUpper();
                      

                        ListViewItem row2 = new ListViewItem(comBoCRC32.Text);
                        row2.SubItems.Add(hex2);
                        listView1.Items.Add(row2);
                    }


                }




                catch
                    {
                        MessageBox.Show("Error Not A Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

            
            }
           

            //-------------------------------------added 17/12/17 2s complement 8 and 16

            if (txtBCalculateValue.Text != "") 
            {


                try
                {
                   
                    if (ckBHexValueCRC.Checked)  //get bytes from hex values
                    {
                        TwosComplement twosComp = new TwosComplement();
                        string input = textboxString2;

                       // byte [] getbytes ;
                        byte[] bytes = twosComp.HexToBytes(input);

                       
                        string hex = twosComp.TwosComplement8bit(bytes);
                       
                        ListViewItem row = new ListViewItem("2s Complement_8bit");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);

                        string hex2 = twosComp.TwosComplement16bit(bytes);

                        ListViewItem row2 = new ListViewItem("2s Complement_16bit");
                        row2.SubItems.Add(hex2.ToString().ToUpper());
                        listView1.Items.Add(row2);

                    }
                    if (ckBStringValueCRC.Checked)  //getbytes from string text
                    {
                        TwosComplement twosComp = new TwosComplement();

                        //  int count = txtBCalculateValue.TextLength;

                        int count = textboxString.Length;

                        var myBuffer = new byte[count];
                       
                        myBuffer = Encoding.ASCII.GetBytes(textboxString);
                    
                        string hex = twosComp.TwosComplement8bit(myBuffer);

                        ListViewItem row = new ListViewItem("2s Complement_8bit");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);

                        string hex2 = twosComp.TwosComplement16bit(myBuffer);

                        ListViewItem row2 = new ListViewItem("2s Complement_16bit");
                        row2.SubItems.Add(hex2.ToString().ToUpper());
                        listView1.Items.Add(row2);


                    }
                    //BCC Calculation HEX
                    if (ckBHexValueCRC.Checked)  //get bytes from hex values
                    {
                        BCC_Calculation bccCalc = new BCC_Calculation();
                        string input = textboxString2;

                        // byte [] getbytes ;
                        byte[] bytes = bccCalc.HexToBytes(input);


                        string hex = bccCalc.GetBCC(bytes);

                        ListViewItem row = new ListViewItem("Block Check Character");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);

                      

                    }
                    //BCC Calculation String
                    if (ckBStringValueCRC.Checked)  //getbytes from string text
                    {
                        BCC_Calculation bccCalc = new BCC_Calculation();

                     

                        int count = textboxString.Length;

                        var myBuffer = new byte[count];
                     
                        myBuffer = Encoding.ASCII.GetBytes(textboxString);
                      
                        string hex = bccCalc.GetBCC(myBuffer);

                        ListViewItem row = new ListViewItem("Block Check Character");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);
                        
                    }

                    //Modulo 256 HEX
                    if (ckBHexValueCRC.Checked)  //get bytes from hex values
                    {
                        Modulo_256 mod256 =new Modulo_256();
                        string input = textboxString2;

                        // byte [] getbytes ;
                        byte[] bytes = mod256.HexToBytes(input);


                        string hex = mod256.GetModulo256(bytes);

                        ListViewItem row = new ListViewItem("Modulo 256");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);
                        
                    }
                    //Modulo 256 HEX
                    if (ckBStringValueCRC.Checked)  //getbytes from string text
                    {
                        Modulo_256 mod256 = new Modulo_256();

                        //  int count = txtBCalculateValue.TextLength;

                        int count = textboxString.Length;

                        var myBuffer = new byte[count];
                        
                        myBuffer = Encoding.ASCII.GetBytes(textboxString);
                      
                        string hex = mod256.GetModulo256(myBuffer);

                        ListViewItem row = new ListViewItem("Modulo 256");
                        row.SubItems.Add(hex.ToString().ToUpper());
                        listView1.Items.Add(row);

                    }

                }




                catch
                {
                    MessageBox.Show("Error Not A Value", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


            }


        }

        private void comBoCRC8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoCRC8.Text == "CRC8 = 0xd5")
            {
                getpolynominalCRC8 = 0xD5;

            }
            else if (comBoCRC8.Text == "CRC8_DALLAS_MAXIM = 0x31")
            {
                getpolynominalCRC8 = 0x31;


            }
            else if (comBoCRC8.Text == "CRC8_SAE_J1850 = 0x1D")
            {
                getpolynominalCRC8 = 0x1D;


            }
            else if (comBoCRC8.Text == "CRC_8_WCDMA = 0x9b")
            {

                getpolynominalCRC8 = 0x9b;

            }
            else if (comBoCRC8.Text == "CRC8_CCITT = 0x07")
            {

                getpolynominalCRC8 = 0x07;

            }

        }

      
    }
    }

