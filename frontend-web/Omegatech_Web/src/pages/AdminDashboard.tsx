import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { 
  Users, 
  UserPlus, 
  LogOut, 
  Menu, 
  MessageSquare,
  X, 
  Check, 
  ShieldAlert, 
  Omega // <--- CORREÇÃO 1: O nome correto é Omega, não OmegaIcon
} from "lucide-react";

import { criarTecnico, TecnicoPayload } from "@/services/adminservice";

export default function AdminDashboard() {
  const navigate = useNavigate();
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);
  
  // Estado do Formulário
  const [formData, setFormData] = useState<TecnicoPayload>({
    nome: "",
    email: "",
    dataNascimento: "",
    senha: ""
  });
  const [confirmSenha, setConfirmSenha] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  const [loading, setLoading] = useState(false);

  const handleLogout = () => {
    localStorage.clear();
    navigate("/");
  };

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    
    if (formData.senha !== confirmSenha) {
      alert("As senhas não coincidem!");
      return;
    }

    setLoading(true);
    try {
      await criarTecnico(formData);
      alert("Técnico cadastrado com sucesso!");
      setFormData({ nome: "", email: "", dataNascimento: "", senha: "" });
      setConfirmSenha("");
    } catch (error: any) {
      console.error(error);
      alert(error.message || "Erro ao cadastrar.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="flex h-screen bg-[#0f172a] text-slate-100 font-sans overflow-hidden">
      
      {/* OVERLAY MOBILE */}
      {isSidebarOpen && (
        <div 
          className="fixed inset-0 bg-black/60 z-40 md:hidden backdrop-blur-sm"
          onClick={() => setIsSidebarOpen(false)}
        />
      )}

      {/* SIDEBAR ADMIN */}
      <aside className={`
        fixed inset-y-0 left-0 z-50 w-64 bg-[#1e293b] border-r border-slate-800 flex flex-col
        transform transition-transform duration-300 ease-in-out shadow-2xl md:shadow-none
        ${isSidebarOpen ? "translate-x-0" : "-translate-x-full"} 
        md:translate-x-0 md:static
      `}>
        {/* Header Sidebar */}
        <div className="p-6 flex items-center justify-between">
          <div className="flex items-center gap-3">
            <div className="w-8 h-8 bg-indigo-600 rounded-lg flex items-center justify-center shadow-lg shadow-indigo-500/20">
              {/* CORREÇÃO 1: Usando o ícone certo */}
              <Omega className="w-5 h-5 text-white" />
            </div>
            <div>
              <h1 className="font-bold text-lg tracking-tight">OmegaAdmin</h1>
              <p className="text-xs text-slate-400 font-medium">Gestão</p>
            </div>
          </div>
          <button onClick={() => setIsSidebarOpen(false)} className="md:hidden text-slate-400 hover:text-white">
            <X className="w-6 h-6" />
          </button>
        </div>

        <nav className="flex-1 px-4 space-y-2 mt-4">
          {/* Botão ADICIONAR (Ativo) */}
          <button 
            onClick={() => navigate("/admin")}
            className="flex items-center gap-3 w-full px-4 py-3 bg-indigo-600 text-white shadow-lg shadow-indigo-900/20 rounded-xl font-medium transition-colors"
          >
            <UserPlus className="w-5 h-5" />
            Adicionar Técnico
          </button>
          
          {/* Botão LISTAR (Link) */}
          <button 
            // CORREÇÃO 2: Adicionei o onClick para navegar
            onClick={() => navigate("/admin/lista")}
            className="flex items-center gap-3 w-full px-4 py-3 text-slate-400 hover:bg-slate-800 hover:text-slate-200 rounded-xl font-medium transition-colors"
          >
            <Users className="w-5 h-5" />
            Listar Técnicos
          </button>
        </nav>

        <div className="p-4 border-t border-slate-800">
          <button onClick={handleLogout} className="flex items-center gap-3 w-full px-4 py-3 text-slate-400 hover:text-red-400 hover:bg-red-950/30 rounded-xl transition-all">
            <LogOut className="w-5 h-5" /> Sair
          </button>
        </div>
      </aside>

      {/* CONTEÚDO */}
      <main className="flex-1 flex flex-col h-screen relative bg-[#0f172a]">
        
        {/* Header Mobile */}
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between shrink-0">
          <h1 className="font-bold text-lg text-white">Administrador</h1>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        <div className="flex-1 overflow-y-auto p-4 md:p-8 flex flex-col items-center">
          
          <div className="w-full max-w-4xl mt-4">
            <header className="mb-8">
              <h2 className="text-3xl font-bold text-white tracking-tight">Novo Técnico</h2>
              <p className="text-slate-400 mt-1">Cadastre um novo membro para a equipe de suporte.</p>
            </header>

            {/* FORMULÁRIO CARD */}
            <div className="bg-[#1e293b] rounded-2xl border border-slate-800 p-6 md:p-10 shadow-xl">
              <form onSubmit={handleSubmit} className="space-y-6">
                
                {/* Nome */}
                <div className="grid grid-cols-1 md:grid-cols-4 md:items-center gap-2 md:gap-4">
                  <label className="text-sm font-medium text-slate-300 md:text-right">Nome Completo</label>
                  <div className="md:col-span-3">
                    <input 
                      type="text" 
                      required
                      value={formData.nome}
                      onChange={(e) => setFormData({...formData, nome: e.target.value})}
                      className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-slate-200 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all"
                      placeholder="Ex: João da Silva"
                    />
                  </div>
                </div>

                {/* Data Nascimento */}
                <div className="grid grid-cols-1 md:grid-cols-4 md:items-center gap-2 md:gap-4">
                  <label className="text-sm font-medium text-slate-300 md:text-right">Data de Nascimento</label>
                  <div className="md:col-span-3">
                    <input 
                      type="date" 
                      required
                      value={formData.dataNascimento}
                      onChange={(e) => setFormData({...formData, dataNascimento: e.target.value})}
                      className="w-full md:w-1/2 bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-slate-200 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all [color-scheme:dark]"
                    />
                  </div>
                </div>

                {/* Email */}
                <div className="grid grid-cols-1 md:grid-cols-4 md:items-center gap-2 md:gap-4">
                  <label className="text-sm font-medium text-slate-300 md:text-right">E-mail Corporativo</label>
                  <div className="md:col-span-3">
                    <input 
                      type="email" 
                      required
                      value={formData.email}
                      onChange={(e) => setFormData({...formData, email: e.target.value})}
                      className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-slate-200 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all"
                      placeholder="tecnico@omegatech.com"
                    />
                  </div>
                </div>

                <div className="border-t border-slate-700/50 my-6"></div>

                {/* Senha */}
                <div className="grid grid-cols-1 md:grid-cols-4 md:items-start gap-2 md:gap-4">
                  <label className="text-sm font-medium text-slate-300 md:text-right mt-3">Senha de Acesso</label>
                  <div className="md:col-span-3 space-y-4">
                    <div className="flex flex-col gap-2">
                        <input 
                          type={showPassword ? "text" : "password"}
                          required
                          value={formData.senha}
                          onChange={(e) => setFormData({...formData, senha: e.target.value})}
                          className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-slate-200 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all"
                          placeholder="••••••••"
                        />
                        
                        {/* Checkbox Customizado */}
                        <div className="flex items-center gap-2 mt-1">
                          <div 
                            onClick={() => setShowPassword(!showPassword)}
                            className={`w-4 h-4 border rounded cursor-pointer flex items-center justify-center transition-colors ${showPassword ? 'bg-indigo-600 border-indigo-600' : 'bg-[#0f172a] border-slate-600'}`}
                          >
                            {showPassword && <Check className="w-3 h-3 text-white" strokeWidth={3} />}
                          </div>
                          <span onClick={() => setShowPassword(!showPassword)} className="text-xs text-slate-400 cursor-pointer select-none">Mostrar senha</span>
                        </div>
                    </div>
                  </div>
                </div>

                {/* Confirmar Senha */}
                <div className="grid grid-cols-1 md:grid-cols-4 md:items-center gap-2 md:gap-4">
                  <label className="text-sm font-medium text-slate-300 md:text-right">Confirmar Senha</label>
                  <div className="md:col-span-3">
                    <input 
                      type={showPassword ? "text" : "password"}
                      required
                      value={confirmSenha}
                      onChange={(e) => setConfirmSenha(e.target.value)}
                      className={`w-full bg-[#0f172a] border rounded-xl p-3 text-slate-200 focus:outline-none focus:ring-1 transition-all ${formData.senha && confirmSenha && formData.senha !== confirmSenha ? 'border-red-500 focus:border-red-500 focus:ring-red-500' : 'border-slate-700 focus:border-indigo-500 focus:ring-indigo-500'}`}
                      placeholder="••••••••"
                    />
                    {formData.senha && confirmSenha && formData.senha !== confirmSenha && (
                      <p className="text-red-400 text-xs mt-1 flex items-center gap-1">
                        <ShieldAlert className="w-3 h-3" /> As senhas não conferem
                      </p>
                    )}
                  </div>
                </div>

                {/* Botão Salvar */}
                <div className="flex justify-end pt-6">
                  <button 
                    type="submit"
                    disabled={loading || (formData.senha !== confirmSenha)}
                    className="px-8 py-3 bg-indigo-600 hover:bg-indigo-700 disabled:opacity-50 disabled:cursor-not-allowed text-white rounded-xl font-medium shadow-lg shadow-indigo-900/20 transition-all transform active:scale-[0.98]"
                  >
                    {loading ? "Cadastrando..." : "Cadastrar Técnico"}
                  </button>
                </div>

              </form>
            </div>
          </div>
        </div>
      </main>
    </div>
  );
}