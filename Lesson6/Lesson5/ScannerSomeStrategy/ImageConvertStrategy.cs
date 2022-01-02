using NLog;
using ReadDevice.Interface;
using ScannerSomeStrategy.Interface;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace ScannerSomeStrategy
{
    public class ImageConvertStrategy : IConvertStrategy
    {
        public void ReadAndSave(IReading readDevice, string fileName, ILogger logger = null)
        {
            string copy = null;
            Bitmap bmpImage = new Bitmap(400, 400, PixelFormat.Format24bppRgb);
            

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

            using (Graphics graphics = Graphics.FromImage(bmpImage))
            {
                Rectangle rectangle = new Rectangle(0, 0, 400, 400);
                Font font = new Font("Times New Roman", 14);
                graphics.FillRectangle(Brushes.White, rectangle );
                graphics.DrawString(
                    copy,
                    font,
                    Brushes.Black,
                    rectangle,
                    StringFormat.GenericTypographic
                    );
            }
            bmpImage.Save(fileName, ImageFormat.Bmp);
            logger?.Info($"Результат сохранен в {fileName}");
        }
    }
}
