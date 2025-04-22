using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Клік по кнопці ОК
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо текст із TextBox'ів
                string input = txtString.Text;
                string wordToRemove = txtWord.Text;

                // а) Підрахунок кількості однакових слів

                // Створюємо словник для підрахунку слів (регістр не враховується)
                Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                // Розділяємо рядок на слова, прибираючи порожні елементи
                string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Обходимо всі слова в масиві
                foreach (string word in words)
                {
                    // Якщо слово вже є у словнику — збільшуємо лічильник
                    if (wordCount.ContainsKey(word))
                        wordCount[word]++;
                    else
                        // Інакше додаємо слово з лічильником 1
                        wordCount[word] = 1;
                }

                // Додаємо заголовок до ListBox
                lbOutput.Items.Add("Слова, які зустрічаються два або більше разів:");

                bool hasDuplicates = false; // Прапорець, щоб знати чи були такі слова

                // Обходимо словник і виводимо тільки ті слова, які зустрічаються 2 або більше разів
                foreach (var pair in wordCount)
                {
                    if (pair.Value >= 2)
                    {
                        lbOutput.Items.Add($"Слово: \"{pair.Key}\" — {pair.Value} раз(и)");
                        hasDuplicates = true;
                    }
                }

                // Якщо не знайдено жодного повторюваного слова
                if (!hasDuplicates)
                {
                    lbOutput.Items.Add("Таких слів немає.");
                }

                // б) Видалення заданого слова з рядка
                // Формуємо новий рядок, у якому всі входження заданого слова видалено
                string result = string.Join(" ",
                    words.Where(w => !w.Equals(wordToRemove, StringComparison.OrdinalIgnoreCase)));

                // Виводимо результат у ListBox
                lbOutput.Items.Add($"Рядок після видалення слова \"{wordToRemove}\":");
                lbOutput.Items.Add(result);
            }
            catch 
            {
                if (string.IsNullOrEmpty(txtString.Text))
                {
                    txtString.Focus();
                }
                if (string.IsNullOrEmpty(txtWord.Text)) 
                {
                    txtWord.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення
        private void txtString_KeyPress(object sender, KeyPressEventArgs e)
        {
            // <Enter> і <Backspace>.
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
        }
        // Натискання клавіші в полі введення
        private void txtWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            // <Enter> і <Backspace>.
            if (Char.IsControl(e.KeyChar))
            {
                // <Enter>, <Backspace>, <Esc>
                if (e.KeyChar == (char)Keys.Enter)
                    // натиснута клавіша <Enter>
                    // встановити курсор на кнопку OK
                    btnOK.Focus();
                return;
            }
        }
    }
}
