import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { ArrowLeft, Mail, KeyRound, Lock, CheckCircle2, Loader2 } from "lucide-react";
import { solicitarCodigo, validarCodigo, resetarSenha } from "@/services/authService";

export default function ForgotPassword() {
  const navigate = useNavigate();
  const [step, setStep] = useState<1 | 2 | 3>(1);
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);

  // Dados do formulário
  const [email, setEmail] = useState("");
  const [codigo, setCodigo] = useState("");
  const [novaSenha, setNovaSenha] = useState("");
  const [confirmarSenha, setConfirmarSenha] = useState("");

  // --- AÇÕES ---

  const handleSolicitarCodigo = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setError(null);
    try {
      await solicitarCodigo(email);
      setStep(2); // Vai para o passo de código
    } catch (err: any) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const handleValidarCodigo = async (e: React.FormEvent) => {
    e.preventDefault();
    setLoading(true);
    setError(null);
    try {
      await validarCodigo(email, codigo);
      setStep(3); // Vai para o passo de nova senha
    } catch (err: any) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const handleResetarSenha = async (e: React.FormEvent) => {
    e.preventDefault();
    if (novaSenha !== confirmarSenha) {
      setError("As senhas não coincidem.");
      return;
    }
    setLoading(true);
    setError(null);
    try {
      await resetarSenha(email, codigo, novaSenha);
      alert("Senha alterada com sucesso!");
      navigate("/"); // Volta para o login
    } catch (err: any) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="min-h-screen bg-[#0f172a] flex items-center justify-center p-4 font-sans text-slate-100">
      
      <div className="w-full max-w-md relative">
        {/* Glow de fundo */}
        <div className="absolute top-0 right-0 w-64 h-64 bg-indigo-500/10 rounded-full blur-3xl pointer-events-none"></div>
        
        <div className="bg-[#1e293b] rounded-2xl border border-slate-800 shadow-2xl overflow-hidden relative z-10">
          
          {/* Header com Botão Voltar */}
          <div className="p-6 border-b border-slate-800 flex items-center gap-4">
            <button onClick={() => navigate("/")} className="text-slate-400 hover:text-white transition-colors">
              <ArrowLeft className="w-5 h-5" />
            </button>
            <h1 className="font-bold text-lg">Recuperar Senha</h1>
          </div>

          <div className="p-8">
            
            {/* Mensagem de Erro Global */}
            {error && (
              <div className="mb-6 p-3 bg-red-500/10 border border-red-500/20 text-red-400 text-sm rounded-lg flex items-center gap-2">
                <span className="w-1.5 h-1.5 bg-red-400 rounded-full"></span>
                {error}
              </div>
            )}

            {/* --- PASSO 1: EMAIL --- */}
            {step === 1 && (
              <form onSubmit={handleSolicitarCodigo} className="space-y-6 animate-in fade-in slide-in-from-right-4">
                <div className="text-center mb-6">
                  <div className="w-12 h-12 bg-indigo-500/20 rounded-full flex items-center justify-center mx-auto mb-4 text-indigo-400">
                    <Mail className="w-6 h-6" />
                  </div>
                  <h2 className="text-xl font-bold text-white">Esqueceu a senha?</h2>
                  <p className="text-slate-400 text-sm mt-2">
                    Digite seu e-mail cadastrado para receber um código de recuperação.
                  </p>
                </div>

                <div>
                  <label className="text-xs font-bold text-slate-500 uppercase tracking-wider block mb-2">E-mail</label>
                  <input
                    type="email"
                    required
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-white focus:border-indigo-500 focus:outline-none transition-colors"
                    placeholder="seu@email.com"
                  />
                </div>

                <button 
                  type="submit" 
                  disabled={loading}
                  className="w-full py-3 bg-indigo-600 hover:bg-indigo-700 text-white font-bold rounded-xl transition-all shadow-lg shadow-indigo-900/20 flex justify-center items-center gap-2"
                >
                  {loading ? <Loader2 className="w-5 h-5 animate-spin" /> : "Enviar Código"}
                </button>
              </form>
            )}

            {/* --- PASSO 2: CÓDIGO --- */}
            {step === 2 && (
              <form onSubmit={handleValidarCodigo} className="space-y-6 animate-in fade-in slide-in-from-right-4">
                <div className="text-center mb-6">
                  <div className="w-12 h-12 bg-yellow-500/20 rounded-full flex items-center justify-center mx-auto mb-4 text-yellow-400">
                    <KeyRound className="w-6 h-6" />
                  </div>
                  <h2 className="text-xl font-bold text-white">Código de Verificação</h2>
                  <p className="text-slate-400 text-sm mt-2">
                    Enviamos um código para <strong>{email}</strong>. Digite-o abaixo.
                  </p>
                </div>

                <div>
                  <label className="text-xs font-bold text-slate-500 uppercase tracking-wider block mb-2">Código (6 dígitos)</label>
                  <input
                    type="text"
                    required
                    maxLength={6}
                    value={codigo}
                    onChange={(e) => setCodigo(e.target.value)}
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-white text-center tracking-[0.5em] font-mono text-lg focus:border-indigo-500 focus:outline-none transition-colors"
                    placeholder="000000"
                  />
                </div>

                <button 
                  type="submit" 
                  disabled={loading}
                  className="w-full py-3 bg-indigo-600 hover:bg-indigo-700 text-white font-bold rounded-xl transition-all shadow-lg shadow-indigo-900/20 flex justify-center items-center gap-2"
                >
                  {loading ? <Loader2 className="w-5 h-5 animate-spin" /> : "Verificar Código"}
                </button>
                
                <button 
                  type="button"
                  onClick={() => setStep(1)}
                  className="w-full text-sm text-slate-500 hover:text-white transition-colors"
                >
                  Reenviar código ou mudar e-mail
                </button>
              </form>
            )}

            {/* --- PASSO 3: NOVA SENHA --- */}
            {step === 3 && (
              <form onSubmit={handleResetarSenha} className="space-y-6 animate-in fade-in slide-in-from-right-4">
                <div className="text-center mb-6">
                  <div className="w-12 h-12 bg-green-500/20 rounded-full flex items-center justify-center mx-auto mb-4 text-green-400">
                    <CheckCircle2 className="w-6 h-6" />
                  </div>
                  <h2 className="text-xl font-bold text-white">Criar Nova Senha</h2>
                  <p className="text-slate-400 text-sm mt-2">
                    Código validado! Agora defina sua nova senha de acesso.
                  </p>
                </div>

                <div className="space-y-4">
                  <div>
                    <label className="text-xs font-bold text-slate-500 uppercase tracking-wider block mb-2">Nova Senha</label>
                    <div className="relative">
                      <Lock className="w-4 h-4 text-slate-500 absolute left-3 top-3.5" />
                      <input
                        type="password"
                        required
                        value={novaSenha}
                        onChange={(e) => setNovaSenha(e.target.value)}
                        className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 pl-10 text-white focus:border-indigo-500 focus:outline-none transition-colors"
                        placeholder="••••••••"
                      />
                    </div>
                  </div>

                  <div>
                    <label className="text-xs font-bold text-slate-500 uppercase tracking-wider block mb-2">Confirmar Senha</label>
                    <div className="relative">
                      <Lock className="w-4 h-4 text-slate-500 absolute left-3 top-3.5" />
                      <input
                        type="password"
                        required
                        value={confirmarSenha}
                        onChange={(e) => setConfirmarSenha(e.target.value)}
                        className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 pl-10 text-white focus:border-indigo-500 focus:outline-none transition-colors"
                        placeholder="••••••••"
                      />
                    </div>
                  </div>
                </div>

                <button 
                  type="submit" 
                  disabled={loading}
                  className="w-full py-3 bg-green-600 hover:bg-green-700 text-white font-bold rounded-xl transition-all shadow-lg shadow-green-900/20 flex justify-center items-center gap-2"
                >
                  {loading ? <Loader2 className="w-5 h-5 animate-spin" /> : "Redefinir Senha"}
                </button>
              </form>
            )}

          </div>
        </div>
      </div>
    </div>
  );
}