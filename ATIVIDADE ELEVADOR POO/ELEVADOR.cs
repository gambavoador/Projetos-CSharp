using System;

namespace ATIVIDADE_ELEVADOR_POO
{
    class Elevador
    {
        public int andarAtual;
        public int totalAndares;
        public int capacidadeElevador;
        public int quantidadePessoas;       
        public Elevador()
        {
            this.andarAtual = 0;
            this.totalAndares = 5;
            this.capacidadeElevador = 7;
            this.quantidadePessoas = 0;

        }

        public void Entrar()
        {
            if (quantidadePessoas <= capacidadeElevador)
                this.quantidadePessoas = this.quantidadePessoas + 1;

            else
                Console.WriteLine("Capacidade máxima atingida.");
        }

        public void Sair()
        {
            if (quantidadePessoas > 0)
                this.quantidadePessoas = this.quantidadePessoas - 1;

            else
                Console.WriteLine("Não há ninguém no elevador.");
        }

        public void Subir()
        {
            if (andarAtual == totalAndares)
                Console.WriteLine("O elevador está no último andar.");

            else
                this.andarAtual = andarAtual + 1;         
                   
        }

        public void Descer()
        {
            if (andarAtual > 0)           
                this.andarAtual = andarAtual + 1;

                else
                    Console.WriteLine("Você está no térreo");
            
        }


        class Program
        {
            static void Main(string[] args)
            {
                Elevador elevador01 = new Elevador();

                elevador01.Entrar();
                elevador01.Entrar();
                elevador01.Entrar();
                elevador01.Entrar();
                elevador01.Subir();
                elevador01.Subir();
                elevador01.Subir();
                elevador01.Sair();
                elevador01.Sair();
                elevador01.Descer();
                elevador01.Sair();
                elevador01.Subir();
                elevador01.Sair();
                elevador01.Descer();

            }
        }
    }
}