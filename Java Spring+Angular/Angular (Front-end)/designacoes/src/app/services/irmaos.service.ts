import { Irmao } from '../models/irmaos.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppService } from '../app.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class IrmaosService extends AppService {

  constructor(httpClient: HttpClient) {
    super(httpClient);
   }

   public listarIrmaos(): Observable<any>{
    return this.http.get("http://localhost:8080/publicador/all")
   }

   public addIrmaos(irmao:any):Observable<any>{
    return this.http.post("http://localhost:8080/publicador/add", irmao)
  }

  public deleteIrmao(irmao: number):Observable<any>{
    return this.http.delete("http://localhost:8080/publicador/"+ irmao)
  }

  public atualizarIrmao(irmao: any):Observable<any>{
    return this.http.put("http://localhost:8080/publicador/atualizar",irmao)
  }

  public buscarIrmaoPorId(id : any): Observable<any>{
    return this.http.get("http://localhost:8080/publicador/" + id)
  }
}
