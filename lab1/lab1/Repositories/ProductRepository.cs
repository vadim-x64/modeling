using lab1.Interfaces;
using lab1.Models;

namespace lab1.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>();

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Remove(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public Product FindById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> FindByName(string name)
        {
            return _products.Where(p => p.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void PrintAll()
        {
            foreach (var p in _products)
            {
                Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Count: {p.Count}");
            }
        }
    }
}