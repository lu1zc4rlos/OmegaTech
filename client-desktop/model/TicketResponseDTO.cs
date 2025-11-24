namespace model {
    public class TicketResponseDTO {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public string Resposta { get; set; }

        public long ClienteId { get; set; }
        public string NomeCliente { get; set; }

        public long? TecnicoId { get; set; } 
        public string NomeTecnico { get; set; }
    }
}
