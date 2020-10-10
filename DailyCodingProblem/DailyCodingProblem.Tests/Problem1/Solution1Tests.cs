using NUnit.Framework;

namespace DailyCodingProblem.Tests
{
    public class Solution1Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Problem1_WhenPassedInuptHasSumK_ShouldReturnTrue()
        {
            var sut = new Solution1();
            int[] input = new int[] { 10, 20, 30, 40 };

            var result = sut.Solve(input, 30);
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Problem1_WhenPassedInuptHasOnly2Element_ShouldReturnTrueIfSumIsK()
        {
            var sut = new Solution1();
            int[] input = new int[] { 10, 20 };

            var result = sut.Solve(input, 30);
            Assert.AreEqual(true, result);
        }


        [Test]
        public void Problem1_WhenPassedInuptDoesNotHaveSumK_ShouldReturnFalse()
        {
            var sut = new Solution1();
            int[] input = new int[] { 10, 20, 30, 40 };

            var result = sut.Solve(input, 100);
            Assert.AreEqual(false, result);
        }

        [Test]
        public void Problem1_WhenPassedInuptHasOnly1Element_ShouldReturnFalse()
        {
            var sut = new Solution1();
            int[] input = new int[] { 10 };

            var result = sut.Solve(input, 10);
            Assert.AreEqual(false, result);
        }
    }
}
