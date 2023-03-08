using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double first;
        double second;
        char op;
        public MainWindow()
        {
            InitializeComponent();
            foreach(UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    //((Button)el).Click += Button_Click;
                }
            }
        }
           
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (op == 'n' || op == '=')
            //    return;
            Button btn = (Button)sender;
            if (TextLabel.Text == "0")
                TextLabel.Text = btn.Content.ToString();
            else 
                TextLabel.Text += btn.Content.ToString();
        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextLabel.Text == "")
            {
                op = 'n';
                return;
            }
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
                ;
            else
                first = Double.Parse(TextLabel.Text);
            op = '/';
            TextLabel.Text = "/";
        }
     
        private void SubButtomClick(object sender, RoutedEventArgs e)
        {
            if (TextLabel.Text == "")
            {
                op = 'n';
                return;
            }
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
                ;
            else
                first = Double.Parse(TextLabel.Text);
            op = '-';
            TextLabel.Text = "-";
        }
        private void AddButtomClick(object sender, RoutedEventArgs e)
        {
            if (TextLabel.Text == "")
            {
                op = 'n';
                return;
            }
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
                ;
            else
                first = Double.Parse(TextLabel.Text);
            op = '+';
            TextLabel.Text = "+";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double result = 0;
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
            {
                if (TextLabel.Text == "+")
                    result = first + first;
                if (TextLabel.Text == "-")
                    result = first - first;
                if (TextLabel.Text == "*")
                    result = first * first;
                if (TextLabel.Text == "/")
                    result = first / first;
                TextLabel.Text = result.ToString();
                return;
            }
            
            if (TextLabel.Text == "")
                return;
            else second = Double.Parse(TextLabel.Text);
           
            TextLabel.Text = "";

            if (op == '+')
                result = first + second;
            else if (op == '-')
                result = first - second;
            else if (op == '*')
                result = first * second;
            else if (op == '/')
                result = first / second;
            if (TextLabel.Text == "0")
                TextLabel.Text = "";
            first = result;
            op = '='; 
            TextLabel.Text = result.ToString();

        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextLabel.Text == "")
            {
                op = 'n';
                return;
            }
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
                ;
            else
                first = Double.Parse(TextLabel.Text);
            op = '*';
            TextLabel.Text = "*";
        }

        private void buttonNumClick(object sender, RoutedEventArgs e)
        {
            if (TextLabel.Text == "+" || TextLabel.Text == "-" || TextLabel.Text == "*" || TextLabel.Text == "/")
                TextLabel.Text = "";
            Button btn = (Button)sender;

            if (TextLabel.Text == "0")
            {
                if (btn.Content.ToString() == "0")
                    return;
                else
                    TextLabel.Text = btn.Content.ToString();
            }
            else
                TextLabel.Text += btn.Content.ToString();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            TextLabel.Text = "";
        }
    }
}
