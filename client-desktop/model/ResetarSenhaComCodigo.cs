namespace model {
    public class ResetarSenhaComCodigo {
        public string email { get; set; }
       public  string codigo { get; set; }
       public  string novaSenha { get; set; }

        public ResetarSenhaComCodigo(string email,string codigo,string senha) {
            this.email = email;
            this.codigo = codigo;
            this.novaSenha = senha;
        }
    }
}
