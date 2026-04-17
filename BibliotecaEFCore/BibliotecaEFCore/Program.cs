
using BibliotecaEFCore.Data;
using BibliotecaEFCore.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
internal class Program {
    private static void Main(string[] args) {
        BibliotecaMenu menu = new BibliotecaMenu(new BibliotecaDbContext ());

        menu.Iniciar();
    }
}