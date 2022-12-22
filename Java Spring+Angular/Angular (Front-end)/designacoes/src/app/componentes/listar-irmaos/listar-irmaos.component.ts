import { Irmao } from './../../models/irmaos.model';
import { IrmaosService } from '../../services/irmaos.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-listar-irmaos',
  templateUrl: './listar-irmaos.component.html',
  styleUrls: ['./listar-irmaos.component.css']
})
export class ListarIrmaosComponent implements OnInit  {

  constructor(
    private irmaosService: IrmaosService) { }

  listaIrmaos: Irmao[] = []
  irmao: Irmao = new Irmao

  ngOnInit(): void {
    this.carregarIrmaos();

  }

  carregarIrmaos(){
    this.irmaosService.listarIrmaos().subscribe(_data => {
      this.listaIrmaos = _data
     })
  }

  delete(id: number){
    this.irmaosService.deleteIrmao(id).subscribe((_data) => {
     this.carregarIrmaos();
    });
  }


}

