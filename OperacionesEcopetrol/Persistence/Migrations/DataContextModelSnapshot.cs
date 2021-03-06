﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("Model.CentroLogistico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("AreaBodegas")
                        .HasColumnType("REAL");

                    b.Property<double>("AreaCFrios")
                        .HasColumnType("REAL");

                    b.Property<double>("AreaCQuimicos")
                        .HasColumnType("REAL");

                    b.Property<double>("AreaPatios")
                        .HasColumnType("REAL");

                    b.Property<string>("Bodegas")
                        .HasColumnType("TEXT");

                    b.Property<string>("CentrosProdAtiendad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Codigo")
                        .HasColumnType("TEXT");

                    b.Property<string>("CuartosFrios")
                        .HasColumnType("TEXT");

                    b.Property<string>("CuartosQuimicos")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dependencia")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Patios")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CentroLogisticos");
                });

            modelBuilder.Entity("Model.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Alto")
                        .HasColumnType("REAL");

                    b.Property<double>("Ancho")
                        .HasColumnType("REAL");

                    b.Property<string>("Bodega")
                        .HasColumnType("TEXT");

                    b.Property<string>("Campo")
                        .HasColumnType("TEXT");

                    b.Property<double>("CantidadUm")
                        .HasColumnType("REAL");

                    b.Property<string>("CodigoMaterial")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("DetieneOperacion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaFacturacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImporteMl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Largo")
                        .HasColumnType("REAL");

                    b.Property<string>("ModoAlmacenamiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Moneda")
                        .HasColumnType("TEXT");

                    b.Property<string>("NumPedido")
                        .HasColumnType("TEXT");

                    b.Property<double>("Peso")
                        .HasColumnType("REAL");

                    b.Property<string>("Proveedor")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProveedorCentroSuministrador")
                        .HasColumnType("TEXT");

                    b.Property<double>("SafetyStock")
                        .HasColumnType("REAL");

                    b.Property<double>("Tiempo")
                        .HasColumnType("REAL");

                    b.Property<string>("Tipo")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoCargue")
                        .HasColumnType("TEXT");

                    b.Property<string>("TipoTransporte")
                        .HasColumnType("TEXT");

                    b.Property<string>("UbicacionProveedor")
                        .HasColumnType("TEXT");

                    b.Property<string>("UnidadMedida")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Inventarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alto = 7.0,
                            Ancho = 7.0,
                            Bodega = "Value 101",
                            Campo = "Value 101",
                            CantidadUm = 7.0,
                            CodigoMaterial = "Value 101",
                            Data = "Value 101",
                            Descripcion = "Value 101",
                            DetieneOperacion = "Value 101",
                            FechaFacturacion = new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImporteMl = "Value 101",
                            Largo = 7.0,
                            ModoAlmacenamiento = "Value 101",
                            Moneda = "Value 101",
                            NumPedido = "Value 101",
                            Peso = 7.0,
                            Proveedor = "Value 101",
                            ProveedorCentroSuministrador = "Value 101",
                            SafetyStock = 7.0,
                            Tiempo = 7.0,
                            Tipo = "Value 101",
                            TipoCargue = "Value 101",
                            TipoTransporte = "Value 101",
                            UbicacionProveedor = "Value 101",
                            UnidadMedida = "Value 101"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
