using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace W9A_CodeFirstDemo
{
    class CollegeDBContext: DbContext
    {
        //  classes that need to be saved in Db to be included here as props

        public DbSet<Course> Courses { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        //  install-package Microsoft.EntityFrameworkCore.SqlServer

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info= False;Initial Catalog=CollegeDatabase;
                Data Source=DESKTOP-7082PM8\STEPHENBRIMERSQL"
            );
        }

        

    }
}
