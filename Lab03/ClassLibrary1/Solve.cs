using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Solve
    {
        public bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }
        public bool isPerfect(int n)
        {
            int s = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0) s += i;
            if (s == n) return true;
            return false;
        }
        public bool isSquare(int n)
        {
            if ((int)Math.Sqrt(n) * (int)Math.Sqrt(n) == n) return true;
            return false;
        }
    }
}
