using System.Runtime.CompilerServices;

namespace Codility_CountSemiprimes
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 1;
        public const int RANGE_HIGHEST_VALUE = 50000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int[] solution(int N, int[] P, int[] Q)
        {
            int M = P.Length;
            int K = Q.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE &&
                M >= RANGE_LOWEST_VALUE && M <= RANGE_HIGHEST_VALUE - 20000 &&
                K >= RANGE_LOWEST_VALUE && K <= RANGE_HIGHEST_VALUE - 20000 &&
                K == M) 
            {
                int[] prefixSums = CalculateSemiPrimes(N);
                int[] result = new int[M];

                for (int i = 0; i < M; i++)
                    result[i] = prefixSums[Q[i]] - prefixSums[P[i] - 1];
                return result;
            }
            
            return Array.Empty<int>();
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private int[] CalculateSemiPrimes(int N)
        {
            int[] sieve = new int[N + 1];
            int[] prefixSums = new int[N + 1];
            for (int i = 2; i * i <= N; i++)
            {
                if (sieve[i] == 0)
                {
                    for (int j = i * i; j <= N; j += i)
                    {
                        if (sieve[j] == 0)
                            sieve[j] = i;
                    }
                }
            }

            for (int i = 4; i <= N; i++)
            {
                if (sieve[i] > 0)
                {
                    int primeFactor = sieve[i];
                    int secondFactor = i / primeFactor;

                    if (sieve[secondFactor] == 0)
                        prefixSums[i] = 1;
                }
            }

            for (int i = 1; i <= N; i++)
                 prefixSums[i] += prefixSums[i - 1];
            
            return prefixSums;
        }
    }
}
