import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { getTicketById } from "@/services/ticketService";
import { Ticket } from "@/types";
import { ArrowLeft, Calendar, User, MessageCircle, AlertCircle } from "lucide-react";

export default function TicketDetails() {
  const { id } = useParams(); // Pega o ID da URL (ex: /tickets/6)
  const navigate = useNavigate();
  
  const [ticket, setTicket] = useState<Ticket | null>(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState<string | null>(null);

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

  // Funções de Estilo (Mesmas do Dashboard para consistência)
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
    <div className="min-h-screen bg-[#0f172a] text-slate-100 p-6 font-sans flex justify-center">
      <div className="w-full max-w-2xl space-y-6">
        
        {/* HEADER: Botão Voltar + Título */}
        <div className="flex items-center gap-4 mb-8">
          <button 
            onClick={() => navigate(-1)} 
            className="p-2 hover:bg-slate-800 rounded-lg transition-colors text-slate-400 hover:text-white"
          >
            <ArrowLeft className="w-6 h-6" />
          </button>
          <h1 className="text-2xl font-bold">Ticket #{ticket.id}</h1>
        </div>

        {/* BADGES: Status e Prioridade */}
        <div className="flex gap-3">
          <span className={`px-3 py-1 rounded-md text-sm font-semibold tracking-wide ${getStatusColor(ticket.status)}`}>
            {ticket.status}
          </span>
          <span className={`px-3 py-1 rounded-md text-sm font-semibold tracking-wide ${getPriorityColor(ticket.prioridade)}`}>
            {ticket.prioridade}
          </span>
        </div>

        {/* CARD PRINCIPAL: Detalhes do Problema */}
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

        {/* CARD RESPOSTA TÉCNICA (Renderização Condicional) */}
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
  );
}