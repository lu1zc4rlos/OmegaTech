namespace model {
    public class ResetarSenhaComCodigo {
        string email { get; set; }
        string codigo { get; set; }
        string novaSenha { get; set; }

        public ResetarSenhaComCodigo(string email,string codigo,string senha) {
            this.email = email;
            this.codigo = codigo;
            this.novaSenha = senha;
        }
    }
}
