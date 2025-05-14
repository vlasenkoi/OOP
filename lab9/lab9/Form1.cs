using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picBoxOutput.Paint += new PaintEventHandler(this.picBoxOutput_Paint);
        }

        float a = 1;
       
        private void picBoxOutput_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int width = picBoxOutput.Width;
            int height = picBoxOutput.Height;

            // Центр координат
            int centerX = width / 2;
            int centerY = height / 2;

            Pen axisPen = new Pen(Color.Black, 2);
            Pen graphPen = new Pen(Color.Blue, 2);
            Font font = new Font("Arial", 10);

            // Малюємо осі
            g.DrawLine(axisPen, 0, centerY, width, centerY); // Ox
            g.DrawLine(axisPen, centerX, 0, centerX, height); // Oy

            // Малюємо поділки та підписи
            for (int i = -10; i <= 10; i++)
            {
                int x = centerX + i * 40;
                int y = centerY - i * 40;

                // поділки по X
                g.DrawLine(Pens.Black, x, centerY - 5, x, centerY + 5);
                g.DrawString(i.ToString(), font, Brushes.Black, x - 10, centerY + 10);

                // поділки по Y
                g.DrawLine(Pens.Black, centerX - 5, y, centerX + 5, y);
                if (i != 0)
                    g.DrawString((-i).ToString(), font, Brushes.Black, centerX + 10, y - 10);
            }

            // Малюємо графік
            PointF? prevPoint = null;
            for (float t = -10; t <= 10; t += 0.01f)
            {
                float x = a * (t - (float)Math.Sin(t));
                float y = a * (t - (float)Math.Cos(t));

                float drawX = centerX + x * 40;
                float drawY = centerY - y * 40;

                PointF currentPoint = new PointF(drawX, drawY);

                if (prevPoint != null)
                {
                    g.DrawLine(graphPen, prevPoint.Value, currentPoint);
                }

                prevPoint = currentPoint;
            }

            // Підписи осей
            g.DrawString("X", font, Brushes.Black, width - 20, centerY + 10);
            g.DrawString("Y", font, Brushes.Black, centerX + 10, 5);
        }

        // Клік по кнопці ОК
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                a = float.Parse(txtA.Text);
                picBoxOutput.Invalidate();
            }
            catch 
            {
                if (string.IsNullOrEmpty(txtA.Text))
                {
                    txtA.Focus();
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
    }
}
