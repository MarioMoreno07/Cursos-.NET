"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let libro1 = { id: 1, titulo: "Libro1", autor: "Paco", categoria: "miedo", anio: 1900, dis: true };
let libro2 = { id: 2, titulo: "Libro2", autor: "Marco", categoria: "miedo", anio: 1900, dis: true };
let libro3 = { id: 3, titulo: "Libro3", autor: "Ana", categoria: "miedo", anio: 1900, dis: false };
let libros = [libro1, libro2, libro3];
async function obtenerLibrosAsync() {
    return await new Promise((resolve) => { setTimeout(() => { resolve(libros); }, 1000); });
}
function consumirLibro() {
    let libroObt = [];
    obtenerLibrosAsync().then(s => s.forEach(l => console.log(l)));
    return libroObt;
}
try {
    console.log(consumirLibro());
}
catch (error) {
    console.log(error);
}
//# sourceMappingURL=06_promiseTs.js.map