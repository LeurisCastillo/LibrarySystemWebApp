using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class LoanAndReturn
{
    [Key]
    public int Id { get; set; }

    public string Employee { get; set; } = null!;

    public string Book { get; set; } = null!;

    public string User { get; set; } = null!;

    public DateTime LoanDate { get; set; }

    public DateTime ReturnDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PricePerDay { get; set; }

    public int Days { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Comments { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Status { get; set; }
}
