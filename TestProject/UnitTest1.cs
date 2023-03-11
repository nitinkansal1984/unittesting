using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using UnitTest.Controllers;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            HomeController home = new HomeController();
            string result = home.GetCountryName(1);
            Assert.That(result, Is.EqualTo("India"));
            Assert.IsNotEmpty(result);
            Assert.IsNotNull(result);

        }
        [Test]
        public void Test2()
        {
            HomeController home = new HomeController();
            string result = home.GetCountryName(2);
            Assert.IsNotEmpty(result);
            Assert.IsNotNull(result);
            Assert.That(result, Is.EqualTo("Germany"));           
        }

        [TestCase(1, "India")]
        [TestCase(2, "Germany")]
        [TestCase(3, "France")]
        [TestCase(4, "Not Found")]
        public void Test3(int countryID, string name)
        {
            HomeController home = new HomeController();
            string result = home.GetCountryName(countryID);
            Assert.That(result, Is.EqualTo(name));
        }

    }
}