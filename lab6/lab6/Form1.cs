using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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
                // Ввід коефіцієнтів
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                // Обчислення дискримінанта
                double D = b * b - 4 * a * c;

                lbOutput.Items.Add($"Дискримінант D = {D}");

                // Аналіз дискримінанта
                if (a == 0)
                {
                    lbOutput.Items.Add("Це не квадратне рівняння (a = 0).");
                }
                else if (D > 0)
                {
                    // Два дійсні корені
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    lbOutput.Items.Add($"Рівняння має два дійсні корені: x₁ = {x1}, x₂ = {x2}");
                }
                else if (D == 0)
                {
                    // Один дійсний корінь
                    double x = -b / (2 * a);
                    lbOutput.Items.Add($"Рівняння має один дійсний корінь: x = {x}");
                }
                else
                {
                    // Коренів немає в області дійсних чисел
                    lbOutput.Items.Add("Рівняння не має дійсних коренів.");
                }
            }
            catch 
            {
                // Блок винятків
                if (string.IsNullOrEmpty(txtA.Text))
                {
                    txtA.Focus();
                }
                if (string.IsNullOrEmpty(txtB.Text)) 
                {
                    txtB.Focus(); 
                }
                if(string.IsNullOrEmpty(txtC.Text)) 
                {
                    txtC.Focus(); 
                }
            }
        }
        // Натискання клавіші в полі введення
        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtA.Text.IndexOf(',') != -1)
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
            if (e.KeyChar == '-')
            {
                // дозволено мінус
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtB.Text.IndexOf(',') != -1)
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
            if (e.KeyChar == '-')
            {
                // дозволено мінус
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        // Натискання клавіші в полі введення
        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtC.Text.IndexOf(',') != -1)
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
            if (e.KeyChar == '-')
            {
                // дозволено мінус
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
    }
}
