using System;
using System.Collections.Generic;
using System.Text;

namespace StephenBrimer_Assignment2
{
    class Course
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public Book Book { get; set; }  // navigation property


    }
}
