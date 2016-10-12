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

            TextBlock TopNum = new TextBlock { };
            TopNum.Margin = new Thickness(400, 0, 150, 400);
            //TopNum.Background = Brushes.White;
            TopNum.FontSize = 100;
            TopNum.FontFamily = new FontFamily("Cooper Black");
            TopNum.TextAlignment = TextAlignment.Right;
            TopNum.Text += "33333";
            TopNum.Height = 120;
            TopNum.Width = 300;

            TextBlock BottomNum = new TextBlock { };
            BottomNum.Margin = new Thickness(400, 0, 150, 50);
            //BottomNum.Background = Brushes.White;
            BottomNum.FontSize = 100;
            BottomNum.FontFamily = new FontFamily("Cooper Black");
            BottomNum.TextAlignment = TextAlignment.Right;
            BottomNum.Text += "33333";
            BottomNum.Height = 120;
            BottomNum.Width = 300;

            TextBlock Symbol = new TextBlock ();
            Symbol.Background = Brushes.White;
            Symbol.Height = 60;
            Symbol.Width = 60;
            Symbol.Margin = new Thickness(400, 0, 700, 500);
            Symbol.Text += "+";


            TextBox AnswerBox = new TextBox();
            AnswerBox.Margin = new Thickness(400, 400, 150, 0);
            AnswerBox.FontFamily = new FontFamily("Cooper Black");
            AnswerBox.Height = 120;
            AnswerBox.Width = 300;
            AnswerBox.FontSize = 100;
           

            addWindowGrid.Children.Add(BottomNum);
            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(Symbol);
            addWindowGrid.Children.Add(AnswerBox);
            addition.Content = addWindowGrid;
            addition.Show();

        }
    }
}
