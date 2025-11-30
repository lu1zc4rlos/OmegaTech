import { useState, useRef, useEffect } from "react";
import { 
  Send, 
  Bot, 
  User,
  Menu // <--- Import
} from "lucide-react";
import { enviarMensagemChat } from "@/services/chatService";
import Sidebar from "@/components/Sidebar"; // <--- Import

interface Message {
  id: number;
  text: string;
  sender: 'user' | 'bot';
  timestamp: Date;
}

export default function Chat() {
  const scrollRef = useRef<HTMLDivElement>(null);
  const [isSidebarOpen, setIsSidebarOpen] = useState(false); // Estado Mobile
  
  const [input, setInput] = useState("");
  const [loading, setLoading] = useState(false);
  const [messages, setMessages] = useState<Message[]>([
    {
      id: 1,
      text: "Olá! Sou o assistente virtual do HelpDesk. Como posso ajudá-lo hoje?",
      sender: 'bot',
      timestamp: new Date()
    }
  ]);

  useEffect(() => {
    if (scrollRef.current) {
      scrollRef.current.scrollTop = scrollRef.current.scrollHeight;
    }
  }, [messages]);

  const handleSend = async () => {
    if (!input.trim() || loading) return;
    const userMessageText = input;
    setInput(""); 
    setLoading(true);

    const newMessage: Message = {
      id: Date.now(),
      text: userMessageText,
      sender: 'user',
      timestamp: new Date()
    };
    setMessages(prev => [...prev, newMessage]);

    try {
      const data = await enviarMensagemChat(userMessageText);
      const botResponse: Message = {
        id: Date.now() + 1,
        text: data.resposta || "Desculpe, não entendi.",
        sender: 'bot',
        timestamp: new Date()
      };
      setMessages(prev => [...prev, botResponse]);
    } catch (error) {
      console.error(error);
      setMessages(prev => [...prev, {
        id: Date.now() + 1,
        text: "Erro ao conectar com o assistente.",
        sender: 'bot',
        timestamp: new Date()
      }]);
    } finally {
      setLoading(false);
    }
  };

  const formatTime = (date: Date) => {
    return date.toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' });
  };

  return (
    <div className="flex h-screen bg-[#0f172a] text-slate-100 font-sans overflow-hidden">
      
      <Sidebar isOpen={isSidebarOpen} onClose={() => setIsSidebarOpen(false)} />

      <main className="flex-1 flex flex-col h-screen relative w-full">
        
        {/* Header Mobile */}
        <div className="md:hidden p-4 bg-[#1e293b] border-b border-slate-800 flex items-center justify-between shrink-0">
          <h1 className="font-bold text-lg text-white">OmegaHelp</h1>
          <button onClick={() => setIsSidebarOpen(true)} className="p-2 text-slate-300 hover:bg-slate-800 rounded-lg">
            <Menu className="w-6 h-6" />
          </button>
        </div>

        {/* Header Desktop (Oculto no mobile para economizar espaço) */}
        <header className="hidden md:block p-6 border-b border-slate-800 bg-[#0f172a] shrink-0">
          <h2 className="text-2xl font-bold text-white">Chat com OmegaHelp</h2>
          <p className="text-slate-400 text-sm">Converse com nosso chatbot para obter ajuda</p>
        </header>

        {/* Lista de Mensagens */}
        <div 
          ref={scrollRef}
          className="flex-1 overflow-y-auto p-4 md:p-6 space-y-4 md:space-y-6 scroll-smooth"
        >
          {messages.map((msg) => (
            <div 
              key={msg.id} 
              className={`flex gap-3 ${msg.sender === 'user' ? 'flex-row-reverse' : 'flex-row'}`}
            >
              <div className={`
                w-8 h-8 md:w-10 md:h-10 rounded-full flex items-center justify-center shrink-0
                ${msg.sender === 'bot' ? 'bg-indigo-600/20 text-indigo-400' : 'bg-slate-700 text-slate-300'}
              `}>
                {msg.sender === 'bot' ? <Bot className="w-4 h-4 md:w-5 md:h-5" /> : <User className="w-4 h-4 md:w-5 md:h-5" />}
              </div>

              <div className={`
                max-w-[85%] md:max-w-[70%] p-3 md:p-4 rounded-2xl text-sm leading-relaxed
                ${msg.sender === 'bot' 
                  ? 'bg-[#1e293b] text-slate-200 rounded-tl-none border border-slate-700' 
                  : 'bg-indigo-600 text-white rounded-tr-none'}
              `}>
                <p>{msg.text}</p>
                <span className="text-[10px] mt-1 block opacity-70 text-right">
                  {formatTime(msg.timestamp)}
                </span>
              </div>
            </div>
          ))}
          
          {loading && (
             <div className="flex gap-3 flex-row">
                <div className="w-8 h-8 rounded-full bg-indigo-600/20 text-indigo-400 flex items-center justify-center shrink-0">
                  <Bot className="w-4 h-4" />
                </div>
                <div className="bg-[#1e293b] p-3 rounded-2xl rounded-tl-none border border-slate-700 flex items-center gap-1">
                  <span className="w-1.5 h-1.5 bg-slate-500 rounded-full animate-bounce"></span>
                  <span className="w-1.5 h-1.5 bg-slate-500 rounded-full animate-bounce delay-100"></span>
                  <span className="w-1.5 h-1.5 bg-slate-500 rounded-full animate-bounce delay-200"></span>
                </div>
             </div>
          )}
        </div>

        {/* Input Area */}
        <div className="p-3 md:p-4 bg-[#1e293b] border-t border-slate-800 shrink-0">
          <div className="max-w-4xl mx-auto relative flex items-center gap-2">
            <input
              type="text"
              value={input}
              onChange={(e) => setInput(e.target.value)}
              onKeyDown={(e) => e.key === 'Enter' && handleSend()}
              placeholder="Digite sua mensagem..."
              disabled={loading}
              className="w-full bg-[#0f172a] border border-slate-700 rounded-xl px-4 py-3 text-slate-200 placeholder:text-slate-500 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all text-sm md:text-base"
            />
            
            <button 
              onClick={handleSend}
              disabled={loading || !input.trim()}
              className="p-3 bg-indigo-600 hover:bg-indigo-700 disabled:opacity-50 disabled:cursor-not-allowed rounded-xl text-white transition-colors"
            >
              <Send className="w-5 h-5" />
            </button>
          </div>
        </div>

      </main>
    </div>
  );
}