using System;

namespace uberProjeto
{
    public class Conta
    {
        private string agencia = "12345";
        private string conta = "12345";

        public string cadastrar(string agencia, string conta){
            this.agencia = agencia;
            this.conta = conta;
            if(this.agencia != "" && this.conta != ""){
                return "Cadastro da conta efetuado com sucesso!";
            }
            return "Falha no cadastro da conta!";
        }
        public void excluir(){
            this.agencia = "";
            this.conta = "";
            Console.WriteLine("Dados da conta excluídos com sucesso!");
        }
    }
}