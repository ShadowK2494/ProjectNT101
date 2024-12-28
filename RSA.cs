using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
using System.Reflection.Emit;

namespace ProjectNT101
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }

        // Hàm tính nghịch đảo modulo
        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1)
                return 0;

            // Áp dụng Euclid mở rộng
            while (a > 1)
            {
                // q là thương
                q = a / m;
                t = m;

                // m là số dư, tương đương với a % m
                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            // Đảm bảo x1 dương
            if (x1 < 0)
                x1 += m0;

            return x1;
        }


        private void GenerateRSAKeys(out BigInteger e, out BigInteger d, out BigInteger n)
        {
            BigInteger p, q;

            if (BigInteger.TryParse(tbP.Text, out p) && BigInteger.TryParse(tbQ.Text, out q))
            {

            }
            else
            {
                // Nếu không có giá trị hợp lệ, tự động tạo p, q ngẫu nhiên
                p = GenerateRandomPrime();
                tbP.Text = p.ToString();
                q = GenerateRandomPrime();
                tbQ.Text = q.ToString();
            }

            // Tính toán n = p * q
            n = p * q;
            BigInteger phi = (p - 1) * (q - 1); // Phi(n)

            // Kiểm tra nếu tbE có giá trị, nếu không tạo giá trị ngẫu nhiên
            if (!BigInteger.TryParse(tbE.Text, out e))
            {
                e = 65537; // Giá trị e phổ biến
                tbE.Text = e.ToString();
            }

            // Tính d (khóa riêng tư) bằng cách tìm nghịch đảo của e mod phi
            d = ModInverse(e, phi);
        }

        //Hàm kiểm tra số nguyên tố 
        private bool IsPrime(BigInteger number)
        {
            if (number < 2)
                return false;
            if (number == 2 || number == 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            BigInteger i = 5;
            while (i * i <= number)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }

        // Hàm tạo số nguyên tố ngẫu nhiên 
        private BigInteger GenerateRandomPrime(int bitLength = 32)
        {
            Random random = new Random();
            BigInteger prime;

            do
            {
                prime = GenerateRandomBigInteger(bitLength);

                // Đảm bảo rằng số sinh ra là lẻ (số chẵn không thể là số nguyên tố trừ số 2)
                if (prime % 2 == 0)
                {
                    prime += 1;
                }

            } while (!IsPrime(prime));

            return prime;
        }

        private BigInteger GenerateRandomBigInteger(int bitLength)
        {
            byte[] bytes = new byte[bitLength / 8];

            // Sử dụng RNGCryptoServiceProvider để sinh số ngẫu nhiên an toàn
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }

            return new BigInteger(bytes) | 1; // Đảm bảo số sinh ra là số dương và lẻ
        }

        private string RemoveVietnameseDiacritics(string input)
        {
            string[] vietnameseSigns = new string[]
            {
                "aáàảãạâấầẩẫậăắằẳẵặ",
                "eéèẻẽẹêếềểễệ",
                "iíìỉĩị",
                "oóòỏõọôốồổỗộơớờởỡợ",
                "uúùủũụưứừửữự",
                "yýỳỷỹỵ",
                "dđ",
                "AÁÀẢÃẠÂẤẦẨẪẬĂẮẰẲẴẶ",
                "EÉÈẺẼẸÊẾỀỂỄỆ",
                "IÍÌỈĨỊ",
                "OÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢ",
                "UÚÙỦŨỤƯỨỪỬỮỰ",
                "YÝỲỶỸỴ",
                "DĐ"
            };
            
            foreach (string signs in vietnameseSigns)
            {
                char baseChar = signs[0];
                foreach (char sign in signs.Substring(1))
                {
                    input = input.Replace(sign, baseChar);
                }
            }
            return input;
        }

        private void RSA_Load(object sender, EventArgs e)
        {
            pbCode.Hide();
            pbDecode.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCiphertext.Text = null;
            tbPlaintext.Text = null;
            tbE.Text = null;
            tbP.Text = null;
            tbQ.Text = null;
            pbCode.Hide();
            pbDecode.Hide();
        }

        private void btnMahoa_Click(object sender, EventArgs e)
        {
            pbCode.Show();
            pbDecode.Hide();
            tbCiphertext.Clear();

            BigInteger E, d, n;
            GenerateRSAKeys(out E, out d, out n); // Tạo cặp khóa từ giá trị nhập

            BigInteger p, q;


            // Kiểm tra giá trị đầu vào
            if (!tbPlaintext.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)))
            {
                tbPlaintext.Text = null;
                tbCiphertext.Text = null;
                MessageBox.Show("Vui lòng chỉ nhập ký tự chữ cái, số, hoặc ký tự hợp lệ vào vị trí văn bản cần mã hóa!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if ((BigInteger.TryParse(tbP.Text, out p) && BigInteger.TryParse(tbQ.Text, out q)) && (!IsPrime(p) || !IsPrime(q)))
            {
                    MessageBox.Show("P và Q phải là các số nguyên tố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            else
            {
                string message = tbPlaintext.Text;

                // Bỏ dấu tiếng Việt trước khi mã hóa
                message = RemoveVietnameseDiacritics(message);

                StringBuilder cipherText = new StringBuilder();

                foreach (char c in message)
                {
                    // Chuyển đổi ký tự thành số nguyên
                    BigInteger charValue = c;

                    // Mã hóa ký tự
                    BigInteger cipher = BigInteger.ModPow(charValue, E, n);

                    // Chuyển kết quả mã hóa thành chuỗi
                    cipherText.Append(cipher.ToString() + " ");
                }
                tbCiphertext.Text = cipherText.ToString().Trim();
            }            
        }

        private void btnGiaima_Click(object sender, EventArgs e)
        {
            pbDecode.Show();
            pbCode.Hide();

            BigInteger E, d, n;
            GenerateRSAKeys(out E, out d, out n); // Tạo cặp khóa từ giá trị nhập

            // Lấy thông điệp mã hóa từ TextBox
            string[] cipherValues = tbCiphertext.Text.Split(' ');
            StringBuilder decryptedMessage = new StringBuilder(); // Kết quả sau khi giải mã

            foreach (string cipher in cipherValues)
            {
                // Chuyển đổi chuỗi mã hóa thành BigInteger
                BigInteger cipherValue = BigInteger.Parse(cipher);

                // Giải mã giá trị
                BigInteger decryptedValue = BigInteger.ModPow(cipherValue, d, n);

                // Chuyển BigInteger thành ký tự
                decryptedMessage.Append((char)(int)decryptedValue);
            }

            tbPlaintext.Text = decryptedMessage.ToString();
        }
    }
}
