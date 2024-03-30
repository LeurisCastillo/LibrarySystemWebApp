using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class Employee
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Identification { get; set; } = null!;

    public string ScheduleType { get; set; } = null!;

    public string ComissionPercentage { get; set; } = null!;

    public DateTime EntryDate { get; set; }

    public string Status { get; set; } = null!;
}
