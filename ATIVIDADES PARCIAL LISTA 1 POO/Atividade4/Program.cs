using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string funcao;
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            funcao = VerificaIdade(idade);
            Console.WriteLine("A categoria do nadador é: " + funcao);
        }
        static string VerificaIdade(int idade)
        {
            string categoria = "";

            if (idade >= 5 && idade <= 7)
            {
                categoria = "Infantil A";
            }

            else if (idade >= 8 && idade <= 10)
            {
                categoria = "Infantil B";
            }

            else if (idade >= 11 && idade <= 13)
            {
                categoria = "Juvenil A";
            }

            else if (idade >= 14 && idade <= 17)
            {
                categoria = "Juvenil B";
            }

            else if (idade >= 18)
            {
                categoria = "Adulto";
            }

            else
            {
                Console.WriteLine("O nadador não possui idade mínima");
            }

            return categoria;
        }
    }
}
