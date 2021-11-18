using System;

namespace Lesson3
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Console.WriteLine("Menu");
            Console.WriteLine("Print figure");
            var models = new (string name, Func<Model> func)[]
            {
            ("Rectangle", () => new Rectangle()),
            ("Triangle", () => new Triangle())
            };
            foreach(var model in models)
            {
                Console.WriteLine($"{i++}) {model.name}");
            }
            var number = Convert.ToInt32(Console.ReadLine());

            var figure = models[number - 1].func();

            var symbol = new ConsoleDrawer('*');

            figure.Print(symbol);

            symbol = new ConsoleDrawer('-');

            figure.Print(symbol);

            Console.ReadLine();            
        }
    }
}
