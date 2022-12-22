package Controle.Designacoes.Controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import Controle.Designacoes.Models.Privilegios;
import Controle.Designacoes.Services.PrivilegiosService;

@RestController
@RequestMapping("/privilegios")
public class PrivilegiosController {
	
	@Autowired
	PrivilegiosService privilegiosService;
	
	@PostMapping("/add")
	public ResponseEntity<?> gravarPrivilegio(@RequestBody Privilegios privilegio){
		return ResponseEntity.ok().body(privilegiosService.gravar(privilegio));
	}
	
	@GetMapping("/all")
	public ResponseEntity<?> retornaListaPrivilegios(){
		return ResponseEntity.ok().body(privilegiosService.retornaTodosPrivilegios());
	}
	
	@GetMapping ("/{id}")
	public ResponseEntity<?> buscarPrivilegioPorId(@PathVariable Long id){
		return ResponseEntity.ok().body(privilegiosService.buscarPrivilegioPorId(id));
	}
	
	@DeleteMapping("/{id}")
	public void deletaPrivilegioPorId(@PathVariable Long id) {
		privilegiosService.deletaPrivilegioPorId(id);
	}
	
}
