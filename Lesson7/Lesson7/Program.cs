using Lesson7;

DriveInfo[] allDrives = DriveInfo.GetDrives();
byte currentDrive = 1;
DiskInfo fileInfo = new DiskInfo();

foreach (DriveInfo d in allDrives)
{
    fileInfo.DiskIndex = currentDrive;
    fileInfo.DiskName = d.Name;
    fileInfo.DriveFormat = d.DriveFormat;
    fileInfo.DriveType = d.DriveType.ToString();
    fileInfo.IsReady = d.IsReady;
    fileInfo.RootDirectory = d.RootDirectory.ToString();
    fileInfo.VolumeLabel = d.VolumeLabel.ToString();
    fileInfo.AvailableFreeSpace = d.AvailableFreeSpace;
    fileInfo.FreeSpace = d.TotalFreeSpace.ToString();
    fileInfo.CurrentDiskSize = d.TotalSize;
    currentDrive++;

    ReportService reportService = new ReportService();
    reportService.GenerateReport(fileInfo);
}
        