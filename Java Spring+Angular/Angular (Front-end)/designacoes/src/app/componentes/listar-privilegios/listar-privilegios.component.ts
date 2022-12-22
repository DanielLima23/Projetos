import { PrivilegiosService } from '../../services/privilegios.service';
import { Component, OnInit } from '@angular/core';
import { Privilegios } from 'src/app/models/privilegios.model';

@Component({
  selector: 'app-listar-privilegios',
  templateUrl: './listar-privilegios.component.html',
  styleUrls: ['./listar-privilegios.component.css']
})
export class ListarPrivilegiosComponent implements OnInit {

  constructor(private privilegiosService: PrivilegiosService ) { }

  public listaPrivilegios: Privilegios[] = []

  ngOnInit(): void {
    this.carregaPrivilegios();
  }

  carregaPrivilegios(){
    this.privilegiosService.listarPrivilegios().subscribe(_data => {
      this.listaPrivilegios = _data
     })
  }

  delete(id: number){
    this.privilegiosService.delete(id).subscribe((_data) => {
     this.carregaPrivilegios();
    });
  }

  atualizarPrivilegio(){

  }
}
