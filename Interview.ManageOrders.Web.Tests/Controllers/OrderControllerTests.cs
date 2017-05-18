using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Moq;
using Interview.ManageOrders.BusinessServices.Interfaces;
using Microsoft.Practices.Unity;

namespace Interview.ManageOrders.Web.Controllers.Tests
{
    [TestClass()]
    public class OrderControllerTests
    {

        #region private variables
        private Mock<IOrderService> Service;
      
   
        #endregion


        [TestInitialize]
        public void SetUp()
        {
            Service = new Mock<IOrderService>();

        }


        [TestMethod]
        public void Index()
        {
            // Arrange
            OrderController controller = new OrderController(Service.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }



        /* Need to add More test fixtures here */


        [TestCleanup]
        public void CleanUp()
        {
            Service = null;

        }
    }
}