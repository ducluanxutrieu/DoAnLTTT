using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class BinaryGenerator
    {
        public List<int>  GenerateBinaryFormat(long number)
        {

            List<int> binary = new List<int>();
            int bineq;

            while (number > 0)
            {
                bineq = (int)number % 2;
                binary.Add(bineq);
                number = number / 2;
            }
            return binary;
        }
    }
}
