// src/services/chatService.ts

export interface ChatResponse {
  resposta: string;
  tipo: string;
  dados: any;
  timestamp: string;
}

//const API_URL = "http://localhost:8080/chat";
const API_URL = "http://192.168.x.xxx:8080/chat";

export const enviarMensagemChat = async (mensagem: string): Promise<ChatResponse> => {
  const token = localStorage.getItem("token");

  if (!token) {
    throw new Error("Usuário não autenticado");
  }

  const response = await fetch(`${API_URL}/mensagem`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
      "Authorization": `Bearer ${token}`
    },
    body: JSON.stringify({ mensagem })
  });

  if (!response.ok) {
    throw new Error("Erro ao enviar mensagem ao assistente");
  }

  return await response.json();
};