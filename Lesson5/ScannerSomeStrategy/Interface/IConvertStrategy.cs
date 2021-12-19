using Interface.ReadDevice;
using NLog;

namespace Interface.ScannerSomeStrategy
{
    public interface IConvertStrategy
    {
        void ReadAndSave(IReading readDevice, string fileName, ILogger logger = null);
    }
}
