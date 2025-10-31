namespace model {
    public class AlterarSenhaRequest {
        public string Email { get; set; }
        public string SenhaAtual { get; set; }
        public string NovaSenha { get; set; }
    }
}
