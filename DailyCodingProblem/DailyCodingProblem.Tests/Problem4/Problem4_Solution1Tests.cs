using DailyCodingProblem.Problem4;
using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem4
{
    public class Problem4_Solution1Tests
    {
        [Test]
        public void Problem4_Solution1_TestWithProvidedExample1()
        {
            var sut = new Problem4_Solution1();
            var input = new int[]
            {
                1,2,3,5
            };
            var actual = sut.Solve(input);
            Assert.AreEqual(4, actual);
        }

        [Test]
        public void Problem4_Solution1_TestWithProvidedExample2()
        {
            var sut = new Problem4_Solution1();
            var input = new int[]
            {
                1,2,0
            };
            var actual = sut.Solve(input);
            Assert.AreEqual(3, actual);
        }
        [Test]
        public void Problem4_Solution1_TestWithProvidedExample3()
        {
            var sut = new Problem4_Solution1();
            var input = new int[]
            {
                -2, -6, -10, 1,2
            };
            var actual = sut.Solve(input);
            Assert.AreEqual(-9, actual);
        }

        [Test]
        public void Problem4_Solution1_TestWithProvidedExample4()
        {
            var sut = new Problem4_Solution1();
            var input = new int[]
            {
                1
            };
            var actual = sut.Solve(input);
            Assert.AreEqual(2, actual);
        }
    }
}
