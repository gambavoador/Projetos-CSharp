using System;

namespace VSCODE
{
    class Program
    {
        static void Main(string[] args)
        {
            int PrimeroNumero, SegundoNumero, TerceiroNumero;

            Console.WriteLine("Digite o primeiro numero: ");
            PrimeroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            SegundoNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            TerceiroNumero = int.Parse(Console.ReadLine());
            verificador(PrimeroNumero, SegundoNumero, TerceiroNumero);
        }
        static void verificador(int NumeroUm, int NumeroDois, int NumeroTres)
        {
            if (NumeroUm > NumeroDois && NumeroUm > NumeroTres)
            {
                Console.WriteLine("O maior numero e o:  " + NumeroUm);
            }
            else if (NumeroDois > NumeroUm && NumeroDois > NumeroTres)
            {
                Console.WriteLine("O maior numero e o: " + NumeroDois);
            }
            else if (NumeroTres > NumeroUm && NumeroTres > NumeroDois)
            {
                Console.WriteLine("O maior numero e o: " + NumeroTres);
            }
            else
            {
                Console.WriteLine("Os valores sao iguais");
            }
        }
    }
}
