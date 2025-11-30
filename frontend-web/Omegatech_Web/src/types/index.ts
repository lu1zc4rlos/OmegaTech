// src/types/index.ts

export interface Ticket {
  id: number;
  titulo: string; // Vem do enum TipoProblema
  descricao: string;
  dataCriacao: string; // Vem como string "2024-11-29" ou array
  prioridade: "ALTA" | "MEDIA" | "BAIXA";
  status: "PENDENTE" | "EM_ANDAMENTO" | "CONCLUIDO";
  resposta?: string;
  clienteId: number;
  nomeCliente: string;
  tecnicoId?: number;
  nomeTecnico?: string;
}

export interface TicketStats {
  total: number;
  abertos: number; // PENDENTE
  emAndamento: number; // EM_ANDAMENTO
  resolvidos: number; // CONCLUIDO
}