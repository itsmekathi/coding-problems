using NUnit.Framework;

namespace DailyCodingProblem.Tests.Problem1
{
    public class Problem1_Solution1Tests
    {
        [Test]
        public void Problem1_Solution1_TestWithSmallArray()
        {
            var sut = new Problem2.Problem2_Solution1();
            var input = new int[]
            {
                1,2,3,4,5
            };
            var expectedOut = new int[]
            {
                120,60,40,30,24
            };
            var actual = sut.ApplyLogic(input);
            Assert.AreEqual(expectedOut, actual);
        }

        [Test]
        public void Problem1_Solution1_TestWithArrayOfTenElements()
        {
            var sut = new Problem2.Problem2_Solution1();
            var input = new int[]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            var expectedOut = new int[]
            {
                3628800,1814400,1209600,907200,725760,604800,518400,453600,403200,362880
            };
            var actual = sut.ApplyLogic(input);
            Assert.AreEqual(expectedOut, actual);
        }
    }
}
