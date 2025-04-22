using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
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
                // Отримуємо і конвертуємо значення необхідні для обрахунку
                double A = Convert.ToDouble(txtCatetA.Text);
                double B = Convert.ToDouble(txtCatetB.Text);
                double Base = Convert.ToDouble(txtBase.Text);
                double Side = Convert.ToDouble(txtSide.Text);

                // Створення об'єктів різних трикутників
                Triangle rightTriangle = new RightTriangle(A, B);
                Triangle isoscelesTriangle = new IsoscelesTriangle(Base, Math.PI / 3); // кут 60°
                Triangle equilateralTriangle = new EquilateralTriangle(Side);

                // Виведення результатів
                lbOutput.Items.Add("Прямокутний трикутник:");
                lbOutput.Items.Add($"Площа: {rightTriangle.Area():F2}");
                lbOutput.Items.Add($"Периметр: {rightTriangle.Perimeter():F2}");

                lbOutput.Items.Add("\nРівнобедрений трикутник:");
                lbOutput.Items.Add($"Площа: {isoscelesTriangle.Area():F2}");
                lbOutput.Items.Add($"Периметр: {isoscelesTriangle.Perimeter():F2}");

                lbOutput.Items.Add("\nРівносторонній трикутник:");
                lbOutput.Items.Add($"Площа: {equilateralTriangle.Area():F2}");
                lbOutput.Items.Add($"Периметр: {equilateralTriangle.Perimeter():F2}");
            }
            catch 
            {
                // Бдок винятків
                if (string.IsNullOrEmpty(txtCatetA.Text))
                {
                    txtCatetA.Focus();
                }
                if (string.IsNullOrEmpty(txtCatetB.Text))
                {
                    txtCatetB.Focus();
                }
                if (string.IsNullOrEmpty(txtBase.Text))
                {
                    txtBase.Focus();
                }
                if (string.IsNullOrEmpty(txtSide.Text))
                {
                    txtSide.Focus();
                }
            }
        }
        // Натискання клавіші в полі введення
        private void txtCatetA_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtCatetA.Text.IndexOf(',') != -1)
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
        private void txtCatetB_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtCatetB.Text.IndexOf(',') != -1)
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
        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtBase.Text.IndexOf(',') != -1)
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
        private void txtSide_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtSide.Text.IndexOf(',') != -1)
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
