using System;

namespace AtividadePOO_Jogador
{
    class Jogador
    {    
        
        // 1 - Definir as variáveis pedidas no exercício como privadas
        private string nome;
        private string posicao;
        private DateTime dataNascimento;
        private string nacionalidade;
        private double altura;
        private double peso;



        // 2 - Acessar as variáveis privadas
        public string Nome { get => nome; set => nome = value; }
        public string Posicao { get => posicao; set => posicao = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Peso { get => peso; set => peso = value; }

        
    

      
      // 3 - dar um jeito de fazer a idade funcionar, n sei fazer isso na mão, n tendi muito mas blz ta funcionando
        public int CalcularIdade()
        {
            int idade;
            DateTime dataNascimento = DateTime.Now;
            int ano = dataNascimento.Year;
            idade = ano - this.dataNascimento.Year;

            return idade;
        }



        // 4 método de calcular a aposentadoria com if e else, vai funcionar na aposentadoria de acordo com a posição e idade
        public string CalcularAposentadoria()
        {
            int idade01 = this.CalcularIdade(); // to falando pro progama q o idade01 vai receber a função da data de nascimento
            string resultadoAposentadoria = " ";

            if (this.posicao == "1" && idade01 >= 40)
                resultadoAposentadoria = "O jogador pode se aposentar";

            else if (this.posicao == "1" && idade01 < 40)
                resultadoAposentadoria = $"O jogador poderá se aposentar depois de {40 - idade01} anos ";

            else if (this.posicao == "2" && idade01 >= 38)
                resultadoAposentadoria = "O jogador pode se aposentar";

            else if (this.posicao == "2" && idade01 < 38)
                resultadoAposentadoria = $"O jogador poderá se aposentar depois de {38 - idade01} anos ";

            else if (this.posicao == "3" && idade01 >= 35)
                resultadoAposentadoria = "O jogador pode se aposentar";

            else if (this.posicao == "3" && idade01 < 35)
                resultadoAposentadoria = $"O jogador poderá se aposentar depois de {35 - idade01} anos ";

            return resultadoAposentadoria; // tem que retornar essa variavel n sei pq mas precisa          
        }


        //5 - fazer um método para imprimir os dados do jogador que vai imprimir oq eu digitei (ainda n fiz, mas vai ser no void main ou classe programa)
        public void ImprimirDadosJogador() //sempre cria o metodo antes de fazer os bagui
        {
            Console.WriteLine("\n\n===Dados do Jogador===");
            Console.WriteLine($"Nome do jogador: " + this.nome);
            Console.WriteLine($"Posição: " + this.posicao);
            Console.WriteLine("Data de nascimento: " + dataNascimento);
            Console.WriteLine($"Nacionalidade: " + nacionalidade);
            Console.WriteLine($"altura " + this.altura);
            Console.WriteLine("Peso: " + this.peso);
            Console.WriteLine($"Idade: " + this.CalcularIdade());
            Console.WriteLine($"Aposentadoria: " + this.CalcularAposentadoria());


        }
    }



    // 5 - perguntar ao usuário os dados do jogador (agr sim vai)
    class Program
    {
        static void Main(string[] args)
        {
            Jogador jogador01 = new Jogador(); //mostro pro programa que a classe jogador01 ta se referindo a classe jogador

            Console.WriteLine("Digite o nome do jogador: ");
            jogador01.Nome = Console.ReadLine();

            Console.WriteLine("Digite a opção correspondente à posição do jogador\n\n 1 - Defesa\n 2 - Meio-Campo\n 3 - Atacante : ");
            jogador01.Posicao = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento do jogador (ANO/MÊS/DIA): ");
            jogador01.DataNascimento = DateTime.Parse(Console.ReadLine()); //converte o datetime

            Console.WriteLine("Digite a nacionalidade do jogador: ");
            jogador01.Nacionalidade = Console.ReadLine();

            Console.WriteLine("Digite a altura do jogador: ");
            jogador01.Altura = double.Parse(Console.ReadLine()); // tem q converter pq e double

            Console.WriteLine("Digite o peso do jogador: ");
            jogador01.Peso = double.Parse(Console.ReadLine()); //aq tbm

            jogador01.ImprimirDadosJogador(); //mostrar pro programa pra onde vai os dados q eu digitei

        }
    }
}
