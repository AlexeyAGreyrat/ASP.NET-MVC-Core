using Calculator.Interface;

namespace Calculator.Effect
{
    class Subtraction : IEffect
    {
        public double Effect(double x, double y)
        {
            return x - y;
        }
    }
}
