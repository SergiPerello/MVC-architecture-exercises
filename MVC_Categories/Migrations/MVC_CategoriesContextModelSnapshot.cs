﻿// <auto-generated />
using System;
using MVC_Categories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Categories.Migrations
{
    [DbContext(typeof(MVC_CategoriesContext))]
    partial class MVC_CategoriesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Categories.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });
#pragma warning restore 612, 618
        }
    }
}
