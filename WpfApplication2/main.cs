//Authors: Charles Clayton and Robert Rayburn
//Last date modified: november 15, 2016
//File name: main.cs
//Description:

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
            first.Background = Brushes.Yellow;

            add.Background = Brushes.Red;
            add.Height = 300;
            add.Width = 500;
            add.Content = "Add";
            add.FontFamily = new FontFamily("Cooper Black");
            add.FontSize = 80;
            add.VerticalAlignment = VerticalAlignment.Bottom;
            add.HorizontalAlignment = HorizontalAlignment.Left;
            add.Click += add_Click;

            subtract.Background = Brushes.Blue;
            subtract.Height = 300;
            subtract.Width = 500;
            subtract.Content = "Subtract";
            subtract.FontFamily = new FontFamily("Cooper Black");
            subtract.FontSize = 80;
            subtract.VerticalAlignment = VerticalAlignment.Bottom;
            subtract.HorizontalAlignment = HorizontalAlignment.Center;
            subtract.Click += subtract_Click;

            multiply.Background = Brushes.Green;
            multiply.Height = 300;
            multiply.Width = 500;
            multiply.Content = "Multiply";
            multiply.FontFamily = new FontFamily("Cooper Black");
            multiply.FontSize = 80;
            multiply.VerticalAlignment = VerticalAlignment.Bottom;
            multiply.HorizontalAlignment = HorizontalAlignment.Right;
            multiply.Click += multiply_Click;

            grid.Children.Add(add);
            grid.Children.Add(subtract);
            grid.Children.Add(multiply);

            first.Content = grid;
            first.Show();

        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            AddWindow THIS = new AddWindow();
        }

        private void subtract_Click(object sender, RoutedEventArgs e)
        {
            SubtractWindow THIS = new SubtractWindow();
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            MultiplyWindow THIS = new MultiplyWindow();
        }
    }
}
