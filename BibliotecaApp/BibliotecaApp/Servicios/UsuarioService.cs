using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    internal class UsuarioService {
       internal List<Usuario> usuarios =  [];

        public void AgregarUsuario(Usuario usuario) {
            usuarios.Add(usuario);

        }
    }
}
