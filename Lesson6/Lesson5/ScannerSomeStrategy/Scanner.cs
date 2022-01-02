using NLog;
using ReadDevice.Interface;
using ScannerSomeStrategy.Interface;

namespace ScannerSomeStrategy
{
    public sealed class Scanner : IScanner
    {
        private IReading _device;
        private IConvertStrategy _strategy;
        private ILogger _logger;


        public void SetupLogger(ILogger logger = null)
        {
            _logger = logger;
            _logger?.Info("Начата запись");
        }
        public void SetupConvertStrategy(IConvertStrategy strategy)
        {
            _strategy = strategy;
            _logger?.Info($"Задана стретегия выполнения {_strategy.GetType().Name}");

        }
        public void SetupDevice(IReading read)
        {
            _device = read;
            _logger?.Info($"Задан девайс {_device.GetType().Name}");
        }
        public void Run(string fileName = null)
        {            
            _strategy.ReadAndSave(_device, fileName, _logger);
            _logger?.Info($"Запуск метода с использованием стратегии: {_strategy.GetType().Name}");
        }
    }
}
