package com.almoxarifado.almoxarifadoRepository;

import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.almoxarifado.almoxarifadoModel.MaterialAlmoxarifado;

@Repository
public interface MaterialAlmoxarifadoRepository extends CrudRepository<MaterialAlmoxarifado, Long>{

}
