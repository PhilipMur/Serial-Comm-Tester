using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serial_Comm_Tester
{
   public class Modulo_256
    {

        //cheksum8 Modulo 256
        public string GetModulo256(byte[] data)
        {
            int checksum = 0;
            foreach (byte chData in data)
            {
                checksum += chData;
            }
            checksum &= 0xff;


            return checksum.ToString("X2");
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
