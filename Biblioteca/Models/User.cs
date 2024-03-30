using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Identification { get; set; } = null!;

    public string LicenseNumber { get; set; } = null!;

    public string PersonType { get; set; } = null!;

    public string Status { get; set; } = null!;
}
