
namespace lab2.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Author(int authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }
}