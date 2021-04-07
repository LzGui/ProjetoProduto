﻿// <auto-generated />
using Aula2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aula2.Migrations
{
    [DbContext(typeof(LocalDbContext))]
    [Migration("20210406220446_Primeiro Migrations")]
    partial class PrimeiroMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Aula2.Entities.Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("categorianome")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("Aula2.Entities.Produto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.Property<string>("nome")
                        .HasColumnType("text");

                    b.Property<int>("valor")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("produto");
                });
#pragma warning restore 612, 618
        }
    }
}
