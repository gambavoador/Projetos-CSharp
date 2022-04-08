using System;

class Program
{
    static void Main(string[] args)
    {

        double area;
        const double pi = 3.14;
        double raio;


        Console.WriteLine("Digite o raio: ");
        raio = double.Parse(Console.ReadLine());
        area = CalculaArea(pi, raio);
        Console.WriteLine("area = " + area);
    }
    static double CalculaArea(double pi1, double raio1)
    {
        double area = pi1 * (raio1 * raio1);

        return area;
    }


}