using System;
namespace uberProjeto
{
    public class Cartao
    {
        private string numero;
        private string titular;
        private string bandeira;
        private string cvv;

        public string Cadastrar(){
            Console.Write("Dados do Cartão \n\n");
            Console.Write("Número do cartão: ");
            this.numero = Console.ReadLine();
            Console.Write("\nTitular do cartão: ");
            this.titular = Console.ReadLine();
            Console.Write("\nBandeira do cartão: ");
            this.bandeira = Console.ReadLine();
            Console.Write("\nCVV: ");
            this.cvv = Console.ReadLine();
            return "Cadastro realizado com sucesso!";
        }
        public void Excluir(){
            this.numero = "";
            this.titular = "";
            this.bandeira = "";
            this.cvv = "";
            Console.WriteLine("Dados do cartão excluídos com sucesso!");
        }
    }
}