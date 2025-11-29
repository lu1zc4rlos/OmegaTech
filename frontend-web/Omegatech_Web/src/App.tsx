import { BrowserRouter, Routes, Route } from "react-router-dom";
import Login from "@/pages/Login";
import Dashboard from "@/pages/Dashboard"; 
import TicketDetalhes from "@/pages/TicketDetalhes";
import Chat from "@/pages/Chat";
import NovoTicket from "@/pages/NovoTicket";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/tickets/:id" element={<TicketDetalhes />} />
        <Route path="/chat" element={<Chat />} />
        <Route path="/novo-chamado" element={<NovoTicket />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App