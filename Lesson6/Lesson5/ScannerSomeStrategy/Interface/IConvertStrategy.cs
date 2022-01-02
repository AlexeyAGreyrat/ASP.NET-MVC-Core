using ReadDevice.Interface;
using NLog;

namespace ScannerSomeStrategy.Interface
{
    public interface IConvertStrategy
    {
        void ReadAndSave(IReading readDevice, string fileName, ILogger logger = null);
    }
}
