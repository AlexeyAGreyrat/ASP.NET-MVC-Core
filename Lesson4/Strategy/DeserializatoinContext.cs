using System;
using System.IO;

namespace Lesson4.Strategy
{
    public sealed class DeserializatoinContext
    {
        private StreamReader _reader;
        private IDeserializer _currentStrategy;
        public object Result { get; private set; }
        public DeserializatoinContext(StreamReader reader)
        {
            _reader = reader;
        }

        public void SetupDeserializatoinStrategy(IDeserializer strategy)
        {
            _currentStrategy = strategy;
        }
        public void Execute()
        {
            if (_currentStrategy is null)
            {
                throw new ArgumentNullException("Current scan strategy can not be null");
            }
            Result = _currentStrategy.Deserialize(_reader);
        }
    }
}
