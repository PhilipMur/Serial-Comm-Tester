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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_Comm_Tester
{
  public  class TwosComplement
    {
        /// <summary>
        /// Takes byte data in and Gives back 2s complemet 8 bit by modulus( 0xff / 255) 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string TwosComplement8bit(byte[] data)
        {
            byte bytesIn = 0;

            int numOut = 0;



            unchecked
            {
                for (int i = 0; i < data.Length; i++)
                {
                    bytesIn = data[i];

                    numOut += ~bytesIn + 0x01 % 0xff;

                }

            }

            numOut = numOut & 255;

            return numOut.ToString("X2");
        }
        /// <summary>
        /// Takes byte data in and Gives back 2s complemet 16 bit by modulus( 0xffff / 65535) 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string TwosComplement16bit(byte[] data)
        {
            byte bytesIn = 0;

            int numOut = 0;
           


            unchecked
            {
                for (int i = 0; i < data.Length; i++)
                {
                    bytesIn = data[i];

                    numOut += ~bytesIn + 0x01 % 0xffff;

                }

            }
          
            numOut = numOut & 65535;

            return numOut.ToString("X2");
        }

        public byte[] HexToBytes(string input)
        {
            StringBuilder sb = new StringBuilder(input);  //---get rid of null or white space
            sb.Replace(" ", "");
            sb.Replace("  ", "");
            input = sb.ToString();

            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }
    }
}
