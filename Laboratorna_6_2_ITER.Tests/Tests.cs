using System;
using NUnit.Framework;

namespace Laboratorna_6_2_ITER.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestFindMinMax()
        {
            const int n = 5;
            int[] arr = { 1, 2, 3, 4, 5 };

            int minValue, maxValue;
            Program.FindMinMax(arr, n, out minValue, out maxValue);

            Assert.AreEqual(1, minValue);
            Assert.AreEqual(5, maxValue);
        }
    }
}