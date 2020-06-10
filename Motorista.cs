using System;

namespace uberProjeto
{
    public class Motorista
    {
        public string carro = "Renault Sandeiro";
        public string placa = "EZN-0901";
        public string aceitarPassageiro (string nome){
            if(nome != "" && nome != null){
                return "Passageiro aceito";
            }
            return "Passageiro recusado";
        }
        public bool receberPagamento(){
            Random numAleatorio = new Random();
            int pagamento = numAleatorio.Next(1,1000);
            Console.WriteLine("Preço da corrida: R$"+pagamento);
            return true;
        }
    }
}