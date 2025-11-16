using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VideoclubFinal.Models;

public partial class Pelicula
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Categoria { get; set; } = null!;

    public int? Duracion { get; set; }

    [Column("estaDisponible")]
    public bool? EstaDisponible { get; set; } = false;


}
