using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using angularjs_webapi.api.Models;

namespace angularjs_webapi.api.Data
{
    public class FakeDb
    {
        private readonly List<Product> productList;

        private static readonly Lazy<FakeDb> Lazy = new Lazy<FakeDb>(() => new FakeDb());

        public static FakeDb Instance => Lazy.Value;

        private FakeDb()
        {
            productList = new List<Product>
                          {
                              new Product
                              {
                                  Id = 1,
                                  Name = "Product 1",
                                  Active = true
                              },
                              new Product
                              {
                                  Id = 2,
                                  Name = "Product 2",
                                  Active = true
                              }
                          };
        }

        public void Add(Product newProduct)
        {
            productList.Add(newProduct);
        }

        public void Remove(int productId)
        {
            var productToRemove = productList.Single(x => x.Id == productId);
            productList.Remove(productToRemove);
        }

        public Product Get(int productId)
        {
            return productList.Find(x => x.Id == productId);
        }

        public List<Product> GetAll()
        {
            return productList;
        }

        public bool Update(Product product)
        {
            var productToUpdate = productList.Single(x => x.Id == product.Id);

            productToUpdate.Name = product.Name;
            productToUpdate.Active = product.Active;

            return true;
        }
    }
}