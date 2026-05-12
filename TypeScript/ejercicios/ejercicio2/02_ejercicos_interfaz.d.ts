export interface Libro {
    id: number;
    titulo: string;
    autor: string;
    categoria: string;
    anio: number;
    dis: boolean;
}
export interface LibroCreate {
    titulo: string;
    autor: string;
    categoria: string;
    anio: number;
    dis: boolean;
}
export interface Usuario {
    id: number;
    nombre: string;
    dni: string;
    fechaAlta: Date;
}
export interface Prestamo {
    id: number;
    id_Libro: number;
    nombreLibro: string;
    id_Usuario: number;
    nombreUsuario: string;
    FechaPrestamo: Date;
    FechaDevolucion: Date;
    FechaDevolucionReal: Date | null;
}
//# sourceMappingURL=02_ejercicos_interfaz.d.ts.map