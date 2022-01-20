using TemplateEngine.Docx;

namespace Lesson7
{
    public class ReportService
    {
        public void GenerateReport(DiskInfo fileInfo, string nameFile = null)
        {
            if (string.IsNullOrWhiteSpace(nameFile))
            {
            nameFile = Path.Combine(Directory.GetCurrentDirectory(), $"Disk{fileInfo.DiskIndex.ToString()}_FileSystemReport.docx");
            }
            if (File.Exists(nameFile))
            {
                File.Delete(nameFile);
            }
            File.Copy("..\\..\\..\\Template.docx", nameFile);
            var fillContetn = new Content(
               new FieldContent("Disk Index", fileInfo.DiskIndex.ToString()),
               new FieldContent("Disk Name", fileInfo.DiskName),
               new FieldContent("Drive Format", fileInfo.DriveFormat),
               new FieldContent("Drive Type", fileInfo.DriveType),
               new FieldContent("IsReady", fileInfo.IsReady.ToString()),
               new FieldContent("Root Directory", fileInfo.RootDirectory),
               new FieldContent("Volume Label", fileInfo.VolumeLabel),
               new FieldContent("Disk Size", fileInfo.CurrentDiskSize.ToString()),
               new FieldContent("Free bytes", fileInfo.AvailableFreeSpace.ToString())
               );

            using (var outputDocument =
                new TemplateProcessor(nameFile)
                .SetRemoveContentControls(true))

            {
                outputDocument.FillContent(fillContetn);
                outputDocument.SaveChanges();
            }

        }

    }
}
