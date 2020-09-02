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
using System.Windows.Forms;

namespace Serial_Comm_Tester
{
    public partial class Conversion_Table : Form
    {
        public Conversion_Table()
        {
            InitializeComponent();
        }

       
        //convert the parsed value in from value back in base 2 = binary base 8 = ocatal base 16 = hex and base 0 = dec
        private void btnConvert_Click(object sender, EventArgs e)
        {
         
            if (richTextBoxTextValue.Text != string.Empty )//&& checkBoxTextVal.Checked == true)
            {
                richTextBoxHex.Text = toHex(richTextBoxTextValue.Text);
                richTextBoxDec.Text = toDec(richTextBoxTextValue.Text);
                richTextBoxOctal.Text = toOct(richTextBoxTextValue.Text);
                richTextBoxBinary.Text = toBin(richTextBoxTextValue.Text);


            }

            }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBoxTestDec.Clear();
            richTextBoxTestHex.Clear();
            richTextBoxDecToHex2.Clear();
            richTextBoxTextValue.Clear();
            richTextBoxDecToHex.Clear();
            richTextBoxHex.Clear();
            richTextBoxDec.Clear();
            richTextBoxBinary.Clear();
            richTextBoxOctal.Clear();



            richTextBoxAscii2.Clear();
            richTextBoxDec.Clear();
            richTextBoxHex.Clear();
            richTextBoxHex2.Clear();
        }

      

        public void btnExit_Click(object sender, EventArgs e)
        {
           // Hide();
        
            Close();
        }

      
        //this code gets the value of richtextbox2 and displays it in hex in RTB4
        public string toHex(string inp)
        {
            string outp = string.Empty;
            char[] value = inp.ToCharArray();

            foreach (char L in value)
            {
                int v = Convert.ToInt32(L);
                // long v = Convert.ToInt64(L);
                outp += string.Format("{0:X}" + "  ", v);


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

                outp2 += string.Format("{0}" + "  ", v2);

            }
            return outp2;
        }
        //to base 8
        public string toOct(string inp2)
        {


            string outp2 = string.Empty;
            char[] value = inp2.ToCharArray();

            foreach (char L in value)
            {

                int v2 = Convert.ToInt32(L);
                //convert to base 8
               string v2Con = Convert.ToString(v2, 8);
                //long v2 = Convert.ToInt64(L);

              //  outp2 += string.Format("{0}" + "  ", v2);
                outp2 += string.Format("{0}" + "  ", v2Con);

            }
            return outp2;
        }
        //to base 2 = binary
        public string toBin(string inp2)
        {


            string outp2 = string.Empty;
            char[] value = inp2.ToCharArray();

            foreach (char L in value)
            {

                int v2 = Convert.ToInt32(L);
                //convert to a base 2 =binary
                string v2Con = Convert.ToString(v2, 2).PadLeft(8,'0');
                //long v2 = Convert.ToInt64(L);

                //  outp2 += string.Format("{0}" + "  ", v2);
                outp2 += string.Format("{0}" + "  ", v2Con);

            }
            return outp2;
        }
        //hex to dec
        private static Decimal ParseHexString(string hexNumber)
        {
            hexNumber = hexNumber.Replace("x", string.Empty);
            long result = 0;
            long.TryParse(hexNumber, System.Globalization.NumberStyles.HexNumber, null, out result);
            return result;
        }

        //hex to ascii
        public static string ConvertHex(string hexString)
        {
            try
            {
                string ascii = string.Empty;

                for (int i = 0; i < hexString.Length; i += 2)
               // for (int i = 0; i < hexString.Length; i++)
                {
                    string hs = string.Empty;

                    hs = hexString.Substring(i, 2);
                   // hs = hexString;
                    uint decval = Convert.ToUInt32(hs, 16);
                   // int decval = System.Convert.ToInt32(hs, 16);
                    char character = Convert.ToChar(decval);
                   
                 

                     ascii += character;
                   // ascii += equivalentLetter;

                }

                return ascii;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

            return string.Empty;
        }


      


        private void btnHexToDec_Click(object sender, EventArgs e)
        {
            //hex to dec
            richTextBoxTestDec.Text = Convert.ToString(ParseHexString(richTextBoxTestHex.Text));
        }

        private void btnHexToAscii_Click(object sender, EventArgs e)
        {
            if (richTextBoxHex2.TextLength < 2)
            {
                MessageBox.Show("Enter 2 Values  = example: enter (01) not (1) by itself", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else
                {
               
                 richTextBoxAscii2.Text = Convert.ToString(ConvertHex(richTextBoxHex2.Text));
              


                if (richTextBoxAscii2.Text == "") //00
                {
                    lblAsciiChar.Text = "NUL = Null char";
                    //labelText = "NUL = Null char";
                }
                else if (richTextBoxAscii2.Text == "")//01
                {
                    //MessageBox.Show("hi");
                    lblAsciiChar.Text = "SOH = Start of Heading";
                }
                else if (richTextBoxAscii2.Text == "")//02
                {
                    lblAsciiChar.Text = "STX = Start of Text";
                }
                else if (richTextBoxAscii2.Text == "")//03
                {
                    lblAsciiChar.Text = "ETX = End of Text";
                }
                else if (richTextBoxAscii2.Text == "")//04
                {
                    lblAsciiChar.Text = "EOT = End of Transmission";
                }
                else if (richTextBoxAscii2.Text == "")//05
                {
                    lblAsciiChar.Text = "ENQ =	Enquiry";
                }
                else if (richTextBoxAscii2.Text == "")//06
                {
                    lblAsciiChar.Text = "ACK = Acknowledgment";
                }
                if (richTextBoxAscii2.Text == "")//07
                {
                    lblAsciiChar.Text = "BEL = Bell";
                }
                else if (richTextBoxAscii2.Text == "")//08
                {
                    lblAsciiChar.Text = "BS = Back Space";
                }
                else if (richTextBoxHex2.Text == "09" )
               // else if (richTextBoxAscii2.Text == "	")//09
                {
                    lblAsciiChar.Text = "HT = Horizontal Tab";
                }
                // else if (richTextBoxAscii2.Text == "") 

                else if (richTextBoxHex2.Text == "0A" | richTextBoxHex2.Text == "0a")

                {
                    lblAsciiChar.Text = "LF = Line Feed";
                }

                // else if (richTextBoxAscii2.Text == "")//0B
                else if (richTextBoxHex2.Text == "0B" | richTextBoxHex2.Text == "0b")
                {
                    lblAsciiChar.Text = "VT = Vertical Tab";
                }
                // else if (richTextBoxAscii2.Text == "")//0C
                else if (richTextBoxHex2.Text == "0C" | richTextBoxHex2.Text == "0c")
                {
                    lblAsciiChar.Text = "FF = Form Feed";
                }
                //else if (richTextBoxAscii2.Text == "")//0D
                else if (richTextBoxHex2.Text == "0D" | richTextBoxHex2.Text == "0d")
                {
                    lblAsciiChar.Text = "CR = Carriage Return";
                }
                else if (richTextBoxAscii2.Text == "")//0E
                {
                    lblAsciiChar.Text = "SO = Shift Out / X-On";
                }
                else if (richTextBoxAscii2.Text == "")//0F
                {
                    lblAsciiChar.Text = "SI = Shift In / X-Off";
                }
                else if (richTextBoxAscii2.Text == "")//10
                {
                    lblAsciiChar.Text = "DLE = Device Control 1 (oft. XON)";
                }
                if (richTextBoxAscii2.Text == "")//11
                {
                    lblAsciiChar.Text = "DC1 = Device Control 1 (oft. XON)";
                }
                if (richTextBoxAscii2.Text == "")//12
                {
                    lblAsciiChar.Text = "DC2 = Device Control 2";
                }
                else if (richTextBoxAscii2.Text == "")//13
                {
                    lblAsciiChar.Text = "DC3 = 	Device Control 3 (oft. XOFF)";
                }
                else if (richTextBoxAscii2.Text == "")//14
                {
                    lblAsciiChar.Text = "DC4 = Device Control 4";
                }
                else if (richTextBoxAscii2.Text == "")//15
                {
                    lblAsciiChar.Text = "NAK = Negative Acknowledgement";
                }
                else if (richTextBoxAscii2.Text == "")//16
                {
                    lblAsciiChar.Text = "SYN = Synchronous Idle";
                }
                else if (richTextBoxAscii2.Text == "")//17
                {
                    lblAsciiChar.Text = "ETB = End of Transmit Block";
                }
                else if (richTextBoxAscii2.Text == "")//18
                {
                    lblAsciiChar.Text = "CAN = Cancel";
                }
                else if (richTextBoxAscii2.Text == "")//19
                {
                    lblAsciiChar.Text = "EM = End of Medium";
                }
                else if (richTextBoxAscii2.Text == "")//1A
                {
                    lblAsciiChar.Text = "SUB = Substitute";
                }
                else if (richTextBoxAscii2.Text == "")//1B
                {
                    lblAsciiChar.Text = "ESC = Escape";
                }
                else if (richTextBoxAscii2.Text == "")//1C
                {
                    lblAsciiChar.Text = "FS = File Separator";
                }

                else if (richTextBoxAscii2.Text == "")//1D
                {
                    lblAsciiChar.Text = "GS = Group Separator";
                }
                else if (richTextBoxAscii2.Text == "")//1E
                {
                    lblAsciiChar.Text = "RS = Record Separator";
                }
                else if (richTextBoxAscii2.Text == "")//1F
                {
                    lblAsciiChar.Text = "US = Unit Separator";
                }
                else if (richTextBoxAscii2.Text == "")//7f
                {
                    lblAsciiChar.Text = "DEL = Delete";
                }
                //else
                //{
                //    lblAsciiChar.Text = "";
                //}
            }
        }

        private void richTextBoxTextValue_TextChanged(object sender, EventArgs e)
        {
            //// richTextBoxValue.Clear();
            richTextBoxHex.Clear();
            richTextBoxDec.Clear();
            richTextBoxBinary.Clear();
            richTextBoxOctal.Clear();
            //richTextBoxTextValue.Text += " ";
            //richTextBoxTextValue.Text.Insert(richTextBoxTextValue.TextLength, "+1");
        }

        private void richTextBoxValue_TextChanged(object sender, EventArgs e)
        {
            //// richTextBoxValue.Clear();
            //richTextBoxHex.Clear();
            //richTextBoxDec.Clear();
            //richTextBoxBinary.Clear();
            //richTextBoxOctal.Clear();
        }

       
        private int t;

        private void btnDecToHex_Click_1(object sender, EventArgs e)
        {
            //THIS CHECKS TO SEE IF IT CAN BE PARSED
            bool b = int.TryParse(richTextBoxDecToHex.Text , out t);

            

            if (richTextBoxDecToHex.Text != string.Empty && b == true)//&& checkBoxNumVal.Checked == true)
            {
                int textConverter = int.Parse(richTextBoxDecToHex.Text);

                richTextBoxDecToHex2.Text = Convert.ToString(textConverter, 16);
              
            }
            else if(b == false)
            {
                richTextBoxDecToHex.Clear();
                MessageBox.Show("Enter a Value that can be converted", "Message for a noobie",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void richTextBoxHex2_TextChanged(object sender, EventArgs e)
        {
            lblAsciiChar.Text = "?";
        }

        //THIS WILL ADD SPACES TO THE TEXT IN THE ASCII TEXT CONVERT BOX
        private void richTextBoxTextValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string newTextSpace = richTextBoxTextValue.Text;
            //richTextBoxTextValue.Text = newTextSpace.Insert(0, " ");
        }

        //THIS IS USED TO OPEN ONLY ONE INSTANCE OF THE CONVERSION TABLE AND IF ITS CREATED BRING TO FRONT
        //  Conversion_Table conTable = null;
        private HexChart hexTable;
        private void button1_Click(object sender, EventArgs e)
        {
            // Conversion_Table conTable = new Conversion_Table();
            if (hexTable == null || (hexTable != null && hexTable.IsDisposed))
            {
                hexTable = new HexChart();
                hexTable.Show();
                //   MessageBox.Show("disposed");
            }
            if (hexTable.WindowState == FormWindowState.Minimized)
            {
                hexTable.WindowState = FormWindowState.Normal;
            }
            else
            {
                hexTable.BringToFront();
                //  MessageBox.Show("bring to front");
            }
        }
        //copy paste hex to dec
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxTestHex.SelectedText == "" && richTextBoxTestHex.Text != "")
            {
                Clipboard.SetText(richTextBoxTestHex.Text);
            }
            if (richTextBoxTestHex.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxTestHex.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxTestHex.Text += Clipboard.GetText();
        }

        //copy paste hex to ascii
        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBoxHex2.SelectedText == "" && richTextBoxHex2.Text != "")
            {
                Clipboard.SetText(richTextBoxHex2.Text);
            }
            if (richTextBoxHex2.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxHex2.SelectedText);
            }

        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBoxHex2.Text += Clipboard.GetText();
        }
        //copy paste dec to hex
        private void copyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (richTextBoxDecToHex.SelectedText == "" && richTextBoxDecToHex.Text != "")
            {
                Clipboard.SetText(richTextBoxDecToHex.Text);
            }
            if (richTextBoxDecToHex.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxDecToHex.SelectedText);
            }
        }

        private void pasteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBoxDecToHex.Text += Clipboard.GetText();
        }

        private void copyToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (richTextBoxTextValue.SelectedText == "" && richTextBoxTextValue.Text != "")
            {
                Clipboard.SetText(richTextBoxTextValue.Text);
            }
            if (richTextBoxTextValue.SelectedText != "")
            {
                Clipboard.SetText(richTextBoxTextValue.SelectedText);
            }
        }

        private void pasteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBoxTextValue.Text += Clipboard.GetText();
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
    }
}
