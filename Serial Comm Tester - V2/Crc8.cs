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

namespace Serial_Comm_Tester
{

    public class Crc8
    {
        public byte poly;

        
        static byte[] table = new byte[256];
        // x8 + x7 + x6 + x4 + x2 + 1
        //public const byte poly = 0xD5;

        //  const byte poly = 0x7;
        //const byte poly = 0xea;
        //public enum CRC8_POLY
        //{
        //    CRC8 = 0xd5,
        //    CRC8_CCITT = 0x07,
        //    CRC8_DALLAS_MAXIM = 0x31,
        //    CRC8_SAE_J1850 = 0x1D,
        //    CRC_8_WCDMA = 0x9b,
        //};
     



        public  byte ComputeChecksum( byte[] bytes)
        {
           // ChecksumCalc c = new ChecksumCalc();
          //  poly = c.getpolynominal;

            byte crc = 0x00;
            if (bytes != null && bytes.Length > 0)
            {
                foreach (byte b in bytes)
                {
                    crc = table[crc ^ b];
                }
            }
            return crc;
        }

        public Crc8(byte Poly)
        {
            poly = Poly;

            for (int i = 0; i < 256; ++i)
            {
                int temp = i;
                for (int j = 0; j < 8; ++j)
                {
                    if ((temp & 0x80) != 0)
                    {
                        temp = (temp << 1) ^ poly;
                       
                    }
                    else
                    {
                        temp <<= 1;
                    }
                }
                table[i] = (byte)temp;
            }
        }
       public  byte[] HexToBytes(string input)
        {
            StringBuilder sb = new StringBuilder(input);  //---get rid of null or white space
            sb.Replace(" ", "");
            sb.Replace("  ", "");
            input = sb.ToString();

            //// string input = "hello world";
            // char[] inputarray = input.ToCharArray();
            // Array.Reverse(inputarray);
            // string output = new string(inputarray);

            // byte[] result = new byte[output.Length / 2];
            // for (int i = 0; i < result.Length; i++)
            // {
            //     result[i] = Convert.ToByte(output.Substring(2 * i, 2), 16);
            // }
            // return result;
            //byte[] getByte = new byte[input.Length];

            //foreach(char t in input)
            //{
            //    getByte[t] = Convert.ToByte(t);
            //}
            //return getByte;

            byte[] result = new byte[input.Length / 2]; //------------------------------------14/7/17
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }
        //public  ushort Reflect16(ushort val)
        //{
        //    ushort resVal = 0;

        //    for (ushort i = 0; i < 8; i++)
        //    {
        //        if ((val & (1 << i)) != 0)
        //        {
        //            resVal |= (ushort)(1 << (15 - i));
        //        }
        //    }

        //    return resVal;
        //}
    }
}
