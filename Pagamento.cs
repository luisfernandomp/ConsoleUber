using System;

namespace uberProjeto
{
    public class Pagamento
    {
        public DateTime data { get; set; }
        public string status { get; set; }
        private string pagamento;
        public string FormaPagamento
        {
            get { return pagamento; }
            set {
                if(value == "1"){
                    pagamento = "Dinheiro";
                }else{
                    if(value == "2"){
                        pagamento = "Cartão";
                    }
                }
             }
        }
        


    }
}