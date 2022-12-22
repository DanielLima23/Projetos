import { Privilegios } from 'src/app/models/privilegios.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppService } from '../app.service';
import { observableToBeFn } from 'rxjs/internal/testing/TestScheduler';

@Injectable({
  providedIn: 'root'
})
export class PrivilegiosService extends AppService {

  constructor(http: HttpClient) {
    super(http);
  }

  public listarPrivilegios(): Observable<any>{
    return this.http.get("http://localhost:8080/privilegios/all");
  }

  public gravarPrivilegios(privilegio: Privilegios):Observable<any>{
    return this.http.post("http://localhost:8080/privilegios/add", privilegio)
  }


  public delete(privilegio: number):Observable<any>{
    return this.http.delete("http://localhost:8080/privilegios/"+ privilegio)
  }

  public buscarPrivilegioPorId(id : any): Observable<any>{
    return this.http.get("http://localhost:8080/privilegios/" + id)
  }

}
