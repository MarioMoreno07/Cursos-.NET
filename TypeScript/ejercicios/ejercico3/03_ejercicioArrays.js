"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let libro1 = { id: 1, titulo: "Libro1", autor: "Paco", categoria: "miedo", anio: 1900, dis: true };
let libro2 = { id: 2, titulo: "Libro2", autor: "Marco", categoria: "miedo", anio: 1900, dis: true };
let libro3 = { id: 3, titulo: "Libro3", autor: "Ana", categoria: "miedo", anio: 1900, dis: false };
let usuario1 = { id: 1, nombre: "Manolo", dni: "111", fechaAlta: new Date() };
let usuario2 = { id: 2, nombre: "Ana", dni: "222", fechaAlta: new Date() };
let usuario3 = { id: 3, nombre: "Pe", dni: "333", fechaAlta: new Date() };
let prestamo1 = { id: 1, id_Libro: 1, nombreLibro: "Libro1", id_Usuario: 1, nombreUsuario: "Marco", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)), FechaDevolucionReal: null };
let prestamo2 = { id: 2, id_Libro: 2, nombreLibro: "Libro2", id_Usuario: 1, nombreUsuario: "Paco", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)), FechaDevolucionReal: null };
let prestamo3 = { id: 3, id_Libro: 3, nombreLibro: "Libro3", id_Usuario: 1, nombreUsuario: "Ana", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)), FechaDevolucionReal: new Date(new Date().getTime() + (86400000 * 12)) };
let libros = [libro1, libro2, libro3];
let usuarios = [usuario1, usuario2, usuario3];
let prestamos = [prestamo1, prestamo2, prestamo3];
libros.forEach(l => {
    console.log(`Id: ${l.id} titulo: ${l.titulo} autor: ${l.autor} categoria: ${l.categoria} anio ${l.anio} dis: ${l.dis}`);
});
usuarios.forEach(u => {
    console.log(`Id: ${u.id} nombre: ${u.nombre} dni: ${u.dni} fechaAlta ${u.fechaAlta}`);
});
prestamos.forEach(p => {
    console.log(`Id: ${p.id} idLibro: ${p.id_Libro} nombreLibro: ${p.nombreLibro} idUsuario: ${p.id_Usuario} nombreUsuario: ${p.nombreUsuario} FechaPrestamo: ${p.FechaPrestamo} FechaDevolucion: ${p.FechaDevolucion} FechaDevolucionReal: ${p.FechaDevolucionReal}`);
});
console.log("Los libros disponibles son: " + disponibles());
function disponibles() {
    let librosDis = [];
    libros.forEach(l => {
        if (l.dis == true) {
            librosDis.push(l);
        }
    });
    return librosDis;
}
//# sourceMappingURL=03_ejercicioArrays.js.map