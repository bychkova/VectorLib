namespace VectorLib;

public class VectorTests
{
    private const double Precision = 0.000001;
    // Вычисление длины вектора
    [Test]
    public void Length_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] { 2, 3 });
        double expected = 3.605551275463989;

        double actual = v2Dim.Length();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Length_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -2, -4, -6 });
        double expected = 7.483314773547883;

        double actual = v3Dim.Length();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Length_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { -7, 8, 0, 6 });
        double expected = 12.206555615733702;

        double actual = v4Dim.Length();

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Length_3Dim_ZeroCoor()
    {
        Vector v3Dim = new Vector(new double[] { 0, 0, 0 });
        double expected = 0;

        double actual = v3Dim.Length();

        Assert.AreEqual(expected, actual);
    }

    // Нормализация вектора
    [Test]
    public void Normalize_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] { 3, 10 });
        Vector expected = new Vector(new double[] {0.2873478855663454, 0.9578262852211513});

        Vector actual = v2Dim.Normalize();
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Normalize_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -6, -3, -15 });
        Vector expected = new Vector(new double[] { -0.36514837167011077, -0.18257418583505539, -0.9128709291752769 });

        Vector actual = v3Dim.Normalize();
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }
    [Test]
    public void Normalize_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { -6, 3, -15, 0 });
        Vector expected = new Vector(new double[] { -0.36514837167011077, 0.18257418583505539, -0.9128709291752769, 0 });

        Vector actual = v4Dim.Normalize();
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }
    // сложение векторов
    [Test]
    public void Sum_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] { 25, 17 });
        Vector v2Dim2 = new Vector(new double[] { 25, 33 });
        Vector expected = new Vector(new double[] {50, 50 });

        Vector actual = v2Dim + v2Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sum_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -25, -17 , -3});
        Vector v3Dim2 = new Vector(new double[] { -25, -33, -4 });
        Vector expected = new Vector(new double[] { -50, -50, -7 });

        Vector actual = v3Dim + v3Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sum_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { -25, 17, 3, 0 });
        Vector v4Dim2 = new Vector(new double[] { 25, -33, 0, 4 });
        Vector expected = new Vector(new double[] { 0, -16, 3, 4 });

        Vector actual = v4Dim + v4Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sum_ThrowsExeption()
    {
        Vector v2Dim = new Vector(new double[] { 3, 0 });
        Vector v4Dim = new Vector(new double[] { 25, -33, 0, 4 });
        Vector expected = new Vector(new double[] { 0, -16, 3, 4 });

        Vector actual = v2Dim + v4Dim;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    // вычитание векторов
    [Test]
    public void Sub_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] { 25, 17 });
        Vector v2Dim2 = new Vector(new double[] { 25, 33 });
        Vector expected = new Vector(new double[] { 0, -16 });

        Vector actual = v2Dim - v2Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sub_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -25, -17, -3 });
        Vector v3Dim2 = new Vector(new double[] { -25, -33, -4 });
        Vector expected = new Vector(new double[] { 0, 16, 1 });

        Vector actual = v3Dim - v3Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sub_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { -25, 17, 3, 0 });
        Vector v4Dim2 = new Vector(new double[] { 25, -33, 0, 4 });
        Vector expected = new Vector(new double[] { -50, 50, 3, -4 });

        Vector actual = v4Dim - v4Dim2;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Sub_ThrowsExeption()
    {
        Vector v2Dim = new Vector(new double[] { 3, 0 });
        Vector v4Dim = new Vector(new double[] { 25, -33, 0, 4 });
        Vector expected = new Vector(new double[] { 0, -16, 3, 4 });

        Vector actual = v2Dim - v4Dim;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    // Умножение вектора на скаляр
    [Test]
    public void Mult_PositiveCoor_NegMult()
    {
        Vector v2Dim = new Vector(new double[] { 2, 3 });
        double scalar = -3;
        Vector expected = new Vector(new double[] { -6, -9 });

        Vector actual = scalar* v2Dim;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Mult_NegativeCoor_ZeroMult()
    {
        Vector v3Dim = new Vector(new double[] { -2, -3, -54 });
        double scalar = 0;
        Vector expected = new Vector(new double[] { 0, 0, 0 });

        Vector actual = scalar * v3Dim;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Mult_MixedCoor_PositiveMult()
    {
        Vector v4Dim = new Vector(new double[] { 0, -3, 54 });
        double scalar = 13;
        Vector expected = new Vector(new double[] { 0, -39, 702 });

        Vector actual = scalar * v4Dim;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }
    // Скалярное произведение векторов

    [Test]
    public void DotProduct_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] {34, 12 });
        Vector v2Dim2 = new Vector(new double[] { 4, 132 });
        double expected = 1720;

        double actual = Vector.DotProduct(v2Dim, v2Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void DotProduct_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -45, -123, -65 });
        Vector v3Dim2 = new Vector(new double[] { -32, -13, -90 });
        double expected = 8889;

        double actual = Vector.DotProduct(v3Dim, v3Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void DotProduct_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { 5, -123, 5, 0 });
        Vector v4Dim2 = new Vector(new double[] { 2, 0, -90, 15 });
        double expected = -440;

        double actual = Vector.DotProduct(v4Dim, v4Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void DotProduct_ThrowsExeption()
    {
        Vector v4Dim = new Vector(new double[] { 5, -123, 5, 0 });
        Vector v3Dim = new Vector(new double[] { 2, 0, -90 });
        double expected = -440;

        double actual = Vector.DotProduct(v4Dim, v3Dim);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    // Векторное произведение векторов
    [Test]
    public void CrossProd_PositiveCoor()
    {
        Vector v3Dim = new Vector(new double[] { 34, 3, 54 });
        Vector v3Dim2 = new Vector(new double[] { 65, 23, 4 });
        Vector expected = new Vector(new double[] { -1230, 3374, 587 });

        Vector actual = Vector.CrossProduct(v3Dim, v3Dim2); ;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void CrossProd_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -67, -23, -70 });
        Vector v3Dim2 = new Vector(new double[] { -3, -5, -34 });
        Vector expected = new Vector(new double[] { 432, -2068, 266 });

        Vector actual = Vector.CrossProduct(v3Dim, v3Dim2); ;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void CrossProd_MixedCoor()
    {
        Vector v3Dim = new Vector(new double[] { -67, 0, 70 });
        Vector v3Dim2 = new Vector(new double[] { 3, -5, 0 });
        Vector expected = new Vector(new double[] { 350, 210, 335});

        Vector actual = Vector.CrossProduct(v3Dim, v3Dim2); ;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void CrossProd_ThrowsExeption()
    {
        Vector v3Dim = new Vector(new double[] { -67, 0, 70, 0 });
        Vector v3Dim2 = new Vector(new double[] { 3, -5, 0 });
        Vector expected = new Vector(new double[] { 350, 210, 335 });

        Vector actual = Vector.CrossProduct(v3Dim, v3Dim2); ;
        Vector res = actual - expected;

        double difference = res.Length();
        Assert.LessOrEqual(difference, Precision);
    }

    // Вычисление угла между векторами
    [Test]
    public void Angle_2Dim_PositiveCoor()
    {
        Vector v2Dim = new Vector(new double[] { 45, 3 });
        Vector v2Dim2 = new Vector(new double[] { 54, 67 });
        double expected = 47.31814766338895; 

        double actual = Vector.Angle(v2Dim, v2Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Angle_3Dim_NegativeCoor()
    {
        Vector v3Dim = new Vector(new double[] { -5, -3, -45 });
        Vector v3Dim2 = new Vector(new double[] { -4, -7, -1 });
        double expected = 76.50908523875049;

        double actual = Vector.Angle(v3Dim, v3Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Angle_4Dim_MixedCoor()
    {
        Vector v4Dim = new Vector(new double[] { -5, 0, -45, 5 });
        Vector v4Dim2 = new Vector(new double[] { -4, 0, -1, 1 });
        double expected = 68.7644128502515;

        double actual = Vector.Angle(v4Dim, v4Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }

    [Test]
    public void Angle_ThrowsExeption()
    {
        Vector v4Dim = new Vector(new double[] { -5, 0, 5 });
        Vector v4Dim2 = new Vector(new double[] { -4, 0, -1, 1 });
        double expected = 68.7644128502515;

        double actual = Vector.Angle(v4Dim, v4Dim2);
        double difference = actual - expected;

        Assert.LessOrEqual(difference, Precision);
    }
}