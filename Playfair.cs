using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectNT101
{
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }

        // Tạo bảng mã Playfair từ từ khóa
        private char[,] GenerateMatrix(string keyword)
        {
            // Chuẩn hóa từ khóa: chuyển thành chữ in hoa và loại bỏ khoảng trắng
            keyword = NormalizeInput(keyword).Replace(" ", "");

            // Loại bỏ các ký tự trùng lặp trong từ khóa
            keyword = new string(keyword.Distinct().ToArray());

            // Định nghĩa bảng chữ cái mở rộng gồm chữ cái (không có 'J') và chữ số
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Loại bỏ các ký tự không thuộc bảng chữ cái mở rộng
            keyword = new string(keyword.Where(c => alphabet.Contains(c)).ToArray());

            // Kết hợp từ khóa với các ký tự còn lại trong bảng chữ cái
            string matrixString = keyword + new string(alphabet.Where(c => !keyword.Contains(c)).ToArray());

            // Đảm bảo chuỗi matrixString chỉ dài 36 ký tự
            matrixString = new string(matrixString.Take(36).ToArray());

            // Khởi tạo ma trận 6x6
            char[,] matrix = new char[6, 6];
            for (int i = 0; i < 36; i++) // 6x6 = 36
            {
                matrix[i / 6, i % 6] = matrixString[i];
            }

            return matrix;
        }

        // Hiển thị ma trận Playfair trong TextBox
        private void DisplayMatrix(char[,] matrix)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    sb.Append(matrix[row, col] + " ");
                }
                sb.AppendLine();
            }
            textMatrix.Text = sb.ToString();
        }

        // Chuẩn bị văn bản (xử lý lặp ký tự, thêm 'X')
        private string PrepareText(string input, bool isDecrypting = false)
        {
            input = input.ToUpper().Replace(" ", "");
            if (!isDecrypting)
            {
                string preparedText = "";
                for (int i = 0; i < input.Length; i += 2)
                {
                    preparedText += input[i];
                    if (i + 1 < input.Length)
                    {
                        preparedText += (input[i] == input[i + 1]) ? "X" + input[i + 1] : input[i + 1].ToString();
                    }
                }
                if (preparedText.Length % 2 != 0) preparedText += "X";
                return preparedText;
            }
            return input; // Không thay đổi văn bản khi giải mã
        }

        // Tìm vị trí ký tự trong bảng
        private (int, int) FindPosition(char[,] matrix, char c)
        {
            for (int row = 0; row < 6; row++) // Ma trận 6x6
            {
                for (int col = 0; col < 6; col++)
                {
                    if (matrix[row, col] == c) return (row, col);
                }
            }
            throw new Exception("Character not found in matrix");
        }


        // Hàm mã hóa/giải mã
        private string ProcessText(string input, string keyword, bool isDecrypting = false)
        {
            char[,] matrix = GenerateMatrix(keyword);
            DisplayMatrix(matrix); // Hiển thị ma trận Playfair
            string processedText = PrepareText(input, isDecrypting);
            string result = "";

            int shift = isDecrypting ? -1 : 1;

            for (int i = 0; i < processedText.Length; i += 2)
            {
                char a = processedText[i], b = processedText[i + 1];
                (int rowA, int colA) = FindPosition(matrix, a);
                (int rowB, int colB) = FindPosition(matrix, b);

                if (rowA == rowB) // Cùng hàng
                {
                    result += matrix[rowA, (colA + shift + 6) % 6];
                    result += matrix[rowB, (colB + shift + 6) % 6];
                }
                else if (colA == colB) // Cùng cột
                {
                    result += matrix[(rowA + shift + 6) % 6, colA];
                    result += matrix[(rowB + shift + 6) % 6, colB];
                }
                else // Hình chữ nhật
                {
                    result += matrix[rowA, colB];
                    result += matrix[rowB, colA];
                }
            }
            return result;
        }

        public static string NormalizeInput(string input)
        {
            // Bước 1: Loại bỏ dấu tiếng Việt
            string noDiacritics = RemoveDiacritics(input);

            // Bước 2: Loại bỏ ký tự đặc biệt (chỉ giữ lại chữ cái và số)
            string alphanumericOnly = Regex.Replace(noDiacritics, @"[^a-zA-Z0-9\s]", "");

            // Bước 3: Chuyển đổi toàn bộ chữ cái sang in hoa
            string upperCase = alphanumericOnly.ToUpper();

            // Trả về chuỗi kết quả
            return upperCase;
        }

        private static string RemoveDiacritics(string text)
        {
            string normalizedString = text.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                if (c == 'Đ' || c == 'đ')
                {
                    stringBuilder.Append('D');
                    continue;
                }

                System.Globalization.UnicodeCategory unicodeCategory = System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        // Hàm kiểm tra ký tự có phải là chữ tiếng Việt (có dấu hoặc không dấu)
        private bool IsVietnameseLetter(char c)
        {
            string vietnameseLetters = "aăâáàạảãắằặẳẵấầậẩẫ" + // chữ cái thường
                                       "eêéèẹẻẽếềệểễ" +
                                       "iíìịỉĩ" +
                                       "oôơóòọỏõốồộổỗớờợởỡ" +
                                       "uưúùụủũứừựửữ" +
                                       "yýỳỵỷỹ" +
                                       "AĂÂÁÀẠẢÃẮẰẶẲẴẤẦẬẨẪ" + // chữ cái in hoa
                                       "EÊÉÈẸẺẼẾỀỆỂỄ" +
                                       "IÍÌỊỈĨ" +
                                       "OÔƠÓÒỌỎÕỐỒỘỔỖỚỜỢỞỠ" +
                                       "UƯÚÙỤỦŨỨỪỰỬỮ" +
                                       "YÝỲỴỶỸ" +
                                       "đĐ"; // thêm ký tự đ và Đ
            return vietnameseLetters.Contains(c);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = NormalizeInput(textInput.Text.Replace("\r\n", "").Replace("\n","").ToUpper());
            string keyword = NormalizeInput(textKey.Text.Replace("\n", "").ToUpper());
            textOutput.Clear();
            textMatrix.Clear();

            if (string.IsNullOrWhiteSpace(plaintext) || string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập cả văn bản và từ khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!keyword.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || IsVietnameseLetter(c)))
            {
                MessageBox.Show("Từ khóa không được chứa các ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!plaintext.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c) || IsVietnameseLetter(c)))
            {
                MessageBox.Show("Văn bản không được chứa các ký tự đặc biệt!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textOutput.Text = ProcessText(plaintext, keyword, isDecrypting: false);
        }


        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = NormalizeInput(textInput.Text);
            string keyword = NormalizeInput(textKey.Text);
            textOutput.Clear();
            textMatrix.Clear();

            if (string.IsNullOrWhiteSpace(ciphertext) || string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Vui lòng nhập cả bản mã và từ khóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textOutput.Text = ProcessText(ciphertext, keyword, isDecrypting: true);
        }
    } 
}