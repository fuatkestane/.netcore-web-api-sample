using System.Collections.Generic;

namespace NetCoreWebApi.Model
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfBooksOfInterest { get { return booksOfInterest.Count; } }

        public ICollection<BooksOfInterest> booksOfInterest { get; set; } = new List<BooksOfInterest>();
    }
}