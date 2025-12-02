import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";
import { Omega, Loader2, User, Mail, Calendar, Lock, Check, X, Eye, EyeOff } from "lucide-react";
import { registerUser, RegisterPayload } from "@/services/authService";

export default function Register() {
  const navigate = useNavigate();
  const [loading, setLoading] = useState(false);
  const [error, setError] = useState<string | null>(null);
  
  // Estado do Formulário
  const [formData, setFormData] = useState<RegisterPayload>({
    nome: "",
    email: "",
    dataNascimento: "",
    senha: ""
  });
  const [confirmSenha, setConfirmSenha] = useState("");
  const [showPassword, setShowPassword] = useState(false);

  // Regras de Validação da Senha
  const validations = [
    { label: "Pelo menos 8 caracteres", valid: formData.senha.length >= 8 },
    { label: "Uma letra maiúscula", valid: /[A-Z]/.test(formData.senha) },
    { label: "Uma letra minúscula", valid: /[a-z]/.test(formData.senha) },
    { label: "Um número", valid: /[0-9]/.test(formData.senha) },
    { label: "Um símbolo (!@#$)", valid: /[^A-Za-z0-9]/.test(formData.senha) },
  ];

  const allValid = validations.every(v => v.valid);

const handleSubmit = async (e: React.FormEvent) => {
    e.preventDefault();
    setError(null);

    if (formData.senha !== confirmSenha) {
      setError("As senhas não coincidem.");
      return;
    }

    if (!allValid) {
      setError("A senha não atende aos requisitos de segurança.");
      return;
    }

    setLoading(true);
    try {
      // Envia para a API
      await registerUser(formData);
      
      // Mostra mensagem de sucesso
      alert("Cadastro realizado com sucesso! Faça login.");
      
      // REDIRECIONA PARA O LOGIN 
      navigate("/"); 
      
    } catch (err: any) {
      console.error(err);
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="min-h-screen bg-[#0f172a] flex items-center justify-center p-4 font-sans text-slate-100">
      
      <div className="w-full max-w-lg relative">
        {/* Glow Effects */}
        <div className="absolute -top-10 -left-10 w-64 h-64 bg-indigo-500/10 rounded-full blur-3xl pointer-events-none"></div>
        <div className="absolute -bottom-10 -right-10 w-64 h-64 bg-purple-500/10 rounded-full blur-3xl pointer-events-none"></div>

        <div className="bg-[#1e293b] rounded-2xl border border-slate-800 shadow-2xl overflow-hidden relative z-10">
          
          {/* Header */}
          <div className="p-8 pb-4 text-center">
            <div className="mx-auto w-14 h-14 bg-indigo-600 rounded-xl flex items-center justify-center shadow-lg shadow-indigo-500/20 mb-4">
              <Omega className="w-7 h-7 text-white" />
            </div>
            <h1 className="text-2xl font-bold text-white">Crie sua conta</h1>
            <p className="text-slate-400 text-sm mt-1">Junte-se à OmegaTech e abra seus chamados.</p>
          </div>

          <div className="p-8 pt-2">
            
            {error && (
              <div className="mb-6 p-4 bg-red-500/10 border border-red-500/20 text-red-400 text-sm rounded-xl flex items-center gap-2 animate-in fade-in slide-in-from-top-2">
                <span className="w-1.5 h-1.5 bg-red-400 rounded-full shrink-0"></span>
                {error}
              </div>
            )}

            <form onSubmit={handleSubmit} className="space-y-5">
              
              {/* Nome */}
              <div className="space-y-1.5">
                <label className="text-xs font-bold text-slate-400 uppercase tracking-wider ml-1">Nome Completo</label>
                <div className="relative">
                  <User className="w-5 h-5 text-slate-500 absolute left-3 top-3" />
                  <input
                    type="text"
                    required
                    value={formData.nome}
                    onChange={(e) => setFormData({...formData, nome: e.target.value})}
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 pl-10 text-white focus:border-indigo-500 focus:outline-none transition-colors placeholder:text-slate-600"
                    placeholder="Seu nome"
                  />
                </div>
              </div>

              {/* Data Nascimento e Email (Grid no Desktop, Stack no Mobile) */}
              <div className="grid grid-cols-1 md:grid-cols-2 gap-5">
                <div className="space-y-1.5">
                  <label className="text-xs font-bold text-slate-400 uppercase tracking-wider ml-1">Nascimento</label>
                  <div className="relative">
                    <input
                      type="date"
                      required
                      value={formData.dataNascimento}
                      onChange={(e) => setFormData({...formData, dataNascimento: e.target.value})}
                      className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 text-white focus:border-indigo-500 focus:outline-none transition-colors [color-scheme:dark]"
                    />
                  </div>
                </div>

                <div className="space-y-1.5">
                  <label className="text-xs font-bold text-slate-400 uppercase tracking-wider ml-1">E-mail</label>
                  <div className="relative">
                    <Mail className="w-5 h-5 text-slate-500 absolute left-3 top-3" />
                    <input
                      type="email"
                      required
                      value={formData.email}
                      onChange={(e) => setFormData({...formData, email: e.target.value})}
                      className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 pl-10 text-white focus:border-indigo-500 focus:outline-none transition-colors placeholder:text-slate-600"
                      placeholder="seu@email.com"
                    />
                  </div>
                </div>
              </div>

              {/* Senha */}
              <div className="space-y-1.5">
                <label className="text-xs font-bold text-slate-400 uppercase tracking-wider ml-1">Senha</label>
                <div className="relative">
                  <Lock className="w-5 h-5 text-slate-500 absolute left-3 top-3" />
                  <input
                    type={showPassword ? "text" : "password"}
                    required
                    value={formData.senha}
                    onChange={(e) => setFormData({...formData, senha: e.target.value})}
                    className="w-full bg-[#0f172a] border border-slate-700 rounded-xl p-3 pl-10 pr-10 text-white focus:border-indigo-500 focus:outline-none transition-colors placeholder:text-slate-600"
                    placeholder="••••••••"
                  />
                  <button 
                    type="button"
                    onClick={() => setShowPassword(!showPassword)}
                    className="absolute right-3 top-3 text-slate-500 hover:text-white"
                  >
                    {showPassword ? <EyeOff className="w-5 h-5" /> : <Eye className="w-5 h-5" />}
                  </button>
                </div>

                {/* Validador Visual de Senha */}
                <div className="grid grid-cols-2 gap-2 mt-2">
                  {validations.map((v, i) => (
                    <div key={i} className="flex items-center gap-1.5">
                      {v.valid ? (
                        <Check className="w-3.5 h-3.5 text-green-500" />
                      ) : (
                        <div className="w-3.5 h-3.5 rounded-full border border-slate-600" />
                      )}
                      <span className={`text-[10px] ${v.valid ? 'text-green-400' : 'text-slate-500'}`}>
                        {v.label}
                      </span>
                    </div>
                  ))}
                </div>
              </div>

              {/* Confirmar Senha */}
              <div className="space-y-1.5">
                <label className="text-xs font-bold text-slate-400 uppercase tracking-wider ml-1">Confirmar Senha</label>
                <div className="relative">
                  <Lock className="w-5 h-5 text-slate-500 absolute left-3 top-3" />
                  <input
                    type="password"
                    required
                    value={confirmSenha}
                    onChange={(e) => setConfirmSenha(e.target.value)}
                    className={`w-full bg-[#0f172a] border rounded-xl p-3 pl-10 text-white focus:outline-none transition-colors placeholder:text-slate-600 ${confirmSenha && formData.senha !== confirmSenha ? 'border-red-500 focus:border-red-500' : 'border-slate-700 focus:border-indigo-500'}`}
                    placeholder="••••••••"
                  />
                </div>
              </div>

              <button 
                type="submit" 
                disabled={loading || !allValid || formData.senha !== confirmSenha}
                className="w-full py-3.5 bg-indigo-600 hover:bg-indigo-700 text-white font-bold rounded-xl transition-all shadow-lg shadow-indigo-900/20 flex justify-center items-center gap-2 disabled:opacity-50 disabled:cursor-not-allowed mt-4"
              >
                {loading ? <Loader2 className="w-5 h-5 animate-spin" /> : "Criar Conta"}
              </button>
            </form>

            <div className="mt-8 text-center border-t border-slate-800 pt-6">
              <span className="text-slate-500 text-sm">Já tem uma conta? </span>
              <Link to="/" className="text-indigo-400 hover:text-indigo-300 font-medium text-sm transition-colors hover:underline">
                Fazer Login
              </Link>
            </div>

          </div>
        </div>
      </div>
    </div>
  );
}