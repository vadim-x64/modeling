using lab2.Models;

namespace lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Category category1 = new Category(1, "Класика");
            Category category2 = new Category(2, "Роман");
            Category category3 = new Category(3, "Антиутопія");

            Author author1 = new Author(1, "Ернест Міллер Хемінгуей");
            Author author2 = new Author(2, "Френсіс Скотт Фіцджеральд");
            Author author3 = new Author(3, "Джордж Орвелл");

            Book book1 = new Book(1, "Старий і море", 1952, category2);
            Book book2 = new Book(2, "Великий Гетсбі", 1925, category1);
            Book book3 = new Book(3, "1984", 1949, category3);

            book1.Authors.Add(author1);
            book2.Authors.Add(author2);
            book3.Authors.Add(author3);

            Reader reader = new Reader(1, "Вадим Войцеховський");
            Librarian librarian = new Librarian(1, "Надія Степанівна");

            Order order = new Order(1, DateTime.Now, DateTime.Now.AddDays(14), reader, librarian);
            order.Books.Add(book1);
            order.Books.Add(book2);
            order.Books.Add(book3);

            Console.WriteLine($"********** Інформація про замовлення {order.OrderId} **********\n");

            foreach (var book in order.Books)
            {
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"   Книга: \"{book.Title}\"");
                Console.WriteLine($"   Автор: {string.Join(", ", book.Authors.ConvertAll(a => a.Name))}");
                Console.WriteLine($"   Рік видання: {book.PublishedYear}");
                Console.WriteLine($"   Категорія: {book.Category.Name}");
                Console.WriteLine();
                Console.WriteLine($"   Видана читачу: {order.Reader.Name}");
                Console.WriteLine($"   Оформлено бібліотекарем: {order.Librarian.Name}");
                Console.WriteLine($"   Дата видачі: {order.OrderDate.ToShortDateString()}");
                Console.WriteLine($"   Дата повернення: {order.ReturnDate.ToShortDateString()}");
                Console.WriteLine("--------------------------------------\n");
            }

            Console.ReadLine();
        }
    }
}