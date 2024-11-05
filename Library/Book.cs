using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private static int _booksCounter = 0;
        private int Id { get; }
        private string Name { get; set; }
        private string Author { get; set; }
        private bool IsAvailable { get; set; }

        public Book(string name, string author)
        {
            Id = _booksCounter++;
            Name = name;
            Author = author;
            IsAvailable = true;
        }

        public void ChangeAvailability()
        {
            this.IsAvailable = !this.IsAvailable;
        }
    }
}
