using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();

            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programción", Descripcion= "Curso", IsActivo= true},
                new Categoria{Nombre="Dise;o gráfico", Descripcion= "Curso", IsActivo= true},
            };

            foreach (var item in categorias)
            {
                context.Categoria.Add(item);
            }
            context.SaveChanges();
        }
    }
}
