using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoClub.Backend.Models;
using VideoclubFinal.data;
using VideoclubFinal.Models;
using VideoclubFinal.Services;


namespace PeliculasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilerController : ControllerBase
    {
        private readonly PeliculasDbContext _context;
        private readonly PeliculasServices _peliculasServices;
        public AlquilerController(PeliculasServices peliculasServices, PeliculasDbContext context)
        {
            _context = context;
            _peliculasServices = peliculasServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAlquiler()
        {

            return Ok( _context.AlquilerPeliculas);
        }
     
        [HttpGet("nombre/{nombre}")]
        public async Task<IActionResult> GetAlquilerPorNombre(string nombre)
        {
            var alquileres = await _context.AlquilerPeliculas
                .Where(a => a.NombreCliente == nombre)
                .ToListAsync();

            var resultado = alquileres.Select(p => new VistaClienteAlquiler
            {
                NombreCliente = p.NombreCliente,
                IdPelicula = p.IdPelicula,
                FechaAlquiler = p.FechaAlquiler,
                FechaDevolucion = p.FechaDevolucion,
                NombrePelicula = _context.Peliculas
                     .Where(o => o.Id == p.IdPelicula)
                     .Select(g => g.Nombre)
                     .FirstOrDefault()
            }).ToList();

            return Ok(resultado);
        }



        [HttpGet("{id}")]
        public async Task<IActionResult> GetAlquilerPorId(int id)
        {
            try
            {
                var ObjetoPelicula = await _context.AlquilerPeliculas.FirstOrDefaultAsync(p => p.Id == id);

                if (ObjetoPelicula is not null)
                {
                    return Ok(ObjetoPelicula);
                }
                else

                    return NotFound("Esa id no existe");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
        [HttpGet("Ejercicio1")]
        public async Task<IActionResult> GetEjercicio1()
        {
           var lista =  _context.Peliculas.Join(
                _context.AlquilerPeliculas,
                pelicula => pelicula.Id,
                alquiler => alquiler.IdPelicula,
                (pelicula, alquiler) => new
                {
                    nombrePelicula = pelicula.Nombre,
                    idPelicula = alquiler.IdPelicula
                }
            );
            return Ok(lista);
        }
        [HttpGet("Ejercicio2")]
        public async Task<IActionResult> GetEjercicio2()
        {
            var lista = _context.AlquilerPeliculas.Join(
                        _context.Peliculas,
                        a => a.IdPelicula,
                        p => p.Id,
                        (a, p) => new
                        {
                            nombreCliente = a.NombreCliente,
                            nombrePelicula = p.Nombre,
                            fecha = a.FechaDevolucion
                        }
                    ).Where(c => c.fecha == null)
                    .Select(a => new
                    {
                        a.nombreCliente,
                        a.nombrePelicula
                    });
            return Ok(lista);
            
        }
        [HttpGet("Ejercicio3")]
        public async Task<IActionResult> GetEjercicio3()
        {
            var lista = _context.AlquilerPeliculas.Join(
                        _context.Peliculas,
                        a => a.IdPelicula,
                        p => p.Id,
                        (a, p) => new
                        {
                            nombreCliente = a.NombreCliente,
                            nombrePelicula = p.Nombre,
                            fecha = a.FechaDevolucion
                        }
                    ).Where(c => c.fecha != null)
                    .Select(a => new
                    {
                        a.nombreCliente,
                        a.nombrePelicula
                    });
            return Ok(lista);

        }
        [HttpGet("Ejercicio4")]
        public async Task<IActionResult> GetEjercicio4()
        {
            var lista = _context.AlquilerPeliculas.Join(
                        _context.Peliculas,
                        a => a.IdPelicula,
                        p => p.Id,
                        (a, p) => new
                        {
                            nombreCliente = a.NombreCliente,
                            nombrePelicula = p.Nombre,
                            fechaAlquiler = a.FechaAlquiler
                        }
                    )
                .GroupBy(e => e.nombrePelicula)
                .Select(g => new
                {
                    nombrePelicula = g.Key,
                    numeroDeAlquiladas = g.Count()
                });
            return Ok(lista);

            
        }

        [HttpGet("Ejercicio7")]
        public async Task<IActionResult> GetEjercicio7()
        {
            var PeliculasNoDevueltas = await _context.AlquilerPeliculas.Join(
                                        _context.Peliculas,
                                        alquiler => alquiler.IdPelicula,
                                        pelicula => pelicula.Id,
                                        (alqui, peli) => new
                                        {
                                            nombreCliente = alqui.NombreCliente,
                                            nombrePelicula = peli.Nombre,
                                            fechaDevolucion = alqui.FechaDevolucion

                                        }
                                ).Where(a => a.fechaDevolucion == null)
                                  .Select(o => new
                                  {
                                      nombreCliente = o.nombreCliente,
                                      nombrePelicula = o.nombrePelicula
                                  }).ToListAsync();
                                        

            return Ok(PeliculasNoDevueltas);

        }
        [HttpGet("Ejercicio8")]
        public async Task<IActionResult> GetEjercicio8()
        {
            var PeliculasNoDevueltas =  _context.AlquilerPeliculas.Join(
                                        _context.Peliculas,
                                        alquiler => alquiler.IdPelicula,
                                        pelicula => pelicula.Id,
                                        (alqui, peli) => new
                                        {
                                            nombreCliente = alqui.NombreCliente,
                                            nombrePelicula = peli.Nombre,
                                            fechaAlquiler = alqui.FechaAlquiler.Value.ToDateTime(TimeOnly.MinValue)
                                        }
                                        )
                                         .AsEnumerable()
                                         .OrderByDescending(x => x.fechaAlquiler)
                                         .Take(3)
                                         .Select(g => new
                                         {
                                             nombreCliente = g.nombreCliente,
                                             nombrePelicula = g.nombrePelicula,
                                             Fechaalquiler = g.fechaAlquiler
                                         }).ToList();

            return Ok(PeliculasNoDevueltas);



        }
        [HttpGet("Ejercicio9")]
        public async Task<IActionResult> GetEjercicio9()
        {
            var NombreyPeliculas = await _context.AlquilerPeliculas.GroupBy(
                                    x => x.NombreCliente)
                                    .Select(g => new
                                    {
                                        nombreCliente = g.Key,
                                        PeliculasAlquiladas = g.Count()
                                    }).OrderByDescending(x => x.PeliculasAlquiladas)
                                    .ToListAsync();
            return Ok(NombreyPeliculas);

        }

        [HttpPost("añadir")]
        public async Task<IActionResult> PostAlquiler([FromBody] AlquilerPelicula nuevoAlquiler)
        {
            try
            {

                Pelicula BuscarPelicula = new Pelicula();


                 if (_peliculasServices.ComprobarSiPuedeAlquilar((int)nuevoAlquiler.IdPelicula, nuevoAlquiler.NombreCliente))
                { 
                    return BadRequest("Solo puedes alquilar la misma pelicula una sola vez por persona");
                }
                var ObjetoPelicula = await _context.Peliculas.FirstOrDefaultAsync(p => p.Id == nuevoAlquiler.IdPelicula);

                if (ObjetoPelicula == null)
                {
                    return BadRequest("La pelicula que intentas alquilar no existe");
                }
                if (!_peliculasServices.ComprobarDisponibilidadPelicula((int)nuevoAlquiler.IdPelicula))
                {
                    return BadRequest("La pelicula que intentas alquilar no esta disponible");
                }
                var objetoCantidad = await _context.PeliculasDisponibles.FirstOrDefaultAsync(c => c.IdPelicula == nuevoAlquiler.IdPelicula);
                if (objetoCantidad == null)
                {
                    return BadRequest("No hay copias disponibles de la pelicula que intentas alquilar");
                }

                if (!_peliculasServices.ComprobarDisponibilidadPelicula((int)nuevoAlquiler.IdPelicula))
                {
                    return BadRequest("La pelicula que intentas alquilar no esta disponible");
                }
                else if (objetoCantidad.Cantidad > 0)
                {
                    objetoCantidad.Cantidad--;
                }
                if (objetoCantidad.Cantidad == 0)
                {
                    ObjetoPelicula.EstaDisponible = false;
                }
                if (nuevoAlquiler.FechaAlquiler == null)
                {
                    nuevoAlquiler.FechaAlquiler = DateOnly.FromDateTime(DateTime.Now);
                }


                _context.AlquilerPeliculas.Add(nuevoAlquiler);
                _context.PeliculasDisponibles.Update(objetoCantidad);
                await _context.SaveChangesAsync();
                return Ok("El alquiler a nombre de " + nuevoAlquiler.NombreCliente + " ha sido añadido");

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }

        [HttpPatch("devolucion/{id}")]
        public async Task <IActionResult> devolverPelicula(int id, [FromBody] AlquilerPelicula Devolucion)
        {
            try
            {
                Pelicula ObjetoPelicula1 = new Pelicula();

                var ObjetoAlquiler = await _context.AlquilerPeliculas.Where(a => a.IdPelicula == id && a.NombreCliente == Devolucion.NombreCliente && a.FechaDevolucion == null).FirstOrDefaultAsync();
                var ObjetoCantidad = await _context.PeliculasDisponibles.FirstOrDefaultAsync(c => c.IdPelicula == id);
                var ObjetoPelicula = await _context.Peliculas.FirstOrDefaultAsync(p => p.Id == id);

                if (ObjetoAlquiler == null) 
                {
                    return BadRequest("No existe un alquiler con esa id y ese nombre de cliente");
                }
                if (Devolucion.FechaDevolucion == null)
                {
                    ObjetoAlquiler.FechaDevolucion = DateOnly.FromDateTime(DateTime.Now);



                    if (ObjetoPelicula.EstaDisponible == true)
                    {
                        ObjetoCantidad.Cantidad++;

                    }
                    else if (ObjetoPelicula.EstaDisponible == false)
                    {
                        ObjetoCantidad.Cantidad++;
                        ObjetoPelicula.EstaDisponible = true;

                    }
                }
                else
                {
                    return BadRequest("Inserte una fecha de alquiler valida");
                }
                
                await _context.SaveChangesAsync();

                return Ok("La fecha de alquiler se ha introducido correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }

        }
        [HttpDelete("borrar/{id}")]
        public async Task<IActionResult> DeleteAlq(int id)
        {
            try
            {
                var borrar = await _context.AlquilerPeliculas.FirstOrDefaultAsync(e => e.Id == id);

                if (borrar == null)
                {
                    return NotFound("El alquiler no existe");
                }
                await _context.SaveChangesAsync();
                return Ok("Se ha el alquiler con el id " + id + " correctamente");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno del servidor ");
            }
        }
    }
}

