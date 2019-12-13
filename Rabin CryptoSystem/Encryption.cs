using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class Encryption
    {
        private long break_size;

        private List<List<int>> BrokenMessage = new List<List<int>>();
        private long finalMessage = 0;

        public long Encrypt(long msg, long n)
        {
            BinaryGenerator binary = new BinaryGenerator();
            DecimalGenerator decimals = new DecimalGenerator();

            //msg
            List<int> binArrayM = binary.GenerateBinaryFormat(msg); //Chuyển msg từ thập phân sang nhị phân nhưng giá trị bị đảo ngược

            //padded msg
            List<int> padBinMsg = new List<int>(binArrayM);
            padBinMsg.Add(0);
            padBinMsg.Add(0);
            padBinMsg.Add(0);

            //n in binary
            List<int> binArrayN = binary.GenerateBinaryFormat(n);
            long padMsg = decimals.getDecimal(padBinMsg);

       
            //Kiểm tra nếu message lớn hơn n thì tính được tin nhắn đã mã hóa
            if (padMsg < n)
            {
                long c = (long)(Math.Pow(padMsg, 2) % n);
                finalMessage = c;
                break_size = binArrayM.Count; //-3 bởi vì đã thêm nó vào phía giải mã nên nó sẽ hoạt động cho cả Message break and non-break
            }
            return finalMessage;
        }

        public long getBreakSize()
        {
            return break_size;
        }
    }
}
