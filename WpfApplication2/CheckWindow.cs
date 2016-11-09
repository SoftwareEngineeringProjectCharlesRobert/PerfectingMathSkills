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
    class CheckWindow : AddWindow
    {
        public CheckWindow()
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
                next.Click += Next_Click;

                cGrid.Children.Add(next);
                cGrid.Children.Add(right);
                correct.Content = cGrid;
                correct.Show();

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
                back.Click += Back_Click;

                cGrid.Children.Add(back);
                cGrid.Children.Add(wrong);
                incorrect.Content = cGrid;
                incorrect.Show();
                AnswerBox.Clear();
            }
        }
    }
}
