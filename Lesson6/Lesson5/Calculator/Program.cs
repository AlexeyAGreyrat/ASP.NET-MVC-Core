using Autofac;
using Calculator.Effect;
using Calculator.Interface;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Вычитание");
            Console.WriteLine("2)Умножение");
            Console.WriteLine("3)Сложение");
            Console.WriteLine("4)Деление");

            var builder = new ContainerBuilder();

            builder.RegisterType<Calculator>().As<ICalculator>().SingleInstance();

            builder.RegisterType<Multiplier>().Named<IEffect>("*");
            builder.RegisterType<Splitting>().Named<IEffect>("/");
            builder.RegisterType<Subtraction>().Named<IEffect>("-");
            builder.RegisterType<Summation>().Named<IEffect>("+");

            IContainer container = builder.Build();
            var calculator = container.Resolve<ICalculator>();

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    calculator.SetupEffect(container.ResolveKeyed<IEffect>("-"));
                    Console.WriteLine(calculator.Run(10, 10));
                    break;
                case 2:
                    calculator.SetupEffect(container.ResolveKeyed<IEffect>("*"));
                    Console.WriteLine(calculator.Run(10, 10));
                    break;
                case 3:
                    calculator.SetupEffect(container.ResolveKeyed<IEffect>("+"));
                    Console.WriteLine(calculator.Run(10, 10));
                    break;
                case 4:
                    calculator.SetupEffect(container.ResolveKeyed<IEffect>("/"));
                    Console.WriteLine(calculator.Run(10, 10));
                    break;
            }

        }
    }
}
