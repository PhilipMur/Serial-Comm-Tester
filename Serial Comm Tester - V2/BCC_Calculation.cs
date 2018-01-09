using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_Comm_Tester
{
   public  class BCC_Calculation
    {
        /// <summary>
        /// Takes in a byte array and gives bacl the Block Check Character
        /// </summary>
        /// <param name="inputStream"></param>
        /// <returns></returns>
        public string GetBCC(byte[] inputStream)
        {
            byte bcc = 0;
            int numOut = 0;

            if (inputStream != null && inputStream.Length > 0)
            {

                for (int i = 0; i < inputStream.Length; i++)
                {
                    bcc ^= inputStream[i];
                }
            }

            numOut = bcc;

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
