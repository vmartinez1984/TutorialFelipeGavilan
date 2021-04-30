﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreEjemplos
{
    class ApplicationDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9CVRRTC\\SQLEXPRESS;Database=PruebaEF;User Id=sa;Password=123456;")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));            
        }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Escuela> Escuela { get; set; }
    }
}
