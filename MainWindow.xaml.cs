using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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

namespace StephenBrimer_Assignment2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Repository _repo = new Repository();
        public MainWindow()
        {
            InitializeComponent();
        }


        // click event for adding book
        private void Button_AddBook_OnClick(object sender, RoutedEventArgs e)
        {
            _repo.AddBook(BookTitle_AddBook.Text, Isbn_AddBook.Text, AuthorName_AddBook.Text);
        }

        //  click event for adding a course
        private void Button_AddCourse_OnClick(object sender, RoutedEventArgs e)
        {
            _repo.AddCourse(CourseTitle_AddCourse.Text);
        }

        // click event for assigning a book to a course
        private void Button_AssBookToCourse_OnClick(object sender, RoutedEventArgs e)
        {
            _repo.AssignBookToCourse(BookTitle_AssBookToCourse.Text, CourseTitle_AssBookToCourse.Text);
        }

        //  click event for Show Course
        private void Button_ShowCourse_OnClick(object sender, RoutedEventArgs e)
        {
            
            Course c1 = _repo.GetCourseByTitle(CourseTitle_ShowCourse.Text);

            string message = "Course Name:\t" + c1.Title + "\nCourse Textbook:\t" + c1.Book.Title;
            MessageBox.Show(message);

        }
    }
}
