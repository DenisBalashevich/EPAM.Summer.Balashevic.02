using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtonRoot;
namespace TestNewtonRoot
{
    [TestClass]
    public class Root_Test_Class
    {
        [TestMethod]
        public void FindRoot_TestMethod()
        {
            double arrange = Math.Pow(3, 0.25);
            double act = FindRoot.NewtonRoot(3, 4);
            Assert.AreEqual(arrange, act);
        }
    }
}
