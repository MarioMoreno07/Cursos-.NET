export interface Libro {
  id: number;
  titulo: string;
  autor: string;
  categoria: string;
  anio: number;
  disponible: boolean;
}
export interface LibroUpdate {
  titulo: string;
  autor: string;
  categoria: string;
  anio: number;
  disponible: boolean;
}

export interface LibroCreate {
  titulo: string;
  autor: string;
  categoria: string;
  anio: number;
  disponible: boolean;
}
