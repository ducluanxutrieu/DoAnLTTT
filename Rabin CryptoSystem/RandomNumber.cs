using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class RandomNumber
    {
        private long maximum;
        private long value;
        private long nextvalue;

        public RandomNumber(long max)
        {
            this.maximum = max;
            value = (CurrentTimeMillis() % maximum);
        }

        public long nextValue()
        {
            nextvalue = (32719 * value + 2133) % maximum;
            if (nextvalue % 2 == 0)
            {
                value = (CurrentTimeMillis() % maximum);
            }
            else
            {
                value = nextvalue % maximum;
            }
            return value;

        }

        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public static long CurrentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }
}
