using System.Collections.Generic;
using angularjs_webapi.api.Data;
using angularjs_webapi.api.Models;

namespace angularjs_webapi.api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FakeDb fakeDb = FakeDb.Instance;

        public List<Product> GetAll()
        {
            return fakeDb.GetAll();
        }

        public Product Get(int productId)
        {
            return fakeDb.Get(productId);
        }

        public Product Add(Product product)
        {
            fakeDb.Add(product);

            return product;
        }

        public void Remove(int id)
        {
            fakeDb.Remove(id);
        }

        public bool Update(Product product)
        {
            return fakeDb.Update(product);
        }
    }
}