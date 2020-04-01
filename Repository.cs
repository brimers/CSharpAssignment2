using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;


namespace StephenBrimer_Assignment2
{
    class Repository
    {

        private static CollegeDBContext _collegeDatabase = new CollegeDBContext();

        public void AddBook(string title, string isbn, string authorName)
        {

            var author = GetAuthor(authorName);


            if (author == null)
            {
                author = new Author { Name = authorName };

            }

            var book = new Book
            {
                Title = title,
                Author = author,
                Isbn = isbn
            };

            var result = _collegeDatabase.Books.Where(b => b.Title.ToLower().Contains(title.ToLower()));
            if (result == null)
            {
                throw new Exception("Title already exists");
            }
            else
            {
                _collegeDatabase.Books.Add(book);
                //todo: here
                _collegeDatabase.SaveChanges();
            }

        }

        public void AddCourse(string title)
        {

            // not sure how to do if stmnt
            if (_collegeDatabase.Books.FirstOrDefault(b => b.Title.Equals(title)) != null)
            {
                throw new Exception("Course alreayd exists");
            }
            var course = new Course()
            {
                Title = title
            };

            _collegeDatabase.Courses.Add(course);
            _collegeDatabase.SaveChanges();

        }

        public Course GetCourseByTitle(string title)
        {
            var result = _collegeDatabase.Courses.FirstOrDefault(b => b.Title.ToLower().Contains(title.ToLower()));

            return result;
        }

        public List<Book> GetAllBooks()
        {

            var books = _collegeDatabase.Books;
            List<Book> result = new List<Book>();

            foreach (var book in books)
            {
                result.Add(book);
            }

            return result;
        }

        public void AssignBookToCourse(string bookTitle, string courseTitle)
        {

            var book = _collegeDatabase.Books.FirstOrDefault(b => b.Title.Equals(bookTitle));
            var course = _collegeDatabase.Courses.FirstOrDefault(c => c.Title.Equals(courseTitle));

            course.Book = book;

            _collegeDatabase.SaveChanges();

        }

        public Author GetAuthor(string name)
        {
            return _collegeDatabase.Authors.FirstOrDefault((a => a.Name.Equals(name)));
        }
    }
}
