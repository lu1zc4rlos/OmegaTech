import { useEffect, useState } from "react";
import { useParams, useNavigate } from "react-router-dom";
import { ArrowLeft, Mail, Calendar, Hash, MessageSquare, CheckCircle2 } from "lucide-react";
import { buscarTecnicoPorId, listarTicketsRespondidos, TecnicoResponse } from "@/services/adminservice";
import { Ticket } from "@/types";

export default function AdminTechnicianDetails() {
  const { id } = useParams();
  const navigate = useNavigate();
  
  const [tecnico, setTecnico] = useState<TecnicoResponse | null>(null);
  const [tickets, setTickets] = useState<Ticket[]>([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    if (id) carregarDados(Number(id));
  }, [id]);

  const carregarDados = async (techId: number) => {
    try {
      const [techData, ticketsData] = await Promise.all([
        buscarTecnicoPorId(techId),
        listarTicketsRespondidos(techId)
      ]);
      setTecnico(techData);
      setTickets(ticketsData);
    } catch (error) {
      console.error(error);
    } finally {
      setLoading(false);
    }
  };

  const formatarData = (data: string) => {
    return data ? new Date(data).toLocaleDateString('pt-BR') : '-';
  };

  if (loading) return <div className="min-h-screen bg-[#0f172a] flex items-center justify-center text-white">Carregando...</div>;
  if (!tecnico) return <div className="min-h-screen bg-[#0f172a] flex items-center justify-center text-white">Técnico não encontrado</div>;

  return (
    <div className="min-h-screen bg-[#0f172a] text-slate-100 font-sans p-8">
      <div className="max-w-6xl mx-auto">
        
        {/* Header Voltar */}
        <button 
          onClick={() => navigate("/admin/lista")}
          className="flex items-center gap-2 text-slate-400 hover:text-white mb-6 transition-colors"
        >
          <ArrowLeft className="w-5 h-5" /> Voltar para lista
        </button>

        {/* CARD DO TÉCNICO */}
        <div className="bg-[#1e293b] rounded-2xl border border-slate-800 p-8 mb-8 shadow-xl">
          <div className="flex flex-col md:flex-row justify-between items-start md:items-center gap-4">
            <div>
              <h1 className="text-3xl font-bold text-white mb-2">{tecnico.nome}</h1>
              <div className="flex flex-wrap gap-6 text-slate-400 text-sm">
                <span className="flex items-center gap-2"><Mail className="w-4 h-4 text-indigo-400" /> {tecnico.email}</span>
                <span className="flex items-center gap-2"><Hash className="w-4 h-4 text-indigo-400" /> Matrícula: {tecnico.matricula}</span>
                <span className="flex items-center gap-2"><Calendar className="w-4 h-4 text-indigo-400" /> Desde: {formatarData(tecnico.dataCriacao)}</span>
              </div>
            </div>
            <div className="bg-indigo-500/10 px-4 py-2 rounded-xl border border-indigo-500/20">
              <span className="block text-2xl font-bold text-indigo-400 text-center">{tickets.length}</span>
              <span className="text-xs text-indigo-300 uppercase font-bold tracking-wider">Chamados Resolvidos</span>
            </div>
          </div>
        </div>

        {/* LISTA DE TICKETS RESOLVIDOS */}
        <h2 className="text-xl font-bold text-white mb-4 flex items-center gap-2">
          <CheckCircle2 className="w-6 h-6 text-green-500" />
          Histórico de Atendimentos
        </h2>

        <div className="bg-[#1e293b] rounded-2xl border border-slate-800 overflow-hidden shadow-xl">
          {tickets.length === 0 ? (
            <div className="p-12 text-center text-slate-500">Este técnico ainda não finalizou nenhum chamado.</div>
          ) : (
            <div className="divide-y divide-slate-800">
              {tickets.map((ticket) => (
                <div key={ticket.id} className="p-6 hover:bg-slate-800/50 transition-colors">
                  <div className="flex justify-between items-start mb-3">
                    <div className="flex items-center gap-3">
                      <span className="bg-slate-900 text-slate-400 px-2 py-1 rounded text-xs font-mono">#{ticket.id}</span>
                      <h3 className="font-bold text-white text-lg">{ticket.titulo?.replace(/_/g, " ")}</h3>
                    </div>
                    <span className="text-xs text-slate-500">{formatarData(ticket.dataCriacao)}</span>
                  </div>

                  <div className="grid grid-cols-1 md:grid-cols-2 gap-6 mt-4">
                    {/* Problema Original */}
                    <div className="bg-red-500/5 border border-red-500/10 rounded-xl p-4">
                      <p className="text-xs text-red-300 uppercase font-bold mb-1">Problema relatado</p>
                      <p className="text-slate-300 text-sm">{ticket.descricao}</p>
                    </div>

                    {/* Resposta do Técnico */}
                    <div className="bg-green-500/5 border border-green-500/10 rounded-xl p-4">
                      <p className="text-xs text-green-300 uppercase font-bold mb-1 flex items-center gap-1">
                        <MessageSquare className="w-3 h-3" /> Resposta dada
                      </p>
                      <p className="text-slate-300 text-sm">{ticket.resposta}</p>
                    </div>
                  </div>
                </div>
              ))}
            </div>
          )}
        </div>

      </div>
    </div>
  );
}