export interface Libro{
    id: number,
    titulo:string,
    autor:string,
    categoria:string,
    anio:number,
    dis: boolean
}

export interface LibroCreate{
    titulo:string,
    autor:string,
    categoria:string,
    anio:number,
    dis: boolean
}

export interface Usuario{
    id:number,
    nombre:string,
    dni:string,
    fechaAlta:Date
}

interface UsuarioCreate{
    nombre:string,
    dni:string
}

export interface Prestamo{
    id:number,
    id_Libro:number,
    nombreLibro:string,
    id_Usuario:number,
    nombreUsuario:string,
    FechaPrestamo:Date,
    FechaDevolucion:Date,
    FechaDevolucionReal:Date|null
}

export interface PrestamoCreate{
    id_Libro:number,
    id_Usuario:number,
    diasPrestamo:number
}

export interface LoginRequest{
    Username:string,
    Password:string
}

export interface LoginResponse{
    accessToken:string,
    TokenType:string ,
    ExpiredInSeconds:number
}