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



export interface Libro{
    id: number,
    titulo:string,
    autor:string,
    categoria:string,
    anio:number,
    dis: boolean
}

export interface LibroCreate{
    titulo:string,
    autor:string,
    categoria:string,
    anio:number,
    dis: boolean
}

export interface Usuario{
    id:number,
    nombre:string,
    dni:string,
    fechaAlta:Date
}

interface UsuarioCreate{
    nombre:string,
    dni:string
}

export interface Prestamo{
    id:number,
    id_Libro:number,
    nombreLibro:string,
    id_Usuario:number,
    nombreUsuario:string,
    FechaPrestamo:Date,
    FechaDevolucion:Date,
    FechaDevolucionReal:Date|null
}

interface PrestamoCreate{
    id_Libro:number,
    id_Usuario:number,
    diasPrestamo:number
}

interface LoginRequest{
    username:string,
    password:string
}

interface LoginResponse{
    accessToken:string,
    TokenType:string ,
    ExpiredInSeconds:number
}

const libro:Libro ={
    id:1,
    titulo:"Hola",
    autor:"Mundo",
    categoria:"miedo",
    anio:1530,
    dis:true
}

const libroCreate:LibroCreate={
    titulo:"Buenas",
    autor:"Tardes",
    categoria:"miedo",
    anio:1930,
    dis:true
}

const usuario:Usuario ={
    id:1,
    nombre:"Paolo",
    dni:"11222333",
    fechaAlta:new Date()
}

const usuarioCreate:UsuarioCreate ={
    nombre:"Ana",
    dni:"44452346",
}

const prestamo:Prestamo ={
    id:1,
    id_Libro:1,
    nombreLibro:"Buenas",
    id_Usuario:1,
    nombreUsuario:"Ana",
    FechaPrestamo:new Date(),
    FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),
    FechaDevolucionReal: null
}

const prestamosCreate:PrestamoCreate ={
    id_Libro:1,
    id_Usuario:1,
    diasPrestamo:15
}

const loginRequest:LoginRequest ={
    username:"admin",
    password:"Admin"
}

const loginResponse:LoginResponse={
    accessToken:"aaFASFtdfAJPKK",
    TokenType:"Bearer" ,
    ExpiredInSeconds:100000000000000
}