using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Book
    {
        #region Property
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        #endregion

        #region Constructor
        public Book(string _ISBN, string _Title,string[] _Authors, DateTime _PublicationDate,decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        #endregion

        #region Method
        public override string ToString() => $"Title: {Title}, ISBN: {ISBN}, Authors: {string.Join(", ", Authors)}, Published: {PublicationDate:yyyy-MM-dd}, Price: {Price}";
        
        #endregion
    }
}
