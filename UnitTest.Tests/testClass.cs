using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Controllers;
using UnitTest.Models;

namespace UnitTest.Tests
{
    [TestClass]
    public class testClass
    {
        [TestMethod]
        public void GetAllProducts()
        {
            var testProduct = GetTestProducts();

            var controller = new SimpleProductController(testProduct);

            var result = controller.GetAllProducts() as List<Product>;
            Assert.AreEqual(testProduct.Count, result.Count);
        }


        private List<Product> GetTestProducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { id = 1, productName = "Demo1" });
            testProducts.Add(new Product { id = 2, productName = "Demo2"});
            testProducts.Add(new Product { id = 3, productName = "Demo3" });
            testProducts.Add(new Product { id = 4, productName = "Demo4" });

            return testProducts;
        }

        [TestMethod]
        public void testMoq ()
        {
            var mock = new Mock<IGetDataRepository>();

            mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");
            MoqController home = new MoqController(mock.Object);

            string result = home.GetNameById(1);
            Assert.AreEqual("Jignesh", result);

        }


    }
}
