using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Dtos.Usuarios {
    public class UsuarioCreateDto {

        [Required,MaxLength(150)] public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(20)] public string Dni { get; set; } = string.Empty;
    }
}
