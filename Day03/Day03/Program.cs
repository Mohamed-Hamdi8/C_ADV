namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Book> books = new List<Book>
            //{
            //new Book("978-1617294532", "C# in Depth",["Jon Skeet"],
            //         new DateTime(2019, 3, 23), 45.50m),

            //new Book("978-0132350884", "Clean Code",["Robert C. Martin"],
            //         new DateTime(2008, 8, 1), 37.99m)
            //};

            ///a. User Defined Delegate Datatype
            ///Console.WriteLine("=== User Defined Delegate ===");
            ///LibraryEngine.ProcessBooksDelegate(books, new BookDelegate(BookFunctions.GetTitle));
            ///Console.WriteLine();

            ///b. BCL Delegates
            ///Console.WriteLine("=== BCL Delegates (Func<Book,string>) ===");
            ///LibraryEngine.ProcessBooksFunc(books, new Func<Book,string>(BookFunctions.GetAuthors));
            ///Console.WriteLine();

            ///c. Anonymous Method (GetISBN)
            ///Console.WriteLine("\n=== Anonymous Method (GetISBN) ===");
            ///LibraryEngine.ProcessBooksFunc(books, delegate (Book b) { return b.ISBN; });
            ///Console.WriteLine();

            ///d. Lambda Expression (GetPublicationDate)
            ///Console.WriteLine("\n=== Lambda Expression (GetPublicationDate) ===");
            ///LibraryEngine.ProcessBooksFunc(books, b => b.PublicationDate.ToShortDateString());

        }
    }
}
