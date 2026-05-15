import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Libro } from '../models/libro.model';
import {environment} from '../../environments/environments'
@Injectable({ providedIn: 'root' })
// Configura este servicio como un Singleton (instancia única en toda la 
// aplicación).
export class LibrosService {
  private baseUrl = `${environment.apiUrl}/libros`

  constructor(private http: HttpClient) { }

  getLibros(): Observable<Libro[]> {
    return this.http.get<Libro[]>(this.baseUrl);
  }
}
