
using BibliotecaEFCore.Data;
using BibliotecaEFCore.Servicios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
internal class Program {
    private static void Main(string[] args) {
        
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(AppContext.BaseDirectory)
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .Build();

        string? cs = config.GetConnectionString("BibliotecaDB");
        if (string.IsNullOrWhiteSpace(cs)) {
            Console.WriteLine(" No se encontró..");
            return;
        }

        var options = new DbContextOptionsBuilder<BibliotecaDbContext> ()
        .UseSqlServer(cs)
        .Options;

        using var context = new BibliotecaDbContext(options);
        if (!context.Database.CanConnect()) {
            Console.WriteLine(" No se puede conectar...");
            return;
        }

        var menu = new BibliotecaMenu(context);
        menu.Iniciar();
    }
}