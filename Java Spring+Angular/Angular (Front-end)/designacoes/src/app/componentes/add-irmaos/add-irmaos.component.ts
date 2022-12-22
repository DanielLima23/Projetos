import { Irmao } from './../../models/irmaos.model';
import { IrmaosService } from './../../services/irmaos.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, TitleStrategy } from '@angular/router';

@Component({
  selector: 'app-add-irmaos',
  templateUrl: './add-irmaos.component.html'
})
export class AddIrmaosComponent implements OnInit {

  public irmao: Irmao = new Irmao();
  listaIrmaos: Irmao[] = []

  constructor(
    private irmaosService :IrmaosService ,
    private activatedRoute: ActivatedRoute
    ){}

  ngOnInit(): void {
    this.carregarIrmaos();
    this.activatedRoute.params.subscribe( _parametros =>{
      if(_parametros['id']){
        this.irmaosService.buscarIrmaoPorId(_parametros['id']).subscribe(_data =>{
          this.irmao = _data
        })
      }
    })
  }

  public addIrmao(){
    if(this.irmao.nomePublicador.trim().length > 0 ){
      this.irmaosService.addIrmaos(this.irmao).subscribe(_data =>{
        this.irmaosService.listarIrmaos().subscribe(_data => {
         this.listaIrmaos = _data
          this.irmao = new Irmao();
        })
      });
    }
  }

  carregarIrmaos(){
    this.irmaosService.listarIrmaos().subscribe(_data => {
      this.listaIrmaos = _data
       this.irmao.nomePublicador = "";
     })
  }

  delete(id: number){
    this.irmaosService.deleteIrmao(id).subscribe(_data => {
    this.carregarIrmaos();
    });
  }

  atualizarIrmao(objEditar: Irmao){
  this.irmao = objEditar;
  }

  alert(){
    alert('Irmão Salvo')
  }
}
