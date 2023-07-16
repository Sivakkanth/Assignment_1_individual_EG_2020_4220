using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Assignment_1.Models
{
    public class User
    {
        public float Age
        {
            get;
            set;
        }
        public string Firstname
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public BitmapImage Image
        {
            get;
            set;
        }
        public string Dateofbirth
        {
            get;
            set;
        }
        public double GPA
        {
            get;
            set;
        }
        public string Imagepath
        {
            get { return $"C:\\Users\\sivak\\Desktop\\Indivudal\\Assignment_1\\Assignment_1\\Models\\icon\\{Image}"; }

        }
        
        public User(float age, string firstname, string lastname, string dateofbirth, double gpa, BitmapImage image)
        {
            Age = age;
            Firstname = firstname;
            Lastname = lastname;
            Dateofbirth = dateofbirth;
            GPA = gpa;
            Image = image;
        }
        public User()
        { 
        }
    }
}