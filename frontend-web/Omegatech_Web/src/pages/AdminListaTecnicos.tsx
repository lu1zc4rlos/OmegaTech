import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { 
  Users, 
  UserPlus, 
  LogOut, 
  Menu, 
  MessageSquare, 
  X, 
  BadgeCheck, 
  Mail, 
  Hash, 
  Calendar 
} from "lucide-react";
import { listarTecnicos, TecnicoResponse } from "@/services/adminservice";

export default function AdminListTechnicians() {
  const navigate = useNavigate();
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);
  
  const [tecnicos, setTecnicos] = useState<TecnicoResponse[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    carregarTecnicos();
  }, []);

  const carregarTecnicos = async () => {
    try {
      const data = await listarTecnicos();
      setTecnicos(data);
    } catch (err: any) {
      setError("Erro ao carregar técnicos.");
    } finally {
      setLoading(false);
    }
  };

  const handleLogout = () => {
    localStorage.clear();
    navigate("/");
  };

  const formatarData = (dataString: string) => {
    if (!dataString) return "-";
    return new Date(dataString).toLocaleDateString('pt-BR');
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
        <div className="p-6 flex items-center justify-between">
          <div className="flex items-center gap-3">
            <div className="w-8 h-8 bg-indigo-600 rounded-lg flex items-center justify-center shadow-lg shadow-indigo-500/20">
              <MessageSquare className="w-5 h-5 text-white" />
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
          <button 
            onClick={() => navigate("/admin")} 
            className="flex items-center gap-3 w-full px-4 py-3 text-slate-400 hover:bg-slate-800 hover:text-slate-200 rounded-xl font-medium transition-colors"
          >
            <UserPlus className="w-5 h-5" />
            Adicionar Técnico
          </button>
          <button 
            className="flex items-center gap-3 w-full px-4 py-3 bg-indigo-600 text-white shadow-lg shadow-indigo-900/20 rounded-xl font-medium transition-colors"
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

      {/* CONTEÚDO PRINCIPAL */}
      <main className="flex-1 flex flex-col h-screen relative bg-[#0f172a]">
        
        {/* Header Mobile */}
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between shrink-0">
          <h1 className="font-bold text-lg text-white">Técnicos</h1>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        <div className="flex-1 overflow-y-auto p-4 md:p-8 flex flex-col items-center">
          
          <div className="w-full max-w-6xl mt-2 md:mt-4">
            <header className="mb-6 md:mb-8 flex justify-between items-end">
              <div>
                <h2 className="text-2xl md:text-3xl font-bold text-white tracking-tight">Equipe Técnica</h2>
                <p className="text-slate-400 mt-1 text-sm md:text-base">Gerencie os técnicos cadastrados no sistema.</p>
              </div>
              <span className="bg-indigo-500/10 text-indigo-400 px-3 py-1 rounded-full text-xs md:text-sm border border-indigo-500/20 whitespace-nowrap">
                Total: {tecnicos.length}
              </span>
            </header>

            {loading ? (
               <div className="text-center py-20 text-slate-500">Carregando dados...</div>
            ) : error ? (
               <div className="text-center py-20 text-red-400">{error}</div>
            ) : tecnicos.length === 0 ? (
               <div className="p-12 text-center text-slate-500 bg-[#1e293b] rounded-2xl border border-slate-800">
                 Nenhum técnico encontrado.
               </div>
            ) : (
              <>
                {/* --- VISÃO MOBILE (CARDS) --- */}
                {/* Só aparece em telas pequenas (md:hidden) */}
                <div className="md:hidden flex flex-col gap-4">
                  {tecnicos.map((tec) => (
                    <div key={tec.id} className="bg-[#1e293b] p-5 rounded-xl border border-slate-800 shadow-sm flex flex-col gap-4">
                      
                      <div className="flex justify-between items-start">
                        <div>
                          <h3 className="text-white font-bold text-lg">{tec.nome}</h3>
                          <div className="flex items-center gap-2 mt-1">
                            <span className="text-slate-500 text-xs font-mono">ID #{tec.id}</span>
                            <span className="bg-slate-800 border border-slate-700 text-slate-300 px-2 py-0.5 rounded text-[10px] font-mono uppercase">
                              {tec.matricula || "N/A"}
                            </span>
                          </div>
                        </div>
                        <div className="inline-flex items-center justify-center w-8 h-8 rounded-full bg-green-500/10 text-green-500">
                           <BadgeCheck className="w-5 h-5" />
                        </div>
                      </div>

                      <div className="space-y-2 text-sm text-slate-400 border-t border-slate-700/50 pt-3">
                        <div className="flex items-center gap-2">
                          <Mail className="w-4 h-4 text-indigo-400" />
                          <span className="truncate">{tec.email}</span>
                        </div>
                        <div className="flex items-center gap-2">
                          <Calendar className="w-4 h-4 text-indigo-400" />
                          <span>Desde: {formatarData(tec.dataCriacao)}</span>
                        </div>
                      </div>

                      <button
                        onClick={() => navigate(`/admin/tecnicos/${tec.id}`)}
                        className="w-full bg-slate-800 hover:bg-slate-700 text-indigo-400 border border-slate-700 hover:border-indigo-500/50 py-2 rounded-lg text-sm font-bold transition-all"
                      >
                        Ver Detalhes
                      </button>
                    </div>
                  ))}
                </div>

                {/* --- VISÃO DESKTOP (TABELA) --- */}
                {/* Só aparece em telas médias ou maiores (hidden md:block) */}
                <div className="hidden md:block bg-[#1e293b] rounded-2xl border border-slate-800 overflow-hidden shadow-xl">
                  <div className="overflow-x-auto">
                    <table className="w-full text-left border-collapse">
                      <thead>
                        <tr className="bg-slate-900/50 border-b border-slate-700/50 text-slate-400 text-xs uppercase tracking-wider">
                          <th className="p-6 font-semibold">ID</th>
                          <th className="p-6 font-semibold">Nome</th>
                          <th className="p-6 font-semibold">Matrícula</th>
                          <th className="p-6 font-semibold">Email</th>
                          <th className="p-6 font-semibold">Data Cadastro</th>
                          <th className="p-6 font-semibold text-center">Ações</th>
                        </tr>
                      </thead>
                      <tbody className="divide-y divide-slate-800">
                        {tecnicos.map((tec) => (
                          <tr key={tec.id} className="hover:bg-slate-800/50 transition-colors group">
                            <td className="p-6 text-slate-500 font-mono text-sm">#{tec.id}</td>
                            <td className="p-6 font-medium text-white whitespace-nowrap">{tec.nome}</td>
                            <td className="p-6">
                              <span className="bg-slate-800 border border-slate-700 text-slate-300 px-2 py-1 rounded text-xs font-mono whitespace-nowrap">
                                {tec.matricula || "N/A"}
                              </span>
                            </td>
                            <td className="p-6 text-slate-400">{tec.email}</td>
                            <td className="p-6 text-slate-400 text-sm whitespace-nowrap">{formatarData(tec.dataCriacao)}</td>
                            <td className="p-6 text-center">
                               <button
                                  onClick={() => navigate(`/admin/tecnicos/${tec.id}`)}
                                  className="bg-indigo-600 hover:bg-indigo-500 text-white px-3 py-1 rounded text-xs font-bold transition-colors shadow-lg shadow-orange-900/20"
                                >
                                  Detalhes
                                </button>
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                  </div>
                </div>
              </>
            )}
          </div>
        </div>
      </main>
    </div>
  );
}