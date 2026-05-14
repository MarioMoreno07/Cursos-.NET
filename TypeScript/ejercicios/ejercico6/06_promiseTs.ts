/*EJERCICIO 6 - PROMESAS Y ASYNC/AWAIT

Objetivo:
Entender la asincronía antes de usar HttpClient en Angular.

Tareas:
1. Crear una función obtenerLibrosAsync que devuelva Promise<Libro[]>.
2. Simular una espera con setTimeout.
3. Consumir la función con .then().
4. Consumir la función con async/await.
5. Manejar errores con try/catch.*/
import type {Libro,LibroCreate} from '../ejercicio2/02_ejercicos_interfaz';
let libro1:Libro= {id:1,titulo:"Libro1",autor:"Paco",categoria:"miedo",anio:1900,dis:true};
let libro2:Libro= {id:2,titulo:"Libro2",autor:"Marco",categoria:"miedo",anio:1900,dis:true};
let libro3:Libro= {id:3,titulo:"Libro3",autor:"Ana",categoria:"miedo",anio:1900,dis:false};
let libros:Libro[]=[libro1,libro2,libro3];

async function obtenerLibrosAsync(): Promise<Libro[]> {
    return await new Promise<Libro[]>((resolve) => {setTimeout(() => {resolve(libros); }, 1000);});
}

function consumirLibro():Libro[]{
    let libroObt:Libro[]=[]
    obtenerLibrosAsync().then(s=>s.forEach(l=>console.log(l)))
    return libroObt;
}

try{
    console.log(consumirLibro());
}catch(error){
    console.log(error);
}