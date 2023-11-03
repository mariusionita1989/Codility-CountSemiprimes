# Codility-CountSemiprimes
A prime is a positive integer X that has exactly two distinct divisors: 1 and X.</br>
The first few prime integers are 2, 3, 5, 7, 11 and 13.</br>
A semiprime is a natural number that is the product of two (not necessarily distinct) prime numbers.</br> 
The first few semiprimes are 4, 6, 9, 10, 14, 15, 21, 22, 25, 26.</br>
You are given two non-empty arrays P and Q, each consisting of M integers.</br> 
These arrays represent queries about the number of semiprimes within specified ranges.</br>
Query K requires you to find the number of semiprimes within the range (P[K], Q[K]), where 1 ≤ P[K] ≤ Q[K] ≤ N.

For example, consider an integer N = 26 and arrays P, Q such that:</br>
P[0] = 1    Q[0] = 26</br>
P[1] = 4    Q[1] = 10</br>
P[2] = 16   Q[2] = 20</br>
The number of semiprimes within each of these ranges is as follows:</br>
(1, 26) is 10,</br>
(4, 10) is 4,</br>
(16, 20) is 0.

Write a function:</br>
class Solution { public int[] solution(int N, int[] P, int[] Q); }</br>
that, given an integer N and two non-empty arrays P and Q consisting of M integers,</br> 
returns an array consisting of M elements specifying the consecutive answers to all the queries.

For example, given an integer N = 26 and arrays P, Q such that:</br>
P[0] = 1    Q[0] = 26</br>
P[1] = 4    Q[1] = 10</br>
P[2] = 16   Q[2] = 20</br>
the function should return the values [10, 4, 0], as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..50,000];</br>
M is an integer within the range [1..30,000];</br>
each element of arrays P and Q is an integer within the range [1..N];</br>
P[i] ≤ Q[i].
