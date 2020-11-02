using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTest.Controllers;
using TechTest.Data;

namespace TechTestTests
{
    [TestClass]
    public class RobotsControllerTests
    {
        [TestMethod]
        public void CheckItWorks()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                      .UseInMemoryDatabase(databaseName: "techtestdb-test")
                      .Options;
            var context = new DataContext(options);
            //We're initializing an in memory database here, but it's empty
            //If you want to add any entity you can do it in the context object

            var controller = new RobotsController(context);

            var result = controller.GetAvailable("Bloaty Head");

            Assert.IsInstanceOfType(result, typeof(OkObjectResult));

            context.Database.EnsureDeleted();
            context.Dispose();
        }
    }
}
