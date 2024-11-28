using System.Security.Cryptography;
using System.Text;
using Vector;

public class Program
{
    public static void Main(string[] args)
    {
        Vector3D vector1 = new Vector3D(1, 2, 3);
        Vector3D vector2 = new Vector3D(4, 5, 6);
        Vector3D vector3 = new Vector3D(4, 5, 6);
        Console.WriteLine((vector1 + vector2).ToString());
        Console.WriteLine((vector1 - vector2).ToString());
        Console.WriteLine((vector1 * vector2).ToString());
        Console.WriteLine(vector3 == vector2);
        Console.WriteLine(vector3 != vector2);
        // Вектор угловой скорости Земли
        double terraVelocity = 7.2921159e-5; // угловая скорость Земли в рад/с
        Vector3D omegaVector = new Vector3D(0, 0, terraVelocity);
        // Вектор скорости студента, бегущего на юг со скоростью 7 м/с
        Vector3D velocityVector = new Vector3D(0, -7, 0);
        // Вычисление силы Кориолиса
        Vector3D coriolisForce = 2 * 70 * (velocityVector * omegaVector);
        Console.WriteLine($"Сила Кориолиса: {coriolisForce.abs}");
    }
}