// src/services/adminService.ts

//const API_URL = "http://localhost:8080/admin"; 
const API_URL = "http://192.168.x.xxx:8080/admin"

export interface TecnicoPayload {
  nome: string;
  email: string;
  dataNascimento: string;
  senha?: string; // Enviaremos a senha para cadastro
}

// dados que vêm do Java (TecnicoResponseDTO)
export interface TecnicoResponse {
  id: number;
  nome: string;
  matricula: string;
  email: string;
  dataCriacao: string;
}

export const criarTecnico = async (dados: TecnicoPayload): Promise<void> => {
  const token = localStorage.getItem("token");

  if (!token) throw new Error("Não autenticado");

  const response = await fetch(`${API_URL}/cadastro`, { // Ajuste a rota se for diferente
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
    body: JSON.stringify(dados)
  });

  if (!response.ok) {
    const errorData = await response.json().catch(() => ({}));
    throw new Error(errorData.message || "Erro ao cadastrar técnico");
  }

  
};

// Função para buscar a lista
export const listarTecnicos = async (): Promise<TecnicoResponse[]> => {
  const token = localStorage.getItem("token");
  
  if (!token) throw new Error("Não autenticado");

  // O endpoint no seu AdminController é GET /admin/tecnicos
  const response = await fetch(`${API_URL}/tecnicos`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    }
  });

  if (!response.ok) {
    throw new Error("Erro ao buscar lista de técnicos");
  }

  // Se o backend retornar 204 No Content (lista vazia), retornamos array vazio
  if (response.status === 204) {
    return [];
  }

  return await response.json();
};


import { Ticket } from "@/types"; // Reaproveitando a tipagem de Ticket existente

// Função para buscar detalhes do técnico (já tínhamos criado o endpoint no Java)
// src/services/adminService.ts

// ... (imports e interface TecnicoPayload continuam iguais)

// CORREÇÃO 1: Remover "/tecnicos" da URL
export const buscarTecnicoPorId = async (id: number): Promise<TecnicoResponse> => {
  const token = localStorage.getItem("token");
  
  // O seu Java espera: GET /admin/{id}
  // Antes estava: /admin/tecnicos/{id} (ERRADO)
  const response = await fetch(`${API_URL}/${id}`, {
    headers: { "Authorization": `Bearer ${token}` }
  });

  if (!response.ok) throw new Error("Erro ao buscar técnico");
  return await response.json();
};

// CORREÇÃO 2: Ajustar a rota de respondidos para bater com o Java
export const listarTicketsRespondidos = async (tecnicoId: number): Promise<Ticket[]> => {
  const token = localStorage.getItem("token");
  
  // O seu Java espera: GET /admin/respondidos/{tecnicoId}
  // Antes estava: /admin/tecnicos/{id}/respondidos (ERRADO)
  const response = await fetch(`${API_URL}/respondidos/${tecnicoId}`, {
    method: "GET",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    }
  });

  if (!response.ok) {
    if (response.status === 204) return [];
    throw new Error("Erro ao buscar histórico do técnico");
  }

  return await response.json();
};