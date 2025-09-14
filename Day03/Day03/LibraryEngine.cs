using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public delegate string BookDelegate(Book book);
    internal class LibraryEngine
    {
        public static void ProcessBooksDelegate(List<Book> bList, BookDelegate fPtr )
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooksFunc(List<Book> bList, Func<Book,string> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
