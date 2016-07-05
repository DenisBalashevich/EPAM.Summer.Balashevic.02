using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewtonRootSpace;
namespace TestNewtonRoot
{
    [TestClass]
    public class NewtonRootTests
    {
        [TestMethod]
        public void FindRoot_25Root2_5Returned()
        {
            double arrange = 5;
            int x = 25;
            int y = 2;
            double act = FindRoot.NewtonRoot(x, y);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void FindRoot_25Root2WithInaccaracy1e11_5Returned()
        {
            double arrange = 5;
            int x = 25;
            int y = 2;
            double eps = 1e-11;
            double act = FindRoot.NewtonRoot(x, y, eps);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void FindRoot_Minus125Root2_5Returned()
        {
            double arrange = -5;
            int x = -125;
            int y = 3;
            double act = FindRoot.NewtonRoot(x, y);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void FindRoot_0Root2_0Returned()
        {
            double arrange = 0;
            int x = 0;
            int y = 2;
            double act = FindRoot.NewtonRoot(x, y);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FindRoot_Minus25Root2_ArgumentExceptionThrows()
        {
            int x = -25;
            int y = 2;
            double act = FindRoot.NewtonRoot(x, y);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FindRoot_25RootMinis2_ArgumentExceptionThrows()
        {
            int x = 25;
            int y = -2;
            double act = FindRoot.NewtonRoot(x, y);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FindRoot_FindRoot_25Root2InaccaracyMinus1e11_ArgumentExceptionThrows()
        {
            int x = 25;
            int y = 2;
            double eps = -1e-11;
            double act = FindRoot.NewtonRoot(x, y, eps);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void FindRoot_25Root2Inaccaracy22_ArgumentExceptionThrows()
        {
            int x = 25;
            int y = 2;
            double eps = 22;
            double act = FindRoot.NewtonRoot(x, y, eps);
        }

    }
}
