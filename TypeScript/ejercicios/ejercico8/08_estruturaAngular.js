"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.AuthService = void 0;
class AuthService {
    jwtToken = null;
    async login() {
        try {
            let loginRequest = { Username: "admin", Password: "Admin123!" };
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
                this.jwtToken = data.accessToken;
                console.log("Token:", this.jwtToken);
                console.log("Token guardado con exito");
                return true;
            }
            else {
                console.error('Error en el login:', response.statusText);
                return false;
            }
        }
        catch (error) {
            console.error('Error de red:', error);
            return false;
        }
    }
    getToken() {
        return this.jwtToken;
    }
    logout() {
        this.jwtToken = null;
        console.log("Tu token es: " + this.jwtToken);
    }
}
exports.AuthService = AuthService;
const authService = new AuthService();
authService.login();
authService.getToken();
authService.logout();
//# sourceMappingURL=08_estruturaAngular.js.map