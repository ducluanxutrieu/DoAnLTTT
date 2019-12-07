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
            List<int> binArrayM = binary.GenerateBinaryFormat(msg);
            binArrayM.Reverse();
            //System.out.print("Msg = " + msg);
            //System.out.println("  = " + binArrayM);

            //padded msg
            List<int> padBinMsg = new List<int>(binArrayM);
            padBinMsg.Add(0);
            padBinMsg.Add(0);
            padBinMsg.Add(0);

            //n in binary
            List<int> binArrayN = binary.GenerateBinaryFormat(n);
            binArrayN.Reverse();
            long padMsg = decimals.getDecimal(padBinMsg);
            //System.out.print("\nPadded msg = " + padMsg);
            //System.out.println(" = " + padBinMsg);
            //System.out.print("n = " + n);
            //System.out.println(" = " + binArrayN);

            //Check if message is greater than n or smaller than n (if greater than n then break into smaller parts)
            if (padMsg < n)
            {
                //System.out.println("\nPADDED MESSAGE < N ");
                long c = (long)(Math.Pow(padMsg, 2) % n);
                //System.out.println("Encrypted message is" + c);
                finalMessage = c;
                break_size = binArrayM.Count; //-3 because we already aded it on decryption side so it would work for both Message break and non break
            }
            //else
            //{
            //    //System.out.println("\nPADDED MESSAGE > N : So Break Message And then Add Padding ");
            //    //Normalized padding
            //    long n_size = binArrayN.Count;
            //    long m_size = binArrayM.Count;
            //    break_size = n_size / 2;
            //    //System.out.println("\nBreak Size = " + break_size);
            //    long toadd;
            //    if (m_size % break_size == 0)
            //    {
            //        toadd = 0;
            //    }
            //    else
            //    {
            //        toadd = break_size - m_size % break_size;
            //    }

            //    binArrayM.Reverse();
            //    long i1;
            //    for (i1 = 0; i1 < toadd; i1++)
            //    {
            //        binArrayM.Add(0);
            //    }

            //    List<int> normMsg;
            //    normMsg = binArrayM;
            //    normMsg.Reverse();
            //    //System.out.println("\nNormalized size =" + normMsg);

            //    //breakimg data
            //    int k = 0;
            //    long nobreaks = normMsg.Count / break_size;
            //    for (long i = 0; i < nobreaks; i++)
            //    {
            //        List<int> piece = new List<int>();
            //        for (long j = 0; j < break_size; j++)
            //        {
            //            piece.Add(normMsg[k]);
            //            k++;
            //        }
            //        BrokenMessage.Add(piece);
            //    }
            //    k = 0;
            //    //System.out.println("\nBreaks = " + BrokenMessage);
            //    for (int i = 0; i < nobreaks; i++)
            //    {
            //        BrokenMessage[i].Add(0);
            //        BrokenMessage[i].Add(0);
            //        BrokenMessage[i].Add(0);
            //        k++;
            //        DecimalGenerator dg = new DecimalGenerator();
            //        long c = dg.getDecimal(BrokenMessage[i]);
            //        c = (long)(Math.Pow(c, 2) % n);
            //        finalMessage.Add(c);
            //    }
            //    //System.out.println("\nPadded Broken Message = " + BrokenMessage);
            //    //System.out.println("\nEncrypted Broken Message" + finalMessage);

            //}
            return finalMessage;

        }

        public long getBreakSize()
        {
            return break_size;
        }
    }
}
