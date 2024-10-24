﻿// <auto-generated />
using ElizabethGuerron_TallerLigaPro.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElizabethGuerron_TallerLigaPro.Migrations
{
    [DbContext(typeof(ElizabethGuerron_TallerLigaProContext))]
    [Migration("20241023222757_MigracionInicialLiga")]
    partial class MigracionInicialLiga
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AceptaExtranjeros")
                        .HasColumnType("bit");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estadio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEstadio")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titulos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadio")
                        .IsUnique();

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Estadio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Estadio");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<int>("IdEquipo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Posicion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdEquipo");

                    b.ToTable("Jugador");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Equipo", b =>
                {
                    b.HasOne("ElizabethGuerron_TallerLigaPro.Models.Estadio", "estadio")
                        .WithOne("Equipo")
                        .HasForeignKey("ElizabethGuerron_TallerLigaPro.Models.Equipo", "IdEstadio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("estadio");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Jugador", b =>
                {
                    b.HasOne("ElizabethGuerron_TallerLigaPro.Models.Equipo", "Equipo")
                        .WithMany("Jugadores")
                        .HasForeignKey("IdEquipo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipo");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Equipo", b =>
                {
                    b.Navigation("Jugadores");
                });

            modelBuilder.Entity("ElizabethGuerron_TallerLigaPro.Models.Estadio", b =>
                {
                    b.Navigation("Equipo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
