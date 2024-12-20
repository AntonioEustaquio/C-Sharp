﻿// <auto-generated />
using BibliotecaApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BibliotecaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("BibliotecaApi.Models.Biblioteca", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("contato")
                        .HasColumnType("TEXT");

                    b.Property<string>("fim_funcionamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("inauguracao")
                        .HasColumnType("TEXT");

                    b.Property<string>("inicio_funcionamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Bibliotecas");
                });
#pragma warning restore 612, 618
        }
    }
}
