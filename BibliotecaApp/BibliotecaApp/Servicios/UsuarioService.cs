using BibliotecaApp.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp.Servicios {
    public class UsuarioService {
       public List<Usuario> usuarios =  new List<Usuario>();

        public bool AgregarUsuario(Usuario usuario) {
            bool r = false;
           if(usuario == null) {
                throw new ArgumentNullException("El usuario no puede estar vacio");
            }else if(usuario.Dni.Equals("")){
                throw new ArgumentNullException("El dni del usuario no puede estar vacio");
            }else if (usuario.Nombre.Equals("")) {
                throw new ArgumentNullException("El nombre del usuario no puede estar vacio");
            }else if(usuarios.Where(user => user.Dni.Equals(usuario.Dni)).Count() > 0) {
                throw new DuplicateWaitObjectException("El usuario ya existe");
            } else {
                usuarios.Add(usuario);
                r = true;
            }
            return r;
        }

        public void MostrarUsuarios() {
            if (usuarios.Count() == 0) {
                throw new NullReferenceException("No hay usuarios qu mostrar");
            } else {
                foreach (Usuario usario in usuarios) {
                    Console.WriteLine($"El usuario con dni {usario.Dni}, se llama {usario.Nombre}");
                }
            }
               
        }

        public Usuario BuscarUsuarioDni(string dni) {
            Usuario user = null;
            if(dni.Equals(null)) {
                throw new ArgumentNullException("El dni no puede estar vacio");
            }else if((usuarios.Where(user => user.Dni.Equals(dni)).Count() == 0)){
                throw new NullReferenceException("El usuario no exite");
            } else {
                user = usuarios.Where(user => user.Dni.Equals(dni)).FirstOrDefault();
                if (user == null) {
                    throw new NullReferenceException("No hay usuario");
                }
            }

                return user;
        }
    }
}
