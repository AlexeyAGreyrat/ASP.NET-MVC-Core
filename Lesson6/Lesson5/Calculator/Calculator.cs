using Calculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator : ICalculator
    {
        private IEffect _effect;
        public void SetupEffect(IEffect effect)
        {
            _effect = effect;
        }
        public double Run(double x, double y)
        {
            return _effect.Effect(x, y);
        }
    }
}
