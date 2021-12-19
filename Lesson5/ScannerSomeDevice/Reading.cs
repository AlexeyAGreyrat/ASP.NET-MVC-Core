using Interface.ReadDevice;
using System;
using System.IO;
using System.Text;

namespace ScannerSomeDevice
{
    public sealed class Reading : IReading
    {
        public Stream ReadInfo()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            string str = $"{DateTime.Now}\n";
            foreach (var drive in drives)
            {
                str += $"Name: {drive.Name} \nType: {drive.DriveType}\n";
                if (drive.IsReady)
                {
                    str += $"Total size of drive: {drive.TotalSize} bytes \n";
                    str += $"Total available space: {drive.TotalFreeSpace} bytes\n";
                }
            }
            byte[] byteArray = Encoding.UTF8.GetBytes(str);
            MemoryStream result = new MemoryStream(byteArray);
            return result;
        }
    }
}
