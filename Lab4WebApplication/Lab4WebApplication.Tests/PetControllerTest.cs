using System.Web.Mvc;
// <copyright file="PetControllerTest.cs">Copyright ©  2018</copyright>

using System;
using Lab4WebApplication.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab4WebApplication.Controllers.Tests
{
    [TestClass]
    [PexClass(typeof(PetController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PetControllerTest
    {

        [PexMethod]
        public ActionResult List([PexAssumeUnderTest]PetController target)
        {
            ActionResult result = target.List();
            return result;
            // TODO: add assertions to method PetControllerTest.List(PetController)
        }
    }
}
