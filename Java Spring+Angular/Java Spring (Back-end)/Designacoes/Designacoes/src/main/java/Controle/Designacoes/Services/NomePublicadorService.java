package Controle.Designacoes.Services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.context.annotation.RequestScope;

import Controle.Designacoes.Models.Publicador;
import Controle.Designacoes.Repositorys.NomePublicadorRepository;

@Service
@RequestScope
public class NomePublicadorService {
	
	@Autowired
	NomePublicadorRepository nomePublicadorRepository;
	
	public Publicador gravar(Publicador nome_publicador) {	
		return nomePublicadorRepository.save(nome_publicador);
	}

	public List<Publicador> retornaTodos (){
		return (List<Publicador>) nomePublicadorRepository.findAll();
	}
	
	public Publicador buscarPublicadorPorId(Long id) {
		return nomePublicadorRepository.findById(id).orElse(null);
	}
	
	public void deletaPorId(Long id) {
		nomePublicadorRepository.deleteById(id);
	}
	
	public Publicador atualizar(Publicador nome_publicador) {
		return nomePublicadorRepository.save(nome_publicador);
	}

	
}
