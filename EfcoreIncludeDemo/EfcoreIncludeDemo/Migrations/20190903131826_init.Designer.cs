﻿// <auto-generated />
using System;
using EfcoreIncludeDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfcoreIncludeDemo.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20190903131826_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfcoreIncludeDemo.Models.Model1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataModel1");

                    b.HasKey("Id");

                    b.ToTable("Model1s");
                });

            modelBuilder.Entity("EfcoreIncludeDemo.Models.Model2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataModel2");

                    b.Property<int?>("Model1Id");

                    b.Property<int?>("Model3Id");

                    b.HasKey("Id");

                    b.HasIndex("Model1Id");

                    b.HasIndex("Model3Id");

                    b.ToTable("Model2s");
                });

            modelBuilder.Entity("EfcoreIncludeDemo.Models.Model3", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataModel3");

                    b.HasKey("Id");

                    b.ToTable("Model3s");
                });

            modelBuilder.Entity("EfcoreIncludeDemo.Models.Model2", b =>
                {
                    b.HasOne("EfcoreIncludeDemo.Models.Model1")
                        .WithMany("Model2")
                        .HasForeignKey("Model1Id");

                    b.HasOne("EfcoreIncludeDemo.Models.Model3", "Model3")
                        .WithMany()
                        .HasForeignKey("Model3Id");
                });
#pragma warning restore 612, 618
        }
    }
}
