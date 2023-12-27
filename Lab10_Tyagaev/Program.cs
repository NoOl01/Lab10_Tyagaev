//Lab 10 Вариант 11 средний уровень

try
{
    Console.WriteLine("Введите действительную часть 1 комлексного числа: ");
    double a1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите мнимую часть 1 комлексного числа: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Complex c1 = new Complex(a1, b1);

    Console.WriteLine("Введите действительную часть 1 комлексного числа: ");
    double a2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите мнимую часть 1 комлексного числа: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Complex c2 = new Complex(a2, b2);

    Complex product = Complex.Multiply(c1, c2);

    Console.WriteLine($"Произведение комплексных чисел {c1} и {c2} равно {product}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex (double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }
    public static Complex Multiply(Complex c1, Complex c2)
    {
        double realPart = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
        double imiginaryPart = c1.Real * c2.Imaginary + c2.Real * c1.Imaginary;
        return new Complex (realPart, imiginaryPart);
    }
    public override string ToString()
    {
        if (Imaginary < 0)
            return $"{Real} - {-Imaginary}i";
        else
            return $"{Real} + {Imaginary}i";
    }
}

