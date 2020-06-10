using System;

namespace uberProjeto
{
    public class Conta
    {
        private string agencia = "12345";
        private string conta = "12345";

        public string cadastrar(){
            return "Cadastrado com sucesso!";
        }
        public void excluir(){
            Console.WriteLine("Excluido com sucesso");
        }
    }
}