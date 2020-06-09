using System;
using System.Threading;

namespace uberProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool teste1 = false, teste2;
            string login = "", senha = "", op = "";
            Passageiro Paulo = new Passageiro();
            Console.Clear();
            while(teste1 == false){
                Console.Clear();
                teste2 = false;
                Console.WriteLine("----------------------------");
                Console.WriteLine("-       UBER - CONSOLE     -");
                Console.WriteLine("----------------------------");
                Console.WriteLine("\nBem - vindo!");
                Console.Write("\nLogin:  ");
                login =  Console.ReadLine();
                Console.Write("\nSenha:  ");
                senha =  Console.ReadLine();
                Paulo.Login(login, senha);
                if(Paulo.TokenLogin != null && Paulo.TokenLogin != ""){
                    Console.WriteLine("Login autorizado!");
                    Console.WriteLine(Paulo.TokenLogin);
                    Console.Clear();
                    Console.Write("\nInforme sua localização: ");
                    string localizacao = Console.ReadLine();
                    Paulo.LocalizacaoAtual = localizacao;
                    Paulo.Nome = "Paulo";
                    Console.WriteLine("--- FORMA DE PAGAMENTO -----");
                    Console.WriteLine("- 1 - Dinheiro             -");
                    Console.WriteLine("- 2 - Cartão               -");
                    Console.WriteLine("----------------------------");
                    string fPagamento = Console.ReadLine();
                    Passageiro.formaPagamento = fPagamento;
                    switch (formaPagamento)
                    {
                        case "1": ;break;
                        case "2": ;break;
                        default: Console.WriteLine("Número inválido!"); break;
                    }
                }else{
                    Console.WriteLine("Não autorizado!");
                }
                while(teste2 == false){
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("\nDeseja realizar outra viagem? (Para s - sim, n - não)");
                    op = Console.ReadLine();
                    if(op == "s"){
                        teste2 = true;
                    }else{
                        if(op == "n"){
                            Console.Clear();
                            Console.WriteLine("\nAté logo...");
                            Thread.Sleep(1000);
                            teste2 = true;
                            teste1 = true;
                        }else{
                            Console.WriteLine("Opção inválida!");
                        }
                    }
                }
            }
            System.Environment.Exit(0);            
        }
    }
}
