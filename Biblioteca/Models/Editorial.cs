using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class Editorial
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string? Description { get; set; }

    [Unicode(false)]
    public string? Status { get; set; }
}
