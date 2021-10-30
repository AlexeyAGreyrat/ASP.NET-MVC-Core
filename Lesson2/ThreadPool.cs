using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson2
{
    public class MyThreadPool : IThreadPool
    {
        private Thread[] _threads;
        private readonly ConcurrentQueue<Work> _tasks;
        private readonly object _lock = new();

        public MyThreadPool(int maxTrade = 2)
        {
            if (maxTrade < 1)
            {
                throw new ArgumentException("Количество максимальных потоков не может быть 0", nameof(maxTrade));
            }


            _threads = new Thread[maxTrade];
            _tasks = new();

            for (var i = 0; i < maxTrade; i++)
            {
                _threads[i] = new Thread(Take) { IsBackground = true, Name = $"Thread Pool-[{i}]" };
                _threads[i].Start();
            }
        }

        public int Count => _threads.Length;

        public void QueueTask(Action task)
        {
            Work worker;
            lock (_lock)
            {
                if (_isDisposed) return;
                worker = new Work(task);
                _tasks.Enqueue(worker);
                Monitor.Pulse(_lock);
            }


        }

        private void Take(object arg)
        {
            while (true)
            {
                Work work;
                lock (_lock)
                {
                    while (_tasks.IsEmpty || _isDisposed || _isDisposing)
                    {
                        Monitor.Wait(_lock);
                        if (_isDisposed || _isDisposing) return;
                    }

                    if (!_tasks.TryDequeue(out work)) continue;
                }
                if (_isDisposed || _isDisposing) return;

                work.Task?.Invoke();
            }
        }

        private bool _isDisposing;
        private bool _isDisposed;

        protected virtual void Dispose(bool disposing)
        {
            if (_isDisposed) return;
            _isDisposing = true;
            if (disposing)
            {
                lock (_lock)
                {
                    Monitor.PulseAll(_lock);
                }

                foreach (var thread in _threads)
                {
                    thread.Join();
                }
            }

            _isDisposed = true;
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
    }
}
