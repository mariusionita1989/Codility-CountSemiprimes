using Codility_CountSemiprimes;

namespace Codility_CountSemiprimesTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleCase()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 26;
            int[] P = { 1, 4, 16 };
            int[] Q = { 26, 10, 20 };
            int[] expected = { 10, 4, 0 };

            // Act
            int[] result = solution.solution(N, P, Q);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleQueryWithSmallestN()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 1;
            int[] P = { 1 };
            int[] Q = { 1 };
            int[] expected = { 0 };

            // Act
            int[] result = solution.solution(N, P, Q);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleQueryWithLargestN()
        {
            // Arrange
            Solution solution = new Solution();
            int N = 50000;
            int[] P = { 1 };
            int[] Q = { 50000 };
            // Expected result is not known but check for no exceptions
            Assert.NotNull(solution.solution(N, P, Q));
        }
    }
}