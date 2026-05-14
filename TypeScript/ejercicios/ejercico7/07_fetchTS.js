"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
let libros = [];
async function getLibrosApi() {
    process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";
    const response = await fetch("https://localhost:52025/api/v1/libros");
    if (!response.ok) {
        throw new Error("Todo mal");
    }
    const data = await response.json();
    return data;
}
async function recibir() {
    libros = await getLibrosApi();
    libros.forEach(l => {
        console.log(l);
    });
}
recibir();
//# sourceMappingURL=07_fetchTS.js.map