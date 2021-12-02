using Lesson4.Products;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Lesson4.Strategy
{
    public sealed class BikeStrategy : IDeserializer
    {
        public object Deserialize(StreamReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bike>));
            return serializer.Deserialize(reader);
        }
    }
}
