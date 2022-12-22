package com.almoxarifado.almoxarifadoController;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PatchMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.almoxarifado.almoxarifadoModel.MaterialAlmoxarifado;
import com.almoxarifado.almoxarifadoService.MaterialAlmoxarifadoService;

@RestController
@RequestMapping("/material")
public class MaterialAlmoxarifadoController {

	@Autowired
	MaterialAlmoxarifadoService materialAlmoxarifadoService;
	
	 @PostMapping("/add")
	    public ResponseEntity<?> gravar(@RequestBody MaterialAlmoxarifado nomeMaterial){
	    	 return ResponseEntity.ok(). body(materialAlmoxarifadoService.gravar(nomeMaterial));
	    }
	 @GetMapping("/all")
	 public ResponseEntity<?> listaMateriais(){
		 return ResponseEntity.ok().body(materialAlmoxarifadoService.retornaMateriais());
	 }
	 
	 @GetMapping("/{id}")
	 public ResponseEntity<?> retornaPorId(@PathVariable Long id){
		 return ResponseEntity.ok().body(materialAlmoxarifadoService.buscaPorId(id));
	 }
	 
	 @PutMapping("/atualizar")
	 public ResponseEntity<?>atualizar(@RequestBody MaterialAlmoxarifado nomeMaterial){
		 return ResponseEntity.ok().body(materialAlmoxarifadoService.atualizar(nomeMaterial));
	 }
	 
	 @DeleteMapping("/{id}")
	public void deletaPorID(@PathVariable Long id) {
		 materialAlmoxarifadoService.deletaPorId(id);
	 }
	 
}
 