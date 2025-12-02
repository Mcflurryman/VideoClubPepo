using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoclubFinal.Models;
using VideoclubFinal.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;
using VideoclubFinal.data;

namespace PeliculasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculasController : ControllerBase
    {
        private readonly PeliculasDbContext _context;
        private readonly PeliculasServices _peliculasServices;
        public PeliculasController(PeliculasServices peliculasService, PeliculasDbContext context)
        {
            _context = context;
            _peliculasServices = peliculasService;
        }
        
        [HttpGet]
        public IActionResult GetPeliculas()
        {

            return Ok(_context.Peliculas);
        }

        [HttpGet("nombre/{nombre}")]
        public async Task<IActionResult> GetPeliculasNombre(string nombre)
        {
            try
            {

                var objetoPelicula = await _context.Peliculas.FirstOrDefaultAsync(p => p.Nombre == nombre);
                if (objetoPelicula == null)
                {
                    return NotFound("No existe una película con ese nombre.");
                }

                var objetoCantidad = await _context.PeliculasDisponibles.FirstOrDefaultAsync(c => c.IdPelicula == objetoPelicula.Id);

                List<PeliculasVistaCliente> ListaPeliculas = new List<PeliculasVistaCliente>()
            {
                new PeliculasVistaCliente()
                {
                    Nombre = objetoPelicula.Nombre,
                    Categoria = objetoPelicula.Categoria,
                    Duracion = (int)objetoPelicula.Duracion,
                    Cantidad = objetoCantidad.Cantidad
                }

            };
                return Ok(ListaPeliculas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPeliculasPorID(int id)
        {
            try
            {

                var resultado = await _context.Peliculas.FirstOrDefaultAsync(r => r.Id == id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");

            }
        }
        [HttpPost("añadir")]
        public async Task<IActionResult> PostPelicula([FromBody] Pelicula nuevaPelicula)
        {
            try
            {

                if (_peliculasServices.EsPeliculaDuplicada(nuevaPelicula.Nombre.ToString(), (int)nuevaPelicula.Duracion)){

                    return BadRequest("La pelicula ya existe");
                }
                
                _context.Peliculas.Add(nuevaPelicula);
                await _context.SaveChangesAsync();

                return Ok("La pelicula ha sido añadida");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }

        [HttpPost("añadir2")]
        public async Task<IActionResult> PostPelicula2([FromBody] PeliculasVistaCliente nuevaPelicula2)
        {
            try
            {

                PeliculasDisponible agregarCantidad = new PeliculasDisponible();

                bool existe = await _context.Peliculas
                    .AnyAsync(p => p.Nombre == nuevaPelicula2.Nombre && p.Duracion == nuevaPelicula2.Duracion);
                if (existe)
                {
                    return BadRequest("La pelicula ya existe");
                }

                if (nuevaPelicula2.Cantidad == null)
                {
                    return BadRequest("Inserte el campo cantidad porfavor");
                }

                Pelicula peliculaAgregar = new Pelicula();

                peliculaAgregar.Nombre = nuevaPelicula2.Nombre;
                peliculaAgregar.Categoria = nuevaPelicula2.Categoria;
                peliculaAgregar.Duracion = nuevaPelicula2.Duracion;



                _context.Peliculas.Add(peliculaAgregar);
                await _context.SaveChangesAsync();


                agregarCantidad.IdPelicula = peliculaAgregar.Id;
                agregarCantidad.Cantidad = nuevaPelicula2.Cantidad.Value;
                if (nuevaPelicula2.Cantidad > 0)
                {

                    peliculaAgregar = await _context.Peliculas.FirstOrDefaultAsync(p => p.Id == peliculaAgregar.Id);

                }
                if (nuevaPelicula2.Cantidad > 0)
                {
                    peliculaAgregar.EstaDisponible = true;
                }



                _context.PeliculasDisponibles.Add(agregarCantidad);
                await _context.SaveChangesAsync();

                return Ok("La pelicula y su cantidad han sido añadidas correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
        [HttpPut("editar/{id}")]
        public async Task<IActionResult> PutPelicula(int id, [FromBody] Pelicula editarPelicula)
        {
            try
            {
                var objetoPelicula =await _context.Peliculas.FirstOrDefaultAsync(p => p.Id == id);
                if (objetoPelicula == null)
                    return NotFound("No existe una película con ese ID.");

                bool existe = await _context.Peliculas.AnyAsync(n => n.Id != id && n.Nombre == editarPelicula.Nombre && n.Duracion == editarPelicula.Duracion);
                if (existe)
                {
                    return BadRequest("La pelicula que intentas editar ya existe");
                }

                if (objetoPelicula != null)
                {
                    objetoPelicula.Duracion = editarPelicula.Duracion;
                    objetoPelicula.Nombre = editarPelicula.Nombre;
                    objetoPelicula.Categoria = editarPelicula.Categoria;
                    await _context.SaveChangesAsync();
                    return Ok("La pelicula se ha modificado correctamente");
                }
                return BadRequest("No existe esa id");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }



        [HttpDelete("borrar/{id}")]
        public async Task<IActionResult> DeletePelicula(int id)
        {
            try
            {
                var pelicula = await _context.Peliculas.FirstOrDefaultAsync(e => e.Id == id);

                if (pelicula == null)
                {
                    return NotFound("La película no existe");
                }

                _context.Peliculas.Remove(pelicula);

                await _context.SaveChangesAsync();

                return Ok($"Se ha borrado la película con el id {id} correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
        [HttpPatch("editarDisponibilidad/{id}")]
        public async Task<IActionResult> PatchPelicula(int id, [FromBody] Pelicula EditarDisponibilidad)
        {
            try
            {
                var comprobarDisponibilidad =await _context.Peliculas.FirstOrDefaultAsync(c => c.Id == id);

                if (comprobarDisponibilidad.EstaDisponible == EditarDisponibilidad.EstaDisponible)
                {
                    return NotFound("Ya tenia el dato que le pasas");
                }
                if (comprobarDisponibilidad.EstaDisponible != EditarDisponibilidad.EstaDisponible)
                {
                    comprobarDisponibilidad.EstaDisponible = EditarDisponibilidad.EstaDisponible;
                }
               await _context.SaveChangesAsync();
                return Ok("Se ha cambiado el estado correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
    }
}