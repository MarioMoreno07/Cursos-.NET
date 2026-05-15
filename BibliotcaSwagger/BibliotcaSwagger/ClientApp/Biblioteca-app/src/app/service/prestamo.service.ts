import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Prestamo } from '../models/prestamo.model';
import { environment } from '../../environments/environments'
@Injectable({ providedIn: 'root' })
// Configura este servicio como un Singleton (instancia única en toda la 
// aplicación).
export class PrestamoService {
  private baseUrl = `${environment.apiUrl}/prestamos`

  constructor(private http: HttpClient) { }

  getPrestamos(): Observable<Prestamo[]> {
    return this.http.get<Prestamo[]>(this.baseUrl);
  }
}
