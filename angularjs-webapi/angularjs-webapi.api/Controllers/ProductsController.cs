using System.Collections.Generic;
using System.Net;
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
        [HttpGet]
        public IHttpActionResult Get()
        {
            var products = productRepository.GetAll();

            if (products == null)
            {
                return NotFound();
            }

            return Ok<IEnumerable<Product>>(products);
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            var product = productRepository.Get(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // POST: api/Products
        [HttpPost]
        public IHttpActionResult Post(Product product)
        {
            var result = productRepository.Add(product);

            if (result == null)
            {
                return InternalServerError();
            }

            return Created(string.Empty, result);
        }

        // PUT: api/Products/5
        [HttpPut]
        public IHttpActionResult Put(Product product)
        {
            if (!productRepository.Update(product))
            {
                return StatusCode(HttpStatusCode.NotModified);
            }

            return Ok();
        }

        // DELETE: api/Products/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var product = productRepository.Get(id);
            if (product == null)
            {
                return NotFound();
            }
            productRepository.Remove(id);

            return Ok();
        }
    }
}
