// src/services/ticketService.ts

import { Ticket } from "@/types";

const API_URL = "http://localhost:8080/tickets";
//const API_URL = "http://192.168.x.xxx:8080/tickets";

export const getMeusTickets = async (): Promise<any[]> => {
  const token = localStorage.getItem("token");

  if (!token) {
    throw new Error("Usuário não autenticado");
  }

  const response = await fetch(`${API_URL}/meus`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}` // O Java exige isso no SecurityConfig
    },
  });

  if (!response.ok) {
    if (response.status === 403) {
      throw new Error("Sessão expirada. Faça login novamente.");
    }
    throw new Error("Erro ao buscar tickets");
  }

  return await response.json();
};

export const getTicketById = async (id: number): Promise<Ticket> => {
  const token = localStorage.getItem("token");

  const response = await fetch(`${API_URL}/${id}`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
  });

  if (!response.ok) {
    throw new Error("Erro ao buscar detalhes do ticket");
  }

  return await response.json();
};

export const criarTicket = async (mensagem: string): Promise<void> => {
  const token = localStorage.getItem("token");

  if (!token) {
    throw new Error("Usuário não autenticado");
  }

  const response = await fetch(`${API_URL}/criar`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
    // O Java espera um objeto MensagemRequest com o campo "mensagem"
    body: JSON.stringify({ mensagem }) 
  });

  if (!response.ok) {
    throw new Error("Erro ao criar ticket");
  }
};

//Função para o Técnico assumir o ticket (Mudar status para EM_ANDAMENTO)
export const assumirTicket = async (id: number): Promise<void> => {
  const token = localStorage.getItem("token");
  
  // O Backend espera um StatusUpdateDTO com o campo "novoStatus"
  const response = await fetch(`${API_URL}/status/${id}`, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
    body: JSON.stringify({ novoStatus: "EM_ANDAMENTO" })
  });

  if (!response.ok) {
    throw new Error("Erro ao assumir o ticket.");
  }
};

// 2. Função para Responder e Concluir
export const responderTicket = async (id: number, resposta: string): Promise<void> => {
  const token = localStorage.getItem("token");

  // O Backend espera o campo "resposta"
  const response = await fetch(`${API_URL}/resposta/${id}`, {
    method: "PUT",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
    body: JSON.stringify({ resposta: resposta })
  });

  if (!response.ok) {
    throw new Error("Erro ao enviar resposta.");
  }
};

// Adicione ao final do arquivo ticketService.ts

export const excluirTicket = async (id: number): Promise<void> => {
  const token = localStorage.getItem("token");

  const response = await fetch(`${API_URL}/deletar/${id}`, {
    method: "DELETE",
    headers: {
      "Authorization": `Bearer ${token}`
    }
  });

  if (!response.ok) {
    const text = await response.text();
    throw new Error(text || "Erro ao excluir ticket.");
  }
};