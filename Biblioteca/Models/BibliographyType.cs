using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class BibliographyType
{
    [Key]
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Status { get; set; } = null!;
}
