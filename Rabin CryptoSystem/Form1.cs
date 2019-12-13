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

            //Tìm ra hai số q và p thỏa mãn yêu cầu: p,q có tính chất p ≡ 3 mod 4, q ≡ 3 mod 4
            while (p % 4 != 3 || q % 4 != 3)
            {
                p = prime1.generatePrime(); //Tạo hai số - và q ngẫu nhiên cho đến khi thỏa mãn yêu cầu nêu trên
                q = prime2.generatePrime();

                //Nếu như p == q  thì phải ramdom lại một trong hai để có được kết quả p==q
                while (p == q)
                {
                    q = prime2.generatePrime();
                }
            }

            //Khóa công khai là giá trị của p*q khi thỏa mãn yêu cầu.
            n = p * q;

            txtP.Text = p.ToString(); //Hiển thị p, q,  ra màn hình theo đúng vị trí và n chính là khóa công khai (txtPublicKey)
            txtQ.Text = q.ToString();
            txtN.Text = n.ToString();
            txtPublicKey.Text = n.ToString();
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {
            Decryption decry = new Decryption();
            decry.setValues(p, q, n, encryption.getBreakSize());
            txtOriginMessage.Text = decry.Decrypt(long.Parse(txtMessageNeedDecription.Text)).ToString();
        }

        private void txtInputMessage_TextChanged(object sender, EventArgs e)
        {
            //Chỉ cho phép người dùng nhập số, nếu như nhập chữ vào thì sẽ có một Dialog hiển thị lên đồng thời xóa chữ cái đó
            if (System.Text.RegularExpressions.Regex.IsMatch(txtInputMessage.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số.");
                txtInputMessage.Text = txtInputMessage.Text.Remove(txtInputMessage.Text.Length - 1);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_encryption_Click(object sender, EventArgs e)
        {
            //Khi nhấn nút Mã Hóa thì sẽ gọi hàm mã hóa để tính ra ddiojcw giá trị đã mã hóa
            long cipher = encryption.Encrypt(long.Parse(txtInputMessage.Text), n);
            //Hiển thị Message đã mã hóa ra màn hình
            txtMessageEncryped.Text = cipher.ToString();
        }
    }
}
