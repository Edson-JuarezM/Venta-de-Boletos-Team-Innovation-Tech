﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Super_Champiñones.Contexto;

#nullable disable

namespace Super_Champiñones.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240606214310_SegundaMigracion")]
    partial class SegundaMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Super_Champiñones.Models.Miembro_Vip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Celular")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ci")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Miembro_Vips");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipoA")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("EquipoB")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Fecha_Hora")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Partidos");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("Rol")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("MiembroVipId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NroRecibo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PartidoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sector")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MiembroVipId");

                    b.HasIndex("PartidoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Venta", b =>
                {
                    b.HasOne("Super_Champiñones.Models.Miembro_Vip", "MiembroVip")
                        .WithMany("Ventas")
                        .HasForeignKey("MiembroVipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Champiñones.Models.Partido", "Partido")
                        .WithMany("Ventas")
                        .HasForeignKey("PartidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Super_Champiñones.Models.Usuario", "Usuario")
                        .WithMany("Ventas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MiembroVip");

                    b.Navigation("Partido");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Miembro_Vip", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Partido", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Super_Champiñones.Models.Usuario", b =>
                {
                    b.Navigation("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
