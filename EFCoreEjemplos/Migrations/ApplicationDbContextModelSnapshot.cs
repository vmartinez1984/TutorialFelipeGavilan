﻿// <auto-generated />
using System;
using EFCoreEjemplos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreEjemplos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreEjemplos.Direccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle");

                    b.Property<int>("EstudianteId");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId")
                        .IsUnique();

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("EFCoreEjemplos.Escuela", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Escuela");
                });

            modelBuilder.Entity("EFCoreEjemplos.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Edad");

                    b.Property<int?>("EscuelaId");

                    b.Property<string>("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("EscuelaId");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("EFCoreEjemplos.Direccion", b =>
                {
                    b.HasOne("EFCoreEjemplos.Estudiante")
                        .WithOne("Direccion")
                        .HasForeignKey("EFCoreEjemplos.Direccion", "EstudianteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreEjemplos.Estudiante", b =>
                {
                    b.HasOne("EFCoreEjemplos.Escuela")
                        .WithMany("ListaDeEstudiantes")
                        .HasForeignKey("EscuelaId");
                });
#pragma warning restore 612, 618
        }
    }
}
