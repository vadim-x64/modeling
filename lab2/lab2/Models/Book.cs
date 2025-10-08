
namespace lab2.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public Category Category { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();

        public Book(int bookId, string title, int publishedYear, Category category)
        {
            BookId = bookId;
            Title = title;
            PublishedYear = publishedYear;
            Category = category;
        }
    }
}