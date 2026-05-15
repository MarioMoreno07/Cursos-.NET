import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Usuario } from '../models/usuario.model';
import { environment } from '../../environments/environments'
@Injectable({ providedIn: 'root' })
// Configura este servicio como un Singleton (instancia única en toda la 
// aplicación).
export class UsuarioService {
  private baseUrl = `${environment.apiUrl}/usuarios`

  constructor(private http: HttpClient) { }

  getUsuarios(): Observable<Usuario[]> {
    return this.http.get<Usuario[]>(this.baseUrl);
  }
}
