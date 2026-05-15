export interface Usuario {
  id: number;
  nombre: string;
  dni: string;
  fechaAlta: Date;

}

export interface UsuarioCreate {
  nombre: string;
  dni: string;
}

export interface UsuarioUpdate {
  nombre: string;
}
