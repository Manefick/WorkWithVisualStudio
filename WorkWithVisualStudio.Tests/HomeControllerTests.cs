using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WorkWithVisualStudio.Controllers;
using WorkWithVisualStudio.Models;
using Xunit;

namespace WorkWithVisualStudio.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelsComplete()
        {
            var controller = new HomeController();
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
            Assert.Equal(SimpleRepository.SharedRepository.Products, model, Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name &&
            p1.Price == p2.Price));
        }
    }
}
