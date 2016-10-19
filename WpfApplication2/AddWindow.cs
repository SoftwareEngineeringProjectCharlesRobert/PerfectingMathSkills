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

        public int getTopNum(int max)
        {               //max will be one more than difficulty bounds
            Random randomNum = new Random();
            int number = randomNum.Next(max);
            return number;
        }

        public int getBotNum(int max)
        {               //max will be one more than difficulty bounds
            Random randomNum = new Random();
            max = max - 1;
            int number = randomNum.Next(max);
            return number;
        }

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
            TopNum.Text += getTopNum(26);
            TopNum.Height = 120;
            TopNum.Width = 300;

            TextBlock BottomNum = new TextBlock { };
            BottomNum.Margin = new Thickness(400, 0, 150, 50);
            //BottomNum.Background = Brushes.White;
            BottomNum.FontSize = 100;
            BottomNum.FontFamily = new FontFamily("Cooper Black");
            BottomNum.TextAlignment = TextAlignment.Right;
            BottomNum.Text += getBotNum(26);
            BottomNum.Height = 120;
            BottomNum.Width = 300;

            TextBlock Symbol = new TextBlock ();
            Symbol.Background = Brushes.SteelBlue;
            Symbol.Height = 120;
            Symbol.Width = 60;
            Symbol.FontSize = 100;
            Symbol.FontFamily = new FontFamily("Cooper Black");
            Symbol.Margin = new Thickness(400, 0, 700, 50);
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
