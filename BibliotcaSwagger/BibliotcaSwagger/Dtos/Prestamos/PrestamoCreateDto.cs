using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotcaSwagger.Dtos.Prestamos {
    public class PrestamoCreateDto {
        [Required] public int LibroId { get; set; }
        [Required] public int UsuarioId { get; set; }
        [Required] public int DiasPrestamo { get; set; }
    }
}
     