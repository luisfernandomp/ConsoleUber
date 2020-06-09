using System;

namespace uberProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Passageiro Paulo = new Passageiro();

            Console.WriteLine("Login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();
            
            Paulo.Login(login, senha);

            if(Paulo.TokenLogin != null && Paulo.TokenLogin != ""){
                Console.WriteLine("Login autorizado!");
                Console.WriteLine(Paulo.TokenLogin);
            }else{
                Console.WriteLine("Não autorizado!");
            }
        }
    }
}
