import { CommonModule } from "@angular/common";
import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../models/usuario.model";
import { UsuarioService } from "../../service/usuario.service";

@Component({
  selector: 'app-usuarios',
  standalone: true,
  imports: [CommonModule],
  template: `<h2>Usuarios</h2>
<table border="1" *ngIf="usuarios.length > 0">
  <tr>
    <th>Nombre</th>
    <th>Dni</th>
  </tr>
  <tr *ngFor="let u of usuarios">
    <td>{{u.nombre}}</td>
    <td>{{u.dni}}</td>
  </tr>
</table>`
})
export class UsuariosComponent implements OnInit {
  usuarios: Usuario[] = [];

  constructor(private service: UsuarioService) { }

  ngOnInit(): void {
    this.service.getUsuarios().subscribe((data: Usuario[]) => this.usuarios = data);
  }
}
