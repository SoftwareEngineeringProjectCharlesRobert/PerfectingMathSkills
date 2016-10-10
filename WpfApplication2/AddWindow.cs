//Authors: Charles Clayton and Robert Rayburn
//Last date modified: October 10, 2016
//File name: AddWindow.cs
//Description:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Documents;


namespace WpfApplication2
{
    public class AddWindow : Window
    {
        public AddWindow()
        {
            Window addition = new Window();
            addition.ResizeMode = ResizeMode.NoResize;
            addition.WindowState = WindowState.Maximized;

            Grid addWindowGrid = new Grid { };
            addition.Background = Brushes.SteelBlue;

            TextBox TopNum = new TextBox { };
            TopNum.Margin = new Thickness(400, 0, 0, 400);
            TopNum.Height = 120;
            TopNum.Width = 60;

            TextBox AnswerBox = new TextBox();
            AnswerBox.Margin = new Thickness(400, 400, 0, 0);
            AnswerBox.Height = 120;
            AnswerBox.Width = 60;

            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(AnswerBox);
            addition.Content = addWindowGrid;
            addition.Show();

        }
    }
}
