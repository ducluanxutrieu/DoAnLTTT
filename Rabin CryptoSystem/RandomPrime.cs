using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class RandomPrime
    {
        RandomNumber randomNo = new RandomNumber(10000);
        long num;

        public long generatePrime()
        {
            do
            {
                num = randomNo.nextValue();
                //			   System.out.println(num);

            } while (!checkPrime(num));

            return num;
        }

        public Boolean checkPrime(long num)
        {
            Boolean result = false;
            if (num % 2 != 0)
            {
                if (fermatPrimariltyTest(num) && millerRabinTest(num))
                {
                    result = true;
                }

            }
            return result;
        }

        Boolean fermatPrimariltyTest(long p)
        {
            Boolean result = false;
            long a = 2;
            // long temp = (long) java.lang.Math.pow(a,p-1);
            if (modPow(a, p - 1, p) == 1)
            {
                result = true;
            }
            return result;
        }


        Boolean millerRabinTest(long n)
        {
            if (n == 0 || n == 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            Boolean result = false;
            long k = 20, a, i = 0, up, low, x, d, s = 0, temp;
            Random random = new Random();
            up = n;
            low = 2;
            temp = n - 1;
            while (temp % 2 == 0)
            {
                temp = temp / 2;
                s++;
            }
            d = temp;
            //		   System.out.println("2^"+s+" X "+d);
            //		    n-1 = 2^s x d

            for (i = 0; i < k; i++)
            {
                a = random.Next((int)((up - low) + 1)) + low;
                x = modPow(a, d, n);
                if (x == 1 || x == n - 1)
                { result = true; }
                for (int r = 1; r < s; r++)
                {
                    x = (x * x) % n;
                    if (x == n - 1)
                    { result = true; }
                }
            }

            return result;
        }

        public long modPow(long a, long d, long n)
        {
            //  output = a^d mod n
            long res = 1;
            for (int i = 0; i < d; i++)
            {
                res = res * a;
                res = res % n;

            }
            return res % n;
        }
    }
}
