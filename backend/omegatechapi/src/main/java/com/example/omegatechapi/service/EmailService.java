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
                    "o seu novo assistente virtual de ajuda e suporte técnico. Estamos muito contentes em tê-lo como usuário da nossa plataforma." +
                    " O OmegaTech foi desenvolvido para tornar seu atendimento mais rápido," +
                    " eficiente e acessível, sempre que você precisar de suporte técnico.\r\n\r\n" + "Com o OmegaTech," +
                    " você pode:\r\n\r\nObter respostas para dúvidas técnicas com agilidade\r\n\r\n" +
                    "Receber instruções passo a passo para resolver problemas\r\n\r\nAcessar suporte a qualquer hora," +
                    " de forma simples e intuitiva\r\n\r\n" + "Contar com um serviço confiável e sempre disponível\r\n\r\n" +
                            "Se tiver qualquer dúvida ou sugestão, nossa equipe está à disposição para ajudá-lo.\r\n\r\n" +
                            "Atenciosamente,\r\nEquipe OmegaTech\r\nsuporteomegatech699@gmail.com"
            );

            mailSender.send(message);
        } catch (Exception e) {
            System.err.println("Erro ao enviar e-mail para " + paraEmail + ": " + e.getMessage());
        }
    }
    @Async
    public void enviarEmailTrocaDeSenha(String paraEmail) {
        try {
            SimpleMailMessage message = new SimpleMailMessage();
            message.setFrom("suporteomegatech699@gmail.com");
            message.setTo(paraEmail);
            message.setSubject("Senha alterada com sucesso");
            message.setText("Sua senha foi alterada, se você realizou essa alteração, pode desconsiderar esta mensagem.\r\r\n" +
                            "Caso não tenha solicitado essa mudança, recomendamos que entre em contato imediatamente" +
                            " com nossa equipe de suporte para garantir a segurança da sua conta.\r\n\r\n" +
                            "Atenciosamente,\r\nEquipe OmegaTech\r\nsuporteomegatech699@gmail.com"
            );

            mailSender.send(message);
        } catch (Exception e) {
            System.err.println("Erro ao enviar e-mail para " + paraEmail + ": " + e.getMessage());
        }
    }
}


