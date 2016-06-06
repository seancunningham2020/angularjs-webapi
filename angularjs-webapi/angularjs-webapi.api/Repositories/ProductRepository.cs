using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using angularjs_webapi.api.Data;
using angularjs_webapi.api.Models;

namespace angularjs_webapi.api.Repositories
{
    public class ProductRepository
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
    }
}