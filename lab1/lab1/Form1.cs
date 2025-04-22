using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1
        // Клік по кнопці ОК
        private void t1BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Введення значень x і y
                double x = Convert.ToDouble(t1TxtX.Text);
                double y = Convert.ToDouble(t1TxtY.Text);

                // Обчислення виразу
                double numerator = 3 + Math.Exp(y - 1);
                double denominator = 1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x));
                double result = numerator / denominator;

                // Вивід результату
                t1LblOutput.Text = Convert.ToString(result);
            }
            catch 
            {
                // Блок винятків
                // Якщо нічого не введено
                if (string.IsNullOrEmpty(t1TxtX.Text))
                {
                    t1TxtX.Focus();
                }
                if(string.IsNullOrEmpty(t1TxtY.Text)) 
                { 
                    t1TxtY.Focus(); 
                }
            }
        }
        // Натискання клавіши в полі введення
        private void t1TxtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t1TxtX.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t1BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіши в полі введення
        private void t1TxtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t1TxtY.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t1BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }


        //2
        // Клік по кнопці ОК
        private void t2BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Конвертація сторін
                double a = Convert.ToDouble(t2TxtA.Text);
                double b = Convert.ToDouble(t2TxtB.Text);
                double c = Convert.ToDouble(t2TxtC.Text);

                // Перевірка умови існування трикутника
                if (a + b <= c || a + c <= b || b + c <= a)
                {
                    t2LblOutput.Text = "Трикутник з такими сторонами не існує.";
                    return;
                }

                // Обчислення кутів у радіанах
                double alphaRad = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                double betaRad = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                double gammaRad = Math.Acos((a * a + b * b - c * c) / (2 * a * b));

                // Переведення в градуси
                double alphaDeg = alphaRad * 180 / Math.PI;
                double betaDeg = betaRad * 180 / Math.PI;
                double gammaDeg = gammaRad * 180 / Math.PI;

                // Вивід результатів
                t2LblOutput.Text  = $"α = {alphaRad:F4} рад = {alphaDeg:F2}°, β = {betaRad:F4} рад = {betaDeg:F2}°, γ = {gammaRad:F4} рад = {gammaDeg:F2}°";
            }
            catch 
            {
                // Блок винятків
                // Перевіряє чи введено значення в TextBox
                if (string.IsNullOrEmpty(t2TxtA.Text))
                {
                    t2TxtA.Focus();
                }
                if (string.IsNullOrEmpty(t2TxtB.Text)) 
                { 
                    t2TxtB.Focus(); 
                }
                if(string.IsNullOrEmpty(t2TxtC.Text)) 
                { 
                    t2TxtC.Focus(); 
                }
            }
        }
        // Натискання клавіши в полі введення
        private void t2TxtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t2TxtA.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t2BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіши в полі введення
        private void t2TxtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t2TxtB.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t2BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіши в полі введення
        private void t2TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t2TxtC.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t2BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        //3
        // Клік по кнопці ОК
        private void t3BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Конвертація N
                int N = Convert.ToInt32(t3TxtN.Text);

                // Знаходження результату
                bool result = (N >= 10 && N <= 99 || N <= -10 && N >= -99) && N % 2 == 0;

                // Вивід результату
                t3LblOutput.Text = Convert.ToString(result);
            }
            catch 
            {
                // Блок винятків
                t3TxtN.Focus();
            }   
        }
        // Натискання клавіши в полі введення
        private void t3TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t3TxtN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t3BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        //4
        // Клік по кнопці ОК
        private void t4BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Введення ціни
                double price = Convert.ToDouble(t4TxtPrice.Text);
                // Введення суми
                double paid = Convert.ToDouble(t4TxtMoney.Text);

                // Розрахунок різниці
                double difference = paid - price;

                // Логіка перевірки платежу
                if (difference == 0)
                {
                    t4LblOutput.Text = "Дякую!";
                }
                else if (difference > 0)
                {
                    t4LblOutput.Text = $"Візьміть решту: {difference:F2} грн.";
                }
                else
                {
                    t4LblOutput.Text = $"Недостатньо грошей! Потрібно ще {Math.Abs(difference):F2} грн.";
                }
            }
            catch 
            {
                // Блок винятків
                // Перевіряє чи введено значення в TextBox
                if (string.IsNullOrEmpty(t4TxtPrice.Text))
                {
                    t4TxtPrice.Focus();
                }
                if(string.IsNullOrEmpty(t4TxtMoney.Text)) 
                {
                    t4TxtMoney.Focus(); 
                }
            }
        }
        // Натискання клавіши в полі введення
        private void t4TxtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t4TxtPrice.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t4BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіши в полі введення
        private void t4TxtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t4TxtMoney.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t4BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        //5
        // Клік по кнопці ОК
        private void t5BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(t5TxtN.Text);
                string output = "";

                for (int M = 2; M < N; M++)
                {
                    int sum = 0;

                    // Знаходимо суму дільників числа M (без самого M)
                    for (int i = 1; i <= M / 2; i++)
                    {
                        if (M % i == 0)
                        {
                            sum += i;
                        }
                    }

                    // Якщо сума дільників дорівнює самому числу - воно досконале
                    if (sum == M)
                    {
                        output += M + ";";
                    }
                }
                t5LblOutput.Text = output;
            }
            catch
            {
                // Блок винятків
                t5TxtN.Focus();
            }
        }
        // Натискання клавіши в полі введення
        private void t5TxtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t5TxtN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t5BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        //6
        // Клік по кнопці ОК
        private void t6BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string input = t6TxtArr.Text;
                int k = Convert.ToInt32(t6TxtK.Text);

                // Розбиваємо рядок на масив
                string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> newArray = new List<int>();

                // Додаємо елементи які задовольняють умову в новий масив
                foreach (string part in parts)
                {
                    int num = int.Parse(part);
                    if (num % 10 == k)
                    {
                        newArray.Add(num);
                    }
                }
                // Вивід результату
                t6LblOutput.Text = string.Join(" ", newArray);
            }
            catch 
            {
                // Блок винятків
                if (string.IsNullOrEmpty(t6TxtArr.Text)) 
                {
                    t6TxtArr.Focus();
                }
                if(string.IsNullOrEmpty(t6TxtK.Text)) 
                {
                    t6TxtK.Focus(); 
                }
            }
        }

        // Натискання клавіши в полі введення
        private void t6TxtArr_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>, <Space>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t3TxtN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t3BtnOK.Focus();
                return;
            }
            // Додано перевірку для пробілу
            if (e.KeyChar == ' ')
            {
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіши в полі введення
        private void t6TxtK_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>, <Space>.
            // Будемо вважати правильним символом
            // також крапку, замінимо її комою.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
                return;
            }
            if (e.KeyChar == '.')
            {
                // крапку замінемо комою
                e.KeyChar = ',';
            }
            if (e.KeyChar == ',')
            {
                if (t3TxtN.Text.IndexOf(',') != -1)
                {
                    // кома вже є в полі редагування
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    t3BtnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        //7
        // Клік по кнопці ОК
        private void t7BtnOK_Click(object sender, EventArgs e)
        {
            try
            {
                string input = t7TxtString.Text;

                // Розбиваємо текст на слова
                string[] words = input.Split(new char[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                int minLength = words[0].Length;
                int maxLength = words[0].Length;

                // Перевірка довжини слова
                foreach (string word in words)
                {
                    if (word.Length < minLength)
                        minLength = word.Length;

                    if (word.Length > maxLength)
                        maxLength = word.Length;
                }

                // Вивід результатів
                t7LblOutputMin.Text = Convert.ToString(minLength);
                t7LblOutputMax.Text = Convert.ToString(maxLength);
            }
            catch 
            {
                //Блок винятків
                t7TxtString.Focus();
            }
        }

    }
}
