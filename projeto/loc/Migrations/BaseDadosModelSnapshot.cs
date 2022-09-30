﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using locadora;

#nullable disable

namespace loc.Migrations
{
    [DbContext(typeof(BaseDados))]
    partial class BaseDadosModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("locadora.Alocar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("dataAloc")
                        .HasColumnType("TEXT");

                    b.Property<int>("idFilme")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Alocacoes");
                });

            modelBuilder.Entity("locadora.Filme", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("dataLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("diretor")
                        .HasColumnType("TEXT");

                    b.Property<string>("genero")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("locadora.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<int>("idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
