"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const _08_estruturaAngular_1 = require("./08_estruturaAngular");
class LibroService {
    authService;
    libros = [];
    constructor(authService) {
        this.authService = authService;
    }
    async getAll() {
        process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
        const response = await fetch("https://localhost:52025/api/v1/libros");
        this.libros = await response.json();
        this.libros.forEach(l => console.log(l));
    }
    async create() {
        let libroCreate = {
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
            }
            else {
                console.error('Error en la subida:', response.statusText);
                console.log(await response.text());
                return false;
            }
        }
        catch (error) {
            console.error('Error de red:', error);
            return false;
        }
    }
}
async function ejecutar() {
    const authService = new _08_estruturaAngular_1.AuthService();
    const login = await authService.login();
    if (!login) {
        console.log("Error de login");
        return;
    }
    const librosService = new LibroService(authService);
    await librosService.create();
    await librosService.getAll();
}
ejecutar();
//# sourceMappingURL=LibroApiSevice.js.map