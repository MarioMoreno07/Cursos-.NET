using BibliotcaSwagger.Data;
using BibliotcaSwagger.Dtos.Libros;
using BibliotcaSwagger.Modelos;
using BibliotcaSwagger.Servicios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BibliotcaSwagger.Controllers {
    [ApiController]
    [Route("api/v1/libros")]
    [Produces("application/json","application/xml")]
    [Authorize]
    public class LibroController:ControllerBase {
        private readonly BibliotecaDbContext _db;
        public LibroController(BibliotecaDbContext db)=>_db = db;

        [HttpGet]
        [AllowAnonymous]
        [ProducesResponseType(typeof(IEnumerable<LibroReadDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<LibroReadDto>>>
        GetAll([FromQuery] bool? disponible, [FromQuery] string? 
            categoria, [FromQuery] string? q, [FromQuery] int page = 1, 
            [FromQuery] int pageSize=20, CancellationToken ct = default) {
            IQueryable<Libro> query = _db.Libros.AsNoTracking();
            if (disponible is not null) query = query.Where(l => l.Disponible == disponible.Value);
            if (!string.IsNullOrWhiteSpace(categoria))
                query = query.Where(l => l.Categoria == categoria);
            if (!string.IsNullOrWhiteSpace(q))
                query = query.Where(l => l.Titulo.Contains(q) || l.Autor.Contains(q));
            var items = await query.OrderBy(l => l.Titulo).Skip((page -1) * pageSize).Take(pageSize).ToListAsync(ct);
            return Ok(items.Select(x => x.ToReadLibroDto()).ToList());
        }
        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<ActionResult<LibroReadDto>>GetById(int id, CancellationToken ct) {
            var libro = await _db.Libros.AsNoTracking().FirstOrDefaultAsync(l => l.Id == id,ct);
            return libro is null ? NotFound() : Ok(libro.ToReadLibroDto());
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<ActionResult<LibroReadDto>> Create([FromBody]LibroCreateDto dto, CancellationToken ct) {
            var entity = new Libro {
                Titulo = dto.Titulo,
                Autor = dto.Autor,
                Categoria = dto.Categoria,
                Anio = dto.Anio,
                Disponible = true
            };
            _db.Libros.Add(entity);
                await _db.SaveChangesAsync(ct);
                return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity.ToReadLibroDto());
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin,Staff")]
        public async Task<ActionResult<LibroReadDto>>Update(int id, [FromBody]LibroUpdateDto dto, CancellationToken ct) {
            var entity = await _db.Libros.FirstOrDefaultAsync(l => l.Id == id,ct);
            if (entity is null) return NotFound();
            entity.Titulo = dto.Titulo;
            entity.Autor = dto.Autor;
            entity.Categoria = dto.Categoria;
            entity.Anio = dto.Anio;
            entity.Disponible = dto.Disponible;
            await _db.SaveChangesAsync(ct);
            return Ok(entity.ToReadLibroDto());
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id, CancellationToken ct) {
            var entity = await _db.Libros.FirstOrDefaultAsync(l => l.Id == id,ct);
            if (entity is null) return NotFound();
            _db.Libros.Remove(entity);
            await _db.SaveChangesAsync(ct);
            return NoContent();
        }

    }
}
