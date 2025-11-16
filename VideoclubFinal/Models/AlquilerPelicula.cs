using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VideoclubFinal.Models;

public partial class AlquilerPelicula
{
    [Key]
    public int Id { get; set; }

    public int? IdPelicula { get; set; }

    [Column("nombreCliente")]
    [StringLength(50)]
    public string? NombreCliente { get; set; } = null!;

    public DateOnly? FechaAlquiler { get; set; }

    public DateOnly? FechaDevolucion { get; set; }

   
   
}
