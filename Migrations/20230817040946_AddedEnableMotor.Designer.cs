﻿// <auto-generated />
using APIFilamentoExtruido.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace APIFilamentoExtruido.Migrations
{
    [DbContext(typeof(FDbContext))]
    [Migration("20230817040946_AddedEnableMotor")]
    partial class AddedEnableMotor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("APIFilamentoExtruido.Domain.ExtrudedFilament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<float>("CollectMeters")
                        .HasColumnType("real");

                    b.Property<bool>("EnableMotor")
                        .HasColumnType("boolean");

                    b.Property<float>("ExtruderTemperature")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("SetPointTemperature")
                        .HasColumnType("real");

                    b.Property<int>("SpeedMotor")
                        .HasColumnType("integer");

                    b.Property<bool>("StateMaterial")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ExtrudedFilaments");
                });
#pragma warning restore 612, 618
        }
    }
}
