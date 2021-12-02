using System.Collections.Generic;

namespace Lesson4
{
    public interface ISerializer
    {
        void Serialize<T>(List<T> data);
    }
}
