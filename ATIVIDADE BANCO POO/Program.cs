using System;

namespace ATIVIDADE_BANCO_POO
{
    class Contribuinte
    {
        public string nome = "";
    }

    class ContribuintePJ : Contribuinte
    {
        public double cnpj;       
    }

    class ContribuintePF : Contribuinte
    {
        public double cpf;          
    }

    class InterfaceUsuario 
    {
        public string nome;
        public string tipoContribuinte;
        public double rendaBruta;
        public double aliquota;
        public double cpf;
        public double cnpj;

        public void SolicitarDados()
        {
            Console.WriteLine("Digite o nome: ");
            this.nome = Console.ReadLine();

            Console.WriteLine("Selecione a opção para o tipo de pessoa:\n 1 - Pessoa Física\n 2 - Pessoa Jurídica");
            this.tipoContribuinte = Console.ReadLine();

            
            if (this.tipoContribuinte == "1")
            {
                Console.WriteLine("Digite o CPF (11 digitos sem pontos e traços) : ");
                this.cpf = double.Parse(Console.ReadLine());
            }

            else if (this.tipoContribuinte == "2")
            {
                Console.WriteLine("Digite o CNPJ (14 digitos sem pontos e traços): ");
                this.cnpj = double.Parse(Console.ReadLine());
            }

                Console.WriteLine("Digite a renda bruta: ");
            this.rendaBruta = double.Parse(Console.ReadLine());


            if (this.tipoContribuinte == "2")
            {
                this.aliquota = this.rendaBruta * 0.1;
                Console.WriteLine($"Valor da aliquota: {this.aliquota} reais. ");
            }

            if (this.tipoContribuinte == "1")
            {
                if (this.rendaBruta >= 0 && this.rendaBruta <= 1400)
                {
                    Console.WriteLine("A alíquota é de 0,00 reais.");
                }
                    

                
                else if (this.rendaBruta >= 1400.01 && this.rendaBruta <= 2100.00)
                {
                    Console.WriteLine($"A alíquota é de {this.rendaBruta * 0.1} reais.");
                    Console.WriteLine($"A parcela a deduzir é de {(this.rendaBruta * 0.1) - 100} reais.");
                }

                else if (this.rendaBruta >= 2100.01 && this.rendaBruta <= 2800.00)
                {
                    Console.WriteLine($"A alíquota é de {this.rendaBruta * 0.15} reais.");
                    Console.WriteLine($"A parcela a deduzir é de {(this.rendaBruta * 0.15) - 270} reais.");
                }

                else if (this.rendaBruta >= 2800.01 && this.rendaBruta <= 3600.00)
                {
                    Console.WriteLine($"A alíquota é de {this.rendaBruta * 0.25} reais.");
                    Console.WriteLine($"A parcela a deduzir é de {(this.rendaBruta * 0.25) - 500} reais.");
                }

                else if (this.rendaBruta >= 3600.01)
                {
                    Console.WriteLine($"A alíquota é de {this.rendaBruta * 0.30} reais.");
                    Console.WriteLine($"A parcela a deduzir é de {(this.rendaBruta * 0.30) - 700} reais.");
                }
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContribuintePJ contribuintePJ01 = new ContribuintePJ();
            ContribuintePF contribuintePF01 = new ContribuintePF();
            InterfaceUsuario interfaceUsuario01 = new InterfaceUsuario();
            interfaceUsuario01.SolicitarDados();
            
        }
    }
}
