using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using Videoclub.Frontend.Models;
using VideoClub.Backend.Models;


namespace Videoclub.Frontend.Services;

public class VistaClienteAlquilerMVC
{
    private readonly HttpClient _http;

    public VistaClienteAlquilerMVC()
    {
        _http = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:7182/")
        };
    }
    public async Task<List<VistaClienteAlquiler>> GetAlquilerPorNombre (string nombre)
    {
        return await _http.GetFromJsonAsync<List<VistaClienteAlquiler>>("api/Alquiler/nombre/" + nombre);
    }
    public async Task<string> PostAlquiler(AlquilerPelicula nuevoAlquiler)
    {
        HttpResponseMessage response = await _http.PatchAsJsonAsync("api/Alquiler/añadir", nuevoAlquiler);

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
}







