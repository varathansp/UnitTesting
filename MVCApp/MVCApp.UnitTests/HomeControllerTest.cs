using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCApp.Controllers;
using System.Web.Mvc;



namespace MVCApp.UnitTests
{
    //refer system.web.mvc
    //refer system.web.webpages
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index_IdValueMoreThan5_ReturnsBase()
        {
            HomeController homeController = new HomeController();
            ActionResult actionResult = homeController.Index(6);
            Assert.IsInstanceOfType(actionResult, typeof(RedirectToRouteResult));
            RedirectToRouteResult redirectToRouteResult = actionResult as RedirectToRouteResult;
            Assert.AreEqual(redirectToRouteResult.RouteValues["action"], "Base");
        }
        [TestMethod]
        public void Index_IdValueLessThan5_ReturnsIndex()
        {
            HomeController homeController = new HomeController();
            ActionResult result = homeController.Index(1);
            Assert.IsInstanceOfType(result, typeof(ViewResult));

            ViewResult view = result as ViewResult;
            Assert.AreEqual("Index", view.ViewName);
            
            //ViewResult vResult = result as ViewResult;
            //if (vResult != null)
            //{
            //    Assert.IsInstanceOfType(vResult.Model, typeof());
            //    YourModelType model = vResult.Model as YourModelType;
            //    if (model != null)
            //    {
            //        //...
            //    }
            //}

            //view.ViewData.Model
        }

    }
}
