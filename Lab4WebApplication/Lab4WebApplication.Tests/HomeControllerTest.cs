using System.Web.Mvc;
// <copyright file="HomeControllerTest.cs">Copyright ©  2018</copyright>

using System;
using Lab4WebApplication.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab4WebApplication.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(HomeController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class HomeControllerTest
    {

        [PexMethod]
        public ActionResult About([PexAssumeUnderTest]HomeController target)
        {
            ActionResult result = target.About();
            return result;
            // TODO: add assertions to method HomeControllerTest.About(HomeController)
        }
    }
}
