﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenomaApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241126223350_Inicializar")]
    partial class Inicializar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Individuo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Individuos");
                });

            modelBuilder.Entity("Sequencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IndividuoId")
                        .HasColumnType("int");

                    b.Property<string>("SeqGenetica")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IndividuoId");

                    b.ToTable("Sequencias");
                });

            modelBuilder.Entity("Sequencia", b =>
                {
                    b.HasOne("Individuo", "Individuo")
                        .WithMany()
                        .HasForeignKey("IndividuoId");

                    b.Navigation("Individuo");
                });
#pragma warning restore 612, 618
        }
    }
}