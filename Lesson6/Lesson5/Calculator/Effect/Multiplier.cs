using Calculator.Interface;

namespace Calculator.Effect
{
    class Multiplier : IEffect
    {
        public double Effect(double x, double y)
        {
            return x * y;
        }
    }
}
