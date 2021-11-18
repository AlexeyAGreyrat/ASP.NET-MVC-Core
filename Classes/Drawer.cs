using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    abstract class Drawer
    {
        public abstract void DrawRectangle(Rectangle rectangle);
        public abstract void DrawTriangle(Triangle triangle);
    }

    internal class ConsoleDrawer : Drawer
    {
        private readonly char _symbol;

        public ConsoleDrawer(char symbol)
        {
            _symbol = symbol;
        }

        public override void DrawRectangle(Rectangle rectangle)
        {
            string symbol = _symbol.ToString();
            string str=symbol;
            string space = "";
            string temp = "";
            for (int i = 0; i < rectangle.Width; i++)
            {
                space += " ";
                str += symbol;
            }

            for (int j = 0; j < 0; j++)
                temp += " ";

            str += symbol + "\n";

            for (int i = 0; i < rectangle.Height; i++)
                str += temp + symbol + space + symbol + "\n";

            str += temp + symbol;
            for (int i = 0; i < rectangle.Width; i++)
                str += symbol;

            str += symbol + "\n";
            Console.CursorLeft = 0;
            Console.Write(str);
            Console.ResetColor();
        }

        public override void DrawTriangle(Triangle circle)
        {
            string s = _symbol.ToString();
            var t = circle.Height;
            for (int i = 0; i < t; i++)
            {
                for (int j = 1; j < t - i; j++)
                    Console.Write(" ");
                for (double j = t - 2 * i; j <= t; j++)
                    Console.Write(s);
                Console.WriteLine();
            }
        }
    }
}
