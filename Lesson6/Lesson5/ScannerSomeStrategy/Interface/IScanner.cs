using NLog;
using ReadDevice.Interface;

namespace ScannerSomeStrategy.Interface
{
    public interface IScanner
    {
        public void SetupConvertStrategy(IConvertStrategy strategy);
        public void SetupLogger(ILogger logger);
        public void SetupDevice(IReading read);
        public void Run(string fileName);

    }
}
