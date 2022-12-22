package com.almoxarifado.almoxarifadoService;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.context.annotation.RequestScope;

import com.almoxarifado.almoxarifadoModel.MaterialAlmoxarifado;
import com.almoxarifado.almoxarifadoRepository.MaterialAlmoxarifadoRepository;

@Service
@RequestScope
public class MaterialAlmoxarifadoService {
	
	@Autowired
	MaterialAlmoxarifadoRepository materialAlmoxarifadoRepository;
	
	
	public MaterialAlmoxarifado gravar(MaterialAlmoxarifado nomeMaterial) {
		return materialAlmoxarifadoRepository.save(nomeMaterial);
	}

	public List<MaterialAlmoxarifado> retornaMateriais() {
		return (List<MaterialAlmoxarifado>) materialAlmoxarifadoRepository.findAll();
	}
	
	public void deletaPorId(Long id) {
		materialAlmoxarifadoRepository.deleteById(id);
	}
	
	public MaterialAlmoxarifado atualizar(MaterialAlmoxarifado nomeMaterial) {
		return materialAlmoxarifadoRepository.save(nomeMaterial);
		
	}
	
	public MaterialAlmoxarifado buscaPorId(Long id) {
		return materialAlmoxarifadoRepository.findById(id).orElse(null);
	}
}
