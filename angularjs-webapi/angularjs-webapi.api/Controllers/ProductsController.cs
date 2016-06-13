using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using angularjs_webapi.api.Models;
using angularjs_webapi.api.Repositories;

namespace angularjs_webapi.api.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAll();
        }

        // GET: api/Products/5
        public Product Get(int id)
        {
            return productRepository.Get(id);
        }

        // POST: api/Products
        [HttpPost]
        public Product Post(Product product)
        {
            return productRepository.Add(product);
        }

        // PUT: api/Products/5
        public void Put([FromBody]Product product)
        {
            if (!productRepository.Update(product))
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            var product = productRepository.Get(id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            productRepository.Remove(id);
        }
    }
}
