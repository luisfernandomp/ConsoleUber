using System;

namespace uberProjeto
{
    public class Conta
    {
        private string agencia;
        private string conta;

        public string cadastrar(){
            return "Cadastrado com sucesso!";
        }
        public void excluir(){
            Console.WriteLine("Excluido com sucesso");
        }
    }
}