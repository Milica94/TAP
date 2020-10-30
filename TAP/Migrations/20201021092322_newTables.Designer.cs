﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TAP.Models;

namespace TAP.Migrations
{
    [DbContext(typeof(TAPContext))]
    [Migration("20201021092322_newTables")]
    partial class newTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TAP.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("UQ__client__3213E83E6490E155");

                    b.ToTable("client");
                });

            modelBuilder.Entity("TAP.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnName("client_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasColumnType("varchar(1)")
                        .HasMaxLength(1)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique()
                        .HasName("UQ__project__BF21A4252F6E877C");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("UQ__project__3213E83E6A3395D8");

                    b.ToTable("project");
                });

            modelBuilder.Entity("TAP.Models.Project", b =>
                {
                    b.HasOne("TAP.Models.Client", "Client")
                        .WithOne("Project")
                        .HasForeignKey("TAP.Models.Project", "ClientId")
                        .HasConstraintName("project_client_fk")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
