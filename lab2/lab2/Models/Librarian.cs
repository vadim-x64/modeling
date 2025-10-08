
namespace lab2.Models
{
    public class Librarian
    {
        public int LibrarianId { get; set; }
        public string Name { get; set; }

        public Librarian(int librarianId, string name)
        {
            LibrarianId = librarianId;
            Name = name;
        }
    }
}