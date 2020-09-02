using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Serial Comm Tester")]
[assembly: AssemblyDescription("This Program allows users to test hardware like RS232-USB  for functionality \"Join Tx to Rx \" for an internal loop test or " +
    "test com port settings between devices or trouble shooting hardware and software.    >>   Open this program twice to send / receive from 2 com ports on the same computer/device.   <<" +
   "\r\n" + "\r\n" + "If one of these options (\"Auto Read Bytes To Hex  or Auto Read Bytes To Decimal or Auto Read \") are checked the current serial data will only be sent to that option. " +
    "\r\n" + "\r\n" + "If (\" Request To Send or Request To Send XOnXOff \") is selected then \"Clear To Send \" button should be \"ON\" to send data." +
   "\r\n" + "\r\n" + "This Serial Comm Tester is capable of reading a possible 1,112,064 characters in ASCII / UNICODE ( up to , UTF-16)8-bit enviroments and 0-255 7 bit enviroments"
    + " , Although not all characters will be displayed but the U+ (Unicode) number will be given and Hex and Dec equivalent to the Received Bytes."
   + "\r\n" + "\r\n" +  " New features added :-  Manual save also added , Automatic Logging is now added, Visual graph added, change Font Size added,  Sending hex and Decimal values through the comport is now possible ,"
    + "Conversion Tables :- HEX to DEC / HEX to ASCII etc... ALSO Reference Charts : Hex chart and Unicode chart. Function to verify and calculate CRC Checksums 8bit , 16bit , 32bit. ")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Created by: Philip Murray")]
[assembly: AssemblyProduct("Serial Comm Tester")]
[assembly: AssemblyCopyright("Copyright © Philip Murray All Rights Reserved 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c22ae764-1206-414f-bcd3-aebfe71c08b1")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("3.2.0.0")]
[assembly: AssemblyFileVersion("3.0.0.0")]
