using System;

namespace Aula04_POO_10092021
{

    /* definição da classe, com palavra reservada class
     * seguida do nome da classe com letra maiuscula
     */
    class Naruto
    {
        /* Definição dos atributos (qualidades) da classe
            pode ser public ou private (modificador de acesso)
            Um atributo diz o que o objeto É.
         */
        private string corCabelo; // ENCAPSULANDO o atributo
        public string corOlho;
        public string corRoupa;
        public int chakra;
        
        // GET e SET são acessadores de atributos que estão encapsulados
        public string CorCabelo
        {
            get => corCabelo;

            set {
                corCabelo = value;
            }
        }

        /* Construtor: método especial 
             condicionado ao momento de instanciar o objeto.

            Um construtor é um método cujo nome é igual ao nome de seu tipo. 
            Sua assinatura do método inclui apenas o nome do método e lista de parâmetros, 
            ele não inclui um tipo de retorno.

         Construtor 1 = sem parametro */
        public Naruto() // assinatura do metodo construtor
        {
            // A palavra-chave this refere - se à instância atual da classe
            this.corCabelo = "Amarelo";
            this.corOlho = "Azul";
            this.corRoupa = "Laranja";
            this.chakra = 100;
        }

        /* Construtor 2 = com parametro
      
         Posso ter quantos construtores quiser, 
         porem a assinatura deve ser diferente

        */
        public Naruto(string corCabeloParam)
        {
            this.corCabelo = corCabeloParam;
            this.corOlho = "Azul";
            this.corRoupa = "Laranja";
            this.chakra = 100;
        }

        /* Definição de métodos:
            Um método diz o que o objeto FAZ.
         */
        public void Rasengan() // Metodo sem retorno
        {
            this.chakra = this.chakra - 20;
        }

        public void JutsuClone() // metodo sem retorno
        {
            this.chakra = this.chakra - 1;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Naruto naruto01 = new Naruto();
            Naruto naruto02 = new Naruto("Preto");
            
            naruto01.Rasengan();
            naruto01.JutsuClone();

            naruto02.Rasengan();
            
        }
    }
}
