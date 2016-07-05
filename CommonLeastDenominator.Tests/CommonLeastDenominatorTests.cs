using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CommonDenominator;

namespace CommonLeastDenominator.Tests
{
    [TestFixture]
    public class CommonLeastDenominatorTests
    {
        [TestCaseSource("GetTwoParameters")]
        public double EuclidianAlgorithm_2Parameters(int x, int y)
        {
            return CommonDenominator.CommonLeastDenominator.EuclidianAlgorithm(x, y);
        }

        [TestCaseSource("GetTwoParameters")]
        public double SteinsAlgorithm_2Parameters(int x, int y)
        {
            return CommonDenominator.CommonLeastDenominator.SteinsAlgorithm(x, y);
        }

        [TestCaseSource("GetThreeParameters")]
        public double EuclidianAlgorithm_3Parameters(int x, int y, int z)
        {
            return CommonDenominator.CommonLeastDenominator.EuclidianAlgorithm(x, y, z);
        }

        [TestCaseSource("GetThreeParameters")]
        public double SteinsAlgorithm_3Parameters(int x, int y, int z)
        {
            return CommonDenominator.CommonLeastDenominator.SteinsAlgorithm(x, y, z);
        }

        [TestCaseSource("GetParams")]
        public double SteinsAlgorithm_Params(int[] arr)
        {
            return CommonDenominator.CommonLeastDenominator.SteinsAlgorithm(arr);
        }

        [TestCaseSource("GetParams")]
        public double EuclidianAlgorithm_Params(int[] arr)
        {
            return CommonDenominator.CommonLeastDenominator.EuclidianAlgorithm(arr);
        }

        [TestCaseSource("GetParams")]
        public double EuclidianAlgorithm_ParamsWithTime(int[] arr)
        {
            long time;
            return CommonDenominator.CommonLeastDenominator.EuclidianAlgorithmTime(out time, arr);
        }

        [TestCaseSource("GetParams")]
        public double SteinsAlgorithmTime_ParamsWithTime(int[] arr)
        {
            long time;
            return CommonDenominator.CommonLeastDenominator.SteinsAlgorithmTime(out time, arr);
        }
        public IEnumerable<TestCaseData> GetTwoParameters()
        {
            yield return new TestCaseData(125, 17).Returns(1);
            yield return new TestCaseData(125, 5).Returns(5);
            yield return new TestCaseData(-125, 5).Returns(5);
            yield return new TestCaseData(-125, -5).Returns(5);
            yield return new TestCaseData(0, 5).Returns(5);
            yield return new TestCaseData(0, 0).Returns(0);
        }

        public IEnumerable<TestCaseData> GetThreeParameters()
        {
            yield return new TestCaseData(100, 100, 101).Returns(1);
            yield return new TestCaseData(125, 5, 25).Returns(5);
            yield return new TestCaseData(-125, 5, 25).Returns(5);
            yield return new TestCaseData(-125, -5, -25).Returns(5);
            yield return new TestCaseData(0, 5, 0).Returns(5);
            yield return new TestCaseData(0, 0, 0).Returns(0);
        }

        public IEnumerable<TestCaseData> GetParams()
        {
            yield return new TestCaseData(new int[] { 100, 100, 101, 103, 107 }).Returns(1);
            yield return new TestCaseData(new int[] { 125, 5, 25, 555 }).Returns(5);
            yield return new TestCaseData(new int[] { -125, 5, 25, -15 }).Returns(5);
            yield return new TestCaseData(new int[] { -125, -5, -25, 825 }).Returns(5);
            yield return new TestCaseData(new int[] { 0, 5, 0, 0, 0 }).Returns(5);
            yield return new TestCaseData(new int[] { 0, 0, 0, 0 }).Returns(0);
            yield return new TestCaseData(null).Throws(typeof(ArgumentException));
            yield return new TestCaseData(new int[] { }).Throws(typeof(ArgumentException));
        }
    }
}
