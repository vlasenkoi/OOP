using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
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
                string input = t1TxtArr.Text;

                // Перетворення рядка у масив чисел
                double[] array = input
                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(double.Parse)
                                .ToArray();

                // а) Кількість додатних елементів
                int positiveCount = array.Count(x => x > 0);
                lbOutput.Items.Add($"Кількість додатних елементів: {positiveCount}");

                // б) Сума елементів після останнього нуля
                int lastZeroIndex = Array.LastIndexOf(array, 0.0);
                double sumAfterLastZero = 0;
                if (lastZeroIndex != -1 && lastZeroIndex < array.Length - 1)
                {
                    sumAfterLastZero = array
                        .Skip(lastZeroIndex + 1)
                        .Sum();
                }
                lbOutput.Items.Add($"Сума елементів після останнього нуля: {sumAfterLastZero}");

                // Перетворення масиву
                var transformed = array
                    .Where(x => Math.Floor(x) <= 1)
                    .Concat(array.Where(x => Math.Floor(x) > 1))
                    .ToArray();

                lbOutput.Items.Add("Перетворений масив:");
                lbOutput.Items.Add(string.Join(" ", transformed.Select(x => x.ToString("F2"))));
            }
            catch 
            { 
                // Блок винятків
                t1TxtArr.Focus();
            }
        }
        // Натискання клавіші в полі введення
        private void t1TxtArr_KeyPress(object sender, KeyPressEventArgs e)
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
                if (t1TxtArr.Text.IndexOf(',') != -1)
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
            // Додано перевірку для пробілу
            if (e.KeyChar == ' ')
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                // дозволено мінус
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
                int rows = Convert.ToInt32(t2TxtR.Text);
                int cols = Convert.ToInt32(t2TxtC.Text);

                int[,] array = new int[rows, cols];
                Random rnd = new Random();

                // Заповнення масиву випадковими числами
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = rnd.Next(0, 100); // від 0 до 99
                    }
                }
                // a) Вивід усього масиву
                t2lbOutput.Items.Add("a) Увесь масив:");
                for (int i = 0; i < rows; i++)
                {
                    string rowLine = "";
                    for (int j = 0; j < cols; j++)
                    {
                        rowLine += array[i, j].ToString().PadLeft(4);
                    }
                    t2lbOutput.Items.Add(rowLine);
                }

                // б) Елементи п'ятого рядка (індекс 4)
                t2lbOutput.Items.Add("b) Елементи п’ятого рядка:");
                if (rows >= 5)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        t2lbOutput.Items.Add(array[4, j] + " ");
                    }
                }
                else
                {
                    t2lbOutput.Items.Add("П'ятого рядка не існує.");
                }

                // в) Елементи s-го стовпця
                int s = Convert.ToInt32(t2TxtS.Text);

                if (s >= 1 && s <= cols)
                {
                    t2lbOutput.Items.Add($"Елементи {s}-го стовпця:");
                    for (int i = 0; i < rows; i++)
                    {
                        t2lbOutput.Items.Add(array[i, s - 1]);
                    }
                }
                else
                {
                    t2lbOutput.Items.Add("Стовпець з таким номером не існує.");
                }

            }
            catch 
            {
                if (string.IsNullOrEmpty(t2TxtR.Text))
                {
                    t2TxtR.Focus();
                }
                if (string.IsNullOrEmpty(t2TxtC.Text))
                {
                    t2TxtC.Focus();
                }
                if (string.IsNullOrEmpty(t2TxtS.Text))
                {
                    t2TxtS.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення
        private void t2TxtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>, <Space>.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
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
        // Натискання клавіші в полі введення
        private void t2TxtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>, <Space>.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
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
        // Натискання клавіші в полі введення
        private void t2TxtS_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Правильними символами вважаються цифри,
            // Кома, <Enter> і <Backspace>, <Space>.
            // Інші символи заборонені.
            // Щоб заборонений символ не відображався
            // у полі редагування, привласним
            // значення true властивості Handled параметра e
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                // цифра
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
    }
}
