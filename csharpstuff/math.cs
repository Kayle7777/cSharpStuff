using System;

namespace MathStuff
{
    public class TestMath
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Factorial(int n)
        {
            int ret = 1;
            while (n > 0)
            {
                ret *= n;
                n--;
            }
            return ret;
        }
        public bool Prime(int n)
        {
            // Will find if n is prime or not
            for (int i = 2; i < n; i++)
            {
                if (n != i && n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public string[] PrimeRange(int n)
        {
            // Return all primes from 2 >>> n
            string[] values = new string[n - 1];
            TestMath DoMath = new TestMath();
            for (int i = 2; i <= n; i++)
            {
                if (DoMath.Prime(i))
                {
                    values[i - 2] = $"{i} is prime";
                }
                else values[i - 2] = $"{i} is not prime";
            }
            return values;
        }
    }
}