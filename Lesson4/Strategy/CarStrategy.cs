using Lesson4.Products;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Lesson4.Strategy
{
    public sealed class CarStrategy : IDeserializer
    {
        public object Deserialize(StreamReader reader)
        {
            return JsonSerializer.Deserialize<List<Car>>(reader.ReadToEnd());
        }
    }
}
