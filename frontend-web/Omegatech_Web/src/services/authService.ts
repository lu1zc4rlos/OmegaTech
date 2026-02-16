// src/services/authService.ts

// Se estiver rodando o backend localmente na porta 8080:
const API_URL = "http://localhost:8080"; 
//const API_URL = "http://192.168.x.xxx:8080";
export const loginUser = async (email: string, senha: string) => {
  try {
    // CORREÇÃO: Mudamos de /auth/login para /usuarios/login para igualar ao seu Java
    const response = await fetch(`${API_URL}/usuarios/login`, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({ email, senha }),
    });

    if (!response.ok) {
        // Tenta pegar o texto de erro, se houver
        const errorText = await response.text();
        throw new Error(errorText || `Erro ${response.status}: Falha ao logar`);
    }

    // Se sua API retorna JSON, usa .json(). Se retorna texto puro (token), usa .text()
    // Vamos assumir JSON primeiro
    return await response.json();
  } catch (error) {
    console.error("Erro detalhado:", error);
    throw error;
  }
};

// Adicione ao src/services/authService.ts

// src/services/authService.ts

export const solicitarCodigo = async (email: string) => {
  // ADICIONE /usuarios AQUI 👇
  const response = await fetch(`${API_URL}/usuarios/solicitar_codigo`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ email })
  });
  // ...
};

export const validarCodigo = async (email: string, codigo: string) => {
  // ADICIONE /usuarios AQUI 👇
  const response = await fetch(`${API_URL}/usuarios/validar_codigo`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ email, codigo })
  });
  // ...
};

export const resetarSenha = async (email: string, codigo: string, novaSenha: string) => {
  // ADICIONE /usuarios AQUI 👇
  const response = await fetch(`${API_URL}/usuarios/resetar_senha`, {
    method: "PUT",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify({ email, codigo, novaSenha })
  });
  // ...
};

// Adicione no topo ou junto com as outras interfaces
export interface RegisterPayload {
  nome: string;
  email: string;
  dataNascimento: string;
  senha: string;
}

// Adicione esta função exportada
export const registerUser = async (dados: RegisterPayload) => {
  // ATENÇÃO: A rota no seu UsuarioController é /usuarios/cadastro
  const response = await fetch(`${API_URL}/usuarios/cadastro`, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(dados),
  });

  if (!response.ok) {
    const errorText = await response.text();
    // Tenta fazer o parse se for JSON, senão usa o texto puro
    try {
        const errorJson = JSON.parse(errorText);
        throw new Error(errorJson.message || "Erro ao realizar cadastro.");
    } catch {
        throw new Error(errorText || "Erro ao realizar cadastro.");
    }
  }

  return await response.json();
};