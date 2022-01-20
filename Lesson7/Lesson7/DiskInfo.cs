
namespace Lesson7
{
    public class DiskInfo
    {
            public byte DiskIndex { get; set; }
            public string DiskName { get; set; }
            public string DriveFormat { get; set; }
            public string DriveType { get; set; }
            public bool IsReady { get; set; }
            public string RootDirectory { get; set; }
            public string VolumeLabel { get; set; }
            public long AvailableFreeSpace { get; set; }
            public string FreeSpace { get; set; }
            public long CurrentDiskSize { get; set; }
    }
}
