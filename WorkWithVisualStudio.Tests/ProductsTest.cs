using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WorkWithVisualStudio.Models;

namespace WorkWithVisualStudio.Tests
{
    public class ProductsTest
    {
        [Fact]
        public void CanChangeProductName()
        {
            var p = new Product { Name = "Test", Price = 100M };
            p.Name = "New NAme";
            Assert.Equal("New NAme", p.Name);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            var p = new Product { Name = "Test", Price = 100M };
            p.Price = 200M;
            Assert.Equal(200M, p.Price);
        }
    }
}
