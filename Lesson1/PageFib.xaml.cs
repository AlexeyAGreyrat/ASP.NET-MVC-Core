using System;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lesson1
{
    public partial class PageFib : Page
    {
        private readonly struct FibonacciStruct
        {
            public int FibonacciIndex { get; }
            public FibonacciStruct(int fibonacciIndex)
            {
                FibonacciIndex = fibonacciIndex;
            }
        }
        public PageFib()
        {
            InitializeComponent();
            TextBoxSleep.Text = Sleep.ToString();
        }
        private static int Sleep = 1000;
       
        

        private void ButtonStart_OnClick(object sender, RoutedEventArgs e)
        {
            Sleep = Convert.ToInt32(TextBoxSleep.Text);
            TextBoxOutput.Text = string.Empty;            
            int number = Convert.ToInt32(TextBoxNumber.Text);

            var dto = new FibonacciStruct(number);
            Thread fibonacciThread = new(obj =>
            {
                if (obj is not FibonacciStruct fibonacciDTO) return;

                    Fibonacchi(fibonacciDTO.FibonacciIndex);
                
            });
            fibonacciThread.Start(dto);
        }

        private void Fibonacchi(int number)
        {
            int num1 = 0;
            int num2 = 1;
            for (int i = 0; i <= number; i++)
            {
                int fibonacci = i;
                if (i > 1)
                {
                    fibonacci = num1 + num2;
                    num1 = num2;
                    num2 = fibonacci;
                }               

                Display(fibonacci.ToString());
                Thread.Sleep(Sleep);
            }
        }

        private void Display(string toDisplay)
        {
                Application.Current.Dispatcher.Invoke(() => TextBoxOutput.Text += $"{toDisplay} ");         
        }            
    }
}
