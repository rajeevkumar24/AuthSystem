using System;
using AuthSystem.Controllers;
using Microsoft.Build.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AuthSystemTest
{
    [TestClass]
    public class HomeControllerTest

    {
        [TestMethod]
        public void TestMethod1()
        {
            HomeController controller = new HomeController(ILogger < HomeController > logger);


        }
    }
}
