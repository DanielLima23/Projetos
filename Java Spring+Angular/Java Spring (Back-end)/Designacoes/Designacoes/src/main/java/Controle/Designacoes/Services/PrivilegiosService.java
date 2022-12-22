package Controle.Designacoes.Services;

import java.util.List;
import java.util.Set;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.context.annotation.RequestScope;

import Controle.Designacoes.Models.Privilegios;
import Controle.Designacoes.Repositorys.PrivilegiosRepository;

@Service
@RequestScope
public class PrivilegiosService {
	
	@Autowired
	PrivilegiosRepository privilegioRepository;
	
	public Privilegios gravar(Privilegios nomePrivilegio) {
		return privilegioRepository.save(nomePrivilegio);
	}
	
	public List<Privilegios> retornaTodosPrivilegios() {
		return (List<Privilegios>)privilegioRepository.findAll();
	}
	
	public Privilegios buscarPrivilegioPorId(Long id) {
		return privilegioRepository.findById(id).orElse(null);
	}
	
	public void deletaPrivilegioPorId(Long id) {
		privilegioRepository.deleteById(id);
	}
	
	public Privilegios atualizar (Privilegios nomePrivilegio) {
		return privilegioRepository.save(nomePrivilegio);
	}

	
	
}
