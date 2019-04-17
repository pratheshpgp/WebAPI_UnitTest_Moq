using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UnitTest.Models;

namespace UnitTest.Controllers
{
    public class SimpleProductController : ApiController
    {
        List<Product> products = new List<Product>();

        public SimpleProductController()
        {
        }
        public SimpleProductController(List<Product> product)
        {
            this.products = product;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
    }
}
