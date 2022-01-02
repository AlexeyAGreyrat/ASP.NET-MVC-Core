using Calculator.Interface;

namespace Calculator.Effect
{
    class Splitting : IEffect
    {
        public double Effect(double x, double y)
        {
            return x / y;
        }
    }
}
