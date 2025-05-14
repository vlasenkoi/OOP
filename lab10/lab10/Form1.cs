using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            thread1 = new Thread(new ThreadStart(draw_rect));
            thread2 = new Thread(new ThreadStart(draw_eclips));
            thread3 = new Thread(new ThreadStart(Rnd_num));
        }
        Thread thread1;
        Thread thread2;
        Thread thread3;
        private void draw_rect()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panelThread1.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawRectangle(Pens.Pink, 0, 0, rnd.Next(this.Width),
                    rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void draw_eclips()
        {
            try
            {
                Random rnd = new Random();
                Graphics g = panelThread2.CreateGraphics();
                while (true)
                {
                    Thread.Sleep(40);
                    g.DrawEllipse(Pens.Pink, 0, 0, rnd.Next(this.Width),
                   rnd.Next(this.Height));
                }
            }
            catch (Exception ex) { }
        }
        private void Rnd_num()
        {
            try
            {
                Random rnd = new Random();
                Parallel.For(0, 500, i => {
                    rTxtThread3.Invoke((MethodInvoker)delegate ()
                    {
                        rTxtThread3.Text += rnd.Next().ToString();
                    });
                });
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // Клік по кнопці 
        private void t1BtnStartThread1_Click(object sender, EventArgs e)
        {
            thread1.Start();
            //draw_rect();
        }
        // Клік по кнопці
        private void t1BtnStartThread2_Click(object sender, EventArgs e)
        {
            thread2.Start();
            //draw_eclips();
        }
        // Клік по кнопці
        private void t1BtnStartThread3_Click(object sender, EventArgs e)
        {
            thread3.Start();
            //Rnd_num(
        }
        // Клік по кнопці
        private void t1BtnStartThreadAll_Click(object sender, EventArgs e)
        {
            thread1.Start();
            thread2.Start();
            thread3.Start();
            //draw_eclips();
            //draw_rect();
            //Rnd_num();

        }
        // Клік по кнопці
        private void t1BtnStopThread1_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
        }
        // Клік по кнопці
        private void t1BtnStopThread2_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
        }
        // Клік по кнопці
        private void t1BtnStopThread3_Click(object sender, EventArgs e)
        {
            thread3.Suspend();
        }
        // Клік по кнопці
        private void t1BtnStopThreadAll_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            thread2.Suspend();
            thread3.Suspend();
        }
        // Обробник для зупинки потоків при закритій формі
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
        }

        // Клік по кнопці
        private void t1BtnFEAL_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримання вхідного тексту з текстового поля
                string inputText = txtMesFEAL.Text;

                // Перетворення тексту у масив байтів (кодування UTF-8)
                byte[] inputBytes = Encoding.UTF8.GetBytes(inputText);

                // Фіксований 8-байтовий ключ
                byte[] key = { 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF };

                // Визначення довжини вхідних даних з доповненням до кратності 8 байтам
                int paddedLength = ((inputBytes.Length + 7) / 8) * 8;
                byte[] paddedInput = new byte[paddedLength];
                Array.Copy(inputBytes, paddedInput, inputBytes.Length);

                // Створення масивів для зашифрованих та розшифрованих даних
                byte[] encryptedBytes = new byte[paddedLength];
                byte[] decryptedBytes = new byte[paddedLength];

                // Функція F, яка використовується у кожному раунді
                byte F(byte x1, byte x2)
                {
                    int temp = (x1 + x2) & 0xFF; // Додавання по модулю 256
                    temp = ((temp << 2) | (temp >> 6)) & 0xFF; // Циклічний зсув на 2 біти вліво
                    return (byte)temp;
                }

                // Метод шифрування одного 8-байтового блоку
                byte[] EncryptBlock(byte[] block)
                {
                    // Поділ блоку на ліву (L) та праву (R) частини
                    byte[] L = new byte[4];
                    byte[] R = new byte[4];
                    Array.Copy(block, 0, L, 0, 4);
                    Array.Copy(block, 4, R, 0, 4);

                    // Виконання 4 раундів шифрування
                    for (int round = 0; round < 4; round++)
                    {
                        byte[] temp = (byte[])R.Clone(); // Збереження поточної правої частини

                        // Оновлення правої частини
                        for (int i = 0; i < 4; i++)
                        {
                            R[i] = (byte)(L[i] ^ F(R[i], key[i % 8])); // Операція XOR між L і результатом F
                        }

                        L = temp; // Обмін місцями L та R
                    }

                    // Збір результату: після шифрування перша половина — R, друга — L
                    byte[] result = new byte[8];
                    Array.Copy(R, 0, result, 0, 4);
                    Array.Copy(L, 0, result, 4, 4);
                    return result;
                }

                // Метод дешифрування одного 8-байтового блоку
                byte[] DecryptBlock(byte[] block)
                {
                    // Відновлення розподілу на праву (R) та ліву (L) частини (з урахуванням фінального обміну)
                    byte[] R = new byte[4];
                    byte[] L = new byte[4];
                    Array.Copy(block, 0, R, 0, 4);
                    Array.Copy(block, 4, L, 0, 4);

                    // Виконання 4 раундів дешифрування (у зворотному порядку)
                    for (int round = 3; round >= 0; round--)
                    {
                        byte[] temp = (byte[])L.Clone(); // Збереження поточної лівої частини

                        // Оновлення лівої частини
                        for (int i = 0; i < 4; i++)
                        {
                            L[i] = (byte)(R[i] ^ F(L[i], key[i % 8])); // Операція XOR між R і результатом F
                        }

                        R = temp; // Обмін місцями R та L
                    }

                    // Збір результату: перша половина — L, друга — R
                    byte[] result = new byte[8];
                    Array.Copy(L, 0, result, 0, 4);
                    Array.Copy(R, 0, result, 4, 4);
                    return result;
                }

                // Процес шифрування всіх блоків
                for (int i = 0; i < paddedLength; i += 8)
                {
                    byte[] block = new byte[8];
                    Array.Copy(paddedInput, i, block, 0, 8); // Взяти черговий блок
                    byte[] encryptedBlock = EncryptBlock(block); // Зашифрувати блок
                    Array.Copy(encryptedBlock, 0, encryptedBytes, i, 8); // Зберегти результат
                }

                // Процес дешифрування всіх блоків
                for (int i = 0; i < paddedLength; i += 8)
                {
                    byte[] block = new byte[8];
                    Array.Copy(encryptedBytes, i, block, 0, 8); // Взяти зашифрований блок
                    byte[] decryptedBlock = DecryptBlock(block); // Розшифрувати блок
                    Array.Copy(decryptedBlock, 0, decryptedBytes, i, 8); // Зберегти результат
                }

                // Виведення результатів на форму
                lblEncFEAL.Text = BitConverter.ToString(encryptedBytes); // Показати зашифровані дані (у вигляді шістнадцяткових байтів)
                lblDecFEAL.Text = Encoding.UTF8.GetString(decryptedBytes).TrimEnd('\0'); // Показати розшифроване повідомлення (обрізати нульові символи)
            }
            catch
            {
                // Якщо поле введення порожнє — встановити фокус на нього
                if (string.IsNullOrEmpty(txtMesFEAL.Text))
                {
                    txtMesFEAL.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення
        private void txtMesFEAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            // <Enter> і <Backspace>.
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t1BtnFEAL.Focus();
                return;
            }
        }

        // Клік по кнопці
        private void btnMD2_Click(object sender, EventArgs e)
        {
            try
            {
                // Таблиця підстановок для MD2
                byte[] S = new byte[]
                {
    41, 46, 67, 201, 162, 216, 124, 1, 61, 54, 84, 161, 236, 240, 6, 19,
    98, 167, 5, 243, 192, 199, 115, 140, 152, 147, 43, 217, 188, 76, 130, 202,
    30, 155, 87, 60, 253, 212, 224, 22, 103, 66, 111, 24, 138, 23, 229, 18,
    190, 78, 196, 214, 218, 158, 222, 73, 160, 251, 245, 142, 187, 47, 238, 122,
    169, 104, 121, 145, 21, 178, 7, 63, 148, 194, 16, 137, 11, 34, 95, 33,
    128, 127, 93, 154, 90, 144, 50, 39, 53, 62, 204, 231, 191, 247, 151, 3,
    255, 25, 48, 179, 72, 165, 181, 209, 215, 94, 146, 42, 172, 86, 170, 198,
    79, 184, 56, 210, 150, 164, 125, 182, 118, 252, 107, 226, 156, 116, 4, 241,
    69, 157, 112, 89, 100, 113, 135, 32, 134, 91, 207, 101, 230, 45, 168, 2,
    27, 96, 37, 173, 174, 176, 185, 246, 28, 70, 97, 105, 52, 64, 126, 15,
    85, 71, 163, 35, 221, 81, 175, 58, 195, 92, 249, 206, 186, 197, 234, 38,
    44, 83, 13, 110, 133, 40, 132, 9, 211, 223, 205, 244, 65, 129, 77, 82,
    106, 220, 55, 200, 108, 193, 171, 250, 36, 225, 123, 8, 12, 189, 177, 74,
    120, 136, 149, 139, 227, 99, 232, 109, 233, 203, 213, 254, 59, 0, 29, 57,
    242, 239, 183, 14, 102, 88, 208, 228, 166, 119, 114, 248, 235, 117, 75, 10,
    49, 68, 80, 180, 143, 237, 31, 26, 219, 153, 141, 51, 159, 17, 131, 20
                };

                // Введення тексту для хешування
                string inputText = txtMesMD2.Text; // або будь-який інший спосіб

                // Крок 1: Перетворення тексту у байти
                byte[] input = Encoding.UTF8.GetBytes(inputText);

                // Крок 2: Додавання паддінгу (доповнення до кратності 16)
                int paddingLength = 16 - (input.Length % 16);
                byte[] paddedInput = new byte[input.Length + paddingLength];
                Array.Copy(input, paddedInput, input.Length);
                for (int i = input.Length; i < paddedInput.Length; i++)
                    paddedInput[i] = (byte)paddingLength;

                // Крок 3: Ініціалізація буферів
                byte[] checksum = new byte[16];
                byte[] state = new byte[48];

                // Крок 4: Прохід по всім 16-байтовим блокам
                for (int i = 0; i < paddedInput.Length / 16; i++)
                {
                    // Копіювати блок
                    byte[] block = new byte[16];
                    Array.Copy(paddedInput, i * 16, block, 0, 16);

                    // 4.1: Копіювати block в state
                    Array.Copy(block, 0, state, 0, 16);

                    // 4.2: Додати XOR'ом block і checksum
                    for (int j = 0; j < 16; j++)
                        state[16 + j] = (byte)(block[j] ^ state[j]);

                    // 4.3: Копіювати checksum у state
                    Array.Copy(checksum, 0, state, 32, 16);

                    // 4.4: 18 раундів змішування
                    byte t = 0;
                    for (int round = 0; round < 18; round++)
                    {
                        for (int j = 0; j < 48; j++)
                        {
                            state[j] ^= S[t];
                            t = state[j];
                        }
                        t = (byte)((t + round) & 0xFF);
                    }

                    // 4.5: Оновити checksum
                    byte l = checksum[15];
                    for (int j = 0; j < 16; j++)
                    {
                        checksum[j] ^= S[block[j] ^ l];
                        l = checksum[j];
                    }
                }

                // Крок 5: Додаємо checksum як останній блок і робимо ще один раунд
                byte[] finalInput = new byte[state.Length + 16];
                Array.Copy(paddedInput, 0, finalInput, 0, paddedInput.Length);
                Array.Copy(checksum, 0, finalInput, paddedInput.Length, 16);

                // Остання обробка
                Array.Copy(checksum, 0, state, 0, 16);
                for (int j = 0; j < 16; j++)
                    state[16 + j] = (byte)(checksum[j] ^ state[j]);
                Array.Copy(checksum, 0, state, 32, 16);

                // 18 фінальних раундів
                {
                    byte t = 0;
                    for (int round = 0; round < 18; round++)
                    {
                        for (int j = 0; j < 48; j++)
                        {
                            state[j] ^= S[t];
                            t = state[j];
                        }
                        t = (byte)((t + round) & 0xFF);
                    }
                }

                // Крок 6: Отримання хешу (перші 16 байтів стану)
                byte[] hash = new byte[16];
                Array.Copy(state, 0, hash, 0, 16);

                // Виведення результату у вигляді шістнадцяткового рядка
                lblEncMD2.Text = BitConverter.ToString(hash).Replace("-", "");
            }
            catch 
            {
                if (string.IsNullOrEmpty(txtMesMD2.Text))
                {
                    txtMesMD2.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення
        private void txtMesMD2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // <Enter> і <Backspace>.
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t1BtnFEAL.Focus();
                return;
            }
        }

        //Клік по кнопці
        private void btnMcelience_Click(object sender, EventArgs e)
        {
            try
            {
                // Генераторна матриця G (4х7)
                int[,] G = {
            {1,0,0,0,1,1,0},
            {0,1,0,0,1,0,1},
            {0,0,1,0,0,1,1},
            {0,0,0,1,1,1,1}
        };

                // Перевірочна матриця H (3х7)
                int[,] H = {
            {1, 1, 0, 1, 0, 0, 0},
            {0, 1, 1, 0, 1, 0, 0},
            {1, 0, 1, 0, 0, 1, 0}
        };

                // Введення повідомлення
                string message = txtMesMcelience.Text;

                // Перетворення повідомлення у біти
                List<int> messageBits = new List<int>();
                foreach (char c in message)
                {
                    byte b = (byte)c;
                    for (int i = 7; i >= 0; i--)
                    {
                        messageBits.Add((b >> i) & 1);
                    }
                }

                // Доповнення бітів, щоб їх кількість ділилася на 4
                while (messageBits.Count % 4 != 0)
                {
                    messageBits.Add(0);
                }

                // Шифрування блоками по 4 біти
                List<int> encryptedBits = new List<int>();
                for (int i = 0; i < messageBits.Count; i += 4)
                {
                    int[] m = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        m[j] = messageBits[i + j];
                    }

                    int[] c = new int[7];
                    for (int j = 0; j < 7; j++)
                    {
                        c[j] = (m[0] * G[0, j] + m[1] * G[1, j] + m[2] * G[2, j] + m[3] * G[3, j]) % 2;
                        encryptedBits.Add(c[j]);
                    }
                }

                // Об'єднуємо зашифровані біти в один рядок
                string encryptedMessage = string.Join("", encryptedBits.Select(bit => bit.ToString()));

                // Виведення зашифрованого повідомлення в Label
                lblEncMcelience.Text = encryptedMessage;

                // Дешифрування
                List<int> decryptedBits = new List<int>();

                for (int i = 0; i < encryptedBits.Count; i += 7)
                {
                    int[] c = new int[7];
                    for (int j = 0; j < 7; j++)
                    {
                        c[j] = encryptedBits[i + j];
                    }

                    // Обчислення синдрому для перевірки помилок
                    int[] syndrome = new int[3];
                    for (int j = 0; j < 3; j++)
                    {
                        syndrome[j] = 0;
                        for (int k = 0; k < 7; k++)
                        {
                            syndrome[j] ^= (H[j, k] * c[k]) % 2;
                        }
                    }

                    // Відновлення початкових 4 бітів
                    int[] decryptedBlock = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        decryptedBlock[j] = c[j]; // Використовуємо перші 4 біти
                    }

                    // Додаємо відновлені біти до списку результату
                    decryptedBits.AddRange(decryptedBlock);
                }

                // Перетворюємо бітове повідомлення назад у символи
                StringBuilder decryptedMessage = new StringBuilder();
                for (int i = 0; i < decryptedBits.Count; i += 8)
                {
                    byte b = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        if (i + j < decryptedBits.Count)
                        {
                            b |= (byte)(decryptedBits[i + j] << (7 - j));
                        }
                    }
                    decryptedMessage.Append((char)b);
                }

                // Виведення дешифрованого повідомлення
                lblDecMcelience.Text = Convert.ToString(decryptedMessage);
            }
            catch
            {
                if (string.IsNullOrEmpty(txtMesMcelience.Text))
                {
                    txtMesMcelience.Focus();
                }
            }
        }
        // Натискання в полі введення
        private void txtMesMcelience_KeyPress(object sender, KeyPressEventArgs e)
        {
            // <Enter> і <Backspace>.
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t1BtnFEAL.Focus();
                return;
            }
        }
    }
}
