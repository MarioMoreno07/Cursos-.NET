/*EJERCICIO 4 - FUNCIONES TIPADAS DE NEGOCIO

Objetivo:
Crear funciones TypeScript similares a lógica real del proyecto.

Tareas:
1. Crear una función buscarLibros que reciba:
   - array de libros
   - texto de búsqueda
2. Crear una función esPrestamoVencido.
3. Crear una función crearResumenPrestamo.
4. Crear una función validarLibroCreate.
5. Todas las funciones deben tener parámetros y retorno tipados.
*/
import type {Libro} from '../ejercicio2/02_ejercicos_interfaz'
import type {Prestamo} from '../ejercicio2/02_ejercicos_interfaz'
import type {LibroCreate} from '../ejercicio2/02_ejercicos_interfaz'

let libro1:Libro= {id:1,titulo:"Libro1",autor:"Paco",categoria:"miedo",anio:1900,dis:true};
let libro2:Libro= {id:2,titulo:"Libro2",autor:"Marco",categoria:"miedo",anio:1900,dis:true};
let libro3:Libro= {id:3,titulo:"Libro3",autor:"Ana",categoria:"miedo",anio:1900,dis:false};

let prestamo1:Prestamo={id:1,id_Libro:1,nombreLibro:"Libro1",id_Usuario:1,nombreUsuario:"Marco",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),FechaDevolucionReal:null}
let prestamo2:Prestamo={id:2,id_Libro:2,nombreLibro:"Libro2",id_Usuario:1,nombreUsuario:"Paco",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()-(86400000*15)),FechaDevolucionReal:null}
let prestamo3:Prestamo={id:3,id_Libro:3,nombreLibro:"Libro3",id_Usuario:1,nombreUsuario:"Ana",FechaPrestamo:new Date(),FechaDevolucion:new Date(new Date().getTime()+(86400000*15)),FechaDevolucionReal:new Date(new Date().getTime()+(86400000*12))}

let libros:Libro[]=[libro1,libro2,libro3];
let prestamos:Prestamo[]=[prestamo1,prestamo2,prestamo3];



console.log(buscarLibros(libros,"Libro1"));
function buscarLibros(librosARecorrer:Array<Libro>,busqueda:string):Array<Libro>{
return  librosARecorrer.filter(lr=>(lr.titulo==busqueda || lr.autor==busqueda))
}

prestamos.forEach(p=>{
    console.log(esPrestamoVencido(p));
})
function esPrestamoVencido(prestamo:Prestamo):boolean{
    let r:boolean= false;
   if(prestamo.FechaDevolucion < new Date()){
        r=true;
   }
    return r;
}

console.log(resumenPrestamo(prestamos));
function resumenPrestamo(totalPrestamos:Array<Prestamo>):string{
    let numPrestamos:number;
    let numVencidos:number;

    numPrestamos = totalPrestamos.length
    numVencidos = totalPrestamos.filter(tp =>esPrestamoVencido(tp)).length

    return `El total de prestamos es de ${numPrestamos} y en numero de prestamos vencidos es de ${numVencidos}`;
}


console.log(validarLibroCreate(libro1));
function validarLibroCreate(l:Libro):LibroCreate{
    return ({titulo:l.titulo,autor:l.autor,categoria:l.categoria,anio:l.anio,dis:l.dis});
}