using iTextSharp.text;
using iTextSharp.text.pdf;
using NLog;
using ReadDevice.Interface;
using ScannerSomeStrategy.Interface;
using System;
using System.IO;
using System.Text;


namespace ScannerSomeStrategy
{
    public sealed class PdfConvertStrategy : IConvertStrategy
    {
        public void ReadAndSave(IReading readDevice, string fileName, ILogger logger = null)
        {
            string copy = null;
            var doc = new Document(PageSize.A5);

            if (File.Exists(fileName))
            {
                logger?.Info($"Файл с именем {fileName} существует");
                try
                {
                    File.Delete(fileName);
                    logger?.Info($"Файл с именем {fileName} был удален");
                }
                catch (Exception e)
                {
                    logger?.Error($"Файл с именем {fileName} удалить не удалось");
                }
            }

            using (var reader = new StreamReader(readDevice.ReadInfo(), Encoding.UTF8))
            {
                copy = reader.ReadToEnd();
                logger?.Info($"Получены данные сканера");
            }

            using (var writer = PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create)))
            {
                doc.Open();
                doc.NewPage();
                doc.Add(new Paragraph(copy));
                doc.Close();
                logger?.Info($"Результат сохранен в {fileName}");
            }
        }
    }
}
