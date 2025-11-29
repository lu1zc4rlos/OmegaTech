import { useNavigate, useLocation } from "react-router-dom";
import { 
  LayoutDashboard, 
  Omega, 
  Ticket as TicketIcon, 
  LogOut, 
  X 
} from "lucide-react";

interface SidebarProps {
  isOpen: boolean;
  onClose: () => void;
}

export default function Sidebar({ isOpen, onClose }: SidebarProps) {
  const navigate = useNavigate();
  const location = useLocation(); 

  const isActive = (path: string) => location.pathname === path;

  // Estilos Base
  const baseButtonStyle = "flex items-center gap-3 w-full px-4 py-3 rounded-xl font-medium transition-colors group";
  const activeStyle = "bg-indigo-600 text-white shadow-lg shadow-indigo-900/20";
  const inactiveStyle = "text-slate-400 hover:text-slate-200 hover:bg-slate-800";

  const handleNavigation = (path: string) => {
    navigate(path);
    onClose(); 
  };

  const handleLogout = () => {
    localStorage.clear();
    navigate("/");
  };

  return (
    <>
      {/* OVERLAY MOBILE */}
      {isOpen && (
        <div 
          className="fixed inset-0 bg-black/60 z-40 md:hidden backdrop-blur-sm transition-opacity"
          onClick={onClose}
        />
      )}

      {/* SIDEBAR */}
      <aside className={`
        fixed inset-y-0 left-0 z-50 w-64 bg-[#1e293b] border-r border-slate-800 flex flex-col
        transform transition-transform duration-300 ease-in-out shadow-2xl md:shadow-none
        ${isOpen ? "translate-x-0" : "-translate-x-full"} 
        md:translate-x-0 md:static md:h-screen
      `}>
        
        {/* HEADER DA SIDEBAR */}
        <div className="p-6 flex items-center justify-between shrink-0"> {/* shrink-0 impede que o header amasse */}
          <div className="flex items-center gap-3 min-w-0 overflow-hidden">
            <div className="w-8 h-8 bg-indigo-600 rounded-lg flex items-center justify-center shadow-lg shadow-indigo-500/20 shrink-0">
              <Omega className="w-5 h-5 text-white" />
            </div>
            <div className="min-w-0 flex-1"> {/* min-w-0 é CRUCIAL para o truncate funcionar no flex */}
              <h1 className="font-bold text-lg text-slate-100 tracking-tight truncate">OmegaTech</h1>
              <p className="text-xs text-slate-400 font-medium truncate">Sistema de Suporte</p>
            </div>
          </div>
          
          {/* Botão Fechar Mobile */}
          <button onClick={onClose} className="md:hidden text-slate-400 hover:text-white shrink-0 ml-2">
            <X className="w-6 h-6" />
          </button>
        </div>

        {/* NAVEGAÇÃO */}
        <nav className="flex-1 px-4 space-y-2 mt-4 overflow-y-auto">
          <button 
            onClick={() => handleNavigation("/dashboard")}
            className={`${baseButtonStyle} ${isActive("/dashboard") ? activeStyle : inactiveStyle}`}
          >
            <LayoutDashboard className="w-5 h-5 shrink-0" /> {/* shrink-0 protege o ícone */}
            <span className="truncate text-left flex-1">Home</span> {/* truncate corta o texto longo */}
          </button>
          
          <button 
            onClick={() => handleNavigation("/chat")}
            className={`${baseButtonStyle} ${isActive("/chat") ? activeStyle : inactiveStyle}`}
          >
            <Omega className="w-5 h-5 shrink-0" />
            <span className="truncate text-left flex-1">OmegaHelp</span>
          </button>

          <button 
            onClick={() => handleNavigation("/novo-chamado")}
            className={`${baseButtonStyle} ${isActive("/novo-chamado") ? activeStyle : inactiveStyle}`}
          >
            <TicketIcon className="w-5 h-5 shrink-0" />
            <span className="truncate text-left flex-1">Novo Chamado</span>
          </button>
        </nav>

        {/* FOOTER */}
        <div className="p-4 border-t border-slate-800 shrink-0">
          <button onClick={handleLogout} className="flex items-center gap-3 w-full px-4 py-3 text-slate-400 hover:text-red-400 hover:bg-red-950/30 rounded-xl transition-all group">
            <LogOut className="w-5 h-5 shrink-0 group-hover:text-red-400 transition-colors" />
            <span className="truncate text-left flex-1">Sair</span>
          </button>
        </div>
      </aside>
    </>
  );
}