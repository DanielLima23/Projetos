import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListarIrmaosComponent } from './componentes/listar-irmaos/listar-irmaos.component';
import { HttpClientModule } from '@angular/common/http';
import { HomeComponent } from './componentes/home/home.component';
import { ListarPrivilegiosComponent } from './componentes/listar-privilegios/listar-privilegios.component';
import { AddPrivilegiosComponent } from './componentes/add-privilegios/add-privilegios.component';
import { FormsModule } from '@angular/forms';
import { AddIrmaosComponent } from './componentes/add-irmaos/add-irmaos.component';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [
    AppComponent,
    ListarIrmaosComponent,
    HomeComponent,
    ListarPrivilegiosComponent,
    AddPrivilegiosComponent,
    AddIrmaosComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
