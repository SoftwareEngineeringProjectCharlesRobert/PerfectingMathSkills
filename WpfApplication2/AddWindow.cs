//Robert
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
    public class AddWindow : Window
    {
        public AddWindow()
        {
            Window addition = new Window ();
            addition.Height = 600;
            addition.Width = 600;
            Grid addWindowGrid = new Grid { };
            addition.Background = Brushes.SteelBlue;
            TextBox TopNum = new TextBox { };
            TopNum.Height = 120;
            TopNum.Width = 60;
            addWindowGrid.Children.Add(TopNum);
            addition.Content = addWindowGrid;
            addition.Show();

        }
    }
}
