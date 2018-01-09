using System;
using System.Text;

namespace Serial_Comm_Tester
{
    public class CRC16
    {
        public ushort polynomial;
        // const ushort polynomial = 4129;
        //public ushort polynomial = 0x1021; //standard crc16 ccitt
        // const ushort polynomial = 0x8408; //kermit
        // const ushort polynomial = 0xA097; //TELEDISK
        // const ushort polynomial = 0x8BB7; //T10_DIF
        //  const ushort polynomial = 0x589; //DECT_X
        // const ushort polynomial = 0x8005; //DDS_110  / BUYPASS
        // const ushort polynomial = 0xC867;  //CDMA2000
        public ushort[] table = new ushort[256];
        // static ushort initialValue = 0x0000;   //CRC-CCITT (XModem) /TELEDISK/
        //  static ushort initialValue = 0xffff;  //CRC-CCITT (0xFFFF)
        //  static ushort initialValue = 0x1D0F;  //CRC-CCITT (0x1D0F)
        //public ushort initialValue = 0x0000; //kermit  / BUYPASS
        // static ushort initialValue = 0x800D; //DDS_110
        // static ushort initialValue = 0xFFFF; //CDMA2000
        public ushort initialValue;

        public static bool IsitModbus = false;
        // public int calcByte =  0x8000 ;
       // public ushort calcByte { get; set; }


        public  ushort ComputeChecksum(byte[] bytes)
        {
            //if not modbus do the other 16 bit calculations
            if(IsitModbus == false)
            {
                ushort crc = initialValue;

                for (int i = 0; i < bytes.Length; ++i)
                {
                    crc = (ushort)((crc << 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
                }
                return crc;
            }
            else //do the modbus calculation
            {
                ushort crcTemp;

                uint crc = 0xffff;
               // uint crc16 = Convert.ToUInt16( initialValue);
                uint temp;
                uint flag;

                for (int i = 0; i < bytes.Length; i++)
                {
                    temp = bytes[i]; // temp has the first byte 
                    temp &= 0x00ff; // mask the MSB 
                    crc = crc ^ temp; //crc16 XOR with temp 
                    
                    for (uint c = 0; c < 8; c++)
                    {
                        flag = crc & 0x01; // LSBit di crc16 is mantained
                        crc = crc >> 1; // Lsbit di crc16 is lost 
                        if (flag != 0)
                        {
                           // crc16 = crc16 ^ 0x0A001; // crc16 XOR with 0x0a001 
                            crc = crc ^ polynomial; // crc16 XOR with 0x0a001 
                        }
                           
                    }
                }
                //crc16 = (crc16 >> 8) | (crc16 << 8); // LSB is exchanged with MSB
                crcTemp = Convert.ToUInt16(crc);
                return (crcTemp);


                //uint crc = initialValue;
                //uint temp;
                //ushort crcTemp;
                //uint flag;

                //for (int i = 0; i < bytes.Length; ++i)
                //{
                //    temp = bytes[i];
                //    // temp & 00ff;
                //    crc = crc ^ temp;
                //    for (uint c = 0; c < 8; c++)
                //    {
                //        flag = crc & 0x01; // LSBit di crc16 is mantained
                //        crc = crc >> 1; // Lsbit di crc16 is lost 
                //        if (flag != 0)
                //            crc = crc ^ 0x0a001; // crc16 XOR with 0x0a001 
                //    }
                //    //byte index = (byte)(crc ^ bytes[i]);
                //    //crc = (ushort)((crc >> 8) ^ table[index]);
                //    // crc = (ushort)((crc >> 8) ^ table[(crc ^ i) & 0xFF]);
                //    // crc = (ushort)((crc >> 8) ^ table[((crc >> 8) ^ (0xff & bytes[i]))]);
                //}
                //crcTemp = Convert.ToUInt16( crc);
                //return crcTemp;
            }

          
        }

        public  byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return BitConverter.GetBytes(crc);
        }
        public enum InitialCrcValue { Zeros, NonZero1 = 0xffff, NonZero2 = 0x1D0F };

        //public  CRC16(ushort Poly , ushort intialVal ,ushort CalcByte)//(InitialCrcValue initialValue)
        public CRC16(ushort Poly, ushort intialVal)//(InitialCrcValue initialValue)
        {

            if(IsitModbus == false)
            {
                polynomial = Poly;
                initialValue = intialVal;
                // calcByte = CalcByte;


                // initialValue = (ushort)initialValue;

                ushort temp, a;
                for (int i = 0; i < table.Length; ++i)
                {
                    temp = 0;
                    a = (ushort)(i << 8);
                    for (int j = 0; j < 8; ++j)
                    {
                        if (((temp ^ a) & 0x8000) != 0)
                        // if (((temp ^ a) & calcByte) != 0)
                        {
                            temp = (ushort)((temp << 1) ^ polynomial);
                        }
                        else
                        {
                            temp <<= 1;
                        }
                        a <<= 1;
                    }
                    table[i] = temp;
                }
            }
            if(IsitModbus == true)
            {
                polynomial = Poly;
                ushort value;
                ushort temp;
                for (ushort i = 0; i < table.Length; ++i)
                {
                    value = 0;
                    temp = i;
                    for (byte j = 0; j < 8; ++j)
                    {
                        if (((value ^ temp) & 0x0001) != 0)
                        {
                            value = (ushort)((value >> 1) ^ polynomial);
                        }
                        else
                        {
                            value >>= 1;
                        }
                        temp >>= 1;
                    }
                    table[i] = value;
                }
            }
        //    polynomial = Poly;
        //    initialValue = intialVal;
        //   // calcByte = CalcByte;
            

        //    // initialValue = (ushort)initialValue;

        //ushort temp, a;
        //    for (int i = 0; i < table.Length; ++i)
        //    {
        //        temp = 0;
        //        a = (ushort)(i << 8);
        //        for (int j = 0; j < 8; ++j)
        //        {
        //            if (((temp ^ a) & 0x8000) != 0)
        //               // if (((temp ^ a) & calcByte) != 0)
        //                {
        //                temp = (ushort)((temp << 1) ^ polynomial);
        //            }
        //            else
        //            {
        //                temp <<= 1;
        //            }
        //            a <<= 1;
        //        }
        //        table[i] = temp;
        //    }
        }

        //public ushort ComputeChecksumModbus(byte[] bytes)
        //{
        //    ushort crc = 0;
        //    for (int i = 0; i < bytes.Length; ++i)
        //    {
        //        byte index = (byte)(crc ^ bytes[i]);
        //        crc = (ushort)((crc >> 8) ^ table[index]);
        //    }
        //    return crc;
        //}
        //public Crc16Modbus(ushort Poly)
        //{
        //    polynomial = Poly;
        //    ushort value;
        //    ushort temp;
        //    for (ushort i = 0; i < table.Length; ++i)
        //    {
        //        value = 0;
        //        temp = i;
        //        for (byte j = 0; j < 8; ++j)
        //        {
        //            if (((value ^ temp) & 0x0001) != 0)
        //            {
        //                value = (ushort)((value >> 1) ^ polynomial);
        //            }
        //            else
        //            {
        //                value >>= 1;
        //            }
        //            temp >>= 1;
        //        }
        //        table[i] = value;
        //    }
        //}
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

