﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace odontoschedule_backand.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base (Options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet <Consumo> Consumos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }


    }
}
