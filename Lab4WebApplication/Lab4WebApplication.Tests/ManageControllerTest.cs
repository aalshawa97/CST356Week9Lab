using System.Reflection;
using Microsoft.AspNet.Identity;
// <copyright file="ManageControllerTest.cs">Copyright ©  2018</copyright>

using System;
using Lab4WebApplication.Controllers;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab4WebApplication.Controllers.Tests
{
    /// <summary>This class contains parameterized unit tests for ManageController</summary>
    [TestClass]
    [PexClass(typeof(ManageController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ManageControllerTest
    {

        [PexMethod]
        [PexMethodUnderTest("AddErrors(IdentityResult)")]
        internal void AddErrors([PexAssumeUnderTest]ManageController target, IdentityResult result)
        {
            object[] args = new object[1];
            args[0] = (object)result;
            Type[] parameterTypes = new Type[1];
            parameterTypes[0] = typeof(IdentityResult);
            object result01 = ((MethodBase)(typeof(ManageController).GetMethod("AddErrors",
                                                                               BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic, (Binder)null,
                                                                               CallingConventions.HasThis, parameterTypes, (ParameterModifier[])null)))
                                  .Invoke((object)target, args);
            // TODO: add assertions to method ManageControllerTest.AddErrors(ManageController, IdentityResult)
        }
    }
}
