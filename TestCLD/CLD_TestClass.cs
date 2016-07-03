using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommonLeastDenominatorSpace;

namespace TestCLD
{
    [TestClass]
    public class CLD_TestClass
    {
        [TestMethod]
        public void EuclidTest_Positive()
        {
            int arrange = 5;
            int x = 155, y = 5;
            int act = CommonLeastDenominator.EuclidianAlgorithm(x, y);

            Assert.AreEqual(arrange, act);
        }


        [TestMethod]
        public void EuclidTest_Equals()
        {
            int arrange = 5;
            int x = 5, y = 5;
            int act = CommonLeastDenominator.EuclidianAlgorithm(x, y);

            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void SteinsAlgorithm_Positive()
        {
            int arrange = 5;
            int x = 5, y = 25;
            int act = CommonLeastDenominator.SteinsAlgorithm(x, y);

            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void CommonDenominator_EuclidianAlgorithm_Positive()
        {
            int arrange = 5;
            int x = 5, y = 25;
            var del = new CommonLeastDenominator.CLDDelegate(CommonLeastDenominator.EuclidianAlgorithm);
            int act = CommonLeastDenominator.CommonDenominator(del, x, y);
            Assert.AreEqual(arrange, act);
        }

        [TestMethod]
        public void CommonDenominator_SteinsAlgorithm_Positive()
        {
            int arrange = 5;
            int x = 5, y = 25;
            var del = new CommonLeastDenominator.CLDDelegate(CommonLeastDenominator.SteinsAlgorithm);
            int act = CommonLeastDenominator.CommonDenominator(del, x, y);
            Assert.AreEqual(arrange, act);
        }



    }
}
