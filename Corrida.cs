namespace uberProjeto
{
    public class Corrida
    {
        public string localInicio { get; set; }
        public string localChegada { get; set; }
        public string statusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }

        public string Cancelar(){
            this.statusCorrida = "Corrida cancelada";
            return "Corrida cancelada!";
        }
        
    }
}