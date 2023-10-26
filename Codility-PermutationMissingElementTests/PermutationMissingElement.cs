using Codility_PermutationMissingElement;

namespace Codility_PermutationMissingElementTests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_MissingElement_Example()
        {
            Solution solution = new Solution();
            int[] A = { 2, 3, 1, 5 };
            int result = solution.solution(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_MissingElement_SingleElement()
        {
            Solution solution = new Solution();
            int[] A = { 2 };
            int result = solution.solution(A);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_MissingElement_EmptyArray()
        {
            Solution solution = new Solution();
            int[] A = { };
            int result = solution.solution(A);
            Assert.Equal(1, result); // When the array is empty, the missing element is considered 1.
        }

        [Fact]
        public void Test_MissingElement_LargeArray()
        {
            Solution solution = new Solution();
            int[] A = new int[100000];
            for (int i = 1; i <= 100000; i++)
            {
                A[i - 1] = i;
            }
            int result = solution.solution(A);
            Assert.Equal(100001, result); // The missing element in a consecutive series should be N + 1.
        }
    }
}