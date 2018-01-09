using System;
using System.Collections.Generic;
using System.Text;

namespace Serial_Comm_Tester
{

    public class Crc32
    {
        public static uint[] table = new uint[256];

        public static uint poly = 0xedb88320;
         // public static uint poly = 0x1EDC6F41;
        //  public ushort initialValue;

        public static uint ComputeChecksum(byte[] bytes)
        {
            uint crc = 0xffffffff;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(((crc) & 0xffffffff) ^ bytes[i]);
                crc = (crc >> 8) ^ table[index];
            }
            return ~crc;
        }

        public static byte[] ComputeChecksumBytes(byte[] bytes)
        {
            return BitConverter.GetBytes(ComputeChecksum(bytes));
        }

        public Crc32(uint Poly)
        {
             // uint poly = 0xedb88320;
           // uint poly;
            poly = Poly;

          //  table = new uint[256];

            uint temp = 0;
            for (uint i = 0; i < table.Length; ++i)
            {
                temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                    {
                        temp = (uint)((temp >> 1) ^ poly);
                    }
                    else
                    {
                        temp >>= 1;
                    }
                }
                table[i] = temp;
            }
        }
        public byte[] HexToBytes(string input)
        {
            //StringBuilder sb = new StringBuilder(input);  //---get rid of null or white space
            //sb.Replace(" ", "");
            //sb.Replace("  ", "");
            //input = sb.ToString();

            byte[] result = new byte[input.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(input.Substring(2 * i, 2), 16);
            }
            return result;
        }
    }
}
 

