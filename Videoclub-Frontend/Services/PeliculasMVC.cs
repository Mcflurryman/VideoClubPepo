using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using Videoclub.Frontend.Models;


namespace Videoclub.Frontend.Services;

public class PeliculasMVC
{
    private readonly HttpClient _http;

    public PeliculasMVC()
    {
        _http = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7182/")
        };
    }

    public async Task<List<Pelicula>> GetPeliculas()
    {
        return await _http.GetFromJsonAsync<List<Pelicula>>("api/Peliculas");
    }

    public async Task<string> DeletePelicula(int id)
    {
        var response = await _http.DeleteAsync("api/Peliculas/borrar/" + id);

        return await response.Content.ReadAsStringAsync();
    }


}

