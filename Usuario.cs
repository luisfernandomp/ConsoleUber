namespace uberProjeto
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        private string login = "luis@outlook.com";
        private string senha = "123";
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }
        private int idade = 0;
        public int Idade
        {
            get { return idade; }
            set { 
                if(idade > 0){
                    idade = value;
                }
             }
        }
        public bool Login(string login, string senha){

            if(this.login == login && this.senha == senha){
                TokenLogin = "sadsdasdasfasfdasdafagag";
                return true;
            }
            return false;

        }
        public void Logout(){
            TokenLogin = " ";
        }
    }
}