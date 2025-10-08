
namespace lab2.Models
{
    public class Reader
    {
        public int ReaderId { get; set; }
        public string Name { get; set; }

        public Reader(int readerId, string name)
        {
            ReaderId = readerId;
            Name = name;
        }
    }
}