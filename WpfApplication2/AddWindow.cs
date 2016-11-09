//Authors: Charles Clayton and Robert Rayburn
//Last date modified: november 4, 2016
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
        public ButtonClicks buttons = new ButtonClicks { };
       

        public int buttonCounter = 0;
        public int solution;
        public int userAnswer;
        public Window addition = new Window();

        public Grid addWindowGrid = new Grid { };
        public TextBlock TopNum = new TextBlock { };
        public TextBlock BottomNum = new TextBlock { };
        public TextBlock Symbol = new TextBlock();
        public TextBox AnswerBox = new TextBox();

        public Button Enter = new Button { };
        public Button zero = new Button();
        public Button backspace = new Button();

        public Window correct = new Window { };
        public Window incorrect = new Window { };

        Random randomNum = new Random();
        int top;
        int bot;

        public AddWindow()
        {

            addition.ResizeMode = ResizeMode.NoResize;
            addition.WindowState = WindowState.Maximized;
            addition.Background = Brushes.SteelBlue;

            TopNum.Margin = new Thickness(475, 0, 75, 400);
            TopNum.FontSize = 100;
            TopNum.FontFamily = new FontFamily("Cooper Black");
            TopNum.TextAlignment = TextAlignment.Right;
            TopNum.Text += top;
            TopNum.Height = 120;
            TopNum.Width = 300;

            BottomNum.Margin = new Thickness(475, 0, 75, 50);
            BottomNum.FontSize = 100;
            BottomNum.FontFamily = new FontFamily("Cooper Black");
            BottomNum.TextAlignment = TextAlignment.Right;
            BottomNum.Text += bot;
            BottomNum.Height = 120;
            BottomNum.Width = 300;

            update();


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
            AnswerBox.MaxLength = 4;


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
            Enter.Background = Brushes.LimeGreen;
            Enter.SetValue(Grid.ColumnProperty, 0);
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
            zero.Click += buttons.zero_Click;
            zero.SetValue(Grid.ColumnProperty, 0);
            zero.SetValue(Grid.RowProperty, 0);
            zero.HorizontalAlignment = HorizontalAlignment.Center;
            zero.VerticalAlignment = VerticalAlignment.Center;

            backspace.Content = "\u232B";
            backspace.FontSize = 100;
            backspace.Height = 150;
            backspace.Width = 410;
            backspace.FontFamily = new FontFamily("Cooper Black");
            backspace.Background = Brushes.Red;
            backspace.Click += buttons.backspace_Click;
            backspace.SetValue(Grid.ColumnProperty, 0);
            backspace.SetValue(Grid.RowProperty, 2);
            backspace.HorizontalAlignment = HorizontalAlignment.Center;
            backspace.VerticalAlignment = VerticalAlignment.Center;


            gridForEnterZeroAndBackspace.Children.Add(Enter);
            gridForEnterZeroAndBackspace.Children.Add(zero);
            gridForEnterZeroAndBackspace.Children.Add(backspace);

            Grid numberPad = numpad();
            numberPad.HorizontalAlignment = HorizontalAlignment.Left;
            numberPad.VerticalAlignment = VerticalAlignment.Top;

            addWindowGrid.Children.Add(gridForEnterZeroAndBackspace);
            addWindowGrid.Children.Add(numberPad);
            addWindowGrid.Children.Add(BottomNum);
            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(Symbol);
            addWindowGrid.Children.Add(AnswerBox);
            addition.Content = addWindowGrid;
            addition.Show();

            Enter.Click += buttons.Button_Click;
            AnswerBox.KeyDown += buttons.Window_KeyDown;
        }

        public void Check_Window()
        {
            userAnswer = Convert.ToInt32(AnswerBox.Text);
            if (userAnswer == solution)
            {
                correct = new Window { };
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
                next.Click += buttons.Next_Click;

                cGrid.Children.Add(next);
                cGrid.Children.Add(right);
                correct.Content = cGrid;
                correct.Show();
                correct.KeyDown += buttons.Next_EnterKeyDown;
                
            }

            else
            {
                incorrect = new Window { };
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
                back.Click += buttons.Back_Click;

                cGrid.Children.Add(back);
                cGrid.Children.Add(wrong);
                incorrect.Content = cGrid;
                incorrect.Show();
                AnswerBox.Clear();
            }
        }
        
        //void Next_EnterKeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.Key == Key.Enter)
        //    {
        //        Next_Click(this, new RoutedEventArgs());
        //    }
        //}

        //void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        Button_Click(this, new RoutedEventArgs());
        //    }


        //}
        //public void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if(AnswerBox.Text.Length > 0)
        //        Check_Window();
        //    return;
        //}
        //public void Back_Click(object sender, RoutedEventArgs e)
        //{
        //    Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
            
        //}

        //public void Next_Click(object sender, RoutedEventArgs e)
        //{
        //    update();
        //    correct.Close();
        //    AnswerBox.Clear();
            
        //}

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

            numberPad.ColumnDefinitions.Add(new ColumnDefinition());
            numberPad.ColumnDefinitions.Add(new ColumnDefinition());
            numberPad.ColumnDefinitions.Add(new ColumnDefinition());

            Button backspace = new Button { };
            Button clear = new Button { };
            
            Button num;
            //int i = 0;

            for(int row = 0; row < numberPad.RowDefinitions.Count /*- 1*/; row++)
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
                        num.Click += buttons.one_Click;
                    else if (buttonCounter == 2)
                        num.Click += buttons.two_Click;
                    else if (buttonCounter == 3)
                        num.Click += buttons.three_Click;
                    else if (buttonCounter == 4)
                        num.Click += buttons.four_Click;
                    else if (buttonCounter == 5)
                        num.Click += buttons.five_Click;
                    else if (buttonCounter == 6)
                        num.Click += buttons.six_Click;
                    else if (buttonCounter == 7)
                        num.Click += buttons.seven_Click;
                    else if (buttonCounter == 8)
                        num.Click += buttons.eight_Click;
                    else
                        num.Click += buttons.nine_Click;

                    num.SetValue(Grid.ColumnProperty, col);
                    num.SetValue(Grid.RowProperty, row);

                    numberPad.Children.Add(num);
                }
            }
            return numberPad;
        }

        //public void one_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "1";
        //}

        //public void two_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "2";
        //}

        //public void three_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "3";
        //}

        //public void four_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "4";
        //}

        //public void five_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "5";
        //}

        //public void six_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "6";
        //}

        //public void seven_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "7";
        //}

        //public void eight_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "8";
        //}

        //public void nine_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "9";
        //}

        //public void zero_Click(object sender, RoutedEventArgs e)
        //{
        //    AnswerBox.Text += "0";
        //}

        //public void backspace_Click(object sender, RoutedEventArgs e)
        //{
        //    if (AnswerBox.Text.Length == 0)
        //        return;
        //    else
        //        AnswerBox.Text = AnswerBox.Text.Remove(AnswerBox.Text.Length - 1);
        //}

        public void update()
        {
            top = getBotNum(26);
            bot = getBotNum(26);

            solution = top + bot;

            TopNum.Text = top.ToString();
            BottomNum.Text = bot.ToString();
        }

        
    } 
}
