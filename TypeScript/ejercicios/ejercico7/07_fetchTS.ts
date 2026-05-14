import type {Libro} from '../ejercicio2/02_ejercicos_interfaz';

let libros:Libro[]=[];

async function getLibrosApi():Promise<Libro[]>{
    
    process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
    const response = await fetch("https://localhost:52025/api/v1/libros")
    if(!response.ok){
        throw new Error("Todo mal");
    }
      const data: Libro[] = await response.json();
        return data
}

async function recibir(){

    libros = await getLibrosApi();
    libros.forEach(l=>{
    console.log(l);
});
}

recibir();
