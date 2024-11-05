using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member : User
    {
        private List<Book> books;
        public Member(string name) : base(name)
        {
            books = new List<Book>();
        }

        public void Borrow(Book book)
        {
            if(books.Count < 3)
            {
                books.Add(book);
                book.ChangeAvailability();
                Console.WriteLine("book borrowed");
            }
            else
            {
                Console.WriteLine("book is not available");
            }
        }

        public void Return(Book book)
        {
            books.Remove(book);
            book.ChangeAvailability();
            Console.WriteLine("book returned");
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + $", Borrowed Books Count: {books.Count}";
        }
    }
}
