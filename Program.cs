using System;
using System.Windows;

namespace TabControlDemo
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application app = new Application();
            Window mainWindow = new MainWindow();
            Models2.FrontOffice.main(mainWindow);
        }
    }
}
