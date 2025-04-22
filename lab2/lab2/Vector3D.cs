using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Vector3D
    {
        private double x;
        private double y;
        private double z;

        // Властивість для координати X
        public double X
        {
            get { return x; } 
            set { x = value; } 
        }

        // Властивість для координати Y
        public double Y
        {
            get { return y; } 
            set { y = value; } 
        }

        // Властивість для координати Z
        public double Z
        {
            get { return z; } 
            set { z = value; } 
        }

        // Перший конструктор: без параметрів
        public Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        // Другий конструктор: з параметрами
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Третій конструктор: копіювання іншого вектора
        public Vector3D(Vector3D vector)
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        // Метод для додавання векторів
        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        // Метод для віднімання векторів
        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        // Метод для обчислення скалярного добутку
        public double DotProduct(Vector3D other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        // Метод для обчислення довжини вектора
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        // Метод для обчислення косинуса кута між двома векторами
        public double CosineBetween(Vector3D other)
        {
            double dotProduct = DotProduct(other);
            double lengthsProduct = Length() * other.Length();
            return dotProduct / lengthsProduct;
        }

        // Перевантаження методу ToString для виведення вектора
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
