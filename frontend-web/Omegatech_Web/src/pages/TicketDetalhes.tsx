import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { getTicketById, responderTicket, excluirTicket } from "@/services/ticketService"; // Importei excluirTicket
import { Ticket } from "@/types";
import { ArrowLeft, Calendar, User, MessageCircle, AlertCircle, Send, Menu, Trash2 } from "lucide-react"; // Importei Trash2
import Sidebar from "@/components/Sidebar";

export default function TicketDetails() {
  const { id } = useParams(); 
  const navigate = useNavigate();
  
  const [ticket, setTicket] = useState<Ticket | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

  const [isSidebarOpen, setIsSidebarOpen] = useState(false);
  const [respostaTexto, setRespostaTexto] = useState("");
  const [enviando, setEnviando] = useState(false);
  
  // Estado para loading de exclusão
  const [excluindo, setExcluindo] = useState(false);

  const userString = localStorage.getItem("user");
  const user = userString ? JSON.parse(userString) : { username: "", perfil: "" };

  useEffect(() => {
    if (id) {
      carregarTicket(Number(id));
    }
  }, [id]);

  const carregarTicket = async (ticketId: number) => {
    try {
      const data = await getTicketById(ticketId);
      setTicket(data);
    } catch (err) {
      setError("Não foi possível carregar o ticket.");
    } finally {
      setLoading(false);
    }
  };

  const handleEnviarResposta = async () => {
    if (!respostaTexto.trim() || !ticket) return;
    setEnviando(true);
    try {
      await responderTicket(ticket.id, respostaTexto);
      await carregarTicket(ticket.id);
    } catch (error) {
      alert("Erro ao enviar resposta");
    } finally {
      setEnviando(false);
    }
  };

  // --- NOVA FUNÇÃO DE EXCLUSÃO ---
  const handleExcluir = async () => {
    if (!ticket) return;
    
    // Confirmação nativa do navegador
    const confirmacao = window.confirm("Tem certeza que deseja excluir este chamado? Essa ação não pode ser desfeita.");
    
    if (confirmacao) {
      setExcluindo(true);
      try {
        await excluirTicket(ticket.id);
        alert("Chamado excluído com sucesso.");
        navigate("/dashboard"); // Volta para o início
      } catch (err: any) {
        alert("Erro: " + err.message);
      } finally {
        setExcluindo(false);
      }
    }
  };

  const getStatusColor = (status: string) => {
    switch (status) {
      case "PENDENTE": return "bg-red-500/20 text-red-400 border border-red-500/30";
      case "EM_ANDAMENTO": return "bg-yellow-500/20 text-yellow-400 border border-yellow-500/30";
      case "CONCLUIDO": return "bg-green-500/20 text-green-400 border border-green-500/30";
      default: return "bg-gray-500/20 text-gray-400";
    }
  };

  const getPriorityColor = (prioridade: string) => {
    switch (prioridade) {
      case "ALTA": return "bg-red-900/40 text-red-300 border border-red-700/50";
      case "MEDIA": return "bg-yellow-900/40 text-yellow-300 border border-yellow-700/50";
      case "BAIXA": return "bg-blue-900/40 text-blue-300 border border-blue-700/50";
      default: return "bg-gray-800 text-gray-300";
    }
  };

  if (loading) return <div className="min-h-screen bg-[#0f172a] flex items-center justify-center text-white">Carregando...</div>;
  if (error || !ticket) return <div className="min-h-screen bg-[#0f172a] flex items-center justify-center text-red-400">{error || "Ticket não encontrado"}</div>;

  return (
    <div className="flex h-screen bg-[#0f172a] text-slate-100 font-sans overflow-hidden">
      
      <Sidebar isOpen={isSidebarOpen} onClose={() => setIsSidebarOpen(false)} />

      <main className="flex-1 flex flex-col h-screen relative">
        
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between shrink-0">
          <h1 className="font-bold text-lg text-white">Detalhes</h1>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        <div className="flex-1 overflow-y-auto p-4 md:p-8 flex justify-center">
          <div className="w-full max-w-2xl space-y-6 mt-2 md:mt-0">
            
            {/* HEADER COM BOTÕES */}
            <div className="flex items-center justify-between mb-8">
              <div className="flex items-center gap-4">
                <button 
                  onClick={() => navigate(-1)} 
                  className="p-2 hover:bg-slate-800 rounded-lg transition-colors text-slate-400 hover:text-white"
                >
                  <ArrowLeft className="w-6 h-6" />
                </button>
                <h1 className="text-2xl font-bold">Ticket #{ticket.id}</h1>
              </div>

              {/* BOTÃO DE EXCLUIR (Só aparece se for CLIENTE e PENDENTE) */}
              {user.perfil === 'ROLE_CLIENTE' && ticket.status === 'PENDENTE' && (
                <button 
                  onClick={handleExcluir}
                  disabled={excluindo}
                  className="flex items-center gap-2 px-3 py-2 bg-red-500/10 hover:bg-red-500/20 text-red-400 border border-red-500/30 rounded-lg text-sm font-medium transition-all disabled:opacity-50"
                >
                  <Trash2 className="w-4 h-4" />
                  {excluindo ? "Excluindo..." : "Excluir"}
                </button>
              )}
            </div>

            <div className="flex gap-3">
              <span className={`px-3 py-1 rounded-md text-sm font-semibold tracking-wide ${getStatusColor(ticket.status)}`}>
                {ticket.status}
              </span>
              <span className={`px-3 py-1 rounded-md text-sm font-semibold tracking-wide ${getPriorityColor(ticket.prioridade)}`}>
                {ticket.prioridade}
              </span>
            </div>

            <div className="bg-[#1e293b] rounded-xl p-6 shadow-lg border border-slate-800">
              <h2 className="text-xl font-bold text-white mb-2 uppercase tracking-wide">
                {ticket.titulo.replace(/_/g, " ")}
              </h2>
              
              <p className="text-slate-400 text-base mb-6 leading-relaxed">
                {ticket.descricao}
              </p>

              <div className="flex flex-col gap-3 text-sm text-slate-500 border-t border-slate-700/50 pt-4">
                <div className="flex items-center gap-2">
                  <Calendar className="w-4 h-4" />
                  <span>Criado em: {ticket.dataCriacao}</span>
                </div>
                
                {ticket.nomeTecnico ? (
                  <div className="flex items-center gap-2 text-indigo-400">
                    <User className="w-4 h-4" />
                    <span>Atribuído a: {ticket.nomeTecnico}</span>
                  </div>
                ) : (
                  <div className="flex items-center gap-2 text-yellow-500/70">
                    <AlertCircle className="w-4 h-4" />
                    <span>Aguardando técnico</span>
                  </div>
                )}
              </div>
            </div>

            {/* ÁREA DE RESPOSTA DO TÉCNICO */}
            {user.perfil === 'ROLE_TECNICO' && ticket.status === 'EM_ANDAMENTO' && user.username === ticket.nomeTecnico && (
              <div className="bg-[#1e293b] rounded-xl p-6 shadow-lg border border-indigo-500/30 mt-6 animate-in fade-in slide-in-from-bottom-4">
                <h3 className="text-white font-bold text-lg mb-4 flex items-center gap-2">
                  <MessageCircle className="w-5 h-5 text-indigo-400" />
                  Enviar Resposta
                </h3>
                
                <textarea
                  value={respostaTexto}
                  onChange={(e) => setRespostaTexto(e.target.value)}
                  placeholder="Descreva a solução do problema para o cliente..."
                  rows={4}
                  className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-4 text-slate-200 focus:outline-none focus:border-indigo-500 transition-all resize-none mb-4 placeholder:text-slate-600"
                />
                
                <div className="flex justify-end">
                  <button
                    onClick={handleEnviarResposta}
                    disabled={enviando || !respostaTexto.trim()}
                    className="px-6 py-2.5 bg-indigo-600 hover:bg-indigo-700 text-white rounded-xl font-medium transition-colors flex items-center gap-2 disabled:opacity-50 disabled:cursor-not-allowed shadow-lg shadow-indigo-900/20"
                  >
                    {enviando ? (
                      "Enviando..."
                    ) : (
                      <>
                        <Send className="w-4 h-4" />
                        Concluir Chamado
                      </>
                    )}
                  </button>
                </div>
              </div>
            )}

            {/* AVISO PARA OUTROS TÉCNICOS */}
            {user.perfil === 'ROLE_TECNICO' && ticket.status === 'EM_ANDAMENTO' && user.username !== ticket.nomeTecnico && (
               <div className="mt-6 flex items-center gap-3 p-4 rounded-xl bg-slate-800/50 border border-slate-700">
                 <div className="bg-indigo-500/10 p-2 rounded-lg text-indigo-400">
                   <User className="w-5 h-5" />
                 </div>
                 <div>
                   <p className="text-slate-300 text-sm font-medium">Em atendimento</p>
                   <p className="text-slate-500 text-xs">
                     Técnico responsável: <span className="text-white font-semibold">{ticket.nomeTecnico}</span>
                   </p>
                 </div>
               </div>
            )}

            {/* CARD RESPOSTA VISUALIZAÇÃO */}
            {ticket.resposta && (
              <div className="bg-[#1e2433] rounded-xl p-6 shadow-lg border border-indigo-500/20">
                <div className="flex items-center gap-2 mb-3">
                  <MessageCircle className="w-5 h-5 text-indigo-400" />
                  <h3 className="text-indigo-400 font-bold text-sm uppercase">Resposta do Técnico</h3>
                </div>
                <p className="text-slate-200 leading-relaxed">
                  {ticket.resposta}
                </p>
              </div>
            )}

          </div>
        </div>
      </main>
    </div>
  );
}