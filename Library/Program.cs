using Library;

class Program
{
    static void Main(string[] args)
    {
        List<Book> library = new List<Book>();
        Librarian librarian = new Librarian("Moshe");
        Console.WriteLine(librarian.DisplayInfo());
        Book book1 = new Book("50/50", "Dvory Rand");
        Book book2 = new Book("Aleha Hashalom", "Dvory Rand");
        librarian.AddBook(library, book1);
        librarian.AddBook(library, book2);
        Member member = new Member("Yehudit");
        Console.WriteLine(member.DisplayInfo());
        member.Borrow(book1);
        Console.WriteLine(member.DisplayInfo());
        member.Return(book1);
    }
}
