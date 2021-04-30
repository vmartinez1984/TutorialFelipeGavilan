﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreEjemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Practica de EntityFrameWork");
            Console.WriteLine("2021/04/29 22:22");
            Console.WriteLine("Víctor Martínez");
            //Add();
            GetAll();
            //Update();
            //Update2();
            //using (var dbContext = new ApplicationDbContext())
            //{
            //    Estudiante estudiante;
                
            //    estudiante = new Estudiante
            //    {
            //        Nombre = "Wanabana",
            //        Edad = 11,
            //        Direccion = new Direccion
            //        {
            //            Calle = "Bolivar 438"
            //        }
            //    };

            //    dbContext.Add(estudiante);
            //    dbContext.SaveChanges();
            //}

            Console.WriteLine("Listo");
            Console.ReadLine();
        }

        private static void Update2()
        {
            Estudiante estudiante;
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                estudiante = dbContext.Estudiante.Where(x => x.Id == 1).FirstOrDefault();
            }

            estudiante.Nombre = "Víctor Martinez Bravo";

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                dbContext.Entry(estudiante).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        private static void Update()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Estudiante estudiante;

                estudiante = dbContext.Estudiante.Where(x => x.Id == 1).FirstOrDefault();
                estudiante.Nombre = "Víctor Martinez";

                dbContext.SaveChanges();
            }
        }

        private static void GetAll()
        {
            List<Estudiante> lista;

            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                lista = dbContext.Estudiante.Include(x=>x.Direccion).ToList();
            }

            lista.ForEach(estudiante =>
            {
                Console.WriteLine(estudiante.Nombre + " "+estudiante.Direccion.Calle);
            });
        }

        private static void Add()
        {
            using (ApplicationDbContext dbContext = new ApplicationDbContext())
            {
                Estudiante estudiante;

                estudiante = new Estudiante { Nombre = "Estudiante" };
                dbContext.Estudiante.Add(estudiante);

                dbContext.SaveChanges();
            }
        }
    }

    class Escuela
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public List<Estudiante> ListaDeEstudiantes { get; set; }
    }
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? Edad { get; set; }
        public int? EscuelaId { get; set; }
        public Direccion Direccion { get; set; }
    }

    class Direccion
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public int EstudianteId { get; set; }
    }
}
