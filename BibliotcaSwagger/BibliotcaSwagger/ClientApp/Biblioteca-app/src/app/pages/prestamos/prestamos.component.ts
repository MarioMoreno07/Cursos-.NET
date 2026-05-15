import { CommonModule } from "@angular/common";
import { Component, OnInit } from "@angular/core";
import { Prestamo } from "../../models/prestamo.model";
import { PrestamoService } from "../../service/prestamo.service";

@Component({
  selector: 'app-usuarios',
  standalone: true,
  imports: [CommonModule],
  template: `<h2>Prestamos</h2>
<table border="1" *ngIf="prestamos.length > 0">
  <tr>
    <th>Nombre Usuario</th>
    <th>Titulo Libro</th>
  </tr>
  <tr *ngFor="let p of prestamos">
    <td>{{p.nombreUsuario}}</td>
    <td>{{p.tituloLibro}}</td>
  </tr>
</table>`
})
export class PrestamosComponent implements OnInit {
  prestamos: Prestamo[] = [];

  constructor(private service: PrestamoService) { }

  ngOnInit(): void {
    this.service.getPrestamos().subscribe((data: Prestamo[]) => this.prestamos = data);
  }
}

