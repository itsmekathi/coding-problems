using DailyCodingProblem.Problem9;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem9
{
    public class Problem9_solution1Tests
    {
        [Test]
        public void Problem9_solution1_BasicInput()
        {
            var sut = new Problem9_solution1();
            var input = new int[] { 1, 2, 3, 4, 5 };
            var result = sut.solve(input);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void Problem9_solution1_BasicInput1()
        {
            var sut = new Problem9_solution1();
            var input = new int[] { 2, 4, 6, 8 };
            var result = sut.solve(input);
            Assert.AreEqual(12, result);
        }

        [Test]
        public void Problem9_solution1_BasicInput2()
        {
            var sut = new Problem9_solution1();
            var input = new int[] { 5, 1, 1, 5 };
            var result = sut.solve(input);
            Assert.AreEqual(10, result);
        }
    }
}
