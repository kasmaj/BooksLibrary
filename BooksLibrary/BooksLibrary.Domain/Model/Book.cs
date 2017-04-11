namespace BooksLibrary.Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Language { get; set; }
        public int YearOfPublishing { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
    }
}
