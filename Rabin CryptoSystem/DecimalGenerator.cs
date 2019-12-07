using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class DecimalGenerator
    {
        //Generate Decimal
        public long getDecimal(List<int> bits)
        {
            long power = 0, decimals = 0;
            
            for (int i = bits.Count - 1; i >= 0; i--)
            {
                power = bits.Count - i - 1;
                decimals += bits[i] * Convert.ToInt64(Math.Pow(2, power));
            }
            return decimals;
        }
    }
}
