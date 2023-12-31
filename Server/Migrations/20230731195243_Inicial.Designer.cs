﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanzApp.Server.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230731195243_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Ahorros", b =>
                {
                    b.Property<int>("AhorroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("FrecuenciaAhorro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("MontoMeta")
                        .HasColumnType("REAL");

                    b.Property<string>("NombreMeta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AhorroId");

                    b.ToTable("Ahorros");
                });

            modelBuilder.Entity("Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cuenta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Monto = 0.0,
                            NombreCliente = "Nathaly Goris"
                        });
                });

            modelBuilder.Entity("Deudas", b =>
                {
                    b.Property<int>("DeudaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("TEXT");

                    b.Property<double>("MontoTotal")
                        .HasColumnType("REAL");

                    b.Property<string>("NombreAcreedor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoDeuda")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("DeudaId");

                    b.ToTable("Deudas");
                });

            modelBuilder.Entity("Gastos", b =>
                {
                    b.Property<int>("GastoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("MetodoDePago")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Total")
                        .HasColumnType("REAL");

                    b.HasKey("GastoId");

                    b.ToTable("Gastos");
                });

            modelBuilder.Entity("GastosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .HasColumnType("TEXT");

                    b.Property<int>("GastosId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lugar")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("DetalleId");

                    b.HasIndex("GastosId");

                    b.ToTable("GastosDetalle");
                });

            modelBuilder.Entity("Ingresos", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<double>("Monto")
                        .HasColumnType("REAL");

                    b.HasKey("IngresoId");

                    b.ToTable("Ingresos");
                });

            modelBuilder.Entity("GastosDetalle", b =>
                {
                    b.HasOne("Gastos", null)
                        .WithMany("DetalleGastos")
                        .HasForeignKey("GastosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gastos", b =>
                {
                    b.Navigation("DetalleGastos");
                });
#pragma warning restore 612, 618
        }
    }
}
