using Autofac;
using NLog;
using ReadDevice.Interface;
using ScannerSomeDevice;
using ScannerSomeStrategy;
using ScannerSomeStrategy.Interface;


namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = LogManager.GetCurrentClassLogger();
            var builder = new ContainerBuilder();

            builder.RegisterType<Reading>().As<IReading>().SingleInstance();
            builder.RegisterType<Scanner>().As<IScanner>();

            builder.RegisterType<PdfConvertStrategy>().Named<IConvertStrategy>("PDF");
            builder.RegisterType<ImageConvertStrategy>().Named<IConvertStrategy>("Image");


            IContainer container = builder.Build();

            var device = container.Resolve<IReading>();
            var context = container.Resolve<IScanner>();
            context.SetupLogger(logger);
            context.SetupConvertStrategy(container.ResolveKeyed<IConvertStrategy>("PDF"));
            context.SetupDevice(device);
            context.Run("test.pdf");

            context.SetupConvertStrategy(container.ResolveKeyed<IConvertStrategy>("Image"));
            context.SetupDevice(device);
            context.Run("test.bmp");
        }
    }
}
