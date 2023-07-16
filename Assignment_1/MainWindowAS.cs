using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Assignment_1
{
    public partial class MainWindowAS : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<User> users;

        [ObservableProperty]
        public User selectedUser = null;

        public void CloseMainWindow()
        {
            Application.Current.MainWindow.Close();
        }

        [RelayCommand]
        public void message()
        {
            MessageBox.Show($"{selectedUser.Firstname} GPA value must be between 0 and 4.0", "Error");
        }

        [RelayCommand]
        public void Addstudent()
        {
            var AS = new AddStudent();
            AS.title = "ADD STUDENT";
            AddStudentWindow window = new AddStudentWindow(AS);
            window.ShowDialog();

            if (AS.Student.Firstname != null)
            {
                users.Add(AS.Student);
            }
        }

        [RelayCommand]
        public void delete()
        {
            if(selectedUser != null)
            {
                string name = selectedUser.Firstname;
                users.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a");
            }
            else
            {
                MessageBox.Show("Please selecte student before delete.", "Error");
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if(selectedUser != null)
            {
                var AS = new AddStudent(selectedUser);
                AS.title = "EDIT USER";
                var window = new AddStudentWindow(AS);
                window.ShowDialog();
                int index = users.IndexOf(selectedUser);
                users.RemoveAt(index);
                users.Insert(index, AS.Student);
            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        public MainWindowAS()
        {
            users = new ObservableCollection<User>();
            BitmapImage image1 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\1.png", UriKind.Relative));
            users.Add(new User(12, "Kamal", "Murugan", "07/06/2023", 3.052, image1));
            BitmapImage image2 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\10.png", UriKind.Relative));
            users.Add(new User(19, "Vishva", "Paandi", "28/01/2004", 2.065, image2));
            BitmapImage image3 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\2.png", UriKind.Relative));
            users.Add(new User(24, "Kumar", "Sellan", "12/09/1999", 1.052, image3));
            BitmapImage image4 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\3.png", UriKind.Relative));
            users.Add(new User(20, "Suntharam", "Kanapathy", "18/10/2003", 2.980, image4));
            BitmapImage image5 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\4.png", UriKind.Relative));
            users.Add(new User(12, "Kamal", "Murugan", "18/09/2011", 3.052, image1));
            BitmapImage image6 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\5.png", UriKind.Relative));
            users.Add(new User(19, "Vishva", "Paandi", "28/01/2004", 2.957, image2));
            BitmapImage image7 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\6.png", UriKind.Relative));
            users.Add(new User(24, "Kumar", "Sellan", "12/09/1999", 2.701, image3));
            BitmapImage image8 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\4.png", UriKind.Relative));
            users.Add(new User(20, "Suntharam", "Kanapathy", "18/10/2003", 3.042, image4));
            BitmapImage image9 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\3.png", UriKind.Relative));
            users.Add(new User(12, "Kamal", "Murugan", "18/09/2011", 3.952, image1));
            BitmapImage image10 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\2.png", UriKind.Relative));
            users.Add(new User(19, "Vishva", "Paandi", "28/01/2004", 1.022, image2));
            BitmapImage image12 = new BitmapImage(new Uri("C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\1.png", UriKind.Relative));
            users.Add(new User(20, "Suntharam", "Kanapathy", "18/10/2003", 2.650, image4));
        }
    }
}