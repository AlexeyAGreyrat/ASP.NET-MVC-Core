using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public interface IThreadPool : IDisposable
    {
        int Count { get; }

        void QueueTask(Action task);
    }
}
