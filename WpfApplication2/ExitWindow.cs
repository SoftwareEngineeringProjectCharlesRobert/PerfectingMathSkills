using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApplication2
{
    public class ExitWindow
    {
        Grid grid2 = new Grid();
        Window exit = new Window();
        TextBlock goodjob = new TextBlock();
        TextBlock right = new TextBlock();
        TextBlock attempted = new TextBlock();

        public ExitWindow(int correct, int attempts)
        {
            
            exit.Background = Brushes.Fuchsia;
            exit.WindowState = WindowState.Maximized;


            goodjob.Background = Brushes.Fuchsia;
            goodjob.Text = "GOOD JOB!!";
            goodjob.FontFamily = new FontFamily("Cooper Black");
            goodjob.FontSize = 100;
            goodjob.Height = 110;
            goodjob.Width = 550;
            goodjob.VerticalAlignment = VerticalAlignment.Top;
            goodjob.HorizontalAlignment = HorizontalAlignment.Center;

            right.Background = Brushes.Fuchsia;
            right.Text = "You got this many correct! \n" + correct.ToString();
            right.FontFamily = new FontFamily("Cooper Black");
            right.FontSize = 100;
            right.Height = 220;
            right.Width = 1500;
            right.TextAlignment = TextAlignment.Center;
            right.VerticalAlignment = VerticalAlignment.Center;
            right.HorizontalAlignment = HorizontalAlignment.Center;
            
            attempted.Background = Brushes.Fuchsia;
            attempted.Text = "You attempted this many! \n" + attempts.ToString();
            attempted.FontSize = 100;
            attempted.FontFamily = new FontFamily("Cooper Black");
            attempted.Height = 220;
            attempted.Width = 1500;
            attempted.TextAlignment = TextAlignment.Center;
            attempted.VerticalAlignment = VerticalAlignment.Bottom;
            attempted.HorizontalAlignment = HorizontalAlignment.Center;

            grid2.Children.Add(goodjob);
            grid2.Children.Add(right);
            grid2.Children.Add(attempted);

            exit.Content = grid2;
            exit.Show();
            exit.Closed += Exit_Closed;

        }

        private void Exit_Closed(object sender, EventArgs e)
        {
            exit.Close();
        }
    }
}
