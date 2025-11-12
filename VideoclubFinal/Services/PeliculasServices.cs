using Microsoft.AspNetCore.Http.HttpResults;
using PeliculasAPI.Controllers;
using System.Reflection.Metadata.Ecma335;
using Videoclub.Shared.Data;
using VideoclubFinal.Models;

namespace VideoclubFinal.Services
{
    public class PeliculasServices
    {
        private readonly PeliculasDbContext _context;
        public PeliculasServices(PeliculasDbContext context)
        {
            _context = context;
        }
            public bool EsPeliculaDuplicada(string nombre, int duracion)
            {
                //tremenda fumada de linea que comprueba si existe un duplicado de pelcula al añadirla   
                return !_context.Peliculas.Any(p => p.Nombre.ToLower() == nombre.ToLower() && p.Duracion == duracion);
          
            }
          public bool ComprobarSiPuedeAlquilar (int idPelicula, string nombreCliente)
          {
              // Comprueba si el cliente ya ha alquilado la misma película

              if( _context.AlquilerPeliculas.Any(a => a.IdPelicula == idPelicula && a.NombreCliente.ToLower() == nombreCliente.ToLower()))
                {
                return true;
                }
              return false;
          }
        public bool ComprobarDisponibilidadPelicula(int idPelicula)
        {
            // comprueba si la pelicula con el mismo id esta disponible
            if (_context.Peliculas.Where(p => p.Id == idPelicula && p.EstaDisponible == true).Any())
            {
                return true;
            }
            return false;
        }
    }
}
