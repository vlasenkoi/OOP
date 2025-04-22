using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Triangle
    {
        // Поля для зберігання двох сторін та кута між ними
        protected double side1;
        protected double side2;
        protected double angle; // Кут між сторонами у радіанах

        // Конструктор для ініціалізації сторін і кута
        public Triangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
        }

        // Абстрактні методи для обчислення площі та периметра
        public abstract double Area();
        public abstract double Perimeter();
    }

    class RightTriangle : Triangle
    {
        // Конструктор для прямокутного трикутника
        public RightTriangle(double side1, double side2)
            : base(side1, side2, 90) { }

        // Периметр прямокутного трикутника: a + b + c
        public override double Perimeter()
        {
            double hypotenuse = Math.Sqrt(side1 * side1 + side2 * side2); // Гіпотенуза
            return side1 + side2 + hypotenuse;
        }

        // Площа прямокутного трикутника: 0.5 * a * b
        public override double Area()
        {
            return 0.5 * side1 * side2;
        }
    }

    class IsoscelesTriangle : Triangle
    {
        // Конструктор для рівнобедреного трикутника
        public IsoscelesTriangle(double side1, double angle)
            : base(side1, side1, angle) { }

        // Периметр рівнобедреного трикутника: 2 * side1 + side2
        public override double Perimeter()
        {
            // Використовуємо косинусну теорему для обчислення третьої сторони
            double side2 = Math.Sqrt(2 * side1 * side1 - 2 * side1 * side1 * Math.Cos(angle));
            return 2 * side1 + side2;
        }

        // Площа рівнобедреного трикутника: 0.5 * a * b * sin(angle)
        public override double Area()
        {
            return 0.5 * side1 * side1 * Math.Sin(angle);
        }
    }

    class EquilateralTriangle : Triangle
    {
        // Конструктор для рівностороннього трикутника
        public EquilateralTriangle(double side)
            : base(side, side, 60) { }

        // Периметр рівностороннього трикутника: 3 * side
        public override double Perimeter()
        {
            return 3 * side1;
        }

        // Площа рівностороннього трикутника: (sqrt(3) / 4) * side^2
        public override double Area()
        {
            return (Math.Sqrt(3) / 4) * side1 * side1;
        }
    }
}
