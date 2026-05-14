"use strict";
/*EJERCICIO 5 - CLASES Y SERVICIOS SIMULADOS

Objetivo:
Comprender la idea de servicio antes de usar servicios Angular.

Tareas:
1. Crear una clase LibrosServiceSimulado.
2. La clase debe tener un array privado de libros.
3. Crear métodos:
   - getAll()
   - getById(id)
   - create(dto)
   - delete(id)
4. Crear una instancia del servicio.
5. Probar todos los métodos por consola.
*/
Object.defineProperty(exports, "__esModule", { value: true });
class LibrosServiceSimulado {
    libro1 = { id: 1, titulo: "Libro1", autor: "Paco", categoria: "miedo", anio: 1900, dis: true };
    libro2 = { id: 2, titulo: "Libro2", autor: "Marco", categoria: "miedo", anio: 1900, dis: true };
    libro3 = { id: 3, titulo: "Libro3", autor: "Ana", categoria: "miedo", anio: 1900, dis: false };
    libros = [this.libro1, this.libro2, this.libro3];
    getAll() {
        return this.libros;
    }
    getById(id) {
        return this.libros.find(l => l.id == id);
    }
    create(dto) {
        this.libros.push({
            id: this.libros.length,
            titulo: dto.titulo,
            autor: dto.autor,
            categoria: dto.categoria,
            anio: dto.anio,
            dis: dto.dis
        });
        let r = false;
        if (this.libros.find(l => l.titulo == dto.titulo)) {
            r = true;
        }
        return r;
    }
    delete(id) {
        let r = false;
        this.libros.splice(this.libros.findIndex(l => l.id === id));
        if (!this.libros.find(l => l.id === id)) {
            r = true;
        }
        return r;
    }
}
let libroService = new LibrosServiceSimulado;
let libroCreate = { titulo: "Hola", autor: "Buenas", categoria: "miedo", anio: 1900, dis: false };
console.log(libroService.getAll());
console.log(libroService.getById(1));
console.log(libroService.create(libroCreate));
console.log(libroService.delete(2));
//# sourceMappingURL=05_clasesTS.js.map