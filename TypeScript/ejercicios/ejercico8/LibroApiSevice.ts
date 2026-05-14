import type {Libro,LibroCreate} from './modelos'
import {AuthService} from './08_estruturaAngular'

class LibroService{
    public libros:Libro[] =[]
    constructor(private authService:AuthService){}
    public async getAll(){
            process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
            const response = await fetch("https://localhost:52025/api/v1/libros");
            this.libros = await response.json();
            this.libros.forEach(l=>console.log(l));
    }

    public async create(){
        
        let libroCreate:LibroCreate={
            titulo: "Mago de oz",
            autor: "Desconocido",
            categoria: "Aventura",
            anio: 2000,
            dis: true
            };
 
            try {
                process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
                const response = await fetch('https://localhost:52025/api/v1/libros', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'Authorization': `Bearer ${this.authService.getToken()}`

                    },
                    body: JSON.stringify(libroCreate)
                });
                if (response.ok) {
                    console.log("Libro añadido");
                    return true;
                } else {
                    console.error('Error en la subida:', response.statusText);
                    console.log(await response.text());
                    return false;
                }
            } catch (error) {
                console.error('Error de red:', error);
                return false;
            }
    }
}

async function ejecutar() {
    const authService = new AuthService();
    const login = await authService.login();

if(!login){
    console.log("Error de login");
    return;
}
    const librosService = new LibroService(authService);   
    await librosService.create();
    await librosService.getAll();
}


ejecutar();