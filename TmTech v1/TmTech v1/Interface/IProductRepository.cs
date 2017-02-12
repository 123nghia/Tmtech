using System.Collections.Generic;
using TmTech_v1.Model;

namespace TmTech_v1.Interface
{
    public interface IProductRepository
    {
        void Add(Product entity);
        List<Product> All();
        Product Find(int id);
        void Remove(int id);
        void Remove(Product entity);
        void Update(Product entity);
    }
}
