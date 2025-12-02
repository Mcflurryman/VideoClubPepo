using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using Videoclub.Frontend.Models;


    





namespace Videoclub.Frontend.Services
{
    internal class AlquilerPeliculasMVC
    {
        private readonly HttpClient _http;

        public AlquilerPeliculasMVC()
        {
            _http = new HttpClient()
            {
                BaseAddress = new Uri("https://localhost:7182/")
            };
        }

        public async Task<List<AlquilerPelicula>>GetAlquiler()
        {
            return await _http.GetFromJsonAsync<List<AlquilerPelicula>>("api/Alquiler");
        }

        public async Task<string> devolverPelicula(int id, AlquilerPelicula devolucion)
        {
            HttpResponseMessage response = await _http.PatchAsJsonAsync("api/Alquiler/devolucion/" + id, devolucion);

            string cuerpo = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return cuerpo;
            }
            else
            {
                return "Error: " + cuerpo;
            }
        }
        public async Task<string> PostAlquiler(AlquilerPelicula nuevoAlquiler)
        {
            HttpResponseMessage response = await _http.PostAsJsonAsync("api/Alquiler/añadir", nuevoAlquiler);

            string cuerpo = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return cuerpo;
            }
            else
            {
                return "Error: " + cuerpo;
            }
        }
        public async Task<List<AlquilerPelicula>>GetAlquilerPorNombre(string nombre)
        {
            return await _http.GetFromJsonAsync<List<AlquilerPelicula>>("api/Alquiler/"+ nombre);
        }
        public async Task<string> DeleteAlq(int id)
        {
           var response = await _http.DeleteAsync("api/Alquiler/borrar/" + id);
              return await response.Content.ReadAsStringAsync();
        }
    }
}
