using System;
using System.Collections.Generic;

namespace VideoClub.Backend.Models;

public partial class VistaClienteAlquiler
{
    public string? NombrePelicula { get; set; }

    public Nullable<int> IdPelicula { get; set; }

    public string NombreCliente { get; set; }

    public DateOnly? FechaAlquiler { get; set; }

    public DateOnly? FechaDevolucion { get; set; }
}