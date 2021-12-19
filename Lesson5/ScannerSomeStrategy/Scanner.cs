using Interface.ReadDevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using Interface.ScannerSomeStrategy;

namespace ScannerSomeStrategy
{
    public sealed class Scanner
    {
        private readonly IReading _device;
        private IConvertStrategy _strategy;
        private readonly ILogger _logger;

        public Scanner(IReading device, ILogger logger = null)
        {
            _logger = logger;
            _logger?.Info("Сканер создан");
            _device = device;
        }

        public void SetupConvertStrategy(IConvertStrategy strategy)
        {
            _strategy = strategy;
            _logger?.Info($"Задана стретегия выполнения {_strategy.GetType().Name}");
        }

        public void Run(string fileName = null)
        {            
            _strategy.ReadAndSave(_device, fileName, _logger);
            _logger?.Info($"Запуск метода с использованием стратегии: {_strategy.GetType().Name}");
        }
    }
}
