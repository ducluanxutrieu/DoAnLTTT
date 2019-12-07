﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_CryptoSystem
{
    class Decryption
    {
        private long p;
    private long q;
    private long n;
    private List<long> message_pieces = new List<long>();
    private long breakSize;

    public long Decrypt(long c) {
        ExtendedEuclid eEuclid = new ExtendedEuclid();
        eEuclid.compute(p, q);

        long invp = eEuclid.getx();
        if (invp < 0) {
            invp = q + invp;
        }
        long invq = eEuclid.gety();
        if (invq < 0) {
            invq = p + invq;
        }
        //System.out.println("\nEXTENDED EUCLIDEAN : invp = " + invp + " invq =" + invq);

            //System.out.println("c = " + c.get((int) i) + " P+1/4 = " + ((p + 1) / 4) + " q+1/4 =" + ((q + 1) / 4));
            long r = modPow(c, (p + 1) / 4, p);
            long s = modPow(c, (q + 1) / 4, q);
            //System.out.println("\nvalues : r = c^(p+1/4)mod p = " + r + "\n\t s = c^(q+1/4)mod q = " + s);
            long x = (invp * p * s + invq * q * r) % n;
            long y = (invp * p * s - invq * q * r) % n;

            //Four value possible
            long m1 = x;
            if (m1 < 0) {
                m1 = n + m1;
            }
            long m2 = -x % n;
            if (m2 < 0) {
                m2 = n + m2;
            }
            long m3 = y;
            if (m3 < 0) {
                m3 = n + m3;
            }
            long m4 = -y % n;
            if (m4 < 0) {
                m4 = n + m4;
            }
            //System.out.println("Decrypted Messages : m1 = " + m1 + "  m2 = " + m2 + "  m3 = " + m3 + "  m4 = " + m4);
            BinaryGenerator binary = new BinaryGenerator();
            DecimalGenerator decimals = new DecimalGenerator();
                List<List<int>> check = new List<List<int>>();
            // all are in reverse order
            check.Add(binary.GenerateBinaryFormat(m1));
            check.Add(binary.GenerateBinaryFormat(m2));
            check.Add(binary.GenerateBinaryFormat(m3));
            check.Add(binary.GenerateBinaryFormat(m4));


            int correct = -1, j = 0;
            for (j = 0; j < 4; j++) {
                if (check[j].Count < breakSize) {

                    while (check[j].Count != breakSize) {
                        check[j].Add(0);
                    }
                }
                if (check[j].Count <= breakSize + 3) {
                        correct = check[j][0] + check[j][1] + check[j][2];
                    if (correct == 0) {
                            List<int> msg = new List<int>();

                        for (int i = 3; i < check[j].Count; i++)
                        {
                            msg.Add(check[j][i]);
                        }
                        msg.Reverse();
                        long piece = decimals.getDecimal(msg);
                        message_pieces.Add(piece);
                        //System.out.println("DECRYPTED MESSAGE PARTS IS : " + piece);
                        break;
                    }
                }
            }


        
        return generateMessage(message_pieces);

    }


    public void setValues(long p, long q, long n, long breakSize) {
        this.p = p;
        this.q = q;
        this.n = n;
        this.breakSize = breakSize;

    }

    //Generate message from the Broken Pieces

    public long modPow(long a, long d, long n) {
        //  output = a^d mod n
        long res = 1;
        for (int i = 0; i < d; i++) {
            res = res * a;
            res = res % n;

        }
        return res % n;
    }

    public long generateMessage(List<long> msg) {
        int i;
        BinaryGenerator binary1 = new BinaryGenerator();
        DecimalGenerator decimal1 = new DecimalGenerator();
        List<int> message = new List<int>();
        for (i = 0; i < msg.Count; i++) {
            List<int> temp = binary1.GenerateBinaryFormat(msg[i]);
            if (temp.Count < breakSize) {

                while (temp.Count != breakSize) {
                    temp.Add(0);
                }
            }
            temp.Reverse();
            message.AddRange(temp);
            //System.out.println(msg.get(i) + " ");
            //System.out.println(temp);

        }

           return decimal1.getDecimal(message);
        //System.out.println("Message : " + message);
        //System.out.println("Message = " + decimal1.getDecimal(message));
    }
    }
}
