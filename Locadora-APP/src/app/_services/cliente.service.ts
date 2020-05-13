import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../_models/Cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

baseURL = 'http://localhost:5000/api/cliente';

constructor(private http: HttpClient) { }

getClienteById(id: number): Observable<Cliente>
{
  return this.http.get<Cliente>(`${this.baseURL}/${id}`);
}

}
