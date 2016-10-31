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
        private int solution;
        private int userAnswer;
        private Window addition = new Window();

        private Grid addWindowGrid = new Grid { };
        private TextBlock TopNum = new TextBlock { };
        private TextBlock BottomNum = new TextBlock { };
        private TextBlock Symbol = new TextBlock();
        private TextBox AnswerBox = new TextBox();

        private Button Enter = new Button { };


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

           /*Button num1 = new Button { };
            Button num2 = new Button { };
            Button num3 = new Button { };
            Button num4 = new Button { };
            Button num5 = new Button { };
            Button num6 = new Button { };
            Button num7 = new Button { };
            Button num8 = new Button { };
            Button num9 = new Button { };*/

            Button backspace = new Button { };
            Button clear = new Button { };



            /*num1.Background = Brushes.Black;
            num1.Content += "1";
            num1.FontFamily = new FontFamily("Cooper Black");
            num1.FontSize = 100;
            num1.Foreground = Brushes.White;


            num2.Background = Brushes.Black;
            num2.Content += "2";
            num2.FontSize = 100;
            num2.FontFamily = new FontFamily("Cooper Black");
            num2.Foreground = Brushes.White;

            num3.Background = Brushes.Black;
            num3.Content += "3";
            num3.FontSize = 100;
            num3.FontFamily = new FontFamily("Cooper Black");
            num3.Foreground = Brushes.White;

            num4.Background = Brushes.Black;
            num4.Content += "4";
            num4.FontSize = 100;
            num4.FontFamily = new FontFamily("Cooper Black");
            num4.Foreground = Brushes.White;

            num5.Background = Brushes.Black;
            num5.Content += "5";
            num5.FontSize = 100;
            num5.FontFamily = new FontFamily("Cooper Black");
            num5.Foreground = Brushes.White;

            num6.Background = Brushes.Black;
            num6.Content += "6";
            num6.FontSize = 100;
            num6.FontFamily = new FontFamily("Cooper Black");
            num6.Foreground = Brushes.White;

            num7.Background = Brushes.Black;
            num7.Content += "7";
            num7.FontSize = 100;
            num7.FontFamily = new FontFamily("Cooper Black");
            num7.Foreground = Brushes.White;

            num8.Background = Brushes.Black;
            num8.Content += "8";
            num8.FontSize = 100;
            num8.FontFamily = new FontFamily("Cooper Black");
            num8.Foreground = Brushes.White;

            num9.Background = Brushes.Black;
            num9.Content += "9";
            num9.FontSize = 100;
            num9.FontFamily = new FontFamily("Cooper Black");
            num9.Foreground = Brushes.White;

            numberPad.Children.Add(num1);
            numberPad.Children.Add(num2);
            numberPad.Children.Add(num3);
            numberPad.Children.Add(num4);
            numberPad.Children.Add(num5);
            numberPad.Children.Add(num6);
            numberPad.Children.Add(num7);
            numberPad.Children.Add(num8);
            numberPad.Children.Add(num9);*/

            Button num;
            int i = 0;

            for(int row = 0; row < numberPad.RowDefinitions.Count - 1; row++)
            {
                for(int col = 0; col < numberPad.ColumnDefinitions.Count; col++)
                {
                    i++;
                    num = new Button();
                    num.Width = 150;
                    num.Height = 150;
                    num.Content = i.ToString();

                    num.Background = Brushes.Black;
                    num.Foreground = Brushes.White;
                    num.FontFamily = new FontFamily("Cooper Black");
                    num.FontSize = 100;
                    num.HorizontalAlignment = HorizontalAlignment.Center;
                    num.VerticalAlignment = VerticalAlignment.Center;

                    num.SetValue(Grid.ColumnProperty, col);
                    num.SetValue(Grid.RowProperty, row);

                    numberPad.Children.Add(num);
                }
            }

            return numberPad;
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

           
            Enter.Content = "Enter";
            Enter.FontSize = 100;
            Enter.Height = 120;
            Enter.Width = 300;
            Enter.FontFamily = new FontFamily("Cooper Black");
            Enter.Margin = new Thickness(475, 650, 75, 0);
            Enter.Background = Brushes.LimeGreen;

            /*Grid buttonGrid = new Grid();
            ColumnDefinition col1 = new ColumnDefinition();
            col1.Width = GridLength.Auto;
            ColumnDefinition col2 = new ColumnDefinition();
            col2.Width = GridLength.Auto;
            ColumnDefinition col3 = new ColumnDefinition();
            col3.Width = GridLength.Auto;

            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            RowDefinition row4 = new RowDefinition();

            buttonGrid.ColumnDefinitions.Add(col1);
            buttonGrid.ColumnDefinitions.Add(col2);
            buttonGrid.ColumnDefinitions.Add(col3);

            addWindowGrid.Children.Add(buttonGrid);*/

            Grid numberPad = numpad();

            addWindowGrid.Children.Add(numberPad);
            addWindowGrid.Children.Add(BottomNum);
            addWindowGrid.Children.Add(TopNum);
            addWindowGrid.Children.Add(Symbol);
            addWindowGrid.Children.Add(AnswerBox);
            addWindowGrid.Children.Add(Enter);
            addition.Content = addWindowGrid;
            addition.Show();

            Enter.Click += Button_Click;
            AnswerBox.KeyDown += Window_KeyDown;//new RoutedEventHandler(Button_Click);
        }
    } 
}
