using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;

namespace API_Interactive_Lab_1.Tests.Controllers
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffeeObject()
        {

            Coffee expected = new Coffee();
            expected.Name = "cappecino";
            expected.Id = 1;

            var controller = new CoffeeController();
            var result = controller.Get("cappecino");
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Name, result.Name);
        }

        [Test]
        public void TestGetCoffee()
        {

            string expectedContent = "I love coffee!";


            var controller = new CoffeeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }
    }
}
