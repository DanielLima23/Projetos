import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddIrmaosComponent } from './componentes/add-irmaos/add-irmaos.component';
import { AddPrivilegiosComponent } from './componentes/add-privilegios/add-privilegios.component';
import { HomeComponent } from './componentes/home/home.component';
import { ListarIrmaosComponent } from './componentes/listar-irmaos/listar-irmaos.component';
import { ListarPrivilegiosComponent } from './componentes/listar-privilegios/listar-privilegios.component';

const routes: Routes = [

  {
    path:'',
    redirectTo: 'home',
    pathMatch: 'full'
  },

  {
    path:'listarIrmaos',
    component: ListarIrmaosComponent
  },

  {
    path:'home',
    component: HomeComponent,
  },

  {
    path: 'addIrmao/:id',
    component: AddIrmaosComponent,
  },

  {
    path: 'addIrmao',
    component: AddIrmaosComponent
  },

  {
    path: 'listarPrivilegios',
    component: ListarPrivilegiosComponent,
  },

  {
    path: 'addPrivilegio',
    component: AddPrivilegiosComponent
  },

  {
    path: 'addPrivilegio/:id',
    component: AddPrivilegiosComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
