using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD_Matematica;
using CRUD_Matematica.Controllers;
using CRUD_Matematica.ViewModels;

namespace CRUD_Matematica.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void TestSuma()
        {
            // Arrange
            HomeController controller = new HomeController();
            AboutViewModel model = new AboutViewModel();
            model.InputSuma1 = 5;
            model.InputSuma2 = 4;
            RedirectToRouteResult result = controller.Sumar(model) as RedirectToRouteResult;
            Decimal data = Convert.ToDecimal(result.RouteValues.Values.ElementAt(8));
            Assert.AreEqual(9, data);
        }

        [TestMethod]
        public void TestResta()
        {
            // Arrange
            HomeController controller = new HomeController();
            AboutViewModel model = new AboutViewModel();
            model.InputResta1 = 5;
            model.InputResta2 = 4;
            RedirectToRouteResult result = controller.Restar(model) as RedirectToRouteResult;
            Decimal data = Convert.ToDecimal(result.RouteValues.Values.ElementAt(9));
            Assert.AreEqual(1, data);
        }

        [TestMethod]
        public void TestMultiplicacion()
        {
            // Arrange
            HomeController controller = new HomeController();
            AboutViewModel model = new AboutViewModel();
            model.InputMultiplicacion1 = 5;
            model.InputMultiplicacion2 = 4;
            RedirectToRouteResult result = controller.Multiplicar(model) as RedirectToRouteResult;
            Decimal data = Convert.ToDecimal(result.RouteValues.Values.ElementAt(10));
            Assert.AreEqual(20, data);
        }

        [TestMethod]
        public void TestDivision()
        {
            // Arrange
            HomeController controller = new HomeController();
            AboutViewModel model = new AboutViewModel();
            model.InputDivision1 = 20;
            model.InputDivision2 = 4;
            RedirectToRouteResult result = controller.Dividir(model) as RedirectToRouteResult;
            Decimal data = Convert.ToDecimal(result.RouteValues.Values.ElementAt(11));
            Assert.AreEqual(5, data);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
