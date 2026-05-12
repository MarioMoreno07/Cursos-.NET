"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let id_Libro;
let titulo;
let autor;
let anio;
let dis;
console.log(mostrarLibro(1, "El principe", "marco", 1900, true));
function mostrarLibro(id_Libro, titulo, autor, anio, dis) {
    return `ID:${id_Libro} titulo:${titulo} autor:${autor} anio: ${anio},disponible: ${dis}`;
}
//# sourceMappingURL=01_tipos_basicos.js.map