using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        public class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public int Day { get; set; }
        }

        public class BookDbContext : DbContext
        {
            public DbSet<Book> Books { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}
