using System;
using NLog;
using ScannerSomeDevice;
using Interface.ReadDevice;
using ScannerSomeStrategy;
using Interface.ScannerSomeStrategy;


namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            IReading device = new Reading();
            IConvertStrategy strategyPdf = new PdfConvertStrategy();
            IConvertStrategy strategyImage = new ImageConvertStrategy();
            ILogger logger = LogManager.GetCurrentClassLogger();

            var context = new Scanner(device, logger);
            context.SetupConvertStrategy(strategyPdf);
            context.Run("DocumentTest.pdf");

            context.SetupConvertStrategy(strategyImage);
            context.Run("ImageTest.bmp");           
        }
    }
}
