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
        //Tính toán chuyển từ số thập phân sang số nhị phân
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

            binary.Reverse(); //Đảo ngược lại chuổi nhị phân để có được giá trị đúng
            return binary;
        }
    }
}
