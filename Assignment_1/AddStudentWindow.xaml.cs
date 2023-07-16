using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Assignment_1
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow(AddStudent AS)
        {
            InitializeComponent();
            DataContext = AS;
            AS.closeaction = () => Close();
        }

        public AddStudentWindow()
        {
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btnMinimize_Click(Object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUser.Focus();
        }
        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUser.Text) && txtUser.Text.Length > 0)
            {
                textUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUsername.Visibility = Visibility.Visible;
            }
        }

        private void textlastname_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtlast.Focus();
        }
        private void txtlastname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtlast.Text) && txtlast.Text.Length > 0)
            {
                textlastname.Visibility = Visibility.Collapsed;
            }
            else
            {
                textlastname.Visibility = Visibility.Visible;
            }
        }

        private void textage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtage.Focus();
        }
        private void txtage_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtage.Text) && txtage.Text.Length > 0)
            {
                textage.Visibility = Visibility.Collapsed;
            }
            else
            {
                textage.Visibility = Visibility.Visible;
            }
        }

        private void textgpa_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtgpa.Focus();
        }
        private void txtgpa_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtgpa.Text) && txtgpa.Text.Length > 0)
            {
                textgpa.Visibility = Visibility.Collapsed;
            }
            else
            {
                textgpa.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtUser.Clear();
            txtlast.Clear();
            txtage.Clear();
            txtgpa.Clear();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            var a = new MainWindow();
            a.Show();
        }
    }
}