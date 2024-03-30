using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class Book
{
    [Key]
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string TopographicSignature { get; set; } = null!;

    [Column("ISBN")]
    public string Isbn { get; set; } = null!;

    public string Autors { get; set; } = null!;

    public string Editorial { get; set; } = null!;

    public DateTime PublishedDate { get; set; }

    public string Science { get; set; } = null!;

    public string Language { get; set; } = null!;

    public string Status { get; set; } = null!;
}
