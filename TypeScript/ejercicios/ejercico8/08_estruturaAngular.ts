/*EJERCICIO 8 - MINI CAPA DE SERVICIOS TYPESCRIPT

Objetivo:
Crear una estructura parecida a la que se usará en Angular.

Tareas:
1. Crear modelos TypeScript:
   - Libro
   - Usuario
   - Prestamo
   - LoginRequest
   - LoginResponse
2. Crear clase AuthServiceTs:
   - login()
   - getToken()
   - logout()
3. Crear clase LibrosApiServiceTs:
   - getAll()
   - create()
4. Usar fetch con headers.
5. Incluir Authorization: Bearer token al crear libro.
6. Explicar cómo esto se convertirá en servicios Angular.*/ 
import type {LoginRequest} from './modelos'
export class AuthService{
    private jwtToken: string | null = null;
           public  async login() {
            try {
                let loginRequest:LoginRequest={Username:"admin",Password:"Admin123!"}
                process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
                const response = await fetch('https://localhost:52025/api/v1/auth/login', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json'
                        
                    },
                    body: JSON.stringify(loginRequest)
                });

                if (response.ok) {
                    const data = await response.json();
                    this.jwtToken=data.accessToken;
                    console.log("Token:", this.jwtToken);
                    console.log("Token guardado con exito");
                    return true;
                } else {
                    console.error('Error en el login:', response.statusText);
                    return false;
                }
            } catch (error) {
                console.error('Error de red:', error);
                return false;
            }

        }

        public  getToken(){
            return this.jwtToken!;
        }

        public logout(){
            this.jwtToken=null;
            console.log("Tu token es: "+this.jwtToken!);
        }
}
 const  authService = new AuthService()
authService.login();
authService.getToken();
authService.logout();
