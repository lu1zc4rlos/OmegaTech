import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import { 
  Ticket as TicketIcon, 
  AlertCircle, 
  Clock, 
  CheckCircle2,
  ChevronRight,
  Search,
  Menu
} from "lucide-react";
import { getMeusTickets, assumirTicket } from "@/services/ticketService"; // Importei assumirTicket
import { Ticket, TicketStats } from "@/types";
import Sidebar from "@/components/Sidebar";

export default function Dashboard() {
  const navigate = useNavigate();
  const [tickets, setTickets] = useState<Ticket[]>([]);
  const [loading, setLoading] = useState(true);
  const [filterStatus, setFilterStatus] = useState<"TODOS" | "PENDENTE" | "EM_ANDAMENTO" | "CONCLUIDO">("TODOS");
  
  const [isSidebarOpen, setIsSidebarOpen] = useState(false);

  const [stats, setStats] = useState<TicketStats>({
    total: 0, abertos: 0, emAndamento: 0, resolvidos: 0
  });

  const userString = localStorage.getItem("user");
  const user = userString ? JSON.parse(userString) : { username: "Usuário", perfil: "" };

  useEffect(() => {
    carregarDados();
  }, []);

  const carregarDados = async () => {
    try {
      const data = await getMeusTickets();
      const ticketsOrdenados = data.sort((a: Ticket, b: Ticket) => b.id - a.id);
      setTickets(ticketsOrdenados);
      calcularEstatisticas(ticketsOrdenados);
    } catch (error) {
      console.error(error);
      navigate("/"); 
    } finally {
      setLoading(false);
    }
  };

  // Função para o Técnico atender o chamado
  const handleAtender = async (id: number) => {
    try {
      setLoading(true);
      await assumirTicket(id);
      await carregarDados(); // Recarrega para atualizar o status
    } catch (error) {
      alert("Erro ao atender chamado.");
    } finally {
      setLoading(false);
    }
  };

  const calcularEstatisticas = (data: Ticket[]) => {
    setStats({
      total: data.length,
      abertos: data.filter(t => t.status === "PENDENTE").length,
      emAndamento: data.filter(t => t.status === "EM_ANDAMENTO").length,
      resolvidos: data.filter(t => t.status === "CONCLUIDO").length,
    });
  };

  const ticketsFiltrados = tickets.filter((ticket) => {
    if (filterStatus === "TODOS") return true;
    return ticket.status === filterStatus;
  });

  const getStatusColor = (status: string) => {
    switch (status) {
      case "PENDENTE": return "bg-red-500/10 text-red-400 border-red-500/20";
      case "EM_ANDAMENTO": return "bg-yellow-500/10 text-yellow-400 border-yellow-500/20";
      case "CONCLUIDO": return "bg-green-500/10 text-green-400 border-green-500/20";
      default: return "bg-gray-500/10 text-gray-400";
    }
  };

  const getStatusLabel = (status: string) => {
    switch (status) {
      case "PENDENTE": return "Aberto";
      case "EM_ANDAMENTO": return "Em Andamento";
      case "CONCLUIDO": return "Resolvido";
      default: return status;
    }
  };

  const isFilterActive = (status: string) => filterStatus === status 
    ? "ring-2 ring-indigo-500 border-transparent bg-[#1e293b]" 
    : "border-slate-800 hover:bg-[#1e293b] bg-[#1e293b]/50";

  if (loading) return <div className="min-h-screen bg-[#0f172a] flex items-center justify-center text-white">Carregando...</div>;

  return (
    <div className="flex min-h-screen bg-[#0f172a] text-slate-100 font-sans">
      
      <Sidebar isOpen={isSidebarOpen} onClose={() => setIsSidebarOpen(false)} />

      <main className="flex-1 flex flex-col h-screen overflow-hidden">
        
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between">
          <div className="flex items-center gap-2">
             <h1 className="font-bold text-lg text-white">OmegaTech</h1>
          </div>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        <div className="flex-1 overflow-y-auto p-4 md:p-8">
          <header className="mb-8 flex flex-col md:flex-row md:justify-between md:items-end gap-4">
            <div>
              <h2 className="text-2xl md:text-3xl font-bold text-white tracking-tight">Dashboard</h2>
              <p className="text-slate-400 mt-1 text-sm md:text-base">Bem-vindo, <span className="text-indigo-400">{user.username}</span></p>
            </div>
          </header>

          <div className="grid grid-cols-2 lg:grid-cols-4 gap-3 md:gap-5 mb-8">
            <div onClick={() => setFilterStatus("TODOS")} className={`cursor-pointer p-4 md:p-5 rounded-2xl border transition-all duration-200 relative overflow-hidden group ${isFilterActive("TODOS")}`}>
              <div className="relative z-10 flex flex-col md:flex-row justify-between items-start gap-2">
                <div>
                  <p className="text-slate-400 text-[10px] md:text-xs font-bold uppercase tracking-wider">Total</p>
                  <h3 className="text-2xl md:text-3xl font-bold text-white mt-1">{stats.total}</h3>
                </div>
                <div className="p-2 bg-indigo-500/10 rounded-lg group-hover:bg-indigo-500/20 transition-colors self-end md:self-start">
                  <TicketIcon className="w-5 h-5 md:w-6 md:h-6 text-indigo-500" />
                </div>
              </div>
            </div>
            
             <div onClick={() => setFilterStatus("PENDENTE")} className={`cursor-pointer p-4 md:p-5 rounded-2xl border transition-all duration-200 relative overflow-hidden group ${isFilterActive("PENDENTE")}`}>
              <div className="relative z-10 flex flex-col md:flex-row justify-between items-start gap-2">
                <div>
                  <p className="text-slate-400 text-[10px] md:text-xs font-bold uppercase tracking-wider">Abertos</p>
                  <h3 className="text-2xl md:text-3xl font-bold text-white mt-1">{stats.abertos}</h3>
                </div>
                <div className="p-2 bg-red-500/10 rounded-lg group-hover:bg-red-500/20 transition-colors self-end md:self-start">
                  <AlertCircle className="w-5 h-5 md:w-6 md:h-6 text-red-500" />
                </div>
              </div>
            </div>

             <div onClick={() => setFilterStatus("EM_ANDAMENTO")} className={`cursor-pointer p-4 md:p-5 rounded-2xl border transition-all duration-200 relative overflow-hidden group ${isFilterActive("EM_ANDAMENTO")}`}>
              <div className="relative z-10 flex flex-col md:flex-row justify-between items-start gap-2">
                <div>
                  <p className="text-slate-400 text-[10px] md:text-xs font-bold uppercase tracking-wider">Andamento</p>
                  <h3 className="text-2xl md:text-3xl font-bold text-white mt-1">{stats.emAndamento}</h3>
                </div>
                <div className="p-2 bg-yellow-500/10 rounded-lg group-hover:bg-yellow-500/20 transition-colors self-end md:self-start">
                  <Clock className="w-5 h-5 md:w-6 md:h-6 text-yellow-500" />
                </div>
              </div>
            </div>

             <div onClick={() => setFilterStatus("CONCLUIDO")} className={`cursor-pointer p-4 md:p-5 rounded-2xl border transition-all duration-200 relative overflow-hidden group ${isFilterActive("CONCLUIDO")}`}>
              <div className="relative z-10 flex flex-col md:flex-row justify-between items-start gap-2">
                <div>
                  <p className="text-slate-400 text-[10px] md:text-xs font-bold uppercase tracking-wider">Resolvidos</p>
                  <h3 className="text-2xl md:text-3xl font-bold text-white mt-1">{stats.resolvidos}</h3>
                </div>
                <div className="p-2 bg-green-500/10 rounded-lg group-hover:bg-green-500/20 transition-colors self-end md:self-start">
                  <CheckCircle2 className="w-5 h-5 md:w-6 md:h-6 text-green-500" />
                </div>
              </div>
            </div>
          </div>

          <div className="bg-[#1e293b] rounded-2xl border border-slate-800 overflow-hidden shadow-xl">
            <div className="p-4 md:p-6 border-b border-slate-800 flex justify-between items-center bg-[#1e293b]">
              <h3 className="text-base md:text-lg font-bold text-white">
                {filterStatus === "TODOS" ? "Chamados Recentes" : getStatusLabel(filterStatus)}
              </h3>
              {filterStatus !== "TODOS" && (
                <button onClick={() => setFilterStatus("TODOS")} className="text-xs font-medium text-indigo-400 hover:underline">Limpar</button>
              )}
            </div>
            
            <div className="p-3 md:p-4 flex flex-col gap-3">
              {ticketsFiltrados.length === 0 ? (
                 <div className="flex flex-col items-center justify-center py-12 text-slate-500">
                    <Search className="w-8 h-8 opacity-50 mb-2" />
                    <p className="text-sm">Nenhum chamado encontrado.</p>
                 </div>
              ) : (
                ticketsFiltrados.map((ticket) => (
                  <div 
                    key={ticket.id} 
                    onClick={() => navigate(`/tickets/${ticket.id}`)}
                    className="group bg-slate-800/40 border border-slate-700/50 rounded-xl p-4 cursor-pointer active:scale-[0.98] transition-transform"
                  >
                    <div className="flex items-center gap-2 mb-2">
                      <span className="text-slate-500 text-xs font-mono">#{ticket.id}</span>
                      <span className={`px-2 py-0.5 rounded text-[10px] font-bold uppercase border ${getStatusColor(ticket.status)}`}>
                        {getStatusLabel(ticket.status)}
                      </span>
                      <span className="text-slate-500 text-xs ml-auto">{ticket.dataCriacao}</span>
                    </div>
                    
                    <h4 className="text-white font-medium text-base truncate">{ticket.titulo.replace(/_/g, " ")}</h4>
                    <p className="text-slate-400 text-xs truncate mt-1">{ticket.descricao}</p>

                    <div className="mt-3 pt-3 border-t border-slate-700/50 flex justify-between items-center">
                        
                        {/* Bloco de Prioridade (Mantido para todos) */}
                        <div className="flex items-center gap-2">
                          <span className="text-[10px] font-bold text-slate-500 uppercase tracking-wider">
                            Prioridade
                          </span>
                          
                          <span className={`
                            text-[10px] font-bold px-2 py-0.5 rounded border
                            ${ticket.prioridade === 'ALTA' ? 'bg-red-500/10 text-red-400 border-red-500/20' : 
                              ticket.prioridade === 'MEDIA' ? 'bg-yellow-500/10 text-yellow-400 border-yellow-500/20' : 
                              'bg-blue-500/10 text-blue-400 border-blue-500/20'}
                          `}>
                            {ticket.prioridade}
                          </span>
                        </div>

                        {/* AQUI: Lógica dos Botões do Técnico */}
                        <div onClick={(e) => e.stopPropagation()}> 
                          {user.perfil === 'ROLE_TECNICO' && ticket.status === 'PENDENTE' ? (
                            <button
                              onClick={() => handleAtender(ticket.id)}
                              className="px-3 py-1 bg-indigo-600 hover:bg-indigo-500 text-white text-[10px] font-bold uppercase rounded shadow-lg shadow-indigo-900/30 transition-all hover:scale-105"
                            >
                              ATENDER
                            </button>
                          ) : user.perfil === 'ROLE_TECNICO' && ticket.status === 'EM_ANDAMENTO' ? (
                            <span className="flex items-center gap-1 text-[10px] font-bold text-emerald-400 border border-emerald-500/30 px-2 py-1 rounded bg-emerald-500/10">
                              RESPONDER <ChevronRight className="w-3 h-3" />
                            </span>
                          ) : (
                            <ChevronRight className="w-4 h-4 text-slate-600 group-hover:text-indigo-400 transition-colors" />
                          )}
                        </div>

                    </div>
                  </div>
                ))
              )}
            </div>
          </div>
        </div>
      </main>
    </div>
  );
}