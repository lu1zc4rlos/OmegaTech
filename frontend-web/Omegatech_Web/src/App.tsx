import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from "@/pages/Login";
import Dashboard from "@/pages/Dashboard"; 
import TicketDetalhes from "@/pages/TicketDetalhes";
import Chat from "@/pages/Chat";
import NovoTicket from "@/pages/NovoTicket";
import AdminDashboard from "@/pages/AdminDashboard";
import AdminListaTecnicos from "@/pages/AdminListaTecnicos";
import AdminDetalhesTecnico from "@/pages/AdminDetalhesTecnico";
import ResetarSenha from "@/pages/ResetarSenha";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/tickets/:id" element={<TicketDetalhes />} />
        <Route path="/chat" element={<Chat />} />
        <Route path="/novo-chamado" element={<NovoTicket />} />
        <Route path="/admin" element={<AdminDashboard />} />
        <Route path="/admin/lista" element={<AdminListaTecnicos />} />
        <Route path="/admin/tecnicos/:id" element={<AdminDetalhesTecnico />} />
        <Route path="/esqueci-senha" element={<ResetarSenha />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App