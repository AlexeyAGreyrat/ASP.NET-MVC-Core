using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Work
    {
        public Work(Action task)
        {
            Task = task;
        }

        public Action Task { get; }


    }
}
