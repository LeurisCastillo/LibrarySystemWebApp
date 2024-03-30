using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Models;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<BibliographyType> BibliographyTypes { get; set; }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<Editorial> Editorials { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<LoanAndReturn> LoanAndReturns { get; set; }

    public virtual DbSet<User> Users { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Server=localhost;Database=LibrarySystem;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Editorial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Editoria__3214EC07E59E00AE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
