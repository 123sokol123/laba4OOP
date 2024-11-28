public class Program
{
    public static void Main(string[] args)
    {
        Complex.Complex complex1 = new Complex.Complex(1, 1);
        Complex.Complex complex2 = new Complex.Complex(2, 3);
        Console.WriteLine((complex1 + complex2).ToString());
        Console.WriteLine((complex1 - complex2).ToString());
        Console.WriteLine((complex1 * complex2).ToString());
        Console.WriteLine((complex1 / complex2).ToString());
        Console.WriteLine(complex1 == complex2);
        Console.WriteLine(complex1 != complex2);
        complex1 = new Complex.Complex(2, 1);
        complex2 = new Complex.Complex(3, -1);
        Complex.Complex complex3 = complex1 * complex2;
        Console.WriteLine(complex3.ToString());
        var (abs, fi) = Complex.Complex.ToExp(complex3);
        complex3 = Complex.Complex.FromExp(abs, fi);
        Console.WriteLine(complex3.ToString());
    }
}