using Xunit;

namespace SolutionTest
{
    public class SolutionTest
    {
        [Fact]
        public void LCTestOne()
        {
            var solution = new Solution();
            var result = solution.Solve([1, 1, 2]);

            Assert.Equal([1, 2], result);
        }

        [Fact]
        public void LCTestTwo()
        {
            var solution = new Solution();
            var result = solution.Solve([0,0,1,1,1,2,2,3,3,4]);

            Assert.Equal([0, 1, 2, 3, 4], result);
        }

        [Fact]
        public void EmptyArray_ReturnsEmptyArray()
        {
            var solution = new Solution();
            var result = solution.Solve([]);

            Assert.Equal([], result);
        }

        [Fact]
        public void OneItemInArray_ReturnsThatArray()
        {
            var solution = new Solution();
            var result = solution.Solve([1]);

            Assert.Equal([1], result);
        }

        [Fact]
        public void SimpleDuplicateArray_ReturnsCutArray()
        {
            var solution = new Solution();
            var result = solution.Solve([1, 1]);

            Assert.Equal([1], result);
        }
    }
}