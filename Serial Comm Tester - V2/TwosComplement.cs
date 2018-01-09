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
