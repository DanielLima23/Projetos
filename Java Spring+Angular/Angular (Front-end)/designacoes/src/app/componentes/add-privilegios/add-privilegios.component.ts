import { Irmao } from './../../models/irmaos.model';
import { Privilegios } from 'src/app/models/privilegios.model';
import { Component, OnInit } from '@angular/core';
import { PrivilegiosService } from 'src/app/services/privilegios.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-privilegios',
  templateUrl: './add-privilegios.component.html',
  styleUrls: ['./add-privilegios.component.css']
})
export class AddPrivilegiosComponent implements OnInit {

  constructor(
    private privilegioService:PrivilegiosService,
    private activatedRoute: ActivatedRoute
  ) { }

  privilegio:Privilegios = new Privilegios();
  listaPrivilegio: Privilegios[] = []

  public addPrivilegio(){
    if(this.privilegio.nomePrivilegio.trim().length > 0){
      this.privilegioService.gravarPrivilegios(this.privilegio).subscribe(_data =>{
        this.carregaPrivilegios();
        this.privilegio = new Privilegios
      });
    }
  }

  ngOnInit(): void {
    this.carregaPrivilegios();
    this.activatedRoute.params.subscribe( _parametros =>{
      if(_parametros['id']){
        this.privilegioService.buscarPrivilegioPorId(_parametros['id']).subscribe(_data =>{
          this.privilegio = _data
        })
      }
    })
  }

  delete(id: number){
      this.privilegioService.delete(id).subscribe((_data) => {
      this.carregaPrivilegios();
    });
  }

  carregaPrivilegios(){
    this.privilegioService.listarPrivilegios().subscribe(_data => {
      this.listaPrivilegio = _data
       this.privilegio.nomePrivilegio = "";
     })
  }

  alert(){
    alert('Privilegio Salvo')
  }

  atualizarPrivilegio(objEditar: Privilegios){
    this.privilegio = objEditar
  }
}
