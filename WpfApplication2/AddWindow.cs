//Authors: Charles Clayton and Robert Rayburn
//Last date modified: October 27, 2016
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
        private int buttonCounter = 0;
        private int solution;
        private int userAnswer;
        private Window addition = new Window();

        private Grid addWindowGrid = new Grid { };
        private TextBlock TopNum = new TextBlock { };
        private TextBlock BottomNum = new TextBlock { };
        private TextBlock Symbol = new TextBlock();
        private TextBox AnswerBox = new TextBox();

        private Button Enter = new Button { };
        private Button zero = new Button();
        private Button backspace = new Button();

        Random randomNum = new Random();
        int top;
        int bot;

        public void Check_Window()
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

        void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(this, new RoutedEventArgs());
                //e.Handled = true;
            }


        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Check_Window();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            //top = getTopNum(26);
            //bot = getBotNum(26);
            //addWindowGrid.Items.refresh();
            //AddWindow nextProblem = new AddWindow { };
            
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

        public Grid numpad()
        {

            Grid numberPad = new Grid { };
            numberPad.Height = 410;
            numberPad.Width = 310;

            numberPad.RowDefinitions.Add(new RowDefinition());
            numberPad.RowDefinitions.Add(new RowDefinition());
            numberPad.RowDefinitions.Add(new RowDefinition());
            numberPad.RowDefinitions.Add(new RowDefinition());

            numberPad.ColumnDefinitions.Add(new ColumnDefinition());
            numberPad.ColumnDefinitions.Add(new ColumnDefinition());
            numberPad.ColumnDefinitions.Add(new ColumnDefinition());

            Button backspace = new Button { };
            Button clear = new Button { };
            
            Button num;
            //int i = 0;

            for(int row = 0; row < numberPad.RowDefinitions.Count - 1; row++)
            {
                for(int col = 0; col < numberPad.ColumnDefinitions.Count; col++)
                {
                    buttonCounter++;
                    num = new Button();
                    num.Width = 150;
                    num.Height = 150;
                    num.Content = buttonCounter.ToString();

                    num.Background = Brushes.Black;
                    num.Foreground = Brushes.White;
                    num.FontFamily = new FontFamily("Cooper Black");
                    num.FontSize = 100;
                    num.HorizontalAlignment = HorizontalAlignment.Center;
                    num.VerticalAlignment = VerticalAlignment.Center;

                    if (buttonCounter == 1)
                        num.Click += one_Click;
                    else if (buttonCounter == 2)
                        num.Click += two_Click;
                    else if (buttonCounter == 3)
                        num.Click += three_Click;
                    else if (buttonCounter == 4)
                        num.Click += four_Click;
                    else if (buttonCounter == 5)
                        num.Click += five_Click;
                    else if (buttonCounter == 6)
                        num.Click += six_Click;
                    else if (buttonCounter == 7)
                        num.Click += seven_Click;
                    else if (buttonCounter == 8)
                        num.Click += eight_Click;
                    else
                        num.Click += nine_Click;

                    num.SetValue(Grid.ColumnProperty, col);
                    num.SetValue(Grid.RowProperty, row);

                    numberPad.Children.Add(num);
                }
            }
            return numberPad;
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "3";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "6";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "0";
        }

        private void backspace_Click(object sender, RoutedEventArgs e)
        {
            //if anserbox is empty do something.
            AnswerBox.Text = AnswerBox.Text.Remove(AnswerBox.Text.Length - 1);
        }

        public AddWindow()
        {

            addition.ResizeMode = ResizeMode.NoResize;
            addition.WindowState = WindowState.Maximized;

            //Grid addWindowGrid = new Grid { };
            addition.Background = Brushes.SteelBlue;

            TopNum.Margin = new Thickness(475, 0, 75, 400);
            //TopNum.Background = Brushes.White;
            TopNum.FontSize = 100;
            TopNum.FontFamily = new FontFamily("Cooper Black");
            TopNum.TextAlignment = TextAlignment.Right;
            top = getTopNum(26);
            TopNum.Text += top;
            TopNum.Height = 120;
            TopNum.Width = 300;

            BottomNum.Margin = new Thickness(475, 0, 75, 50);
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
            Symbol.Margin = new Thickness(475, 0, 625, 50);
            Symbol.Text += "+";


            
            AnswerBox.Margin = new Thickness(475, 400, 75, 0);
            AnswerBox.FontFamily = new FontFamily("Cooper Black");
            AnswerBox.TextAlignment = TextAlignment.Right;
            AnswerBox.Height = 120;
            AnswerBox.Width = 300;
            AnswerBox.FontSize = 100;


            Grid gridForEnterZeroAndBackspace = new Grid();
            gridForEnterZeroAndBackspace.Height = 410;
            gridForEnterZeroAndBackspace.Width = 310;

            gridForEnterZeroAndBackspace.ColumnDefinitions.Add(new ColumnDefinition());
            gridForEnterZeroAndBackspace.RowDefinitions.Add(new RowDefinition());
            gridForEnterZeroAndBackspace.RowDefinitions.Add(new RowDefinition());
            gridForEnterZeroAndBackspace.RowDefinitions.Add(new RowDefinition());
            gridForEnterZeroAndBackspace.HorizontalAlignment = HorizontalAlignment.Left;
            gridForEnterZeroAndBackspace.VerticalAlignment = VerticalAlignment.Bottom;


            Enter.Content = "Enter";
            Enter.FontSize = 100;
            Enter.Height = 150;
            Enter.Width = 410;
            Enter.FontFamily = new FontFamily("Cooper Black");
            //Enter.Margin = new Thickness(475, 650, 75, 0);
            Enter.Background = Brushes.LimeGreen;
            Enter.SetValue(Grid.ColumnProperty, 1);
            Enter.SetValue(Grid.RowProperty, 1);
            Enter.HorizontalAlignment = HorizontalAlignment.Center;
            Enter.VerticalAlignment = VerticalAlignment.Center;


            zero.Content = "0";
            zero.FontSize = 100;
            zero.Height = 150;
            zero.Width = 410;
            zero.FontFamily = new FontFamily("Cooper Black");
            zero.Background = Brushes.Black;
            zero.Foreground = Brushes.White;
            zero.Click += zero_Click;
            zero.SetValue(Grid.ColumnProperty, 1);
            zero.SetValue(Grid.RowProperty, 2);
            zero.HorizontalAlignment = HorizontalAlignment.Center;
            zero.VerticalAlignment = VerticalAlignment.Center;

            backspace.Content = "\u232B";
            backspace.FontSize = 100;
            backspace.Height = 150;
            backspace.Width = 410;
            backspace.FontFamily = new FontFamily("Cooper Black");
            backspace.Background = Brushes.Red;
            //backspace.Foreground = Brushes.White;
            backspace.Click += backspace_Click;
            backspace.SetValue(Grid.ColumnProperty, 1);
            backspace.SetValue(Grid.RowProperty, 3);
            backspace.HorizontalAlignment = HorizontalAlignment.Center;
            backspace.VerticalAlignment = VerticalAlignment.Center;


            gridForEnterZeroAndBackspace.Children.Add(Enter);
            gridForEnterZeroAndBackspace.Children.Add(zero);
            gridForEnterZeroAndBackspace.Children.Add(backspace);

            Grid numberPad = numpad();
            numberPad.HorizontalAlignment = HorizontalAlignment.Left;
            numberPad.VerticalAlignment = VerticalAlignment.Center;

            addWindowGrid.Children.Add(gridForEnterZeroAndBackspace);
            addWindowGrid.Children.Add(numberPad);
            addWindowGrid.Children.Add(BottomNum);
            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(Symbol);
            addWindowGrid.Children.Add(AnswerBox);
            //addWindowGrid.Children.Add(Enter);
            addition.Content = addWindowGrid;
            addition.Show();

            Enter.Click += Button_Click;
            AnswerBox.KeyDown += Window_KeyDown;//new RoutedEventHandler(Button_Click);
        }
    } 
}
