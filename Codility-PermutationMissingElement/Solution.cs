using System.Runtime.CompilerServices;

namespace Codility_PermutationMissingElement
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 0;
        private const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int N = A.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE)
            {
                long expectedSum = (long)(N + 1) * (N + 2) / 2; // Sum of integers from 1 to N+1

                long actualSum = 0;
                foreach (int num in A)
                    actualSum += num;

                return (int)(expectedSum - actualSum); // we have to return the difference between the expected sum
            }                                          // that is equal to (n + 1)*(n + 2)/2 - mathematical formula 
            return -1; // return -1 if there           // the formula above applies to consecutive series of integer numbers                                
        }              // is an error                  // greater than 0 and less than n
    }                                                  // as an example if we have the following series 1,2,3,4,5,6
}                                                      // the total sum is 1+2+3+4+5+6 = 21
                                                       // using the formula is (for n = 6-1 = 5) 6*7/2 = 42/2 = 21
                                                       // and we can find the missing item from the list of numbers by substracting
                                                       // from the total expected sum the actual calculated sum
                                                       // if the list of numbers is 1,2,4,5,6 - 3 is missing 
                                                       // this list has the sum equal to 1+2+4+5+6 = 18
                                                       // the expected sum would be 21 so the missing item is 21-18 = 3

