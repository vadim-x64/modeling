using lab1.Interfaces;
using lab1.Models;
using lab1.Repositories;

namespace lab1
{
    public class Program
    {
        public static void Main()
        {
            IProductRepository products = new ProductRepository();

            Category category1 = new Category(1, "Drinks");
            Category category2 = new Category(2, "Pizza");
            Category category3 = new Category(3, "Burgers");
            Category category4 = new Category(4, "Salads");

            Product product1 = new Product(1, "Coca-Cola", 15.25m, 100);
            Product product2 = new Product(2, "Carbonara", 55.00m, 50);
            Product product3 = new Product(3, "Cheeseburger", 45.00m, 70);
            Product product4 = new Product(4, "Salad", 45.00m, 70);
            Product product5 = new Product(5, "New York", 45.00m, 70);
            
            category1.Products.Add(product1);
            category2.Products.Add(product2);
            category2.Products.Add(product5);
            category3.Products.Add(product3);
            category4.Products.Add(product4);
            
            product1.Categories.Add(category1);
            product2.Categories.Add(category2);
            product3.Categories.Add(category3);
            product4.Categories.Add(category4);
            product5.Categories.Add(category2);

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);

            Console.WriteLine("Вся продукція:");
            products.PrintAll();

            Console.WriteLine("\nПошук продукту по назві 'New York':");
            
            var found = products.FindByName("New York");
            
            foreach (var p in found)
            {
                Console.WriteLine($"Знайдено: {p.Name} ({p.Price} грн)");
            }

            Console.WriteLine("\nВидаляємо продукт...");
            products.Remove(5);

            Console.WriteLine("\nВся продукція після видалення:");
            products.PrintAll();

            Order order1 = new Order(1, DateTime.Now);
            order1.OrderProducts.Add(new OrderProduct { Order = order1, Product = product1, Quantity = 2 });
            order1.OrderProducts.Add(new OrderProduct { Order = order1, Product = product2, Quantity = 1 });
            order1.OrderProducts.Add(new OrderProduct { Order = order1, Product = product4, Quantity = 1 });

            Console.WriteLine("\nВаше замовлення:");

            decimal total = 0;

            foreach (var op in order1.OrderProducts)
            {
                decimal writeTotal = op.Product.Price * op.Quantity;
                Console.WriteLine($"{op.Product.Name} x {op.Quantity} = {op.Product.Price * op.Quantity} грн");
                total += writeTotal;
            }

            Console.WriteLine($"Загальна вартість: {total} грн");
        }
    }
}