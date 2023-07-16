using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Assignment_1.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment_1
{
    public partial class AddStudent : ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public float age;

        [ObservableProperty]
        public string dateofbirth;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public BitmapImage uploadimage;

        public User Student
        {
            get;
            private set;
        }

        public AddStudent(User s)
        {
            Student= s;
            firstname = Student.Firstname;
            lastname = Student.Lastname;
            age = Student.Age;
            gpa = Student.GPA;
            dateofbirth = Student.Dateofbirth;
            uploadimage = Student.Image;
        }
        public AddStudent()
        {
        }

        [RelayCommand]
        public void insertphoto()//To insert the profile picture
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image file | *.bmg; *.png; *.jpg";
            dialog.FilterIndex = 1;
            if (dialog.ShowDialog() == true)
            {
                uploadimage = new BitmapImage(new Uri(dialog.FileName));
                MessageBox.Show("Image successfuly upload!", "Successfull");
            }
        }

        public Action closeaction
        {
            get;
            internal set;
        }

        [RelayCommand]
        public void save()
        {
            if(gpa<0 || gpa>4)
            {
                MessageBox.Show("**Inavlid GPA**GPA value must be between 0 and 4", "Error");
                return;
            }

            if(Student==null)
            {
                Student = new User()
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    Age = age,
                    Dateofbirth = dateofbirth,
                    Image = uploadimage,
                    GPA = gpa
                };
            }
            else
            {
                Student.Firstname = firstname;
                Student.Lastname = lastname;
                Student.Age = age;
                Student.GPA = gpa;
                Student.Image = uploadimage;
                Student.Dateofbirth = dateofbirth;
            }

            if (Student.Firstname == null)
            {
                MessageBox.Show("Please Enter First Name", "Error");
                return;
            }

            if (Student.Lastname == null)
            {
                MessageBox.Show("Please Enter Last Name", "Error");
                return;
            }

            //if (Student.Dateofbirth == null)
            //{
            //    MessageBox.Show("Please Enter Your Date of Birth", "Error");
            //    return;
            //}

            //if (Student.Image == null)
            //{
            //    MessageBox.Show("Please Upload Your Image", "Error");
            //    return;
            //}

            if (Student.Firstname != null)
            {
                closeaction();
            }
            Application.Current.MainWindow.Show();
        }
    }
}