namespace lab1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public Order(int id, DateTime date)
        {
            Id = id;
            Date = date;
            OrderProducts = new List<OrderProduct>();
        }
    }
}