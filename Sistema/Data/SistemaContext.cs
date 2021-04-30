using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema.Models;

namespace Sistema.Data
{
    public class SistemaContext : DbContext
    {
        public SistemaContext (DbContextOptions<SistemaContext> options)
            : base(options)
        {
        }

        public DbSet<Sistema.Models.Categoria> Categoria { get; set; }
        public DbSet<Sistema.Models.Curso> Curso { get; set; }
    }
}
