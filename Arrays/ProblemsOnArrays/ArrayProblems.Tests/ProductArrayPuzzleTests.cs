using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArrayProblems.Tests
{
    [TestClass]
    public class ProductArrayPuzzleTests
    {
        ProductArrayPuzzle solution1;

        [TestInitialize]
        public void Initialize()
        {
            solution1 = new ProductArrayPuzzle();
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution1_ShouldReturnProperResult_WhenNonZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] result = solution1.Solution1(input);
            Assert.AreEqual(120, result[0]);
            Assert.AreEqual(60, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(24, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution1_ShouldReturnProperResult_WhenValuesWithZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 0, 5 };
            int[] result = solution1.Solution1(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(0, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution1_ShouldReturnProperResult_WhenAllValuesAreZero()
        {
            int[] input = new int[] { 0, 0, 0, 0, 0 };
            int[] result = solution1.Solution1(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(0, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution2_ShouldReturnProperResult_WhenAllValuesAreZero()
        {
            int[] input = new int[] { 0, 0, 0, 0, 0 };
            int[] result = solution1.Solution2(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(0, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution2_ShouldReturnProperResult_WhenValuesWithZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 0, 5 };
            int[] result = solution1.Solution2(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(0, result[4]);
        }


        [TestMethod]
        public void ProductArrayPuzzle_Solution2_ShouldReturnProperResult_WhenNonZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] result = solution1.Solution2(input);
            Assert.AreEqual(120, result[0]);
            Assert.AreEqual(60, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(24, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution3_ShouldReturnProperResult_WhenAllValuesAreZero()
        {
            int[] input = new int[] { 0, 0, 0, 0, 0 };
            int[] result = solution1.Solution3(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(0, result[3]);
            Assert.AreEqual(0, result[4]);
        }

        [TestMethod]
        public void ProductArrayPuzzle_Solution3_ShouldReturnProperResult_WhenValuesWithZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 0, 5 };
            int[] result = solution1.Solution3(input);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
            Assert.AreEqual(0, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(0, result[4]);
        }


        [TestMethod]
        public void ProductArrayPuzzle_Solution3_ShouldReturnProperResult_WhenNonZeroInputIsProvided()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            int[] result = solution1.Solution3(input);
            Assert.AreEqual(120, result[0]);
            Assert.AreEqual(60, result[1]);
            Assert.AreEqual(40, result[2]);
            Assert.AreEqual(30, result[3]);
            Assert.AreEqual(24, result[4]);
        }

        [TestCleanup]
        public void CleanUp()
        {
            solution1 = null;
        }
    }
}
