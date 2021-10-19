using System.Windows;
using System.Windows.Controls;

namespace Lesson1
{
    public partial class MainWindow : Window
    {
        private readonly PageFib _fibonacciPage = new();
        public MainWindow()
        {
            InitializeComponent();
            NavigateTo(_fibonacciPage);
        }
        private void NavigateTo(Page page)
        {
            Title = page.Title;
            MainPG.Navigate(page);
        }
    }
}
