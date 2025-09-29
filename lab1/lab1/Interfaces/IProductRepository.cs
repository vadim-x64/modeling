using lab1.Models;

namespace lab1.Interfaces
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Remove(int id);
        Product FindById(int id);
        List<Product> FindByName(string name);
        void PrintAll();
    }
}