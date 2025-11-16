using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VideoclubFinal.Models;

public partial class PeliculasVistaCliente
{


    [Column("nombreCliente")]
    [StringLength(50)]
    public string? Nombre { get; set; } = null!;

    public string Categoria { get; set; }

    public int Duracion { get; set; }

    public int? Cantidad { get; set; }
}
