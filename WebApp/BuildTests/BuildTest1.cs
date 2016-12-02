using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApp.Controllers;
using System.Web.Mvc;

namespace BuildTests
{
    [TestClass]
    public class BuildTest1
    {
        HomeController homeController = new HomeController();
        [TestMethod]
        public void Test1()
        {
            var result = (ViewResult)homeController.Index();
            Assert.AreEqual("", result.ViewName);
        }
    }
}
