using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace WpfApplication2
{
    class main
    {
        Window first = new Window();
        Button add = new Button();
        Button subtract = new Button();
        Button multiply = new Button();
        Grid grid = new Grid();
        public main()
        {
            first.ResizeMode = ResizeMode.NoResize;
            first.WindowState = WindowState.Maximized;
            first.Background = Brushes.DarkGoldenrod;

            add.Background = Brushes.Red;
            add.Height = 100;
            add.Width = 200;
            add.VerticalAlignment = VerticalAlignment.Bottom;
            add.HorizontalAlignment = HorizontalAlignment.Left;

            subtract.Background = Brushes.Blue;
            subtract.Height = 100;
            subtract.Width = 200;
            subtract.VerticalAlignment = VerticalAlignment.Bottom;
            subtract.HorizontalAlignment = HorizontalAlignment.Center;

            multiply.Background = Brushes.Green;
            multiply.Height = 100;
            multiply.Width = 200;
            multiply.VerticalAlignment = VerticalAlignment.Bottom;
            multiply.HorizontalAlignment = HorizontalAlignment.Right;

            grid.Children.Add(add);
            grid.Children.Add(subtract);
            grid.Children.Add(multiply);

            first.Content = grid;
            first.Show();

        }
    }
}
