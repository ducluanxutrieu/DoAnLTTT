using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rabin_CryptoSystem
{
    public partial class Form1 : Form
    {
        long n, p = 0, q = 0;
        Encryption encryption = new Encryption();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RandomPrime prime1 = new RandomPrime();
            RandomPrime prime2 = new RandomPrime();
            while (p % 4 != 3 || q % 4 != 3)
            {
                p = prime1.generatePrime();
                q = prime2.generatePrime();

                while (p == q)
                {
                    q = prime2.generatePrime();
                }
            }
            n = p * q;

            txtP.Text = p.ToString();
            txtQ.Text = q.ToString();
            txtN.Text = n.ToString();
            txtPublicKey.Text = n.ToString();
        }

        private void txtInputMessage_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInputMessage.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtInputMessage.Text = txtInputMessage.Text.Remove(txtInputMessage.Text.Length - 1);
            }
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            Decryption decry = new Decryption();
            decry.setValues(p, q, n, encryption.getBreakSize());
            txtOriginMessage.Text = decry.Decrypt(long.Parse(txtMessageNeedDecription.Text)).ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encryption_Click(object sender, EventArgs e)
        {
            long cipher = encryption.Encrypt(long.Parse(txtInputMessage.Text), n);

            txtMessageEncryped.Text = cipher.ToString();
        }
    }
}
