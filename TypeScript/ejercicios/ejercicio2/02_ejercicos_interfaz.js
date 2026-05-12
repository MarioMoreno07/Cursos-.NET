"use strict";
/* EJERCICIO 2 - INTERFACES COMO MODELOS DE DTOs

Objetivo:
Crear interfaces TypeScript que representen los DTOs de la API.

Tareas:
1. Crear interfaces:
   - Libro
   - LibroCreate
   - Usuario
   - UsuarioCreate
   - Prestamo
   - PrestamoCreate
   - LoginRequest
   - LoginResponse
2. Crear objetos de ejemplo para cada interfaz.
3. Explicar qué interfaces son de entrada y cuáles son de salida.*/
Object.defineProperty(exports, "__esModule", { value: true });
const libro = {
    id: 1,
    titulo: "Hola",
    autor: "Mundo",
    categoria: "miedo",
    anio: 1530,
    dis: true
};
const libroCreate = {
    titulo: "Buenas",
    autor: "Tardes",
    categoria: "miedo",
    anio: 1930,
    dis: true
};
const usuario = {
    id: 1,
    nombre: "Paolo",
    dni: "11222333",
    fechaAlta: new Date()
};
const usuarioCreate = {
    nombre: "Ana",
    dni: "44452346",
};
const prestamo = {
    id: 1,
    id_Libro: 1,
    nombreLibro: "Buenas",
    id_Usuario: 1,
    nombreUsuario: "Ana",
    FechaPrestamo: new Date(),
    FechaDevolucion: new Date(new Date().getTime() + (86400000 * 15)),
    FechaDevolucionReal: null
};
const prestamosCreate = {
    id_Libro: 1,
    id_Usuario: 1,
    diasPrestamo: 15
};
const loginRequest = {
    username: "admin",
    password: "Admin"
};
const loginResponse = {
    accessToken: "aaFASFtdfAJPKK",
    TokenType: "Bearer",
    ExpiredInSeconds: 100000000000000
};
//# sourceMappingURL=02_ejercicos_interfaz.js.map