using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NewtonRootSpace;
namespace NewtonRRoot_TestNUnit
{
    [TestFixture]
    public class NewtonRootTests
    {
        [TestCaseSource("GetTestData")]
        public double FindRoot_SimpleTests(int x, int y)
        {
            return FindRoot.NewtonRoot(x, y);
        }
        [TestCaseSource("GetTestDataWithInaccaracy")]
        public double FindRoot_TestsWithInaccaracy(int x, int y, int eps)
        {
            return FindRoot.NewtonRoot(x, y, eps);
        }

        public IEnumerable<TestCaseData> GetTestData()
        {
            yield return new TestCaseData(25,2).Returns(5);
            yield return new TestCaseData(-125, 3).Returns(-5);
            yield return new TestCaseData(0, 2).Returns(0);
            yield return new TestCaseData(-25, 2).Throws(typeof(ArgumentException));
            yield return new TestCaseData(25, -2).Throws(typeof(ArgumentException));
        }

        public IEnumerable<TestCaseData> GetTestDataWithInaccaracy()
        {
            yield return new TestCaseData(25, 2, 1e-11).Throws(typeof(ArgumentException));
            yield return new TestCaseData(-125, 3, -1e-11).Throws(typeof(ArgumentException));
            yield return new TestCaseData(25, 2,22).Throws(typeof(ArgumentException));
        }
    }
}
