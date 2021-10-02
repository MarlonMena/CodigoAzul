﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mintic.App.Persistencia.AppRepositories;

namespace Mintic.App.Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20210926053319_ActualizacionEstudiante")]
    partial class ActualizacionEstudiante
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Mintic.App.Dominio.Ciclo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodigoCiclo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciclo");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Grupo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CicloGrupoId")
                        .HasColumnType("int");

                    b.Property<string>("CodigoGrupo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FormadorId")
                        .HasColumnType("int");

                    b.Property<int?>("TutorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CicloGrupoId");

                    b.HasIndex("FormadorId");

                    b.HasIndex("TutorId");

                    b.ToTable("Grupos");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Nota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<double>("Calificacion")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Departamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fijo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RolPersonaId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RolPersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CodigoRol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreRol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Estudiante", b =>
                {
                    b.HasBaseType("Mintic.App.Dominio.Persona");

                    b.Property<int?>("GrupoEstudianteId")
                        .HasColumnType("int");

                    b.HasIndex("GrupoEstudianteId");

                    b.HasDiscriminator().HasValue("Estudiante");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Grupo", b =>
                {
                    b.HasOne("Mintic.App.Dominio.Ciclo", "CicloGrupo")
                        .WithMany()
                        .HasForeignKey("CicloGrupoId");

                    b.HasOne("Mintic.App.Dominio.Persona", "Formador")
                        .WithMany()
                        .HasForeignKey("FormadorId");

                    b.HasOne("Mintic.App.Dominio.Persona", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");

                    b.Navigation("CicloGrupo");

                    b.Navigation("Formador");

                    b.Navigation("Tutor");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Nota", b =>
                {
                    b.HasOne("Mintic.App.Dominio.Estudiante", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.Navigation("Alumno");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Persona", b =>
                {
                    b.HasOne("Mintic.App.Dominio.Rol", "RolPersona")
                        .WithMany()
                        .HasForeignKey("RolPersonaId");

                    b.Navigation("RolPersona");
                });

            modelBuilder.Entity("Mintic.App.Dominio.Estudiante", b =>
                {
                    b.HasOne("Mintic.App.Dominio.Grupo", "GrupoEstudiante")
                        .WithMany()
                        .HasForeignKey("GrupoEstudianteId");

                    b.Navigation("GrupoEstudiante");
                });
#pragma warning restore 612, 618
        }
    }
}
