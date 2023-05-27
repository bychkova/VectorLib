namespace VectorLib
{
    public class Vector
    {
        public double[] Coordinates { get; set; }

        public Vector(double[] coordinates)
        {
            Coordinates = coordinates;
        }

        public int Dimension() //размерность вектора
        {
            return this.Coordinates.Length;
        }

        public double Length() // Вычисление длины вектора
        {
            double sum = 0;

            for (int i = 0; i < this.Dimension(); i++)
            {
                sum += Coordinates[i] * Coordinates[i];
            }

            return Math.Sqrt(sum);
        }

        public Vector Normalize() // Нормализация вектора
        {
            double length = Length();

            if (length == 0)
            {
                throw new InvalidOperationException("Нельзя нормализовать нулевой вектор");
            }

            var result = new double[this.Dimension()];

            for (int i = 0; i < this.Dimension(); i++)
            {
                result[i] = Coordinates[i] / length;
            }

            return new Vector(result);
        }

        public override string ToString()
        {
            return string.Format("Вектор: {0}", string.Join(", ", Coordinates));
        }

        //сложение векторов
        public static Vector operator +(Vector v1, Vector v2)
        {
            if (v1.Dimension() != v2.Dimension())
            {
                throw new ArgumentException("Векторы должны быть одной размерности");
            }

            var result = new double[v1.Dimension()];

            for (int i = 0; i < v1.Dimension(); i++)
            {
                result[i] = v1.Coordinates[i] + v2.Coordinates[i];
            }

            return new Vector(result);
        }

        //вычитание векторов
        public static Vector operator -(Vector v1, Vector v2)
        {
            if (v1.Dimension() != v2.Dimension())
            {
                throw new ArgumentException("Векторы должны быть одной размерности");
            }

            var result = new double[v1.Dimension()];

            for (int i = 0; i < v1.Dimension(); i++)
            {
                result[i] = v1.Coordinates[i] - v2.Coordinates[i];
            }

            return new Vector(result);
        }

        // Умножение вектора на скаляр
        public static Vector operator *(double scalar, Vector v)
        {
            var result = new double[v.Dimension()];

            for (int i = 0; i < v.Dimension(); i++)
            {
                result[i] = scalar * v.Coordinates[i];
            }

            return new Vector(result);
        }

        // Скалярное произведение векторов
        public static double DotProduct(Vector v1, Vector v2)
        {
            if (v1.Dimension() != v2.Dimension())
            {
                throw new ArgumentException("Векторы должны быть одной размерности");
            }

            double sum = 0;

            for (int i = 0; i < v1.Dimension(); i++)
            {
                sum += v1.Coordinates[i] * v2.Coordinates[i];
            }

            return sum;
        }

        // Векторное произведение векторов
        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            if (v1.Dimension() != 3 || v2.Dimension() != 3)
            {
                throw new ArgumentException("Только для трехмерных векторов");
            }

            var result = new double[3];

            result[0] = v1.Coordinates[1] * v2.Coordinates[2] - v1.Coordinates[2] * v2.Coordinates[1];
            result[1] = v1.Coordinates[2] * v2.Coordinates[0] - v1.Coordinates[0] * v2.Coordinates[2];
            result[2] = v1.Coordinates[0] * v2.Coordinates[1] - v1.Coordinates[1] * v2.Coordinates[0];

            return new Vector(result);
        }

        // Вычисление угла между векторами
        public static double Angle(Vector v1, Vector v2)
        {
            if (v1.Dimension() != v2.Dimension())
            {
                throw new ArgumentException("Векторы должны быть одной размерности");
            }

            double dotProduct = DotProduct(v1, v2);
            double lengthProduct = v1.Length() * v2.Length();

            return Math.Acos(dotProduct / lengthProduct);
        }
    }
}