using Calculator.Interface;

namespace Calculator.Effect
{
    class Summation : IEffect
    {
        public double Effect(double x, double y)
        {
            return x + y;
        }
    }
}
