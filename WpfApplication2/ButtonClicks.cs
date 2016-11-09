using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication2
{
    public class ButtonClicks
    {

        public ButtonClicks() { }
            public void one_Click(object sender, RoutedEventArgs e)
        {
            AnswerBox.Text += "1";
        }

        public void two_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "2";
        }

        public void three_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "3";
        }

        public void four_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "4";
        }

        public void five_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "5";
        }

        public void six_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "6";
        }

        public void seven_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "7";
        }

        public void eight_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "8";
        }

        public void nine_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "9";
        }

        public void zero_Click(object sender, RoutedEventArgs e)
        {
            use.AnswerBox.Text += "0";
        }

        public void backspace_Click(object sender, RoutedEventArgs e)
        {
            if (use.AnswerBox.Text.Length == 0)
                return;
            else
                use.AnswerBox.Text = use.AnswerBox.Text.Remove(use.AnswerBox.Text.Length - 1);
        }

        public void Next_EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Next_Click(this, new RoutedEventArgs());
            }
        }

        public void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Button_Click(this, new RoutedEventArgs());
            }

        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (use.AnswerBox.Text.Length > 0)
                use.Check_Window();
            return;
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Windows[Application.Current.Windows.Count - 1].Close();
        }

        public void Next_Click(object sender, RoutedEventArgs e)
        {
            use.update();
            use.correct.Close();
            use.AnswerBox.Clear();
        }
    }
}


