using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : Member
    {
        public string Name { get; set; }
        public Librarian(string name) : base(name) { }

        /*public void Borrow(Book book, Member member)
        {
            member.Borrow(book);
        }

        public void Return(Book book, Member member)
        {
            member.Return(book);
        }*/

        public void AddBook(List<Book> library, Book book)
        {
            library.Add(book);
            Console.WriteLine("book added");
        }
        public void RemoveBook(List<Book> library, Book book)
        {
            library.Remove(book);
            Console.WriteLine("book removed");
        }

        public override string DisplayInfo()
        {
            return base.DisplayInfo() + " Librarian";
        }
    }
}
