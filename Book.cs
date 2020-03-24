using System;
using System.Collections.Generic;
using System.Text;

namespace W9A_CodeFirstDemo
{
    class Book
    {

        public int Id { get; set; } // primary key for table. VS will autorecognize this. OR **className**Id

        public string Title { get; set; }

        public string Isbn { get; set; }

        public Author Author { get; set; }  //  navigation property
    }
}
