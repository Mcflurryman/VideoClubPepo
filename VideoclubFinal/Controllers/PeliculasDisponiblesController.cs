using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Videoclub.Shared.Data;
using VideoclubFinal.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PeliculasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisponiblesController : ControllerBase
    {
        private readonly PeliculasDbContext _context;
        public DisponiblesController(ILogger<DisponiblesController> logger, PeliculasDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCantidades()
        {
            try
            {
                var resultado = await _context.PeliculasDisponibles
                                .Join(
                                    _context.Peliculas,
                                    disponible => disponible.IdPelicula,
                                    pelicula => pelicula.Id,
                                    (disponible, pelicula) => new
                                    {
                                        Id = disponible.IdPelicula,
                                        Nombre = pelicula.Nombre,
                                        Cantidad = disponible.Cantidad
                                    }
                                )
                                .ToListAsync();

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
    }








}
