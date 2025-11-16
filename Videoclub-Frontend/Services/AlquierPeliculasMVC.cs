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

        public async Task<string>PostAlquiler(AlquilerPelicula nuevoAlquiler)
        {
            HttpResponseMessage response = await _http.PostAsJsonAsync("api/Alquiler/añadir", nuevoAlquiler);

            string cuerpo = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return cuerpo;
            }
            else
            {
                return "Error: " {cuerpo};
            }
        }
    }
}
