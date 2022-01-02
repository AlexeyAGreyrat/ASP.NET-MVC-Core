using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interface
{
    interface ICalculator
    {
        void SetupEffect(IEffect action);
        double Run(double x, double y);
    }
}
