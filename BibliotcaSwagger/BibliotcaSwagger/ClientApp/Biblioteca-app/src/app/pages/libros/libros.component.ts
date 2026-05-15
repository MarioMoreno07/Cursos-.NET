import {CommonModule} from "@angular/common";
import {Component, OnInit } from "@angular/core";
import {Libro} from "../../models/libro.model";
import {LibrosService} from "../../service/libro.service";

@Component({
  selector: 'app-libros',
  standalone: true,
  imports: [CommonModule],
  template: `<h2>Libros</h2>
<table border="1" *ngIf="libros.length > 0">
  <tr>
    <th>Título</th>
    <th>Autor</th>
  </tr>
  <tr *ngFor="let l of libros">
    <td>{{l.titulo}}</td>
    <td>{{l.autor}}</td>
  </tr>
</table>`
})  
export class LibrosComponent implements OnInit {
  libros: Libro[] = [];

  constructor(private service: LibrosService) { }

  ngOnInit(): void {
    this.service.getLibros().subscribe((data: Libro[]) => this.libros = data);
  }
}
