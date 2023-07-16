using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Assignment_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new AddStudent();
            DataContext = new MainWindowAS();
            InitializeComponent();
        }

        private void Border_MouseDown(Object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (IsMaximized)
            {
                this.WindowState = WindowState.Normal;
                this.Width = 1080;
                this.Height = 720;
                IsMaximized = false;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                IsMaximized = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.ruh.ac.lk/index.php/en/");
        }

        private void Button_Click2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://m.facebook.com/universityofruhunasl");
        }

        private void Button_Click3(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/ruhunion");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Dash.Visibility == Visibility.Visible)
            {
                Dash.Visibility = Visibility.Collapsed;
            }
            else
            {
                Dash.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Dashboard.Visibility == Visibility.Visible)
            {
                Dashboard.Visibility = Visibility.Collapsed;
            }
            else
            {
                Dashboard.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (NotificationView.Visibility == Visibility.Visible)
            {
                NotificationView.Visibility = Visibility.Collapsed;
            }
            else
            {
                NotificationView.Visibility = Visibility.Visible;
            }
        }
    }
}