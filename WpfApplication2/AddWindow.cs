﻿//Authors: Charles Clayton and Robert Rayburn
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
using System.Windows.Input;
using System.Windows.Controls.Primitives;

namespace WpfApplication2
{

    public class AddWindow
    {
        private int solution;
        private int userAnswer;
        private Window addition = new Window();
            
        private TextBlock TopNum = new TextBlock { };
        private TextBlock BottomNum = new TextBlock { };
        private TextBlock Symbol = new TextBlock();
        private TextBox AnswerBox = new TextBox();

        private Button Enter = new Button { };


        Random randomNum = new Random();
        int top;
        int bot;


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            userAnswer = Convert.ToInt32(AnswerBox.Text);
            if (userAnswer == solution)
            {
                Window correct = new Window { };
                correct.Background = Brushes.LimeGreen;
                correct.Height = 300;
                correct.Width = 760;

                TextBlock right = new TextBlock { };
                right.FontFamily = new FontFamily("Cooper Black");
                right.FontSize = 100;
                right.Text += "Right";
                right.Background = Brushes.LimeGreen;
                right.Height = 120;
                right.Width = 380;
                right.TextAlignment = TextAlignment.Center;
                right.Margin = new Thickness(100, 0, 100, 100);

                Grid cGrid = new Grid { };

                Button next = new Button { };
                next.FontFamily = new FontFamily("Cooper Black");
                next.FontSize = 100;
                next.Content = "Next";
                next.Background = Brushes.Green;
                next.Height = 120;
                next.Width = 380;
                next.Margin = new Thickness(100, 100, 100, 0);
                next.Click += Next_Click;

                cGrid.Children.Add(next);
                cGrid.Children.Add(right);
                correct.Content = cGrid;
                correct.Show();
            }

            else
            {
                Window incorrect = new Window { };
                incorrect.Height = 300;
                incorrect.Width = 760;
                incorrect.Background = Brushes.Firebrick;

                TextBlock wrong = new TextBlock { };
                wrong.FontSize = 100;
                wrong.FontFamily = new FontFamily("Cooper Black");
                wrong.Text += "Wrong";
                wrong.Background = Brushes.Firebrick;
                wrong.Height = 120;
                wrong.Width = 380;
                wrong.TextAlignment = TextAlignment.Center;
                wrong.Margin = new Thickness(100, 0, 100, 100);

                Grid cGrid = new Grid { };

                Button back = new Button { };
                back.FontFamily = new FontFamily("Cooper Black");
                back.FontSize = 100;
                back.Content = "Retry";
                back.Background = Brushes.Red;
                back.Height = 120;
                back.Width = 380;
                back.Margin = new Thickness(100, 100, 100, 0);
                back.Click += Back_Click;

                cGrid.Children.Add(back);
                cGrid.Children.Add(wrong);
                incorrect.Content = cGrid;
                incorrect.Show();
            }
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //top = getTopNum(26);
            //bot = getBotNum(26);\

            AddWindow nextProblem = new AddWindow { };
            
        }

        public int getTopNum(int max)
        {               //max will be one more than difficulty bounds
            int number = randomNum.Next(max);
            return number;
        }

        public int getBotNum(int max)
        {               //max will be one more than difficulty bounds
            int number = randomNum.Next(max);
            return number;
        }



        public AddWindow()
        {
           

            addition.ResizeMode = ResizeMode.NoResize;
            addition.WindowState = WindowState.Maximized;

            Grid addWindowGrid = new Grid { };
            addition.Background = Brushes.SteelBlue;

            TopNum.Margin = new Thickness(400, 0, 150, 400);
            //TopNum.Background = Brushes.White;
            TopNum.FontSize = 100;
            TopNum.FontFamily = new FontFamily("Cooper Black");
            TopNum.TextAlignment = TextAlignment.Right;
            top = getTopNum(26);
            TopNum.Text += top;
            TopNum.Height = 120;
            TopNum.Width = 300;

            BottomNum.Margin = new Thickness(400, 0, 150, 50);
            //BottomNum.Background = Brushes.White;
            BottomNum.FontSize = 100;
            BottomNum.FontFamily = new FontFamily("Cooper Black");
            BottomNum.TextAlignment = TextAlignment.Right;
            bot = getBotNum(26);
            BottomNum.Text += bot;
            BottomNum.Height = 120;
            BottomNum.Width = 300;

            solution = top + bot;

            Symbol.Background = Brushes.SteelBlue;
            Symbol.Height = 120;
            Symbol.Width = 60;
            Symbol.FontSize = 100;
            Symbol.FontFamily = new FontFamily("Cooper Black");
            Symbol.Margin = new Thickness(400, 0, 700, 50);
            Symbol.Text += "+";


            
            AnswerBox.Margin = new Thickness(400, 400, 150, 0);
            AnswerBox.FontFamily = new FontFamily("Cooper Black");
            AnswerBox.TextAlignment = TextAlignment.Right;
            AnswerBox.Height = 120;
            AnswerBox.Width = 300;
            AnswerBox.FontSize = 100;

           
            Enter.Content = "Enter";
            Enter.FontSize = 100;
            Enter.Height = 120;
            Enter.Width = 300;
            Enter.FontFamily = new FontFamily("Cooper Black");
            Enter.Margin = new Thickness(400, 650, 150, 0);
            Enter.Background = Brushes.LimeGreen;
           

            addWindowGrid.Children.Add(BottomNum);
            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(Symbol);
            addWindowGrid.Children.Add(AnswerBox);
            addWindowGrid.Children.Add(Enter);
            addition.Content = addWindowGrid;
            addition.Show();

            Enter.Click += Button_Click;
        }
    } 
}
