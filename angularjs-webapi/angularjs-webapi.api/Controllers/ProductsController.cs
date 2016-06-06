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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
