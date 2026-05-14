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

import type {Libro} from '../ejercicio2/02_ejercicos_interfaz';
import type {LibroCreate} from '../ejercicio2/02_ejercicos_interfaz'

class LibrosServiceSimulado{
libro1:Libro= {id:1,titulo:"Libro1",autor:"Paco",categoria:"miedo",anio:1900,dis:true};
libro2:Libro= {id:2,titulo:"Libro2",autor:"Marco",categoria:"miedo",anio:1900,dis:true};
libro3:Libro= {id:3,titulo:"Libro3",autor:"Ana",categoria:"miedo",anio:1900,dis:false};
libros:Libro[]=[this.libro1,this.libro2,this.libro3];

getAll():Array<Libro>{
    return this.libros;
}

getById(id:number):Libro|undefined{
   return this.libros.find(l=>l.id==id)
}

create(dto:LibroCreate):boolean{
    this.libros.push({
        id:this.libros.length,
        titulo:dto.titulo,
        autor:dto.autor,
        categoria:dto.categoria,
        anio:dto.anio,
        dis:dto.dis
    });
    let r:boolean=false;
    if(this.libros.find(l=>l.titulo==dto.titulo)){
        r = true;
    }

    return r;
}

delete(id:number):boolean{
    let r:boolean = false;
  
    this.libros.splice(this.libros.findIndex(l=>l.id ===id));
    if(!this.libros.find(l=>l.id===id)){
        r = true;
    }
    return r;
}
}

let libroService:LibrosServiceSimulado = new LibrosServiceSimulado;
let libroCreate:LibroCreate={titulo:"Hola",autor:"Buenas",categoria:"miedo",anio:1900,dis:false}

console.log(libroService.getAll());
console.log(libroService.getById(1));
console.log(libroService.create(libroCreate));
console.log(libroService.delete(2));