using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Videoclub.Frontend.Models;

public partial class PeliculasDisponible
{
   [Key] public int IdPelicula { get; set; }


    public int Cantidad { get; set; }

    [ForeignKey("IdPelicula")]
    public virtual Pelicula? IdPeliculaNavigation { get; set; } = null!;
}
