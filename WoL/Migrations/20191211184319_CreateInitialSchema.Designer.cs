﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WoL.Data;

namespace WoL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191211184319_CreateInitialSchema")]
    partial class CreateInitialSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WoL.Models.Host", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Hostname")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<byte[]>("MacAddress")
                        .IsRequired()
                        .HasColumnType("varbinary(6)")
                        .HasMaxLength(6);

                    b.HasKey("Id");

                    b.HasIndex("Hostname")
                        .IsUnique()
                        .HasFilter("[Hostname] IS NOT NULL");

                    b.HasIndex("MacAddress")
                        .IsUnique();

                    b.ToTable("Host");
                });
#pragma warning restore 612, 618
        }
    }
}
