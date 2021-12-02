using System.IO;

namespace Lesson4.Strategy
{
    public interface IDeserializer
    {
        object Deserialize(StreamReader reader);
    }
}
