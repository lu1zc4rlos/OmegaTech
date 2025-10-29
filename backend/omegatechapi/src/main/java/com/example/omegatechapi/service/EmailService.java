package com.example.omegatechapi.service;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.mail.SimpleMailMessage;
import org.springframework.mail.javamail.JavaMailSender;
import org.springframework.scheduling.annotation.Async;
import org.springframework.stereotype.Service;

@Service
public class EmailService {

    @Autowired
    private JavaMailSender mailSender;

    @Async
    public void enviarEmailDeBoasVindas(String paraEmail, String nomeUsuario) {
        try {
            SimpleMailMessage message = new SimpleMailMessage();
            message.setFrom("suporteomegatech699@gmail.com");
            message.setTo(paraEmail);
            message.setSubject("Bem-vindo à OmegaTech!");
            message.setText("Olá, " + nomeUsuario + "!\n\nSeu cadastro foi realizado com sucesso, OmegaTech é " +
                    "o seu novo assistente virtual de ajuda e suporte técnico.\\r\\n\\r\\n\"" +
                    "Estamos muito contentes em tê-lo como usuário da nossa plataforma." +
                    " O AtendeTech foi desenvolvido para tornar seu atendimento mais rápido," +
                    " eficiente e acessível, sempre que você precisar de suporte técnico.\r\n\r\n" + "Com o AtendeTech," +
                    " você pode:\r\n\r\nObter respostas para dúvidas técnicas com agilidade\r\n\r\n" +
                    "Receber instruções passo a passo para resolver problemas\r\n\r\nAcessar suporte a qualquer hora," +
                    " de forma simples e intuitiva\r\n\r\n" + "Contar com um serviço confiável e sempre disponível\r\n\r\n" +
                            "Se tiver qualquer dúvida ou sugestão, nossa equipe está à disposição para ajudá-lo.\r\n\r\n" +
                            "Atenciosamente,\r\nEquipe AtendeTech\r\nsuporteomegatech699@gmail.com"
            );

            mailSender.send(message);
        } catch (Exception e) {
            System.err.println("Erro ao enviar e-mail para " + paraEmail + ": " + e.getMessage());
        }
    }
}


