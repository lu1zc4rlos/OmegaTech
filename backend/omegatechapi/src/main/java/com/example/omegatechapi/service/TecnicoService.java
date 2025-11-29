package com.example.omegatechapi.service;

import com.example.omegatechapi.model.Perfil;
import com.example.omegatechapi.model.TecnicoProfile;
import com.example.omegatechapi.model.TecnicoResponseDTO;
import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.repository.TecnicoRepository;
import com.example.omegatechapi.repository.UsuarioRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.time.LocalDate;
import java.util.List;
import java.util.NoSuchElementException;
import java.util.stream.Collectors;

@Service
public class TecnicoService {
    @Autowired
    private UsuarioRepository usuarioRepository;

    public TecnicoService(UsuarioRepository usuarioRepository) {
        this.usuarioRepository = usuarioRepository;
    }

    @Autowired
    private TecnicoRepository tecnicoRepository;

    @Autowired
    private BCryptPasswordEncoder passwordEncoder;

    @Transactional
    public Boolean criarTecnico(Usuario novoTecnicoCadastrado) {

        String novaMatricula;
        do {
            novaMatricula = GeradorDeMatricula.gerarMatricula();
        } while (tecnicoRepository.existsByMatricula(novaMatricula));

        Usuario novoUsuario = new Usuario();
        novoUsuario.setNome(novoTecnicoCadastrado.getNome());
        novoUsuario.setEmail(novoTecnicoCadastrado.getEmail());
        novoUsuario.setDataNascimento(novoTecnicoCadastrado.getDataNascimento());

        String senhaHashed = passwordEncoder.encode(novoTecnicoCadastrado.getSenha());
        novoUsuario.setSenha(senhaHashed);
        novoUsuario.setPerfil(Perfil.ROLE_TECNICO);

        Usuario usuarioSalvo = usuarioRepository.save(novoUsuario);

        TecnicoProfile novoTecnico = new TecnicoProfile();
        novoTecnico.setUsuario(novoUsuario);
        novoTecnico.setMatricula(novaMatricula);
        novoTecnico.setDataCertificacao(LocalDate.now());

        tecnicoRepository.save(novoTecnico);

        return true;
    }
    public List<TecnicoResponseDTO> buscarTodosTecnicos() {

        List<Usuario> tecnicos = usuarioRepository.findAllByPerfil(Perfil.ROLE_TECNICO);

        return tecnicos.stream()
                .map(usuario -> {

                    TecnicoProfile perfil = usuario.getTecnicoProfile();

                    TecnicoResponseDTO dto = new TecnicoResponseDTO();

                    dto.setId(usuario.getId());
                    dto.setNome(usuario.getNome());
                    dto.setEmail(usuario.getEmail());

                    if (perfil != null) {
                        dto.setMatricula(perfil.getMatricula());


                        if (perfil.getDataCertificacao() != null) {
                            dto.setDataCriacao(perfil.getDataCertificacao().atStartOfDay());
                        } else {
                            dto.setDataCriacao(null);
                        }

                    } else {
                        dto.setMatricula("N/A");
                        dto.setDataCriacao(null);
                    }

                    return dto;
                })
                .collect(Collectors.toList());
    }
    public TecnicoResponseDTO buscarTecnicoPorId(Long tecnicoId) {

        Usuario usuario = usuarioRepository.findById(tecnicoId)
                .orElseThrow(() -> new NoSuchElementException("Técnico não encontrado com ID: " + tecnicoId));

        if (usuario.getPerfil() != Perfil.ROLE_TECNICO) {
            throw new NoSuchElementException("Usuário encontrado, mas não possui o perfil de Técnico.");
        }

        TecnicoProfile perfil = usuario.getTecnicoProfile();

        TecnicoResponseDTO dto = new TecnicoResponseDTO();

        dto.setId(usuario.getId());
        dto.setNome(usuario.getNome());
        dto.setEmail(usuario.getEmail());

        if (perfil != null) {
            dto.setMatricula(perfil.getMatricula());

            if (perfil.getDataCertificacao() != null) {
                dto.setDataCriacao(perfil.getDataCertificacao().atStartOfDay());
            } else {
                dto.setDataCriacao(null);
            }
        } else {
            dto.setMatricula("N/A");
            dto.setDataCriacao(null);
        }

        return dto;
    }
}
