﻿using HolaMundo.Data;
using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo.Services
{
    public class PaisRepositorioEf : IRepositorioPais
    {
        public PaisRepositorioEf(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;

        }

        public ApplicationDbContext DbContext { get; }

        public List<Pais> ObtenerTodos()
        {
            return DbContext.Paises.ToList();
        }
    }
}
