using System;

namespace VectorLib
{
    class Demo
    {
        static void Main(string[] args)
        {
            // Создание векторов
            Vector v1 = new Vector(new double[] { 1, 2, 3 });
            Vector v2 = new Vector(new double[] { 4, 5, 6 });

            // Вычисление длины вектора
            Console.WriteLine("\nВычисление длины вектора:");
            Console.WriteLine("v2: " + v2.ToString());
            double length = v2.Length();
            Console.WriteLine($"Длина вектора {v2.ToString()} = {length}");

            // Нормализация вектора
            Console.WriteLine("\nНормализация вектора:");
            Console.WriteLine("v1: " + v1.ToString());
            Vector normalized = v1.Normalize();
            Console.WriteLine($"Нормализация вектора {v1.ToString()} = {normalized.ToString()}");

            //сложение векторов
            Console.WriteLine("\nСложение векторов:");
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Vector v3 = v1 + v2;
            Console.WriteLine($"Сложение вектора {v1.ToString()} и вектора {v2.ToString()} = вектор: {v3.ToString()}");


            //вычитание векторов
            Console.WriteLine("\nВычитание векторов:");
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Vector v4 = v1 + v2;
            Console.WriteLine($"Разность вектора {v1.ToString()} и вектора {v2.ToString()} = вектор: {v4.ToString()}");

            // Умножение вектора на скаляр
            Console.WriteLine("\nУмножение вектора на скаляр:");
            Console.WriteLine("v1: " + v1.ToString());
            double scalar = 3;
            Vector result1 = scalar * v1;
            Console.WriteLine($"Умножение вектора {v1.ToString()} на скаляр {scalar} = {result1.ToString()}");

            // Скалярное произведение векторов
            Console.WriteLine("\nСкалярное произведение векторов:");
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            double dotProduct = Vector.DotProduct(v1, v2);
            Console.WriteLine($"Скалярное произведение векторов {v1.ToString()} и {v2.ToString()} = {dotProduct}");

            // Векторное произведение векторов
            Console.WriteLine("\nВекторное произведение векторов:");
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            Vector crossProduct = Vector.CrossProduct(v1, v2);
            Console.WriteLine($"Векторное произведение векторов {v1.ToString()} и {v2.ToString()} = {crossProduct.ToString()}");

            // Вычисление угла между векторами
            Console.WriteLine("\nВычисление угла между векторами:");
            Console.WriteLine("v1: " + v1.ToString());
            Console.WriteLine("v2: " + v2.ToString());
            double angle = Vector.Angle(v1, v2);
            Console.WriteLine($"Угол между векторами {v1.ToString()} и {v2.ToString()} = {angle}");
        }
    }
}