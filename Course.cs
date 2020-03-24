using System;
using System.Collections.Generic;
using System.Text;

namespace W9A_CodeFirstDemo
{
    class Course
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public Book Book { get; set; }  // navigation property


    }
}
