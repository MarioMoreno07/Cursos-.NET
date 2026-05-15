export interface Prestamo {
  id: number;
  idLibro: number;
  idUsuario: number;
  nombreUsuario: string;
  tituloLibro: string;
  fechaPrestamos: Date;
  fechaDevolucion: Date;
  fechaDevolucionReal: Date|null;
  disponible: boolean;
  vencido: boolean;
}

export interface PrestamosCreate {
  idLibro: number;
  idUsuario: number;
  diasPrestamos: number;
}

export interface PrestamosUpdate {
  fechaDevolucionRea: Date | null;
}
