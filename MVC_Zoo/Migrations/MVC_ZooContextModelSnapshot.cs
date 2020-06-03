﻿// <auto-generated />
using System;
using MVC_Zoo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Zoo.Migrations
{
    [DbContext(typeof(MVC_ZooContext))]
    partial class MVC_ZooContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Zoo.Models.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion");

                    b.Property<string>("foto");

                    b.Property<string>("nombre_cient");

                    b.Property<string>("nombre_com");

                    b.HasKey("Id");

                    b.ToTable("Especie");
                });

            modelBuilder.Entity("MVC_Zoo.Models.Habitat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("clima");

                    b.Property<int?>("itinerarioId");

                    b.Property<string>("nombre");

                    b.Property<string>("vegetacion");

                    b.HasKey("Id");

                    b.HasIndex("itinerarioId");

                    b.ToTable("Habitat");
                });

            modelBuilder.Entity("MVC_Zoo.Models.HabitatEspecie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("especieId");

                    b.Property<int>("habitatId");

                    b.Property<int>("indice");

                    b.HasKey("Id");

                    b.HasIndex("especieId");

                    b.HasIndex("habitatId");

                    b.ToTable("HabitatEspecie");
                });

            modelBuilder.Entity("MVC_Zoo.Models.Itinerario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigo");

                    b.Property<int>("duracion");

                    b.Property<int>("longitud");

                    b.Property<int>("visitantes");

                    b.HasKey("Id");

                    b.ToTable("Itinerario");
                });

            modelBuilder.Entity("MVC_Zoo.Models.Habitat", b =>
                {
                    b.HasOne("MVC_Zoo.Models.Itinerario", "itinerario")
                        .WithMany("habitats")
                        .HasForeignKey("itinerarioId");
                });

            modelBuilder.Entity("MVC_Zoo.Models.HabitatEspecie", b =>
                {
                    b.HasOne("MVC_Zoo.Models.Especie", "especie")
                        .WithMany("habitatEspecies")
                        .HasForeignKey("especieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MVC_Zoo.Models.Habitat", "habitat")
                        .WithMany("habitatEspecies")
                        .HasForeignKey("habitatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
