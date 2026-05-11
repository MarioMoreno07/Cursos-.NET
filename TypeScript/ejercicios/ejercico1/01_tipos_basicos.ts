let id_Libro:number;
let titulo:string;
let autor:string;
let anio:number;
let dis: boolean;
console.log(mostrarLibro(1,"El principe","marco",1900,true));

function mostrarLibro(id_Libro:number,titulo:string,
    autor:string,anio:number,dis:boolean):string{

        return `ID:${id_Libro} titulo:${titulo} autor:${autor} anio: ${anio},disponible: ${dis}`
}