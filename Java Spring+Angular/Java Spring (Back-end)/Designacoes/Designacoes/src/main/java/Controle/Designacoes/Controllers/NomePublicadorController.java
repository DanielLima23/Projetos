package Controle.Designacoes.Controllers;

import java.util.List;

import org.apache.catalina.connector.Response;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import Controle.Designacoes.Models.Publicador;
import Controle.Designacoes.Services.NomePublicadorService;

@RestController
@RequestMapping ("/publicador")
public class NomePublicadorController {
	
	@Autowired
	NomePublicadorService nomePublicadorService;
	
	@PostMapping("/add")
	public ResponseEntity<Publicador> gravar (@RequestBody Publicador nome_publicador){
		return ResponseEntity.ok().body(nomePublicadorService.gravar(nome_publicador));
	}
	
	@GetMapping("/all")
	public ResponseEntity<?> retornaTodos(){
		return ResponseEntity.ok().body(nomePublicadorService.retornaTodos());
	}

	@GetMapping ("/{id}")
	public ResponseEntity<?> buscarPublicadorPorId(@PathVariable Long id){
		return ResponseEntity.ok().body(nomePublicadorService.buscarPublicadorPorId(id));
	}
	
	@DeleteMapping ("/{id}")
	public void deletaPorId(@PathVariable Long id) {
		nomePublicadorService.deletaPorId(id);
	}
	
	@PutMapping("/atualizar")
	public ResponseEntity<?> atualizar(@RequestBody Publicador nome_publicador){
		return ResponseEntity.ok().body(nomePublicadorService.atualizar(nome_publicador));
	}
	
}
