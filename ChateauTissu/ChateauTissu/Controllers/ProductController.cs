using ChateauTissu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChateauTissu.Controllers
{
    public class ProductController : ApiController
    {
        // GET: api/Product
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> productList = new List<ProductModel>();
            for(var i = 0; i < 10; i++)
            {
                productList.Add(new ProductModel($"nom produit { i }", $"id{ i }", $"Couleur { i }", $"Categorie { i }"));
            }
            return productList;
        }

        // GET: api/Product/5
        public ProductModel Get(int id)
        {
            return new ProductModel($"nom produit { id }", $"id{ id }", $"Couleur { id }", $"Categorie { id }");
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
