import { useState } from "react";
// ADICIONEI O ÍCONE 'Check' AQUI
import { Omega, Loader2, Lock, Mail, Check } from "lucide-react";
import { loginUser } from "@/services/authService";
import { useNavigate,Link} from "react-router-dom";

const Login = () => {
  const navigate = useNavigate();
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");
  const [showPassword, setShowPassword] = useState(false);
  
  const [isLoading, setIsLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);
    setIsLoading(true);

try {
      const data = await loginUser(email, password);
      
      // 1. Salva os dados no navegador
      localStorage.setItem("token", data.token);
      localStorage.setItem("user", JSON.stringify(data));
      
      // Verifica o perfil que veio do Java e decide o destino
      if (data.perfil === 'ROLE_ADMIN') {
        navigate("/admin"); // Manda pro Dashboard novo
      } else {
        navigate("/dashboard"); // Manda pro Dashboard padrão (Cliente/Técnico)
      }
      
    } catch (err: any) {
      console.error(err);
      setError(err.message || "Credenciais inválidas.");
    }

  };

  return (
    <div className="min-h-screen bg-[#0f172a] flex items-center justify-center p-4 font-sans selection:bg-indigo-500/30">
      
      <div className="relative w-full max-w-md">
        <div className="absolute -top-4 -right-4 w-72 h-72 bg-indigo-500/10 rounded-full blur-3xl pointer-events-none"></div>
        <div className="absolute -bottom-4 -left-4 w-72 h-72 bg-purple-500/10 rounded-full blur-3xl pointer-events-none"></div>

        <div className="relative bg-[#1e293b] rounded-2xl shadow-2xl border border-slate-800 overflow-hidden">
          
          <div className="p-8 pb-6 text-center space-y-4">
            <div className="mx-auto w-16 h-16 bg-indigo-600 rounded-2xl flex items-center justify-center shadow-lg shadow-indigo-500/20 transform hover:scale-105 transition-transform duration-300">
              <Omega className="w-8 h-8 text-white" />
            </div>
            <div>
              <h1 className="text-3xl font-bold text-white tracking-tight">Bem-vindo</h1>
              <p className="text-slate-400 text-sm mt-2">
                Entre com suas credenciais para acessar o sistema
              </p>
            </div>
          </div>

          <div className="p-8 pt-0">
            <form onSubmit={handleSubmit} className="space-y-5">
              
              {error && (
                <div className="p-4 bg-red-500/10 border border-red-500/20 text-red-400 text-sm rounded-xl flex items-center gap-2 animate-in fade-in slide-in-from-top-2">
                  <div className="w-1.5 h-1.5 rounded-full bg-red-400 shrink-0" />
                  {error}
                </div>
              )}

              <div className="space-y-2">
                <label htmlFor="email" className="text-sm font-medium text-slate-300 ml-1">
                  E-mail
                </label>
                <div className="relative">
                  <div className="absolute left-3 top-1/2 -translate-y-1/2 text-slate-500">
                    <Mail className="w-5 h-5" />
                  </div>
                  <input
                    id="email"
                    type="email"
                    placeholder="seu@email.com"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    required
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl py-3 pl-10 pr-4 text-slate-200 placeholder:text-slate-600 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all"
                    disabled={isLoading}
                  />
                </div>
              </div>

              <div className="space-y-2">
                <div className="flex items-center justify-between ml-1">
                  <label htmlFor="password" className="text-sm font-medium text-slate-300">
                    Senha
                  </label>
                  <Link 
                    to="/esqueci-senha" 
                    className="text-xs text-indigo-400 hover:text-indigo-300 transition-colors">
                    Esqueceu a senha?
                  </Link>
                </div>
                <div className="relative">
                  <div className="absolute left-3 top-1/2 -translate-y-1/2 text-slate-500">
                    <Lock className="w-5 h-5" />
                  </div>
                  <input
                    id="password"
                    type={showPassword ? "text" : "password"} 
                    placeholder="••••••••"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl py-3 pl-10 pr-4 text-slate-200 placeholder:text-slate-600 focus:outline-none focus:border-indigo-500 focus:ring-1 focus:ring-indigo-500 transition-all"
                    disabled={isLoading}
                  />
                </div>

                {/* --- CHECKBOX CUSTOMIZADO INÍCIO --- */}
                <div className="flex items-center gap-2 pt-2 ml-1 relative">
                  
                  {/* 1. O Input Real (Invisível mas clicável) */}
                  <input
                    id="show-password"
                    type="checkbox"
                    checked={showPassword}
                    onChange={() => setShowPassword(!showPassword)}
                    // 'peer' é crucial aqui. 'opacity-0' o torna invisível. 'z-20' garante que ele fique por cima para receber o clique.
                    className="peer absolute w-5 h-5 opacity-0 cursor-pointer z-20"
                  />

                  {/* 2. O Visual Customizado (O quadrado falso) */}
                  {/* Ele muda de cor baseado no estado do 'peer' (o input acima) */}
                  <div className="w-5 h-5 bg-[#0f172a] border-2 border-slate-700 rounded-[6px] flex items-center justify-center transition-all
                                  peer-checked:bg-indigo-600 peer-checked:border-indigo-600 peer-hover:border-indigo-500/50">
                    
                    {/* O Ícone de Check (só aparece quando checked) */}
                    <Check 
                      className={`w-3.5 h-3.5 text-white transition-opacity duration-200 ${showPassword ? 'opacity-100' : 'opacity-0'}`} 
                      strokeWidth={3} // Deixa o check mais gordinho
                    />
                  </div>

                  {/* 3. O Texto do Label */}
                  <label 
                    htmlFor="show-password" 
                    className="text-sm text-slate-400 cursor-pointer select-none hover:text-slate-300 transition-colors z-10"
                  >
                    Exibir senha
                  </label>
                </div>
                {/* --- CHECKBOX CUSTOMIZADO FIM --- */}

              </div>

              <button
                type="submit"
                disabled={isLoading}
                className="w-full bg-indigo-600 hover:bg-indigo-700 text-white font-medium py-3 rounded-xl shadow-lg shadow-indigo-900/20 transition-all transform active:scale-[0.98] disabled:opacity-70 disabled:cursor-not-allowed flex items-center justify-center gap-2"
              >
                {isLoading ? (
                  <>
                    <Loader2 className="w-5 h-5 animate-spin" />
                    Entrando...
                  </>
                ) : (
                  "Entrar"
                )}
              </button>
            </form>

            <div className="mt-8 text-center border-t border-slate-800 pt-6">
              <span className="text-slate-500 text-sm">Não tem uma conta? </span>
              <a href="#" className="text-indigo-400 hover:text-indigo-300 font-medium text-sm transition-colors hover:underline">
                Cadastre-se
              </a>
            </div>
          </div>
        </div>
        
        <p className="text-center text-slate-600 text-xs mt-6">
          &copy; 2025 OmegaTech. Todos os direitos reservados.
        </p>
      </div>
    </div>
  );
};

export default Login;