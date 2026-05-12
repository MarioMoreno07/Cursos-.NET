"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let libro1 = { id: 1, titulo: "Libro1", autor: "Paco", categoria: "miedo", anio: 1900, dis: true };
let libro2 = { id: 2, titulo: "Libro2", autor: "Marco", categoria: "miedo", anio: 1900, dis: true };
let libro3 = { id: 3, titulo: "Libro3", autor: "Ana", categoria: "miedo", anio: 1900, dis: false };
let usuario1 = { id: 1, nombre: "Manolo", dni: "111", fechaAlta: new Date() };
let usuario2 = { id: 2, nombre: "Ana", dni: "222", fechaAlta: new Date() };
let usuario3 = { id: 3, nombre: "Pe", dni: "333", fechaAlta: new Date() };
let prestamo1 = { id: 1, id_Libro: 1, nombreLibro: "Libro1", id_Usuario: 1, nombreUsuario: "Marco", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)), FechaDevolucionReal: null };
let prestamo2 = { id: 2, id_Libro: 2, nombreLibro: "Libro2", id_Usuario: 1, nombreUsuario: "Paco", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() - (86400000 * 15)), FechaDevolucionReal: null };
let prestamo3 = { id: 3, id_Libro: 3, nombreLibro: "Libro3", id_Usuario: 1, nombreUsuario: "Ana", FechaPrestamo: new Date(), FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)), FechaDevolucionReal: new Date(new Date().getTime() + (86400000 * 12)) };
let libros = [libro1, libro2, libro3];
let usuarios = [usuario1, usuario2, usuario3];
let prestamos = [prestamo1, prestamo2, prestamo3];
console.log(buscarLibros(libros, "Libro1"));
function buscarLibros(librosARecorrer, busqueda) {
    return librosARecorrer.filter(lr => (lr.titulo == busqueda || lr.autor == busqueda));
}
prestamos.forEach(p => {
    console.log(esPrestamoVencido(p));
});
function esPrestamoVencido(prestamo) {
    let r = false;
    if (prestamo.FechaDevolucion < new Date()) {
        r = true;
    }
    return r;
}
console.log(resumenPrestamo(prestamos));
function resumenPrestamo(totalPrestamos) {
    let numPrestamos;
    let numVencidos;
    numPrestamos = totalPrestamos.length;
    numVencidos = totalPrestamos.filter(tp => esPrestamoVencido(tp)).length;
    return `El total de prestamos es de ${numPrestamos} y en numero de prestamos vencidos es de ${numVencidos}`;
}
console.log(validarLibroCreate(libro1));
function validarLibroCreate(l) {
    return ({ titulo: l.titulo, autor: l.autor, categoria: l.categoria, anio: l.anio, dis: l.dis });
}
//# sourceMappingURL=04_ejercicio_funciones.js.map