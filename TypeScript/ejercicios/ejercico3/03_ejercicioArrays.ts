/*EJERCICIO 3 - ARRAYS TIPADOS

Objetivo:
Trabajar con colecciones tipadas de libros, usuarios y préstamos.

Tareas:
1. Crear arrays:
   - libros: Libro[]
   - usuarios: Usuario[]
   - prestamos: Prestamo[]
2. Añadir varios datos de ejemplo.
3. Recorrer arrays con forEach.
4. Mostrar un resumen de cada entidad por consola.
5. Crear una función que reciba Libro[] y devuelva solo los disponibles.*/ 
import type {Libro} from '../ejercicio2/02_ejercicos_interfaz'
import type {Usuario} from '../ejercicio2/02_ejercicos_interfaz'
import type {Prestamo} from '../ejercicio2/02_ejercicos_interfaz'

let libro1:Libro= {id:1,titulo:"Libro1",autor:"Paco",categoria:"miedo",anio:1900,dis:true};
let libro2:Libro= {id:2,titulo:"Libro2",autor:"Marco",categoria:"miedo",anio:1900,dis:true};
let libro3:Libro= {id:3,titulo:"Libro3",autor:"Ana",categoria:"miedo",anio:1900,dis:false};

let usuario1:Usuario={id:1,nombre:"Manolo",dni:"111",fechaAlta:new Date()};
let usuario2:Usuario={id:2,nombre:"Ana",dni:"222",fechaAlta:new Date()};
let usuario3:Usuario={id:3,nombre:"Pe",dni:"333",fechaAlta:new Date()};

let prestamo1:Prestamo={id:1,id_Libro:1,nombreLibro:"Libro1",id_Usuario:1,nombreUsuario:"Marco",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),FechaDevolucionReal:null}
let prestamo2:Prestamo={id:2,id_Libro:2,nombreLibro:"Libro2",id_Usuario:1,nombreUsuario:"Paco",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),FechaDevolucionReal:null}
let prestamo3:Prestamo={id:3,id_Libro:3,nombreLibro:"Libro3",id_Usuario:1,nombreUsuario:"Ana",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),FechaDevolucionReal:new Date(new Date().getTime()+(86400000*12))}



let libros:Libro[]=[libro1,libro2,libro3];
let usuarios:Usuario[]=[usuario1,usuario2,usuario3];
let prestamos:Prestamo[]=[prestamo1,prestamo2,prestamo3];

libros.forEach(l => {
    console.log(`Id: ${l.id} titulo: ${l.titulo} autor: ${l.autor} categoria: ${l.categoria} anio ${l.anio} dis: ${l.dis}`);
});

usuarios.forEach(u=>{
    console.log(`Id: ${u.id} nombre: ${u.nombre} dni: ${u.dni} fechaAlta ${u.fechaAlta}`);
});

prestamos.forEach(p=>{
    console.log(`Id: ${p.id} idLibro: ${p.id_Libro} nombreLibro: ${p.nombreLibro} idUsuario: ${p.id_Usuario} nombreUsuario: ${p.nombreUsuario} FechaPrestamo: ${p.FechaPrestamo} FechaDevolucion: ${p.FechaDevolucion} FechaDevolucionReal: ${p.FechaDevolucionReal}`);
});

console.log("Los libros disponibles son: "+disponibles());

function disponibles():Array<Libro>{
let librosDis:Libro[] =[];

libros.forEach(l => {
    if(l.dis==true){
        librosDis.push(l);
    }
});
return librosDis;
}