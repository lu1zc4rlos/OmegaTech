using System.Text.RegularExpressions;

namespace service {
    public static class ValidacaoService {

        public static void validacaoService(String Nome,String Senha,String Email,DateTime DataNascimento,String ConfirmarSenha) {
            if (string.IsNullOrWhiteSpace(Nome) ||
               string.IsNullOrWhiteSpace(Email) ||
               string.IsNullOrWhiteSpace(Senha) ||
               string.IsNullOrWhiteSpace(ConfirmarSenha)) {
                throw new ArgumentException("Por favor, preencha todos os campos obrigatórios.");
            }
            if (Senha != ConfirmarSenha) {
                throw new ArgumentException("As senhas não coincidem.");
            }
            if (Senha.Length < 8) {
                throw new ArgumentException("A senha deve possuir 8 ou mais caracteres.");
            }
            if (!Senha.Any(char.IsUpper)) {
                throw new ArgumentException("A senha deve possuir possuir um caracter maiusculo.");
            }
            if (!Senha.Any(char.IsDigit)) {
                throw new ArgumentException("A senha deve possuir um número.");
            }
            if (!Senha.Any(char.IsLower)) {
                throw new ArgumentException("A senha deve possuir um caracter minúsculo.");
            }
            if (!Senha.Any(ch => "!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?".Contains(ch))) {
                throw new ArgumentException("A senha deve possuir possuir um caracter especial.");
            }
            if (!EmailValido(Email)) {
                throw new FormatException("Formato de email inválido.");
            }

        }
        public static void validacaoService(String Email, String SenhaAtual, String SenhaNova) {
            if (string.IsNullOrWhiteSpace(Email) ||
               string.IsNullOrWhiteSpace(SenhaAtual) ||
               string.IsNullOrWhiteSpace(SenhaNova)) {
                throw new ArgumentException("Por favor, preencha todos os campos obrigatórios.");
            }
            if (SenhaNova.Length < 8) {
                throw new ArgumentException("A senha deve possuir 8 ou mais caracteres.");
            }
            if (!SenhaNova.Any(char.IsUpper)) {
                throw new ArgumentException("A senha deve possuir possuir um caracter maiusculo.");
            }
            if (!SenhaNova.Any(char.IsDigit)) {
                throw new ArgumentException("A senha deve possuir um número.");
            }
            if (!SenhaNova.Any(char.IsLower)) {
                throw new ArgumentException("A senha deve possuir um caracter minúsculo.");
            }
            if (!SenhaNova.Any(ch => "!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?".Contains(ch))) {
                throw new ArgumentException("A senha deve possuir possuir um caracter especial.");
            }
            if (!EmailValido(Email)) {
                throw new FormatException("Formato de email inválido.");
            }

        }
        public static void validacaoService(String SenhaNova, String SenhaNovamente) {
            if (string.IsNullOrWhiteSpace(SenhaNovamente) ||
               string.IsNullOrWhiteSpace(SenhaNova)) {
                throw new ArgumentException("Por favor, preencha todos os campos obrigatórios.");
            }
            if (SenhaNova.Length < 8) {
                throw new ArgumentException("A senha deve possuir 8 ou mais caracteres.");
            }
            if (!SenhaNova.Any(char.IsUpper)) {
                throw new ArgumentException("A senha deve possuir possuir um caracter maiusculo.");
            }
            if (!SenhaNova.Any(char.IsDigit)) {
                throw new ArgumentException("A senha deve possuir um número.");
            }
            if (!SenhaNova.Any(char.IsLower)) {
                throw new ArgumentException("A senha deve possuir um caracter minúsculo.");
            }
            if (!SenhaNova.Any(ch => "!@#$%^&*()-_=+[{]}\\|;:'\",<.>/?".Contains(ch))) {
                throw new ArgumentException("A senha deve possuir possuir um caracter especial.");
            }
        }
        private static bool EmailValido(string email) {
            string padrao = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padrao);
        }

    }
}
