using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class Autor
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string OriginCountry { get; set; } = null!;

    public string NativeLanguage { get; set; } = null!;

    [Column("status")]
    public string Status { get; set; } = null!;
}
