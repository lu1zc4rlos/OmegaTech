import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { 
  ArrowLeft,
  Sparkles,
  Send,
  Menu // <--- Importante para o mobile
} from "lucide-react";
import { criarTicket } from "@/services/ticketService";
import Sidebar from "@/components/Sidebar"; // <--- Importando o componente

export default function NewTicket() {
  const navigate = useNavigate();
  const [descricao, setDescricao] = useState("");
  const [loading, setLoading] = useState(false);
  
  // Estado do Menu Mobile
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    if (!descricao.trim()) return;
    setLoading(true);
    try {
      await criarTicket(descricao);
      navigate("/dashboard");
    } catch (error) {
      console.error(error);
      alert("Erro ao criar chamado.");
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="flex h-screen bg-[#0f172a] text-slate-100 font-sans overflow-hidden">
      
      {/* Componente Reutilizável */}
      <Sidebar isOpen={isSidebarOpen} onClose={() => setIsSidebarOpen(false)} />

      {/* Conteúdo Principal */}
      <main className="flex-1 flex flex-col h-screen relative">
        
        {/* Header Mobile */}
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between shrink-0">
          <h1 className="font-bold text-lg text-white">Novo Chamado</h1>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        {/* Área de Scroll */}
        <div className="flex-1 overflow-y-auto p-4 md:p-8 flex flex-col items-center">
          <div className="w-full max-w-2xl mt-4 md:mt-10">
            
            {/* Botão Voltar */}
            <div className="flex items-center gap-4 mb-8">
              <button 
                onClick={() => navigate("/dashboard")} 
                className="p-2 hover:bg-slate-800 rounded-lg transition-colors text-slate-400 hover:text-white"
              >
                <ArrowLeft className="w-6 h-6" />
              </button>
              <div>
                <h2 className="text-2xl md:text-3xl font-bold text-white tracking-tight">Novo Chamado</h2>
                <p className="text-slate-400 mt-1 text-sm md:text-base">Descreva o problema e deixe nossa IA cuidar do resto.</p>
              </div>
            </div>

            {/* Formulário */}
            <div className="bg-[#1e293b] rounded-2xl border border-slate-800 p-6 md:p-8 shadow-xl relative overflow-hidden">
              <div className="absolute top-0 right-0 p-32 bg-indigo-500/5 rounded-full blur-3xl -mr-16 -mt-16 pointer-events-none"></div>

              <form onSubmit={handleSubmit} className="space-y-6 relative z-10">
                <div className="bg-indigo-500/10 border border-indigo-500/20 rounded-xl p-4 flex gap-3 items-start">
                  <div className="bg-indigo-500/20 p-2 rounded-lg text-indigo-400 shrink-0">
                    <Sparkles className="w-5 h-5" />
                  </div>
                  <div>
                    <h4 className="text-indigo-300 font-bold text-sm">Classificação Automática</h4>
                    <p className="text-slate-400 text-xs mt-1">
                      Nossa Inteligência Artificial analisará sua descrição e definirá a prioridade e o título automaticamente.
                    </p>
                  </div>
                </div>

                <div className="space-y-2">
                  <label htmlFor="descricao" className="text-sm font-medium text-slate-300 block">
                    Descrição da Ocorrência <span className="text-red-400">*</span>
                  </label>
                  <textarea
                    id="descricao"
                    value={descricao}
                    onChange={(e) => setDescricao(e.target.value)}
                    placeholder="Ex: Meu computador não liga..."
                    required
                    rows={6}
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-4 text-slate-200 placeholder:text-slate-600 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all resize-none text-base"
                  />
                </div>

                <div className="flex flex-col-reverse md:flex-row items-center justify-end gap-3 md:gap-4 pt-2">
                  <button
                    type="button"
                    onClick={() => navigate("/dashboard")}
                    className="w-full md:w-auto px-6 py-3 rounded-xl font-medium text-slate-400 hover:text-white hover:bg-slate-800 transition-colors"
                  >
                    Cancelar
                  </button>
                  
                  <button
                    type="submit"
                    disabled={loading || !descricao.trim()}
                    className="w-full md:w-auto px-8 py-3 bg-indigo-600 hover:bg-indigo-700 disabled:opacity-50 disabled:cursor-not-allowed text-white rounded-xl font-medium shadow-lg shadow-indigo-900/20 transition-all flex items-center justify-center gap-2"
                  >
                    {loading ? (
                      <>
                        <Sparkles className="w-5 h-5 animate-pulse" />
                        Analisando...
                      </>
                    ) : (
                      <>
                        <Send className="w-5 h-5" />
                        Criar Chamado
                      </>
                    )}
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