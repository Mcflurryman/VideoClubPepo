using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Videoclub.Frontend.Models;

public partial class PeliculasVistaCliente
{


    public string? Nombre { get; set; } = null!;

    public string Categoria { get; set; }

    public int Duracion { get; set; }

    public int? Cantidad { get; set; }
}
