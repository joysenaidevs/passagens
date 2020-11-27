using System;

namespace passagens
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada
            //senha 
            //Cadastrar passagem
            //nome
            //origem
            //destino
            //data
            //Processamento
            //fazer uma validacao de senha = 12456
            //ao cadastrar a passagem, perguntar se gostaria de cadastrar uma nova passagem.

            //Saida
            //Exibir lista de passagens cadastradas

            // declaração de variavel
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            //menu
            Console.Clear();
            Console.WriteLine("Sistemas de passagens aéreas");

            bool senhaValida = false;
            do
            {
                    Console.WriteLine("Digite sua senha");
                    string senha = Console.ReadLine();
                    senhaValida = EfetuarLogin(senha);
                
            } while (!senhaValida);
            Console.Clear(); //executando clear antes de entrar no laço

            //Criar o menu

            //Criando a variavel por fora
            int escolha;
            int contador = 0;
            do
            {
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        //Cadastrar passagens
                            string resposta;
                            do
                            {
                                if(contador<5)
                                {
                                    Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                                    nomes[contador] = Console.ReadLine();
                                    // Console.WriteLine($"Digite a origem {contador+1}º");
                                    // origem[contador] = Console.ReadLine();
                                    // Console.WriteLine($"Digite o destino do {contador+1}º Passageiro");
                                    // destino[contador] = Console.ReadLine();
                                    // Console.WriteLine($"Digite a data do voo do {contador+1}º passageiro");
                                    // data[contador] = Console.ReadLine();
                                    // contador++; 
                                }else{
                                    Console.WriteLine("Limite excedido!");
                                }

                                Console.WriteLine("Gostaria de cadastrar um novo passageiro? s/n");
                                resposta = Console.ReadLine();
                            } while (resposta == "s");
                        break;
                    case 2:
                        //listar as passagens
                                for (var i = 0; i <5; i++)
                                {
                                    Console.WriteLine($"Passageiro {nomes[i]}");
                                };
                        break;
                    case 0:
                        //sair
                        break;
                    default:
                        Console.WriteLine("Opcão invalida!");
                        break;
                }
        
            } while (escolha != 0);

            

            //Funcões 


            // booleano - Valor verdadeiro ou falso
            
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta");
                    return false;
                }

            } //fim efetuar Login

            


            


            

            

        }
    }
}
