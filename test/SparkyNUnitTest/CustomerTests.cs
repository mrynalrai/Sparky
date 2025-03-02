using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Sparky;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        [TestCase("Jon", "Snow", ExpectedResult = "Bonjour Jon Snow")]
        [TestCase("Sansa", "Stark", ExpectedResult = "Bonjour Sansa Stark")]
        public string GreetCustomer_InputNames_ReturnCorrectGreeting(string firstName, string lastName)
        {
            Customer customer = new ();
            string result = customer.GreetCustomer(firstName, lastName);
            return result;
        }
    }
}