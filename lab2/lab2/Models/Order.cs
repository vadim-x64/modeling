
namespace lab2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Reader Reader { get; set; }
        public Librarian Librarian { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();

        public Order(int orderId, DateTime orderDate, DateTime returnDate, Reader reader, Librarian librarian)
        {
            OrderId = orderId;
            OrderDate = orderDate;
            ReturnDate = returnDate;
            Reader = reader;
            Librarian = librarian;
        }
    }
}