using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
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
                // Отримуємо та конвертуємо координати векторів
                double v1X = Convert.ToDouble(v1TxtX.Text);
                double v1Y = Convert.ToDouble(v1TxtY.Text);
                double v1Z = Convert.ToDouble(v1TxtZ.Text);

                double v2X = Convert.ToDouble(v2TxtX.Text);
                double v2Y = Convert.ToDouble(v2TxtY.Text);
                double v2Z = Convert.ToDouble(v2TxtZ.Text);

                // Створення векторів
                Vector3D v1 = new Vector3D(v1X, v1Y, v1Z);
                Vector3D v2 = new Vector3D(v2X, v2Y, v2Z);

                // Додавання векторів
                Vector3D sum = v1 + v2;
                lbOutput.Items.Add($"Сума векторів: {sum}");

                // Віднімання векторів
                Vector3D difference = v1 - v2;
                lbOutput.Items.Add($"Різниця векторів: {difference}");

                // Обчислення скалярного добутку
                double dotProduct = v1.DotProduct(v2);
                lbOutput.Items.Add($"Скалярний добуток: {dotProduct}");

                // Обчислення довжини вектора
                double lengthV1 = v1.Length();
                lbOutput.Items.Add($"Довжина вектора v1: {lengthV1}");

                double lengthV2 = v2.Length();
                lbOutput.Items.Add($"Довжина вектора v2: {lengthV2}");

                // Обчислення косинуса кута між векторами
                double cos = v1.CosineBetween(v2);
                lbOutput.Items.Add($"Косинус кута між векторами: {cos}");
            }
            catch 
            {
                // Блок винятків
                if (string.IsNullOrEmpty(v1TxtX.Text))
                {
                    v1TxtX.Focus();
                }
                if (string.IsNullOrEmpty(v1TxtY.Text))
                {
                    v1TxtY.Focus();
                }
                if (string.IsNullOrEmpty(v1TxtZ.Text))
                {
                    v1TxtZ.Focus();
                }
                if (string.IsNullOrEmpty(v2TxtX.Text))
                {
                    v2TxtX.Focus();
                }
                if (string.IsNullOrEmpty(v2TxtY.Text))
                {
                    v2TxtY.Focus();
                }
                if (string.IsNullOrEmpty(v2TxtZ.Text))
                {
                    v2TxtZ.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення 
        private void v1TxtX_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v1TxtX.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void v1TxtY_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v1TxtY.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void v1TxtZ_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v1TxtZ.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void v2TxtX_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v2TxtX.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void v2TxtY_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v2TxtY.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void v2TxtZ_KeyPress(object sender, KeyPressEventArgs e)
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
                if (v2TxtZ.Text.IndexOf(',') != -1)
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
                    btnOK.Focus();
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
}
