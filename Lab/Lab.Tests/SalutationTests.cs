using System;
using Xunit;

namespace Lab.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SalutationTest()
        {
            var salutation = Library.Greeting.GetSalutation();
            var shouldBe = "Hello World";
            
            Assert.Equal(salutation, shouldBe);
        }
    }
}