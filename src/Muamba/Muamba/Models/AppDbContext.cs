using Microsoft.EntityFrameworkCore;
using Muamba.Models;
using SiteMuamba.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

    {

    }
    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Viagem> Viagens { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Negociacao> Negociacoes { get; set; }

    public DbSet<Avaliacao> Avaliacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Negociacao>().Navigation(n => n.Produto).AutoInclude(true);
        modelBuilder.Entity<Negociacao>().Navigation(n => n.Viagem).AutoInclude(true);
        modelBuilder.Entity<Negociacao>().Navigation(n => n.Comprador).AutoInclude(true);
        modelBuilder.Entity<Viagem>().Navigation(v => v.UsuarioViajante).AutoInclude(true);
    }
}

